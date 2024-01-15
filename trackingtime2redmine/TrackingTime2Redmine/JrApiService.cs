using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TrackingTime2Redmine.Models;

namespace TrackingTime2Redmine
{
    [Serializable]
    public class JiraException : Exception
    {
        public JiraException() { }
        public JiraException(string message) : base(message) { }
        public JiraException(string message, Exception inner) : base(message, inner) { }
        protected JiraException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    class JrApiService
    {
        private string _JRAuthToken;
        private string _baseUrl;
        
        //public HttpStatusCode GetIdFromIssue(string  )
        public void InitialSetup()
        {
            _baseUrl = ConfigurationManager.AppSettings["JRUrl"];
            _JRAuthToken = ConfigurationManager.AppSettings["JRAuthToken"];
        }

        public string GetIssueIDFromKey(string aKey, bool aNoExceptionsOnCount = true)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{_baseUrl}/issue/{aKey}");
            request.Method = "GET";
            request.Headers.Add("Authorization", _JRAuthToken);
            request.ContentType = "application/json";
            request.Accept = "*/*";

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        JrIssue aJrIssue = JsonConvert.DeserializeObject<JrIssue>(reader.ReadToEnd());
                        return aJrIssue.id;
                    }
                    else if ((int)response.StatusCode == 400)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException("the user does not have permission to add the worklog or the request JSON is malformed "
                            + reader.ReadToEnd());
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException($"status {(int)response.StatusCode}: {reader.ReadToEnd()}");
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
                throw ex;
            }
            catch (JiraException ex)
            {
                // Log errorText
                throw ex;
            }

            //return GetIssueIDFromSummary(aEntry.task, aNoExceptionsOnCount); 
        }

        private string GetIssueIDFromSummary(string aSummary, bool aNoExceptionsOnCount)
        {
            if (aSummary == null)
                return "";

            var escapedSummary = EscapeSpecialChars(aSummary);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create( $"{_baseUrl}/search?fields=key&jql=text{Uri.EscapeDataString( $" ~ \"{escapedSummary}\"")}" );
            request.Method = "GET";
            request.Headers.Add("Authorization", _JRAuthToken);
            request.ContentType = "application/json";
            request.Accept = "*/*";

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if ((response.StatusCode == HttpStatusCode.OK) || (response.StatusCode == HttpStatusCode.Created))
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                        JrIssues allIssues = JsonConvert.DeserializeObject<JrIssues>(reader.ReadToEnd());
                        if (allIssues.issues.Count <= 0 || allIssues.issues.Count > 1)
                        {
                            if (!aNoExceptionsOnCount)
                            {
                                if (allIssues.issues.Count <= 0)
                                {
                                    throw new JiraException($"No tickets found for summary: [{aSummary}] => [{escapedSummary}]");
                                }
                                else
                                {
                                    throw new JiraException($"Multiple tickets found for summary: [{aSummary}] => [{escapedSummary}]");
                                }
                            }
                            else
                            {
                                return "";
                            }
                        }
                        else
                        {
                            return allIssues.issues[0].key;
                        }
                    }
                    else if ((int)response.StatusCode == 400)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException("the user does not have permission to add the worklog or the request JSON is malformed "
                            + reader.ReadToEnd());
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException($"status {(int)response.StatusCode}: {reader.ReadToEnd()}");
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
                throw ex;
            }
            catch (JiraException ex)
            {
                // Log errorText
                throw ex;
            }

        }

        private string EscapeSpecialChars(string aSummary)
        {
            if (aSummary == null)
                return null;
            // + - & | ! ( ) { } [ ] ^ ~ * ? \ :
            string[] specialChars = new string[] { "+", "-", "&", "|", "!", "(", ")", "{", "}", "[", "]", "^", "~", "*", "?", "\\", ":" };
            return specialChars.Aggregate(aSummary, (c1, c2) => c1.Replace(c2, $"\\\\{c2}"));
        }

        public HttpStatusCode SendEntry(JrEntry entry)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_baseUrl + "/issue/" + entry.issue_id + "/worklog");
            request.Method = "POST";
            request.Headers.Add("Authorization", _JRAuthToken);
            request.ContentType = "application/json";
            request.Accept = "*/*";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                var tmpString = JsonConvert.SerializeObject(entry.time_entry);
                streamWriter.Write(tmpString);
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
                    else if ((int)response.StatusCode == 400)
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException("the user does not have permission to add the worklog or the request JSON is malformed "
                            + reader.ReadToEnd());
                    }
                    else
                    {
                        StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                        throw new JiraException($"status {(int)response.StatusCode}: {reader.ReadToEnd()}");
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
            catch (JiraException ex)
            {
                string errorText = ex.Message;
                // Log errorText
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
