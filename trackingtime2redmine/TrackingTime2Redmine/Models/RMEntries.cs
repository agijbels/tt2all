using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TrackingTime2Redmine.Models
{
    public class RMEntries
    {
        public RMEntry[] entries { get; set; }
    }

    public class RmTimeEntry
    {
        public int issue_id { get; set; }
        public string spent_on { get; set; }
        public double hours { get; set; }
        public int activity_id { get; set; }
        public string comments { get; set; }
        public int user_id { get; set; }
    }

    public class RMEntry
    {
        public RmTimeEntry time_entry { get; set; }

        public RMEntry(MapEntry mapEntry)
        {
            time_entry = new RmTimeEntry();
            time_entry.issue_id = mapEntry.RmTask;
            time_entry.spent_on = mapEntry.SpentOn.ToString("yyyy-MM-dd");
            time_entry.hours = mapEntry.TotalHours;
            time_entry.activity_id = (int)mapEntry.RmActivity;
            time_entry.comments = mapEntry.Text;
            time_entry.user_id = Int32.Parse(ConfigurationManager.AppSettings["RMUserId"]);
        }

        public RMEntry()
        {
            time_entry = new RmTimeEntry();
            time_entry.user_id = Int32.Parse(ConfigurationManager.AppSettings["RMUserId"]);
        }
    }
}
