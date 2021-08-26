using System;
using System.Xml.Serialization;

namespace GematriaForTruth.API.DataStructures
{
    [XmlInclude(typeof(HistoricalEvent))]

    [XmlInclude(typeof(DateTime))]
    [Serializable]
    public class HistoricalEvent
    {
        public string Description { get; set; }
        public Type HistoricalEventType { get; set; }
        public bool Enabled { get; set; }
        public string Comment { get; set; }
        public bool IsDefault { get; set; }
        public EventCatagory Catagory { get; set; }
        public DateTime Date { get; set; }

        public enum EventCatagory
        {
            Birth,
            Death,
            Historical,
            Massacre
        };

        public enum Type
        {
            System,
            UserDefined,
            UserDefinedTemporary
        }

        public HistoricalEvent()
        { }

        public HistoricalEvent(EventCatagory catagory,
                               DateTime date,
                               string description,
                               Type historicalEventType,
                               bool enabled,
                               bool isDefault,
                               string comment)
        {
            this.Catagory = catagory;
            this.HistoricalEventType = historicalEventType;
            this.Enabled = enabled;
            this.IsDefault = isDefault;
            this.Comment = comment;
            this.Date = date;
            this.Description = description;
        }

        public static EventCatagory GetHistoricalEventCatagory(int num)
        {
            switch (num)
            {
                case 0:
                    return HistoricalEvent.EventCatagory.Birth;
                case 1:
                    return HistoricalEvent.EventCatagory.Death;
                case 2:
                    return HistoricalEvent.EventCatagory.Historical;
            }
            return HistoricalEvent.EventCatagory.Massacre;
        }
        public static string GetHistoricalEventCatagoryString(EventCatagory catagory)
        {
            switch (catagory)
            {
                case HistoricalEvent.EventCatagory.Birth:
                    return "Birth";
                case HistoricalEvent.EventCatagory.Death:
                    return "Death";
                case HistoricalEvent.EventCatagory.Historical:
                    return "Historical";
                case HistoricalEvent.EventCatagory.Massacre:
                    return "Massacre";

            }

            return "Unknown";
        }

        public override string ToString()
        {
            string stringToReturn = "[" + GetHistoricalEventCatagoryString(Catagory) + "]";

            stringToReturn += " [" + Description + "]";

            stringToReturn += " [" + Date.ToString("M/d/yyyy") + "]";

            if (Comment != null)
                if (Comment.Length > 0)
                    stringToReturn += " [" + Comment + "]";

            return stringToReturn;
        }
    }
}
