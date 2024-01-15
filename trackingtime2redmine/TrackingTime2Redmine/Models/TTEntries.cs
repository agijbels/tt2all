using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingTime2Redmine.Models
{
    public class TTEntries
    {
        public EntryResponse response { get; set; }
        public Datum[] data { get; set; }
    }

    public class EntryResponse
    {
        public int status { get; set; }
        public string version { get; set; }
        public string message { get; set; }
        public object note { get; set; }
        public object note_type { get; set; }
    }

    public class Datum
    {
        [JsonProperty("ety")]
        public string event_type { get; set; }
        [JsonProperty("s")]
        public string start { get; set; }
        public string loc_start { get; set; }
        public string end { get; set; }
        public string loc_end { get; set; }
        [JsonProperty("d")]
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
        [JsonProperty("t")]
        public string task { get; set; }
        [JsonProperty("tid")]
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
        [JsonProperty("n")]
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
        public string json { get; set; }
        public DateTime GetDate()
        {
            return Convert.ToDateTime(start);
        }
        public int GetRmTicket()
        {
            if (task != null && task.IndexOf(" #") >= 0)
                return Int32.Parse(task.Substring(task.IndexOf(" #") + 2, 4));
            else
                return -1;
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

    public class AvailableCustomField
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("value")]
        public object value { get; set; }

        [JsonProperty("notes")]
        public object notes { get; set; }

        [JsonProperty("color")]
        public object color { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("value_type")]
        public string value_type { get; set; }

        [JsonProperty("value_object_class")]
        public object value_object_class { get; set; }

        [JsonProperty("filter_object_class")]
        public string filter_object_class { get; set; }

        [JsonProperty("is_object_default")]
        public object is_object_default { get; set; }

        [JsonProperty("enum_options")]
        public object enum_options { get; set; }

        [JsonProperty("cf_index")]
        public object cf_index { get; set; }

        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("created_at")]
        public object created_at { get; set; }

        [JsonProperty("updated_at")]
        public object updated_at { get; set; }

        [JsonProperty("json")]
        public object json { get; set; }
    }

    public class TaskBilling
    {
        [JsonProperty("is_billable")]
        public bool is_billable { get; set; }

        [JsonProperty("hourly_rate")]
        public object hourly_rate { get; set; }

        [JsonProperty("loc_hourly_rate")]
        public object loc_hourly_rate { get; set; }

        [JsonProperty("hourly_cost")]
        public object hourly_cost { get; set; }

        [JsonProperty("loc_hourly_cost")]
        public object loc_hourly_cost { get; set; }

        [JsonProperty("fixed_rate")]
        public object fixed_rate { get; set; }

        [JsonProperty("loc_fixed_rate")]
        public object loc_fixed_rate { get; set; }

        [JsonProperty("billable_hours")]
        public object billable_hours { get; set; }

        [JsonProperty("non_billable_hours")]
        public object non_billable_hours { get; set; }

        [JsonProperty("loc_billable_hours")]
        public object loc_billable_hours { get; set; }

        [JsonProperty("loc_non_billable_hours")]
        public object loc_non_billable_hours { get; set; }
    }

    public class TaskCreatedBy
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("surname")]
        public string surname { get; set; }

        [JsonProperty("avatar_url")]
        public string avatar_url { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("third_party_data")]
        public object third_party_data { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }
    }

    public class TaskData
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("visibility")]
        public object visibility { get; set; }

        [JsonProperty("project_id")]
        public int project_id { get; set; }

        [JsonProperty("project")]
        public string project { get; set; }

        [JsonProperty("project_accumulated_time")]
        public int project_accumulated_time { get; set; }

        [JsonProperty("project_loc_worked_hours")]
        public string project_loc_worked_hours { get; set; }

        [JsonProperty("project_is_public")]
        public bool project_is_public { get; set; }

        [JsonProperty("project_is_favorite")]
        public bool project_is_favorite { get; set; }

        [JsonProperty("customer")]
        public string customer { get; set; }

        [JsonProperty("customer_id")]
        public int customer_id { get; set; }

        [JsonProperty("service")]
        public object service { get; set; }

        [JsonProperty("service_id")]
        public object service_id { get; set; }

        [JsonProperty("estimated_time")]
        public double estimated_time { get; set; }

        [JsonProperty("loc_estimated_time")]
        public string loc_estimated_time { get; set; }

        [JsonProperty("accumulated_time")]
        public int accumulated_time { get; set; }

        [JsonProperty("is_archived")]
        public bool is_archived { get; set; }

        [JsonProperty("start_date")]
        public string start_date { get; set; }

        [JsonProperty("loc_start_date")]
        public string loc_start_date { get; set; }

        [JsonProperty("end_date")]
        public object end_date { get; set; }

        [JsonProperty("loc_end_date")]
        public object loc_end_date { get; set; }

        [JsonProperty("due_date")]
        public object due_date { get; set; }

        [JsonProperty("loc_due_date")]
        public object loc_due_date { get; set; }

        [JsonProperty("list_position")]
        public double list_position { get; set; }

        [JsonProperty("list_id")]
        public object list_id { get; set; }

        [JsonProperty("list_name")]
        public object list_name { get; set; }

        [JsonProperty("worked_hours")]
        public double worked_hours { get; set; }

        [JsonProperty("loc_worked_hours")]
        public string loc_worked_hours { get; set; }

        [JsonProperty("accumulated_time_display")]
        public string accumulated_time_display { get; set; }

        [JsonProperty("tracking")]
        public bool tracking { get; set; }

        [JsonProperty("account_id")]
        public int account_id { get; set; }

        [JsonProperty("color")]
        public string color { get; set; }

        [JsonProperty("day_index")]
        public int day_index { get; set; }

        [JsonProperty("index")]
        public int index { get; set; }

        [JsonProperty("skill")]
        public object skill { get; set; }

        [JsonProperty("user")]
        public User user { get; set; }

        [JsonProperty("billing")]
        public TaskBilling billing { get; set; }

        [JsonProperty("project_billing")]
        public TaskProjectBilling project_billing { get; set; }

        [JsonProperty("service_item")]
        public object service_item { get; set; }

        [JsonProperty("tracking_event")]
        public object tracking_event { get; set; }

        [JsonProperty("subtasks")]
        public List<object> subtasks { get; set; }

        [JsonProperty("comments")]
        public List<object> comments { get; set; }

        [JsonProperty("users")]
        public List<User> users { get; set; }

        [JsonProperty("files")]
        public List<object> files { get; set; }

        [JsonProperty("description")]
        public object description { get; set; }

        [JsonProperty("created_by")]
        public TaskCreatedBy created_by { get; set; }

        [JsonProperty("task_permalink")]
        public object task_permalink { get; set; }

        [JsonProperty("third_party_data")]
        public object third_party_data { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("updated_at")]
        public string updated_at { get; set; }

        [JsonProperty("json")]
        public string json { get; set; }
    }

    public class TaskProjectBilling
    {
        [JsonProperty("is_billable")]
        public bool is_billable { get; set; }

        [JsonProperty("hourly_rate")]
        public object hourly_rate { get; set; }

        [JsonProperty("loc_hourly_rate")]
        public object loc_hourly_rate { get; set; }

        [JsonProperty("hourly_cost")]
        public object hourly_cost { get; set; }

        [JsonProperty("loc_hourly_cost")]
        public object loc_hourly_cost { get; set; }

        [JsonProperty("fixed_rate")]
        public object fixed_rate { get; set; }

        [JsonProperty("loc_fixed_rate")]
        public object loc_fixed_rate { get; set; }

        [JsonProperty("billable_hours")]
        public object billable_hours { get; set; }

        [JsonProperty("non_billable_hours")]
        public object non_billable_hours { get; set; }

        [JsonProperty("loc_billable_hours")]
        public object loc_billable_hours { get; set; }

        [JsonProperty("loc_non_billable_hours")]
        public object loc_non_billable_hours { get; set; }
    }

    public class TTTaskResponse
    {
        [JsonProperty("status")]
        public int status { get; set; }

        [JsonProperty("version")]
        public string version { get; set; }

        [JsonProperty("message")]
        public string message { get; set; }

        [JsonProperty("note")]
        public object note { get; set; }

        [JsonProperty("note_type")]
        public object note_type { get; set; }
    }

    public class Task
    {
        [JsonProperty("response")]
        public TTTaskResponse response { get; set; }

        [JsonProperty("data")]
        public TaskData data { get; set; }

        [JsonProperty("set_custom_fields")]
        public List<TaskSetCustomField> set_custom_fields { get; set; }

        [JsonProperty("available_custom_fields")]
        public List<AvailableCustomField> available_custom_fields { get; set; }

        //[JsonProperty("users")]
        //public Users users { get; set; }
    }

    public class TaskSetCustomField
    {
        [JsonProperty("task_id")]
        public int task_id { get; set; }

        [JsonProperty("asana_project_id")]
        public object asana_project_id { get; set; }

        [JsonProperty("file_id")]
        public object file_id { get; set; }

        [JsonProperty("custom_field_id")]
        public int custom_field_id { get; set; }

        [JsonProperty("value")]
        public string value { get; set; }

        [JsonProperty("enum_option_id")]
        public object enum_option_id { get; set; }

        [JsonProperty("cf_index")]
        public object cf_index { get; set; }
    }

    public class User
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("surname")]
        public string surname { get; set; }

        [JsonProperty("avatar_url")]
        public string avatar_url { get; set; }

        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("third_party_data")]
        public object third_party_data { get; set; }

        [JsonProperty("id")]
        public int id { get; set; }
    }

    public class TaskUser
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("surname")]
        public string surname { get; set; }

        [JsonProperty("avatar_url")]
        public string avatar_url { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("shared_on")]
        public string shared_on { get; set; }

        [JsonProperty("event")]
        public object @event { get; set; }

        [JsonProperty("estimated_time")]
        public double estimated_time { get; set; }

        [JsonProperty("accumulated_time")]
        public int accumulated_time { get; set; }
    }

    public class TaskDataJsonButton
    {
        public string domain { get; set; }
        public string id { get; set; }
        public string url { get; set; }
    }

    public class TaskDataJson
    {
        public TaskDataJsonButton button { get; set; }
    }

}
