// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Cipher;
using System;
using System.Collections.Generic;

namespace GematriaForTruth.API.DataStructures

{
    [Serializable]
    public class MatchValue
    {
        public enum Type
        {
            System,
            UserDefined,
            UserDefinedTemporary,
            UserDefinedHistoricalDateTwoYearDigitForwardsIso,
            UserDefinedHistoricalDateTwoYearDigitForwards,
            UserDefinedHistoricalDateTwoYearDigitMirrorIso,
            UserDefinedHistoricalDateTwoYearDigitMirror,
            UserDefinedHistoricalDateFourYearDigitForwardsIso,
            UserDefinedHistoricalDateFourYearDigitForwards,
            UserDefinedHistoricalDateFourYearDigitMirrorIso,
            UserDefinedHistoricalDateFourYearDigitMirror
        }

        public Type MatchValueType { get; set; }

        public long Value { get; set; }
        public string[] Catagories { get; set; }
        public bool Enabled { get; set; }
        public string Comment { get; set; }
        public bool IsDefault { get; set; }
        public bool IsExpermimental { get; set; }
        public List<GematriaCipher> Ciphers { get; set; }
        public MatchValue()
        { }

        public MatchValue(Type matchValueType,
                          string[] catagories,
                          long value,
                          string comment,
                          List<GematriaCipher> ciphers,
                          bool isDefault,
                          bool isExpermimental,
                          bool enabled)
        {
            this.MatchValueType = matchValueType;
            this.Catagories = catagories;
            this.Value = value;
            this.Comment = comment;
            this.Ciphers = ciphers;
            this.IsDefault = isDefault;
            this.IsExpermimental = isExpermimental;
            this.Enabled = enabled;
        }

        public static string GetTypeString(Type theType)
        {
            switch (theType)
            {
                case Type.System:
                    return "System Defined";
                case Type.UserDefined:
                    return "User Defined";
                case Type.UserDefinedHistoricalDateFourYearDigitForwards:
                    return "H-Event-4Y-F";
                case Type.UserDefinedHistoricalDateFourYearDigitMirror:
                    return "H-Event-4Y-M";
                case Type.UserDefinedHistoricalDateTwoYearDigitForwards:
                    return "H-Event-2Y-F";
                case Type.UserDefinedHistoricalDateTwoYearDigitMirror:
                    return "H-Event-2Y-M";

            }
            return "Unknown";
        }
    }
}
