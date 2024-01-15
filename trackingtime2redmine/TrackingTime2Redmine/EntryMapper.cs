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
        public List<JrEntry> _jrEntries { get; set; }

        public List<RmTimeEntry> GetRMTimeEntries()
        {
            return _rmEntries.Select(rmEntry => rmEntry.time_entry).ToList();
        }
        public List<JrTimeEntry> GetJrTimeEntries()
        {
            return _jrEntries.Select(jrEntry => jrEntry.time_entry).ToList();
        }

        public EntryMapper(DateTime fromDate, DateTime toDate)
        {
            var ttService = new TtApiService();
            ttService.InitialSetup();
            var entries = ttService.GetEntriesBetween(fromDate, toDate);

            _unmappedTtEntries = entries.data.OfType<Datum>().ToList();
            _mappedEntries = new List<MapEntry>();
            _rmEntries = new List<RMEntry>();
            _jrEntries = new List<JrEntry>();
        }

        public void StartMapping(bool mapRedmineEntries, bool mapJiraEntries)
        {
            _mappedEntries = new List<MapEntry>();
            List<Datum> entriesToMap = _unmappedTtEntries.Where(entry => (entry.event_type == "WORK") ).ToList();
            _unmappedTtEntries.RemoveAll(entry => entriesToMap.Contains(entry));

            TtApiService ttService = new TtApiService();
            ttService.InitialSetup();
            var jrService = new JrApiService();
            jrService.InitialSetup();
            var entriesGroupedByDateAndTask = entriesToMap.GroupBy(entry => $"{entry.GetDate().ToString("yyyyMMdd")}_{entry.GetRmTicket()}_{jrService.GetIssueIDFromKey(ttService.GetJiraIdFromTaskID(entry.task_id.ToString()))}");

            foreach (var group in entriesGroupedByDateAndTask)
            {
                var mapEntry = new MapEntry();
                mapEntry.Title = group.First().task;
                mapEntry.RmActivity = RMActivity.Development;
                mapEntry.RmTask = group.First().GetRmTicket();

                if (mapEntry.RmTask == -1)
                {
                    var akey = ttService.GetJiraIdFromTaskID(group.First().task_id.ToString());
                    mapEntry.JrTask = jrService.GetIssueIDFromKey(akey, false);
                    mapEntry.JrKey = akey;
                }
                else
                {
                    mapEntry.JrTask = ""; 
                    mapEntry.JrKey = "";
                }

                mapEntry.SpentOn = group.First().GetDate();
                mapEntry.TotalHours = Math.Round((double)group.Sum(entry => entry.duration) / 900) / 4;
                mapEntry.Text = string.Join(", ", group.Where(entry => (entry.notes != null)&&(!entry.notes.Equals(string.Empty))).Select(entry => entry.notes)); 
                mapEntry.TtEntries = new List<Datum>();
                mapEntry.TtEntries.AddRange(group);

                if (mapEntry.RmTask > -1 )
                    _mappedEntries.Add(mapEntry);
                else if (mapEntry.JrTask != "")
                    _mappedEntries.Add(mapEntry);
            }
        }

        public void MapToRmEntries()
        {
            _rmEntries = _mappedEntries
                .Where(mapEntry => mapEntry.RmTask > -1)
                .Select(mapEntry => new RMEntry(mapEntry))
                .ToList();
        }

        public void MapToJrEntries()
        {
            _jrEntries = _mappedEntries
                .Where(mapEntry => mapEntry.JrTask != "" )
                .Select(mapEntry => new JrEntry(mapEntry))
                .ToList();
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

        public string SendToJr()
        {
            var resultError = "";
            var resultSent = "";
            var jrService = new JrApiService();
            jrService.InitialSetup();

            foreach (var entry in _jrEntries)
            {
                var result = jrService.SendEntry(entry);
                if (!(result == System.Net.HttpStatusCode.OK || result == System.Net.HttpStatusCode.Created))
                {
                    resultError += $"#{entry.issue_id} ";
                }
                else
                {
                    resultSent += $"#{entry.issue_id} ";
                }
            }

            resultSent = resultSent.Equals(string.Empty) ? "None sent" : $"Sent {resultSent}";
            resultError = (resultError.Equals(string.Empty) ? "No errors" : $"Error sending {resultError}");

            return $"{resultSent} \n{resultError}";
        }
    }
}
