using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingTime2Redmine.Models
{
    public class TTEntries
    {
        public Response response { get; set; }
        public Datum[] data { get; set; }
    }

    public class Response
    {
        public int status { get; set; }
        public string version { get; set; }
        public string message { get; set; }
        public object note { get; set; }
        public object note_type { get; set; }
    }

    public class Datum
    {
        public string event_type { get; set; }
        public string start { get; set; }
        public string loc_start { get; set; }
        public string end { get; set; }
        public string loc_end { get; set; }
        public int duration { get; set; }
        public string loc_duration { get; set; }
        public string formated_duration { get; set; }
        public object service { get; set; }
        public object service_id { get; set; }
        public object customer { get; set; }
        public object customer_id { get; set; }
        public string project { get; set; }
        public int? project_id { get; set; }
        public string project_notes { get; set; }
        public object project_color { get; set; }
        public object project_is_favorite { get; set; }
        public object skill { get; set; }
        public object skill_id { get; set; }
        public string task { get; set; }
        public int task_id { get; set; }
        public object task_type { get; set; }
        public object task_visibility { get; set; }
        public object task_list { get; set; }
        public object due_date { get; set; }
        public float? estimated_time { get; set; }
        public bool is_archived { get; set; }
        public string user { get; set; }
        public int user_id { get; set; }
        public float user_hourly_rate { get; set; }
        public float user_hourly_cost { get; set; }
        public string timezone { get; set; }
        public string notes { get; set; }
        public string color { get; set; }
        public object repeat { get; set; }
        public object end_repeat { get; set; }
        public object frequency { get; set; }
        public object repeat_every { get; set; }
        public object hourly_rate { get; set; }
        public bool is_billable { get; set; }
        public bool is_billed { get; set; }
        public object user_groups { get; set; }
        public Tag[] tags { get; set; }
        public int id { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public object json { get; set; }
        public DateTime GetDate()
        {
            return Convert.ToDateTime(start);
        }
        public int GetRmTicket()
        {
            return Int32.Parse(task.Substring(task.IndexOf(" #") + 2, 4));
        }
    }

    public class Tag
    {
        public int id { get; set; }
        public string n { get; set; }
        public string v { get; set; }
        public object c { get; set; }
        public string t { get; set; }
        public object ns { get; set; }
    }

}
