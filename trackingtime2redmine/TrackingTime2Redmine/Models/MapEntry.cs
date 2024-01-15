using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingTime2Redmine.Models
{
    public enum RMActivity
    {
        Design = 8,
        Development = 9, 
        FunctionalAnalysis = 10, 
        TechnicalAnalysis = 11, 
        TechAnalysisRnD = 25, 
        RnD = 12,
        Installation = 13, 
        CustomerPremises = 14, 
        Testing = 15,
        Costs = 23,
        Holiday = 37
    }

    public class MapEntry
    {
        public DateTime SpentOn;
        public int RmTask;
        public string Title;
        public string JrTask;
        public string JrKey;
        public double TotalHours;
        public string Text;
        public RMActivity RmActivity;
        public List<Datum> TtEntries;
    }
}
