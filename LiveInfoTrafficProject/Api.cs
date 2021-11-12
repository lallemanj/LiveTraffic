using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInfoTrafficProject
{
    internal class Api
    {
        public delegate void MyEventHandler(string fn);
        public event MyEventHandler onGetText;

        public class Incident
        {
            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("properties")]
            public Properties properties { get; set; }

            [JsonProperty("geometry")]
            public Geometry geometry { get; set; }

            public class Properties
            {
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("iconCategory")]
                public int IconCategory { get; set; }

                [JsonProperty("magnitudeOfDelay")]
                public int MagnitudeOfDelay { get; set; }

                [JsonProperty("startTime")]
                public DateTime StartTime { get; set; }

                [JsonProperty("endTime")]
                public DateTime? EndTime { get; set; }

                [JsonProperty("from")]
                public string From { get; set; }

                [JsonProperty("to")]
                public string To { get; set; }

                [JsonProperty("length")]
                public double Length { get; set; }

                [JsonProperty("delay")]
                public int Delay { get; set; }

                [JsonProperty("roadNumbers")]
                public List<object> RoadNumbers { get; set; }

                [JsonProperty("timeValidity")]
                public string TimeValidity { get; set; }

                [JsonProperty("events")]
                public List<Event> Events { get; set; }

                [JsonProperty("aci")]
                public object Aci { get; set; }

                [JsonProperty("tmc")]
                public Tmc Tmc { get; set; }

            }

            public class Tmc
            {
                [JsonProperty("countryCode")]
                public string CountryCode { get; set; }

                [JsonProperty("tableNumber")]
                public string TableNumber { get; set; }

                [JsonProperty("tableVersion")]
                public string TableVersion { get; set; }

                [JsonProperty("direction")]
                public string Direction { get; set; }

                [JsonProperty("points")]
                public List<Point> Points { get; set; }
            }
            public class Event
            {
                [JsonProperty("code")]
                public int Code { get; set; }

                [JsonProperty("description")]
                public string Description { get; set; }
            }


            public class Point
        {
                [JsonProperty("location")]
                public int Location { get; set; }

                [JsonProperty("offset")]
                public int Offset { get; set; }
            }

        public class Geometry
        {
                [JsonProperty("type")]
                public string Type { get; set; }

                [JsonProperty("coordinates")]
                public List<List<double>> Coordinates { get; set; }
            }


        }
        public class Rootobject
        {
            [JsonProperty("incidents")]
            public List<Incident> incidents { get; set; }
            //public Incident.Properties properties { get; set; }

            //public Incident.Event events { get; set; }
        }
 
    }
}


