// Copyright (c) 2020 Gematria Tools


using GematriaForTruth.API.Cipher;
using GematriaForTruth.API.Config;
using GematriaForTruth.API.DataStructures;
using GematriaForTruth.API.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GematriaForTruth.API.Factory
{
    public class GematriaFactory
    {

        private static GematriaFactory m_GematriaFactory;
        public GematriaCipher[] GetGematriaCiphers() { return CipherConfig.Instance().ciphers.ToArray(); }

        private GematriaFactory()
        {
        }
        public static GematriaFactory Instance()
        {
            if (m_GematriaFactory == null)
            {
                m_GematriaFactory = new GematriaFactory();
            }
            return m_GematriaFactory;
        }


        public string GetRelease()
        {
            return "Gematria for Truth UI Beta 1.6";
        }

        public string GetAppDir()
        {
            string appDir = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\" + GetRelease();
            if (Directory.Exists(appDir) == false)
                Directory.CreateDirectory(appDir);

            return appDir;
        }

        public string GetExportsDir()
        {
            string exportsDir = GetAppDir() + "\\Exports";
            if (Directory.Exists(exportsDir) == false)
                Directory.CreateDirectory(exportsDir);

            return exportsDir;
        }

        public string GetScreenShotsDir()
        {
            string screenShotsDir = GetAppDir() + "\\ScreenShots";
            if (Directory.Exists(screenShotsDir) == false)
                Directory.CreateDirectory(screenShotsDir);

            return screenShotsDir;
        }

        public string GetLogDir()
        {
            string logDir = GetAppDir() + "\\Log";
            if (Directory.Exists(logDir) == false)
                Directory.CreateDirectory(logDir);

            return logDir;
        }

        public string GetConfigDir()
        {
            string configDir = GetAppDir() + "\\Config";
            if (Directory.Exists(configDir) == false)
                Directory.CreateDirectory(configDir);

            return configDir;
        }

        public string GetDatabaseDir()
        {
            string databasesDir = GetAppDir() + "\\Database";
            if (Directory.Exists(databasesDir) == false)
                Directory.CreateDirectory(databasesDir);

            return databasesDir;
        }

        public string GetDatabasePredefinedDir()
        {
            string databasesPredefinedDir = GetDatabaseDir() + "\\Predefined";
            if (Directory.Exists(databasesPredefinedDir) == false)
                Directory.CreateDirectory(databasesPredefinedDir);

            return databasesPredefinedDir;
        }

        public string GetSavedResultsDir()
        {
            string savedResultsDir = GetAppDir() + "\\SavedResults";
            if (Directory.Exists(savedResultsDir) == false)
                Directory.CreateDirectory(savedResultsDir);

            return savedResultsDir;
        }

        public string CreateCreatesResultsDirStruct(string subcatagory)
        {

            if (subcatagory.Length > 0)
            {
                if (!Directory.Exists(GetSavedResultsDir() + "\\" + subcatagory))
                {
                    Directory.CreateDirectory(GetSavedResultsDir() + "\\" + subcatagory);
                }
            }
            string DateDir = DateTime.Now.Month + "_"
                + DateTime.Now.Day
                + "_" + DateTime.Now.Year
                + "_" + DateTime.Now.Hour
                + "_" + DateTime.Now.Minute
                + "_" + DateTime.Now.Second;
            DirectoryInfo di = Directory.CreateDirectory(GetSavedResultsDir() + "\\" + subcatagory + "\\" + DateDir);

            return di.FullName;
        }

        public GematriaCipher[] GetEnabledGematriaCiphers()
        {
            List<GematriaCipher> enabledCiphers = new List<GematriaCipher>();
            int displayPriority = 0;

            foreach (GematriaCipher cipher in CipherConfig.Instance().ciphers)
            {
                if (cipher.Enabled)
                {
                    cipher.DisplayPriority = displayPriority;
                    enabledCiphers.Add(cipher);
                    displayPriority++;
                }
            }
            return enabledCiphers.ToArray();
        }

        public RandomizedGematriaCipher[] GetRandomizedGematriaCipher()
        {
            List<RandomizedGematriaCipher> ciphers = new List<RandomizedGematriaCipher>();

            GematriaCipher[] allCiphers = GetGematriaCiphers();

            foreach (GematriaCipher cipher in allCiphers)
            {
                if (typeof(RandomizedGematriaCipher).IsInstanceOfType(cipher))
                    ciphers.Add((RandomizedGematriaCipher)cipher);
            }

            return ciphers.ToArray();
        }

        public MatchValue[] GetEnabledMatchValues()
        {
            List<MatchValue> enabledmatchValues = new List<MatchValue>();

            foreach (MatchValue matchValue in MatchValueConfig.Instance().MatchValues)
            {
                if (matchValue.Enabled)
                {
                    enabledmatchValues.Add(matchValue);
                }
            }
            return enabledmatchValues.ToArray();
        }

        public MatchValue GetMatchValue(long value)
        {
            foreach (MatchValue matchValue in MatchValueConfig.Instance().MatchValues)
            {
                if (matchValue.Value == value)
                    return matchValue;
            }
            return null;
        }

        public bool DoesMatchValueCategoryExist(string category)
        {
            List<MatchValue> matchValues = MatchValueConfig.Instance().MatchValues;

            foreach (MatchValue matchValue in matchValues)
            {
                foreach (string matchValueCatagory in matchValue.Catagories)
                {
                    if (matchValueCatagory == category)
                        return true;
                }
            }
            return false;
        }

        public List<string> GetEventDescriptions(DateTime eventDateTime)
        {
            List<string> eventDescriptions = new List<string>();

            foreach (HistoricalEvent historicalEvent in HistoricalEventConfig.Instance().HistoricalEvents)
            {
                if (historicalEvent.Date == eventDateTime)
                {
                    eventDescriptions.Add("[" + HistoricalEvent.GetHistoricalEventCatagoryString(historicalEvent.Catagory) + "] " + historicalEvent.Description);
                }
            }

            return eventDescriptions;
        }

        public List<string> GetHistoricalEventCategories()
        {
            List<string> historicalCategories = new List<string>();

            historicalCategories.Add(HistoricalEvent.GetHistoricalEventCatagoryString(HistoricalEvent.EventCatagory.Birth));
            historicalCategories.Add(HistoricalEvent.GetHistoricalEventCatagoryString(HistoricalEvent.EventCatagory.Death));
            historicalCategories.Add(HistoricalEvent.GetHistoricalEventCatagoryString(HistoricalEvent.EventCatagory.Historical));

            return historicalCategories;
        }

        public List<string> GetMatchValueCategories()
        {
            List<string> matchValueCategories = new List<string>();

            List<MatchValue> matchValues = MatchValueConfig.Instance().MatchValues;

            foreach (MatchValue matchValue in matchValues)
            {
                foreach (string matchValueCatagory in matchValue.Catagories)
                {
                    if (matchValueCategories.Contains(matchValueCatagory) == false)
                        matchValueCategories.Add(matchValueCatagory);
                }
            }

            return matchValueCategories;
        }

        public List<MatchValue> GetMatchValues(string categoryString)
        {
            List<MatchValue> matchValues = MatchValueConfig.Instance().MatchValues;
            List<MatchValue> matchValuesToReturn = new List<MatchValue>();

            foreach (MatchValue matchValue in matchValues)
            {
                foreach (string matchValueCatagory in matchValue.Catagories)
                {
                    if (matchValueCatagory == categoryString)
                        matchValuesToReturn.Add(matchValue);
                }

            }
            return matchValuesToReturn;
        }
        public List<MatchValue> GetDefaultMatchValues()
        {
            List<MatchValue> matchValues = new List<MatchValue>();
            foreach (MatchValue matchValue in MatchValueConfig.Instance().MatchValues)
            {
                if (matchValue.IsDefault)
                    matchValues.Add(matchValue);
            }
            return matchValues;
        }

        public List<MatchValue> GetAllExpermimentalMatchValues()
        {
            List<MatchValue> matchValues = new List<MatchValue>();
            foreach (MatchValue matchValue in MatchValueConfig.Instance().MatchValues)
            {
                if (matchValue.IsExpermimental)
                    matchValues.Add(matchValue);
            }
            return matchValues;
        }

        public List<MatchValue> GetAllUserDefinedMatchValues()
        {
            List<MatchValue> matchValues = MatchValueConfig.Instance().MatchValues;

            List<MatchValue> allUserDefinedMatchValues = new List<MatchValue>();

            for (int i = 0; i < matchValues.Count; i++)
            {
                if (matchValues.ElementAt(i).MatchValueType == MatchValue.Type.UserDefined)
                {
                    allUserDefinedMatchValues.Add(matchValues.ElementAt(i));
                }
            }
            return allUserDefinedMatchValues;
        }

        public List<MatchValue> GetAllMatchValues()
        {
            return MatchValueConfig.Instance().MatchValues;
        }

        public List<HistoricalEvent> GetAllMatchHistoricalEvents()
        {
            return HistoricalEventConfig.Instance().HistoricalEvents;
        }

        public List<HistoricalEvent> GetAllHistoricalEvents()
        {
            return HistoricalEventConfig.Instance().HistoricalEvents;
        }

        public List<HistoricalEvent> GetDefaultHistoricalEvents()
        {
            List<HistoricalEvent> historicalEvents = new List<HistoricalEvent>();
            foreach (HistoricalEvent historicalEvent in HistoricalEventConfig.Instance().HistoricalEvents)
            {
                if (historicalEvent.IsDefault)
                    historicalEvents.Add(historicalEvent);
            }
            return historicalEvents;
        }

        public List<HistoricalEvent> GetAllEnabledHistoricalEvents()
        {
            List<HistoricalEvent> historicalEvents = new List<HistoricalEvent>();
            foreach (HistoricalEvent historicalEvent in HistoricalEventConfig.Instance().HistoricalEvents)
            {
                if (historicalEvent.Enabled)
                    historicalEvents.Add(historicalEvent);
            }
            return historicalEvents;
        }

        public List<HistoricalEvent> GetAllUserDefinedHistoricalEvents()
        {
            List<HistoricalEvent> historicalEvents = HistoricalEventConfig.Instance().HistoricalEvents;

            List<HistoricalEvent> allUserDefinedHistoricalEvents = new List<HistoricalEvent>();

            for (int i = 0; i < historicalEvents.Count; i++)
            {
                if (historicalEvents.ElementAt(i).HistoricalEventType == HistoricalEvent.Type.UserDefined)
                {
                    allUserDefinedHistoricalEvents.Add(historicalEvents.ElementAt(i));
                }
            }
            return allUserDefinedHistoricalEvents;
        }

        public void DisableAllHistoricalEvents()
        {
            List<HistoricalEvent> historicalEvents = HistoricalEventConfig.Instance().HistoricalEvents.ToList();

            foreach (HistoricalEvent historicalEvent in historicalEvents)
            {
                historicalEvent.Enabled = false;
            }
        }

        public GematriaCipher GetGematriaCipher(string cipherName)
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();

            for (int i = 0; i < ciphers.Length; i++)
                if (ciphers[i].Name.Equals(cipherName))
                    return ciphers[i];

            return null;
        }

        public Task<string[]> FindCipherMatchsByValueAsync(string cypher, long value, int throttleInMiliSeconds)
        {
            WebDbQueryWrapper qr = new WebDbQueryWrapper("http://www.gematrinator.com/nextgen/getmatch.php?search=", throttleInMiliSeconds);
            return qr.FindCipherMatchsByValue(cypher, value);
        }

        public GematriaCipher [] GetBaseCiphers()
        { 
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> baseCiphers = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (ciphers[i].IsBase)
                {
                    baseCiphers.Add(ciphers[i]);
                }
            }
            return baseCiphers.ToArray();
        }

        public List<GematriaCipher> GetAllUserDefinedCiphers()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> allUserDefinedCiphers = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (ciphers[i].IsUserDefined)
                {
                    allUserDefinedCiphers.Add(ciphers[i]);
                }
            }
            return allUserDefinedCiphers;
        }


        public List<GematriaCipher> GetDefaultCiphers()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> defaultCiphers = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (ciphers[i].IsDefault)
                {
                    defaultCiphers.Add(ciphers[i]);
                }
            }
            return defaultCiphers;
        }

        public List<GematriaCipher> GetAllCiphersMinusForeign()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> allCiphersMinusForeign = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (!ciphers[i].IsForeign)
                {
                    allCiphersMinusForeign.Add(ciphers[i]);
                }
            }
            return allCiphersMinusForeign;
        }

        public void DisableAllCiphers()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();

            foreach (GematriaCipher cipher in ciphers)
            {
                cipher.Enabled = false;
            }
        }

        public void DisableAllMatchValues()
        {
            List<MatchValue> matchValues = MatchValueConfig.Instance().MatchValues.ToList();

            foreach (MatchValue matchValue in matchValues)
            {
                matchValue.Enabled = false;
            }
        }

        public List<GematriaCipher> GetAllExpermimentalCiphersMinusForign()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> allExpermimentalCiphersMinusForign = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (ciphers[i].IsExperimental && !ciphers[i].IsForeign)
                {
                    allExpermimentalCiphersMinusForign.Add(ciphers[i]);
                }
            }
            return allExpermimentalCiphersMinusForign;
        }

        public List<GematriaCipher> GetAllForeignCiphers()
        {
            GematriaCipher[] ciphers = GetGematriaCiphers();
            List<GematriaCipher> allForeignCiphers = new List<GematriaCipher>();

            for (int i = 0; i < ciphers.Length; i++)
            {
                if (ciphers[i].IsForeign)
                {
                    allForeignCiphers.Add(ciphers[i]);
                }
            }
            return allForeignCiphers;
        }


        public void SaveNewCiphersConfig(CipherConfig.CurrentConfig theCurentConfig)
        {

            List<GematriaCipher> ciphersToEnable;

            CipherConfig.Instance().currentConfig = theCurentConfig;

            switch (theCurentConfig)
            {
                case CipherConfig.CurrentConfig.IsDefault:
                    ciphersToEnable = GetDefaultCiphers();
                    break;

                case CipherConfig.CurrentConfig.IsBase:
                    ciphersToEnable = GetBaseCiphers().ToList();
                    break;

                case CipherConfig.CurrentConfig.IsAllExperimentalMinusForeign:
                    ciphersToEnable = GetAllExpermimentalCiphersMinusForign();
                    break;

                case CipherConfig.CurrentConfig.IsAllForeign:
                    ciphersToEnable = GetAllForeignCiphers();
                    break;

                case CipherConfig.CurrentConfig.IsAllMinusForeign:
                    ciphersToEnable = GetAllCiphersMinusForeign();
                    break;

                case CipherConfig.CurrentConfig.IsAllUserDefined:
                    ciphersToEnable = GetAllUserDefinedCiphers();
                    break;

                case CipherConfig.CurrentConfig.IsUserFavoriteDefined:
                    ciphersToEnable = GetEnabledGematriaCiphers().ToList();
                    break;

                default:
                    CipherConfig.SaveCipherConfig();
                    return;
            }

            DisableAllCiphers();
            foreach (GematriaCipher cipher in ciphersToEnable)
            {
                cipher.Enabled = true;
            }
            CipherConfig.SaveCipherConfig();
        }

        public void SaveNewMatchValueConfig(MatchValueConfig.ConfigType theCurentConfig)
        {
            List<MatchValue> matchValuesToEnable;

            MatchValueConfig.Instance().CurrentConfigType = theCurentConfig;

            switch (theCurentConfig)
            {
                case MatchValueConfig.ConfigType.IsDefault:
                    matchValuesToEnable = GetDefaultMatchValues();
                    break;

                case MatchValueConfig.ConfigType.IsAllExperimental:
                    matchValuesToEnable = GetAllExpermimentalMatchValues();
                    break;

                case MatchValueConfig.ConfigType.IsAll:
                    matchValuesToEnable = GetAllMatchValues();
                    break;

                case MatchValueConfig.ConfigType.IsAllUserDefined:
                    matchValuesToEnable = GetAllUserDefinedMatchValues();
                    break;
                default:
                    MatchValueConfig.SaveMatchValueConfig();
                    return;
            }

            DisableAllMatchValues();
            foreach (MatchValue matchValue in matchValuesToEnable)
            {
                matchValue.Enabled = true;
            }
            MatchValueConfig.SaveMatchValueConfig();
        }

        public void UpdateHistoricalEventConfig(HistoricalEventConfig.ConfigType theCurentConfig)
        {

            List<HistoricalEvent> historicalEventsToEnable;

            HistoricalEventConfig.Instance().CurrentConfigType = theCurentConfig;

            switch (theCurentConfig)
            {
                case HistoricalEventConfig.ConfigType.IsDefault:
                    historicalEventsToEnable = GetDefaultHistoricalEvents();
                    break;

                case HistoricalEventConfig.ConfigType.IsAll:
                    historicalEventsToEnable = GetAllHistoricalEvents();
                    break;

                case HistoricalEventConfig.ConfigType.IsAllUserDefined:
                    historicalEventsToEnable = GetAllUserDefinedHistoricalEvents();
                    break;
                default:
                    HistoricalEventConfig.SaveHistoricalEventConfig();
                    return;
            }

            DisableAllHistoricalEvents();
            foreach (HistoricalEvent historicalEvent in historicalEventsToEnable)
            {
                historicalEvent.Enabled = true;
            }
            HistoricalEventConfig.SaveHistoricalEventConfig();
        }
    }
}
