using System;

namespace Underground.Models
{
    public class TubeAPI
    {
        public RootArray[] Property1 { get; set; }
    }

    public class RootArray
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string modeName { get; set; }
        public object[] disruptions { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public Linestatus[] lineStatuses { get; set; }
        public Routesection[] routeSections { get; set; }
        public Servicetype[] serviceTypes { get; set; }
        //public Servicetype[] serviceTypes { get; set; }
        //public object[] routeSections { get; set; }
        //public Linestatus[] lineStatuses { get; set; }
        //public DateTime modified { get; set; }
        //public DateTime created { get; set; }
        //public object[] disruptions { get; set; }
        //public string modeName { get; set; }
        //public string name { get; set; }
        //public string id { get; set; }
        //public string type { get; set; }
    }

    public class Linestatus
    {
        public string type { get; set; }
        public int id { get; set; }
        public int statusSeverity { get; set; }
        public string statusSeverityDescription { get; set; }
        public DateTime created { get; set; }
        public Validityperiod[] validityPeriods { get; set; }
        public string lineId { get; set; }
        public string reason { get; set; }
        public Disruption disruption { get; set; }
        //public object[] validityPeriods { get; set; }
        //public DateTime created { get; set; }
        //public string statusSeverityDescription { get; set; }
        //public int statusSeverity { get; set; }
        //public int id { get; set; }

        //public string type { get; set; }
    }

    public class Disruption
    {
        public string type { get; set; }
        public string category { get; set; }
        public string categoryDescription { get; set; }
        public string description { get; set; }
        public Affectedroute[] affectedRoutes { get; set; }
        public Affectedstop[] affectedStops { get; set; }
        public bool isBlocking { get; set; }
        public string closureText { get; set; }
    }

    public class Affectedroute
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string direction { get; set; }
        public string originationName { get; set; }
        public string destinationName { get; set; }
        public Routesectionnaptanentrysequence[] routeSectionNaptanEntrySequence { get; set; }
    }

    public class Routesectionnaptanentrysequence
    {
        public string type { get; set; }
        public int ordinal { get; set; }
        public Stoppoint stopPoint { get; set; }
    }

    public class Stoppoint
    {
        public string type { get; set; }
        public string naptanId { get; set; }
        public object[] modes { get; set; }
        public string icsCode { get; set; }
        public string stationNaptan { get; set; }
        public string hubNaptanCode { get; set; }
        public object[] lines { get; set; }
        public object[] lineGroup { get; set; }
        public object[] lineModeGroups { get; set; }
        public bool status { get; set; }
        public string id { get; set; }
        public string commonName { get; set; }
        public string placeType { get; set; }
        public object[] additionalProperties { get; set; }
        public Child[] children { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Child
    {
        public string type { get; set; }
        public string naptanId { get; set; }
        public object[] modes { get; set; }
        public string icsCode { get; set; }
        public string stationNaptan { get; set; }
        public string hubNaptanCode { get; set; }
        public object[] lines { get; set; }
        public object[] lineGroup { get; set; }
        public object[] lineModeGroups { get; set; }
        public bool status { get; set; }
        public string id { get; set; }
        public string commonName { get; set; }
        public string placeType { get; set; }
        public object[] additionalProperties { get; set; }
        public object[] children { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
        public string indicator { get; set; }
        public string stopLetter { get; set; }
    }

    public class Affectedstop
    {
        public string type { get; set; }
        public string naptanId { get; set; }
        public string stationNaptan { get; set; }
        public bool status { get; set; }
        public string id { get; set; }
        public string commonName { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class Validityperiod
    {
        public string type { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool isNow { get; set; }
    }

    public class Routesection
    {
        public string type { get; set; }
        public string name { get; set; }
        public string direction { get; set; }
        public string originationName { get; set; }
        public string destinationName { get; set; }
        public string originator { get; set; }
        public string destination { get; set; }
        public string serviceType { get; set; }
    }

    public class Servicetype
    {
        public string type { get; set; }
        public string name { get; set; }
        public string uri { get; set; }
    }
}