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

    [Serializable]
    public class RedMineException : Exception
    {
        public RedMineException() { }
        public RedMineException(string message) : base(message) { }
        public RedMineException(string message, Exception inner) : base(message, inner) { }
        protected RedMineException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    class RmApiService
    {
        private string _apiKey;
        private string _baseUrl;

        public void InitialSetup()
        {
            _baseUrl = ConfigurationManager.AppSettings["RMUrl"];
            _apiKey = ConfigurationManager.AppSettings["RMApiKey"];
        }

        public HttpStatusCode SendEntry(RMEntry entry) 
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_baseUrl + "/time_entries.json");
            request.Method = "POST";
            request.Headers.Add("X-Redmine-API-Key", _apiKey);
            request.ContentType = "application/json";
            request.Accept = "*/*";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(JsonConvert.SerializeObject(entry));
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if ((response.StatusCode == HttpStatusCode.OK) || (response.StatusCode == HttpStatusCode.Created))
                    {
                        return response.StatusCode;
                    }
                    else if ((int)response.StatusCode == 422)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new RedMineException("Time entry was not updated due to validation failures: "
                            + reader.ReadToEnd());
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new RedMineException( $"status {(int)response.StatusCode}: {reader.ReadToEnd()}" );
                    }
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
                return HttpStatusCode.Conflict;
            }
            catch (RedMineException ex)
            {
                // Log errorText
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
