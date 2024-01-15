using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using TrackingTime2Redmine.Models;
using System.Net;
using System.IO;

namespace TrackingTime2Redmine
{
    class TtApiService
    {
        private string _ttUrl;
        private string _userName;
        private string _password;

        public void InitialSetup()
        {
            _ttUrl = ConfigurationManager.AppSettings["TTUrl"];
            _userName = ConfigurationManager.AppSettings["TTUserName"];
            _password = ConfigurationManager.AppSettings["TTPassWord"];
        }

        public TTEntries GetEntriesBetween(DateTime fromDate, DateTime toDate)
        {
            var start = fromDate.ToString("yyyy-MM-dd");
            var end = toDate.ToString("yyyy-MM-dd");
            TTEntries entries = new TTEntries();

            // TODO Make client a parameter
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create( $"{_ttUrl}/events?filter=CUSTOMER&id=374735&from={start}&to={end}");
            request.Method = "GET";
            request.PreAuthenticate = true;
            request.Credentials = new NetworkCredential(_userName, _password);

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    entries = JsonConvert.DeserializeObject<TTEntries>(reader.ReadToEnd());
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // Log errorText
                }
                throw;
            }

            return entries;
        }

        public string GetJiraIdFromTaskID(string aTaskID)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{_ttUrl}/tasks/{aTaskID}");
            request.Method = "GET";
            request.PreAuthenticate = true;
            request.Credentials = new NetworkCredential(_userName, _password);

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    //var res = reader.ReadToEnd();
                    Models.Task task = new Models.Task();
                    task = JsonConvert.DeserializeObject<Models.Task>(reader.ReadToEnd());

                    return ExtractJiraIDFromJson(task.data.json);
                }
            }
            catch (WebException ex)
            {
                WebResponse errorResponse = ex.Response;
                using (Stream responseStream = errorResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.GetEncoding("utf-8"));
                    String errorText = reader.ReadToEnd();
                    // Log errorText
                }
                throw;
            }
        }

        private string ExtractJiraIDFromJson(string json)
        {
            TaskDataJson taskDataJson = JsonConvert.DeserializeObject<TaskDataJson>(json);
            return taskDataJson.button.id;
        }
    }
}
