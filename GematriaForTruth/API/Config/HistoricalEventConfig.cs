using GematriaForTruth.API.DataStructures;
using GematriaForTruth.API.Factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static GematriaForTruth.API.DataStructures.HistoricalEvent;

namespace GematriaForTruth.API.Config
{
    [XmlInclude(typeof(HistoricalEvent))]
    [XmlInclude(typeof(EventCatagory))]
    [XmlInclude(typeof(DateTime))]
    [Serializable]

    public class HistoricalEventConfig : GematriaToolsXmlConfig
    {
        public List<HistoricalEvent> HistoricalEvents { get; set; }

        private static HistoricalEventConfig config = null;
        public ConfigType CurrentConfigType { get; set; }
        public enum ConfigType
        {
            IsDefault,
            IsAllExperimental,
            IsAll,
            IsAllUserDefined,
            IsUserDefined
        }

        public HistoricalEventConfig()
        {
            HistoricalEvents = new List<HistoricalEvent>();
        }

        public static void SaveHistoricalEventConfig()
        {
            SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\HistoricalEvents.xml", Instance());
        }

        public void SetDefaults()
        {
            HistoricalEvent historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2001, 9, 11);
            historicalEvent.Description = "September 11, 2001";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2017, 10, 1);
            historicalEvent.Description = "Las Vegas Shooting";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1963, 11, 22);
            historicalEvent.Description = "John F. Kennedy Assassinated";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2012, 12, 14);
            historicalEvent.Description = "Sandy Hook Elementary School Shooting";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2018, 2, 14);
            historicalEvent.Description = "Parkland Florida School Shooting";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1776, 5, 1);
            historicalEvent.Description = "Illuminati Foundation Date";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1776, 7, 4);
            historicalEvent.Description = "United States of America Independence Day";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1941, 12, 7);
            historicalEvent.Description = "Attack on Pearl Harbor";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1945, 8, 6);
            historicalEvent.Description = "Atomic bombings of Hiroshima";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1914, 7, 28);
            historicalEvent.Description = "Start of World War I";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1939, 9, 1);
            historicalEvent.Description = "Start of World War II";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1933, 3, 3);
            historicalEvent.Description = "FDR's New Deal";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1945, 7, 17);
            historicalEvent.Description = "Trinity Nuclear Test";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1540, 9, 27);
            historicalEvent.Description = "Formation of the Jesuits";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1776, 8, 2);
            historicalEvent.Description = "Signing of the Declaration of Independence";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1947, 9, 18);
            historicalEvent.Description = "Central Intelligence Agency Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1912, 4, 14);
            historicalEvent.Description = "Sinking of the RMS Titanic";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1947, 7, 8);
            historicalEvent.Description = "Roswell UFO Incident";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1986, 4, 26);
            historicalEvent.Description = "Chernobyl Disaster";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2011, 3, 11);
            historicalEvent.Description = "Fukushima Nuclear Disaster";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1986, 1, 28);
            historicalEvent.Description = "Space Shuttle Challenger Disaster";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2011, 3, 11);
            historicalEvent.Description = "1993 World Trade Center Bombing";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2013, 12, 23);
            historicalEvent.Description = "Creation of the Federal Reserve Act";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2011, 3, 11);
            historicalEvent.Description = "Fukushima Nuclear Disaster";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1997, 3, 13);
            historicalEvent.Description = "Dunblane Massacre Scotland";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1917, 11, 2);
            historicalEvent.Description = "Balfour Declaration";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1918, 11, 11);
            historicalEvent.Description = "End of World War I";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1945, 9, 2);
            historicalEvent.Description = "End of World War II";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1913, 5, 14);
            historicalEvent.Description = "Rockefeller Foundation Formation";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1952, 11, 4);
            historicalEvent.Description = "National Security Agency Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1983, 1, 1);
            historicalEvent.Description = "Official Birthday of the Internet";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 1, 13);
            historicalEvent.Description = "Coronavirus Pandemic";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 1, 8);
            historicalEvent.Description = "Coronavirus First Instance";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 11, 17);
            historicalEvent.Description = "Coronavirus First Case";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 3, 11);
            historicalEvent.Description = "Coronavirus Global Drsclaration of Pandemic";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 6, 1);
            historicalEvent.Description = "Coronavirus First Study for Treatment ly-voc555";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 6, 1);
            historicalEvent.Description = "Release of Samoan Quarter (eclipse)";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1980, 3, 22);
            historicalEvent.Description = "Opening date of the Georgia Guidestones";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1871, 2, 21);
            historicalEvent.Description = "Passing of the District of Columbia Organic Act of 1871";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1215, 11, 11);
            historicalEvent.Description = "Fourth Council of the Lateran";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1666, 9, 6);
            historicalEvent.Description = "The Cestui que Vie Act 1666 is passed by the Parliament of England";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1666, 9, 2);
            historicalEvent.Description = "Start of the Great Fire of London";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1302, 11, 18);
            historicalEvent.Description = "Unam sanctam[a] is a papal bull that was issued by Pope Boniface VIII";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2014, 11, 3);
            historicalEvent.Description = "One World Trade Center Opens";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2015, 3, 3);
            historicalEvent.Description = "Garissa Massacre Kenya";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2019, 3, 15);
            historicalEvent.Description = "Christchurch Mosque Shootings";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1945, 10, 24);
            historicalEvent.Description = "United Nations Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1865, 4, 14);
            historicalEvent.Description = "Assassination of Abraham Lincoln";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1881, 7, 2);
            historicalEvent.Description = "Assassination of James A. Garfield";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1901, 9, 6);
            historicalEvent.Description = "Assassination of William McKinley";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1869, 9, 24);
            historicalEvent.Description = "Black Friday Stock Market Crash";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1929, 9, 4);
            historicalEvent.Description = "Stock Market Crash of 1929";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1929, 10, 29);
            historicalEvent.Description = "Black Tuesday Stock Market Crash";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1955, 11, 1);
            historicalEvent.Description = "Start of Vietnam War";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1975, 3, 30);
            historicalEvent.Description = "End of Vietnam War";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1998, 9, 4);
            historicalEvent.Description = "Google Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1975, 3, 4);
            historicalEvent.Description = "Microsoft Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1605, 11, 5);
            historicalEvent.Description = "Gunpowder Plot";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1965, 2, 21);
            historicalEvent.Description = "Malcolm X  death	Assassination";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1965, 2, 21);
            historicalEvent.Description = "Malcolm X  death	Assassination";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1968, 4, 4);
            historicalEvent.Description = "Martin Luther King Jr. Assassination";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1991, 8, 6);
            historicalEvent.Description = "World Wide Web went live to the world";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1976, 4, 11);
            historicalEvent.Description = "Apple I";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1985, 11, 20);
            historicalEvent.Description = "Microsoft Windows 1.0 Released";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);



            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1920, 1, 20);
            historicalEvent.Description = "League of Nations Formed";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1955, 5, 14);
            historicalEvent.Description = "Warsaw Pact Founded";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2009, 7, 27);
            historicalEvent.Description = "Wuhan China Total Solar Eclipse";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2020, 12, 14);
            historicalEvent.Description = "First US Vaccination for Coronavirus Given";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1988, 10, 31);
            historicalEvent.Description = "HR 4818 Establish the National Park of Samoan";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2021, 5, 26);
            historicalEvent.Description = "American Samoan eclipse of 2021";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2021, 12, 17);
            historicalEvent.Description = "See 7Seven1One";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2017, 4, 20);
            historicalEvent.Description = "Evanka Trump became adviser to President Donald Trump";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2019, 10, 18);
            historicalEvent.Description = "Event 201";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2000, 1, 1);
            historicalEvent.Description = "MillenuimNation Count Begins";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2022, 3, 16);
            historicalEvent.Description = "Beginning of the MillenuimNation";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1937, 5, 27);
            historicalEvent.Description = "Opening of the Golden Gate Bridge";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2009, 1, 20);
            historicalEvent.Description = "Inaugurated Barack Obama";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2017, 1, 20);
            historicalEvent.Description = "Donald J. Trump Assumed office of President";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);
            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1924, 6, 12);
            historicalEvent.Description = "George H. W. Bush Took Presidental Office";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1989, 1, 20);
            historicalEvent.Description = "George W. Bush Took Presidental Office";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(1993, 1, 20);
            historicalEvent.Description = "Bill Clinton Took Presidental Office";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2013, 3, 13);
            historicalEvent.Description = "Pope Francis Papacy Begins";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Historical;
            historicalEvent.Date = new DateTime(2017, 6, 14);
            historicalEvent.Description = "Grenfell Tower Fire";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1626, 3, 9);
            historicalEvent.Description = "Francis Bacon";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1616, 3, 23);
            historicalEvent.Description = "William Shakespeare";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1603, 3, 24);
            historicalEvent.Description = "Elizabeth I";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);
            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(2020, 1, 26);
            historicalEvent.Description = "Kobe Bryant";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1980, 12, 8);
            historicalEvent.Description = "John Lennon";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1676, 9, 17);
            historicalEvent.Description = "Sabbatai Zevi";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1791, 12, 10);
            historicalEvent.Description = "Jacob Frank";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(2018, 11, 13);
            historicalEvent.Description = "George H. W. Bush";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1997, 8, 31);
            historicalEvent.Description = "Princess Diana";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1945, 4, 30);
            historicalEvent.Description = "Adolf Hitler";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1999, 7, 16);
            historicalEvent.Description = "John F. Kennedy Jr.";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1960, 11, 25);
            historicalEvent.Description = "John F. Kennedy Jr.";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1953, 3, 15);
            historicalEvent.Description = "Joseph Stalin";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1972, 12, 26);
            historicalEvent.Description = "Harry S. Truman";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(1947, 12, 1);
            historicalEvent.Description = "Aleister Crowley";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Death;
            historicalEvent.Date = new DateTime(2018, 8, 25);
            historicalEvent.Description = "John McCain";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1561, 1, 22);
            historicalEvent.Description = "Francis Bacon";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1564, 3, 26);
            historicalEvent.Description = "William Shakespeare";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1533, 9, 7);
            historicalEvent.Description = "Elizabeth I";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1947, 10, 26);
            historicalEvent.Description = "Hillary Clinton";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1946, 8, 19);
            historicalEvent.Description = "Bill Clinton";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);



            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1946, 6, 14);
            historicalEvent.Description = "Donald Trump";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1961, 8, 4);
            historicalEvent.Description = "Barack Obama";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1889, 4, 20);
            historicalEvent.Description = "Adolf Hitler";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1963, 10, 20);
            historicalEvent.Description = "Kamala Harris";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1878, 12, 18);
            historicalEvent.Description = "Joseph Stalin";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1875, 8, 12);
            historicalEvent.Description = "Aleister Crowley";
            HistoricalEvents.Add(historicalEvent);
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1884, 5, 8);
            historicalEvent.Description = "Harry S. Truman";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1959, 6, 7);
            historicalEvent.Description = "Mike Pence";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1924, 6, 12);
            historicalEvent.Description = "George H. W. Bush";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1946, 7, 6);
            historicalEvent.Description = "George W. Bush";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);


            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1936, 8, 29);
            historicalEvent.Description = "John McCain";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);

            historicalEvent = new HistoricalEvent();
            historicalEvent.Catagory = HistoricalEvent.EventCatagory.Birth;
            historicalEvent.Date = new DateTime(1936, 12, 17);
            historicalEvent.Description = "Pope Francis";
            historicalEvent.HistoricalEventType = HistoricalEvent.Type.System;
            historicalEvent.Enabled = true;
            historicalEvent.IsDefault = true;
            historicalEvent.Comment = "";
            HistoricalEvents.Add(historicalEvent);
        }

        public static HistoricalEventConfig Instance()
        {
            if (config == null)
            {
                if (File.Exists(GematriaFactory.Instance().GetConfigDir() + "\\HistoricalEvents.xml"))
                {
                    config = (HistoricalEventConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\HistoricalEvents.xml", typeof(HistoricalEventConfig));
                }
                else
                {
                    HistoricalEventConfig thisConfig = new HistoricalEventConfig();
                    thisConfig.SetDefaults();
                    SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\HistoricalEvents.xml", thisConfig);
                    config = (HistoricalEventConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\HistoricalEvents.xml", typeof(HistoricalEventConfig));
                }
            }
            return config;
        }
    }
}
