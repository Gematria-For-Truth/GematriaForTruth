// Copyright (c) 2020 Gematria Tools
using System;


namespace GematriaForTruth.API.Config
{
    [Serializable]
    public abstract class GematriaToolsXmlConfig
    {
        private static readonly object LockThis = new object();

        public GematriaToolsXmlConfig()
        {
        }

        public static void SaveConfig(string configFilename, object whatToWrite)
        {
            lock (LockThis)
            {
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(whatToWrite.GetType());

                try
                {
                    System.IO.FileStream file = System.IO.File.Create(configFilename);

                    writer.Serialize(file, whatToWrite);
                    file.Close();
                }
                catch
                { }
            }
        }

        public static GematriaToolsXmlConfig LoadConfig(string configFilename, Type type)
        {
            GematriaToolsXmlConfig gematriaSiteGrabberConfig;

            // Now we can read the serialized book ...  
            System.Xml.Serialization.XmlSerializer reader =
            new System.Xml.Serialization.XmlSerializer(type);
            System.IO.StreamReader file = new System.IO.StreamReader(
                @configFilename);
            gematriaSiteGrabberConfig = (GematriaToolsXmlConfig)reader.Deserialize(file);
            file.Close();

            return gematriaSiteGrabberConfig;
        }
    }
}
