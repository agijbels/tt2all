using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingTime2Redmine.Models;

namespace TrackingTime2Redmine
{
    class EntryMapper   
    {
        public List<Datum> _unmappedTtEntries { get; set; }
        //private List<Datum> _mappedTtEntries;
        public List<MapEntry> _mappedEntries { get; set; }
        public List<RMEntry> _rmEntries { get; set; }

        public List<TimeEntry> GetRMTimeEntries()
        {
            return _rmEntries.Select(rmEntry => rmEntry.time_entry).ToList();
        }

        public EntryMapper(DateTime fromDate, DateTime toDate)
        {
            var ttService = new TtApiService();
            ttService.InitialSetup();
            var entries = ttService.GetEntriesBetween(fromDate, toDate);

            _unmappedTtEntries = entries.data.OfType<Datum>().ToList();
            _mappedEntries = new List<MapEntry>();
            _rmEntries = new List<RMEntry>();
        }

        public void StartMapping()
        {
            _mappedEntries = new List<MapEntry>();
            // TODO: Soms is event.task niet ingevuld!
            List<Datum> entriesToMap = _unmappedTtEntries.Where(entry => (entry.event_type == "WORK" && entry.task.Contains(" #"))).ToList();
            _unmappedTtEntries.RemoveAll(entry => entriesToMap.Contains(entry));

            var entriesGroupedByDateAndTask = entriesToMap.GroupBy(entry => $"{entry.GetDate().ToString("yyyyMMdd")}_{entry.GetRmTicket()}");
            foreach (var group in entriesGroupedByDateAndTask)
            {
                var mapEntry = new MapEntry();
                mapEntry.Activity = RMActivity.Development;
                mapEntry.RmTask = group.First().GetRmTicket();
                mapEntry.SpentOn = group.First().GetDate();
                mapEntry.TotalHours = Math.Round((double)group.Sum(entry => entry.duration) / 900) / 4;
                mapEntry.Text = string.Join(", ", group.Where(entry => (entry.notes != null)&&(!entry.notes.Equals(string.Empty))).Select(entry => entry.notes)); 
                mapEntry.TtEntries = new List<Datum>();
                mapEntry.TtEntries.AddRange(group);

                _mappedEntries.Add(mapEntry);
            }
        }

        public void MapToRmEntries()
        {
            _rmEntries = _mappedEntries
                .Select(mapEntry => new RMEntry(mapEntry)).ToList();
        }

        public string SendToRm()
        {
            var resultError = "";
            var resultSent = "";
            var rmService = new RmApiService();
            rmService.InitialSetup();

            foreach (var entry in _rmEntries)
            {
                var result = rmService.SendEntry(entry);
                if (!(result == System.Net.HttpStatusCode.OK || result == System.Net.HttpStatusCode.Created))
                {
                    resultError += $"#{entry.time_entry.issue_id} ";
                }
                else
                {
                    resultSent += $"#{entry.time_entry.issue_id} ";
                }
            }

            resultSent = resultSent.Equals(string.Empty) ? "None sent" : $"Sent {resultSent}";
            resultError = (resultError.Equals(string.Empty) ? "No errors" : $"Error sending {resultError}");

            return $"{resultSent} \n{resultError}";
        }

    }
}
