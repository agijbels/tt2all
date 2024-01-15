using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingTime2Redmine.Models
{
    public class JrEntries
    {
        public JrEntry[] entries { get; set; }
    }

    public class ActualContent
    {
        public string text { get; set; }
        public string type { get; set; }
    }

    public class Content
    {
        public string type { get; set; }
        public List<ActualContent> content { get; set; }
    }

    public class Comment
    {
        public string type { get; set; }
        public int version { get; set; }
        public List<Content> content { get; set; }
    }

    public class JrVisualTimeEntry
    {
        public string issue_key { get; set; }
        public string issue_id { get; set; }
        public string issue_title { get; set; }
        public string started { get; set; }
        public int timeSpentSeconds { get; set; }
        public string comment { get; set; }

        public JrVisualTimeEntry(JrEntry jrEntry)
        {
            issue_id = jrEntry.issue_id;
            issue_key = jrEntry.issue_key;
            issue_title = jrEntry.issue_title;
            started = jrEntry.time_entry.started;
            timeSpentSeconds = jrEntry.time_entry.timeSpentSeconds;
            comment = jrEntry.time_entry.comment.content.First().content.First().text;
        }
    }

    public class JrTimeEntry
    {
        public int timeSpentSeconds { get; set; }
        public Comment comment { get; set; }
        public string started { get; set; }
    }

    public class JrEntry
    {
        public JrTimeEntry time_entry { get; set; }
        public string issue_id { get; set; }

        public string issue_key { get; set; }
        public string issue_title { get; set; }

        public JrEntry(MapEntry mapEntry)
        {
            issue_id = mapEntry.JrTask;
            issue_key = mapEntry.JrKey;
            issue_title = mapEntry.Title;
            time_entry = new JrTimeEntry();
            //time_entry.started = mapEntry.SpentOn;
            time_entry.started = mapEntry.SpentOn.ToString("yyyy-MM-ddThh:mm:ss.000+0000"); 
            time_entry.timeSpentSeconds = (int)(mapEntry.TotalHours * 60 * 60);

            var tmpActualContent = new ActualContent();
            tmpActualContent.type = "text";
            tmpActualContent.text = mapEntry.Text;
            var tmpContent = new Content();
            tmpContent.type = "paragraph";
            tmpContent.content = new List<ActualContent>();
            tmpContent.content.Add(tmpActualContent);

            time_entry.comment = new Comment();
            time_entry.comment.type = "doc";
            time_entry.comment.version = 1;
            time_entry.comment.content = new List<Content>();
            time_entry.comment.content.Add(tmpContent);
        }
    }

    public class JrIssue
    {
        public string expand { get; set; }
        public string id { get; set; }
        public string self { get; set; }
        public string key { get; set; }
    }

    public class JrIssues
    {
        public string expand { get; set; }
        public int startAt { get; set; }
        public int maxResults { get; set; }
        public int total { get; set; }
        public List<JrIssue> issues { get; set; }
    }
}


