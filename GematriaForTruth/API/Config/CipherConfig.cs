// Copyright (c) 2020 Gematria Tools
using GematriaForTruth.API.Cipher;
using GematriaForTruth.API.DataStructures;
using GematriaForTruth.API.Factory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GematriaForTruth.API.Config
{
    [XmlInclude(typeof(GematriaCipher))]
    [XmlInclude(typeof(GreekGematriaCipher))]
    [XmlInclude(typeof(RandomizedGematriaCipher))]
    [XmlInclude(typeof(SumOfAllCiphersGematriaCipher))]
    [XmlInclude(typeof(PolymorphicCipher))]
    [XmlInclude(typeof(SumOfPrimeWithIndices))]
    [XmlInclude(typeof(SumOfTriangularWithIndices))]
    [XmlInclude(typeof(SumOfFibonacciWithIndices))]
    [Serializable]
    public class CipherConfig : GematriaToolsXmlConfig
    {
        public List<GematriaCipher> ciphers { get; set; }
        public CurrentConfig currentConfig { get; set; }
        public enum CurrentConfig
        {
            IsDefault,
            IsBase,
            IsAllExperimentalMinusForeign,
            IsAllForeign,
            IsAllMinusForeign,
            IsAllUserDefined,
            IsUserDefined,
            IsUserFavoriteDefined
        }

        private static CipherConfig config = null;

        public CipherConfig()
        {
            ciphers = new List<GematriaCipher>();
        }

        public static void SaveCipherConfig()
        {
            SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\Ciphers.xml", Instance());
        }

        public void SetDefaults()
        {
            currentConfig = CurrentConfig.IsDefault;

            GematriaCipher englishOrdinalCipher = new GematriaCipher();
            englishOrdinalCipher.Name = "English Ordinal";
            englishOrdinalCipher.Category = "English";
            englishOrdinalCipher.Enabled = true;
            englishOrdinalCipher.IsBase = true;
            englishOrdinalCipher.IsDefault = true;
            englishOrdinalCipher.RGB_Color = new int[] { 0, 186, 0 };
            englishOrdinalCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });

            ciphers.Add(englishOrdinalCipher);

            GematriaCipher cipher = new GematriaCipher();
            cipher.Name = "Full Reduction";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsBase = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 88, 125, 254 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Single Reduction";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 140, 171, 227 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 5, 6, 7, 8 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Full Reduction KV";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 97, 195, 244 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 22, 5, 6, 7, 8 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Single Reduction KV";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 70, 175, 244 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 22, 5, 6, 7, 8 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Extended";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 218, 226, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Francis Bacon";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.IsCapsMatter = true;
            cipher.RGB_Color = new int[] { 150, 244, 77 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Franc Baconis";
            cipher.Category = "English";
            cipher.IsCapsMatter = true;
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 93, 187, 88 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 'T', 't', 'U', 'u', 'V', 'v', 'W', 'w', 'X', 'x', 'Y', 'y', 'Z', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Satanic";
            cipher.Category = "English";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61 });
            ciphers.Add(cipher);

            //reverse English

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Ordinal";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsBase = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 80, 235, 21 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Full Reduction";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsBase = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 100, 226, 226 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8 });

            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Single Reduction";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 100, 216, 209 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 5, 6, 7, 8 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Full Reduction EP";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 101, 224, 194 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 22, 5, 6, 7, 8 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Single Reduction EP";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 110, 226, 156 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 22, 5, 6, 7, 8 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Extended";
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 253, 255, 119 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Francis Bacon";
            cipher.IsCapsMatter = true;
            cipher.Category = "Reverse";
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 163, 255, 88 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a', 'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q', 'P', 'O', 'N', 'M', 'L', 'K', 'J', 'I', 'H', 'G', 'F', 'E', 'D', 'C', 'B', 'A' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Franc Baconis";
            cipher.IsCapsMatter = true;
            cipher.Category = "Reverse";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 111, 193, 121 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Z', 'z', 'Y', 'y', 'X', 'x', 'W', 'w', 'V', 'v', 'U', 'u', 'T', 't', 'S', 's', 'R', 'r', 'Q', 'q', 'P', 'p', 'O', 'o', 'N', 'n', 'M', 'm', 'L', 'l', 'K', 'k', 'J', 'j', 'I', 'i', 'H', 'h', 'G', 'g', 'F', 'f', 'E', 'e', 'D', 'd', 'C', 'c', 'B', 'b', 'A', 'a' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Satanic";
            cipher.Category = "Reverse";
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 51, 51 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Jewish
            cipher = new GematriaCipher();
            cipher.Name = "Jewish Reduction";
            cipher.Category = "Jewish";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 159, 99, 197 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Jewish Ordinal";
            cipher.Category = "Jewish";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 154, 121, 227 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Jewish";
            cipher.Category = "Jewish";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 153, 102, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            ciphers.Add(cipher);

            //Kabbalah

            cipher = new GematriaCipher();
            cipher.Name = "ALW Kabbalah";
            cipher.Category = "Kabbalah";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 64, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'l', 'w', 'h', 's', 'd', 'o', 'z', 'k', 'v', 'g', 'r', 'c', 'n', 'y', 'j', 'u', 'f', 'q', 'b', 'm', 'x', 'i', 't', 'e', 'p' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "KFW Kabbalah";
            cipher.Category = "Kabbalah";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 88, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'k', 'f', 'w', 'r', 'm', 'd', 'y', 't', 'a', 'v', 'q', 'h', 'c', 'x', 'o', 'j', 'e', 'l', 'g', 'b', 's', 'n', 'i', 'z', 'u', 'p' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "LCH Kabbalah";
            cipher.Category = "Kabbalah";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 93, 73 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'i', 'l', 'c', 'h', 'p', 'a', 'x', 'j', 'w', 't', 'o', 'g', 'f', 'e', 'r', 's', 'q', 'k', 'y', 'z', 'b', 'm', 'v', 'd', 'n', 'u' },
                                                            new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });
            ciphers.Add(cipher);

            //Mathematical
            cipher = new GematriaCipher();
            cipher.Name = "English Sumerian";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 93, 73 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 108, 114, 120, 126, 132, 138, 144, 150, 156 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse English Sumerian";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 220, 208, 148 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 108, 114, 120, 126, 132, 138, 144, 150, 156 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Primes";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 204, 111 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Trigonal";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 231, 180, 113 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91, 105, 120, 136, 153, 171, 190, 210, 231, 253, 276, 300, 325, 351 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Squares";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 400, 441, 484, 529, 576, 625, 676 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Primes";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 209, 145 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);



            cipher = new GematriaCipher();
            cipher.Name = "Reverse Trigonal";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 238, 191, 112 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91, 105, 120, 136, 153, 171, 190, 210, 231, 253, 276, 300, 325, 351 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Squares";
            cipher.Category = "Mathematical";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 400, 441, 484, 529, 576, 625, 676 });
            ciphers.Add(cipher);
            cipher.ReverseOrder();

            //Other
            cipher = new GematriaCipher();
            cipher.Name = "Septenary";
            cipher.Category = "Other";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 153, 77 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Chaldean";
            cipher.Category = "Other";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 166, 166, 99 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 8, 3, 5, 1, 1, 2, 3, 4, 5, 7, 8, 1, 2, 3, 4, 6, 6, 6, 5, 1, 7 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Keypad";
            cipher.Category = "Other";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.RGB_Color = new int[] { 255, 126, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Fibonacci";
            cipher.Category = "Other";
            cipher.Enabled = true;
            cipher.IsDefault = true;
            cipher.IsExperimental = false;
            cipher.RGB_Color = new int[] { 233, 202, 148 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 233, 144, 89, 55, 34, 21, 13, 8, 5, 3, 2, 1, 1 });
            ciphers.Add(cipher);

            GematriaCipher hebrewReductionCipher = new GematriaCipher();
            hebrewReductionCipher.Name = "Hebrew Reduction";
            hebrewReductionCipher.Category = "Foreign\\Hebrew";
            hebrewReductionCipher.Enabled = false;
            hebrewReductionCipher.IsForeign = true;
            hebrewReductionCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            hebrewReductionCipher.RGB_Color = new int[] { 255, 189, 2 };
            hebrewReductionCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 2, 4, 5, 8, 9 });
            ciphers.Add(hebrewReductionCipher);

            GematriaCipher hebrewOrdinalCipher = new GematriaCipher();
            hebrewOrdinalCipher.Name = "Hebrew Ordinal";
            hebrewOrdinalCipher.Category = "Foreign\\Hebrew";
            hebrewOrdinalCipher.Enabled = false;
            hebrewOrdinalCipher.IsForeign = true;
            hebrewOrdinalCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            hebrewOrdinalCipher.RGB_Color = new int[] { 255, 209, 36 };
            hebrewOrdinalCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 11, 13, 14, 17, 18 });
            ciphers.Add(hebrewOrdinalCipher);

            GematriaCipher hebrewGematriaCipher = new GematriaCipher();
            hebrewGematriaCipher.Name = "Hebrew Gematria";
            hebrewGematriaCipher.Category = "Foreign\\Hebrew";
            hebrewGematriaCipher.Enabled = false;
            hebrewGematriaCipher.IsForeign = true;
            hebrewGematriaCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            hebrewGematriaCipher.RGB_Color = new int[] { 255, 227, 93 };
            hebrewGematriaCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 20, 40, 50, 80, 90 });
            ciphers.Add(hebrewGematriaCipher);

            cipher = new GematriaCipher();
            cipher.Name = "Hebrew Soffits";
            cipher.Category = "Foreign\\Hebrew";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            cipher.RGB_Color = new int[] { 255, 209, 36 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            ciphers.Add(cipher);

            //Babylonian BASE 60

            //https://oeis.org/A060707
            cipher = new GematriaCipher();
            cipher.Name = "Babyl Exp of Pi";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 252, 30, 101 };
            cipher.Comment = "https://oeis.org/A060707";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 8, 29, 44, 0, 47, 25, 53, 7, 24, 57, 36, 17, 43, 4, 29, 7, 10, 3, 41, 17, 52, 36, 12, 14, 36 });
            ciphers.Add(cipher);

            //https://oeis.org/A060707
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Babyl Exp of Pi";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 252, 30, 101 };
            cipher.Comment = "https://oeis.org/A060707";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 8, 29, 44, 0, 47, 25, 53, 7, 24, 57, 36, 17, 43, 4, 29, 7, 10, 3, 41, 17, 52, 36, 12, 14, 36 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //https://oeis.org/A260512
            cipher = new GematriaCipher();
            cipher.Name = "Babyl Exp Sqrt of Pi";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 247, 0 };
            cipher.Comment = "https://oeis.org/A260512";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 46, 20, 50, 1, 54, 27, 50, 51, 55, 14, 46, 27, 32, 41, 13, 6, 28, 9, 21, 15, 28, 41, 20, 17, 47 });
            ciphers.Add(cipher);

            //https://oeis.org/A260512
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Babyl Exp Sqrt of Pi";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 247, 0 };
            cipher.Comment = "https://oeis.org/A260512";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 46, 20, 50, 1, 54, 27, 50, 51, 55, 14, 46, 27, 32, 41, 13, 6, 28, 9, 21, 15, 28, 41, 20, 17, 47 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A280188
            cipher = new GematriaCipher();
            cipher.Name = "Babyl Exp of Sine(1 Degree)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 81 };
            cipher.Comment = "https://oeis.org/A280188";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 49, 43, 11, 14, 44, 16, 26, 18, 28, 49, 20, 26, 50, 41, 13, 6, 46, 25, 26, 26, 34, 6, 40, 18 });
            ciphers.Add(cipher);

            //https://oeis.org/A280188
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Babyl Exp of Sine(1 Degree)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 81 };
            cipher.Comment = "https://oeis.org/A280188";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 49, 43, 11, 14, 44, 16, 26, 18, 28, 49, 20, 26, 50, 41, 13, 6, 46, 25, 26, 26, 34, 6, 40, 18 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A280190
            cipher = new GematriaCipher();
            cipher.Name = "Babyl Exp of Sine(3 Degrees)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 81 };
            cipher.Comment = "https://oeis.org/A280190";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 8, 24, 33, 59, 34, 28, 14, 50, 5, 28, 29, 38, 47, 51, 57, 24, 25, 56, 50, 24, 30, 4, 12, 1, 50 });
            ciphers.Add(cipher);

            //https://oeis.org/A280190
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Babyl Exp of Sine(3 Degrees)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 255 };
            cipher.Comment = "https://oeis.org/A280190";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 8, 24, 33, 59, 34, 28, 14, 50, 5, 28, 29, 38, 47, 51, 57, 24, 25, 56, 50, 24, 30, 4, 12, 1, 50 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A070197
            cipher = new GematriaCipher();
            cipher.Name = "Babyl Exp of Sqrt(2)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 255 };
            cipher.Comment = "https://oeis.org/A070197";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 24, 51, 10, 7, 46, 6, 4, 44, 50, 28, 51, 20, 34, 26, 20, 4, 31, 2, 38, 30, 53, 27, 38, 34, 5 });
            ciphers.Add(cipher);

            //https://oeis.org/A070197
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Babyl Exp of Sqrt(2)";
            cipher.Category = "Experimental\\Babylonian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 81 };
            cipher.Comment = "https://oeis.org/A070197";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 24, 51, 10, 7, 46, 6, 4, 44, 50, 28, 51, 20, 34, 26, 20, 4, 31, 2, 38, 30, 53, 27, 38, 34, 5 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Novem Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 199, 66 };
            cipher.Comment = "Base 9";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81, 90, 99, 108, 117, 126, 135, 144, 153, 162, 171, 180, 189, 198, 207, 216, 225, 234 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Novem Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 199, 66 };
            cipher.Comment = "Base 9";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 9, 18, 27, 36, 45, 54, 63, 72, 81, 90, 99, 108, 117, 126, 135, 144, 153, 162, 171, 180, 189, 198, 207, 216, 225, 234 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GematriaCipher();
            cipher.Name = "Undenary Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 199, 66 };
            cipher.Comment = "Base 11";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 188, 199, 210, 221, 232, 243, 254, 265, 276, 287 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Undenary Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 199, 66 };
            cipher.Comment = "Base 11";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110, 121, 132, 143, 154, 165, 176, 188, 199, 210, 221, 232, 243, 254, 265, 276, 287 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Duodecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 169, 255, 51 };
            cipher.Comment = "Base 12";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120, 132, 144, 156, 168, 180, 192, 204, 216, 228, 240, 252, 264, 276, 288, 300, 312 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Duodecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 169, 255, 51 };
            cipher.Comment = "Base 12";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120, 132, 144, 156, 168, 180, 192, 204, 216, 228, 240, 252, 264, 276, 288, 300, 312 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Tridecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 50, 218, 240 };
            cipher.Comment = "Base 13";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 13, 26, 39, 52, 65, 78, 91, 104, 117, 130, 143, 156, 169, 182, 195, 208, 221, 234, 247, 260, 273, 286, 299, 312, 325, 338 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Tridecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 50, 218, 240 };
            cipher.Comment = "Base 13";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 13, 26, 39, 52, 65, 78, 91, 104, 117, 130, 143, 156, 169, 182, 195, 208, 221, 234, 247, 260, 273, 286, 299, 312, 325, 338 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Tetradecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 127, 80 };
            cipher.Comment = "Base 14";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 14, 28, 42, 56, 60, 74, 98, 112, 126, 140, 154, 168, 182, 196, 210, 224, 238, 252, 266, 280, 294, 308, 322, 336, 350, 364 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Tetradecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 127, 80 };
            cipher.Comment = "Base 14";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 14, 28, 42, 56, 60, 74, 98, 112, 126, 140, 154, 168, 182, 196, 210, 224, 238, 252, 266, 280, 294, 308, 322, 336, 350, 364 });
            ciphers.Add(cipher);
            cipher.ReverseOrder();

            cipher = new GematriaCipher();
            cipher.Name = "Hexadecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "Base 16";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 16, 32, 48, 64, 80, 96, 112, 128, 144, 160, 176, 192, 208, 224, 240, 256, 272, 288, 304, 320, 336, 352, 368, 384, 400, 416 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Hexadecimal Maximus";
            cipher.Category = "Experimental\\BaseN";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "Base 16";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 16, 32, 48, 64, 80, 96, 112, 128, 144, 160, 176, 192, 208, 224, 240, 256, 272, 288, 304, 320, 336, 352, 368, 384, 400, 416 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            // Beatus
            cipher = new GematriaCipher();
            cipher.Name = "Beatus of Liebana";
            cipher.Category = "Experimental\\Beatus";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 202, 20, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 200, 200, 300, 400, 500 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Beatus Ordinal";
            cipher.Category = "Experimental\\Beatus";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 202, 50, 235 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 20, 21, 21, 23 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Beatus Reduction";
            cipher.Category = "Experimental\\Beatus";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 202, 80, 215 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 2, 2, 3, 4, 5 });
            ciphers.Add(cipher);

            //exp Elizabethan
            //same as ordinal
            cipher = new GematriaCipher();
            cipher.Name = "Elizabethan Simple";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 21, 22, 23, 24 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Elizabethan Simple";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 21, 22, 23, 24 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Elizabethan Short";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 64, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 2, 3, 4, 5, 6 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Elizabethan Short";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 64, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 2, 3, 4, 5, 6 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Elizabethan Kaye";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 191, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 27, 28, 29, 30, 31, 32, 33, 34, 35, 35, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 20, 21, 22, 23, 24 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Modern Kaye";
            cipher.Category = "Experimental\\Elizabethan";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 191, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 27, 28, 29, 30, 31, 32, 33, 34, 35, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(cipher);


            //https://oeis.org/A091785
            cipher = new GematriaCipher();
            cipher.Name = "Evil Numbers";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 230, 230 };
            cipher.Comment = "https://oeis.org/A001969";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 9, 12, 15, 17, 20, 23, 27, 29, 33, 36, 39, 43, 45, 48, 51, 53, 57, 60, 63, 65, 68, 71, 75, 77 });
            ciphers.Add(cipher);

            //https://oeis.org/A091785
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Evil Numbers";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 230, 230 };
            cipher.Comment = "https://oeis.org/A001969";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 9, 12, 15, 17, 20, 23, 27, 29, 33, 36, 39, 43, 45, 48, 51, 53, 57, 60, 63, 65, 68, 71, 75, 77 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A262675
            cipher = new GematriaCipher();
            cipher.Name = "Exponentially Evil";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 26, 26 };
            cipher.Comment = "https://oeis.org/A262675";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 27, 32, 64, 125, 216, 243, 343, 512, 729, 864, 1000, 1024, 1331, 1728, 1944, 2197, 2744, 3125, 3375, 4000, 4096, 4913, 5832, 6859 });
            ciphers.Add(cipher);

            //https://oeis.org/A262675
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Exponentially Evil";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 26, 26 };
            cipher.Comment = "https://oeis.org/A262675";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 27, 32, 64, 125, 216, 243, 343, 512, 729, 864, 1000, 1024, 1331, 1728, 1944, 2197, 2744, 3125, 3375, 4000, 4096, 4913, 5832, 6859 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A125497
            cipher = new GematriaCipher();
            cipher.Name = "Evil Cubes";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 179, 179 };
            cipher.Comment = "https://oeis.org/A125497";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 27, 125, 216, 343, 729, 1000, 1331, 1728, 2744, 3375, 4913, 5832, 6859, 8000, 9261, 10648, 13824, 19683, 21952, 27000, 29791, 35937, 39304, 46656, 50653 });
            ciphers.Add(cipher);

            //https://oeis.org/A125497
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Evil Cubes";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 179, 179 };
            cipher.Comment = "https://oeis.org/A125497";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 27, 125, 216, 343, 729, 1000, 1331, 1728, 2744, 3375, 4913, 5832, 6859, 8000, 9261, 10648, 13824, 19683, 21952, 27000, 29791, 35937, 39304, 46656, 50653 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //https://oeis.org/A125497
            cipher = new GematriaCipher();
            cipher.Name = "Evil Primes";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 204, 204 };
            cipher.Comment = "https://oeis.org/A027699";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 17, 23, 29, 43, 53, 71, 83, 89, 101, 113, 139, 149, 163, 197, 257, 263, 269, 277, 281, 293, 311, 317, 337, 347 });
            ciphers.Add(cipher);


            //https://oeis.org/A125497
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Evil Primes";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 204, 204 };
            cipher.Comment = "https://oeis.org/A027699";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 17, 23, 29, 43, 53, 71, 83, 89, 101, 113, 139, 149, 163, 197, 257, 263, 269, 277, 281, 293, 311, 317, 337, 347 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //https://oeis.org/A231431
            cipher = new GematriaCipher();
            cipher.Name = "Evil Squares";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 102, 102 };
            cipher.Comment = "https://oeis.org/A231431";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 9, 36, 144, 169, 225, 441, 576, 676, 729, 900, 1369, 1764, 2025, 2209, 2304, 2704, 2809, 2916, 3249, 3600, 3721, 3969, 4761, 5329, 5476 });
            ciphers.Add(cipher);

            //https://oeis.org/A231431
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Evil Squares";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 102, 102 };
            cipher.Comment = "https://oeis.org/A231431";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 9, 36, 144, 169, 225, 441, 576, 676, 729, 900, 1369, 1764, 2025, 2209, 2304, 2704, 2809, 2916, 3249, 3600, 3721, 3969, 4761, 5329, 5476 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A130200
            cipher = new GematriaCipher();
            cipher.Name = "Evil Triangular";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 153, 153 };
            cipher.Comment = "https://oeis.org/A130200";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 3, 6, 10, 15, 36, 45, 66, 78, 105, 120, 136, 153, 190, 210, 231, 300, 325, 378, 435, 528, 561, 630, 703, 741, 780 });
            ciphers.Add(cipher);

            //https://oeis.org/A130200
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Evil Triangular";
            cipher.Category = "Experimental\\Evil";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 153, 153 };
            cipher.Comment = "https://oeis.org/A130200";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 3, 6, 10, 15, 36, 45, 66, 78, 105, 120, 136, 153, 190, 210, 231, 300, 325, 378, 435, 528, 561, 630, 703, 741, 780 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            // Arabic Alphabet
            cipher = new GematriaCipher();
            cipher.Name = "Arabic";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 180, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Arabic Reduction";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 235, 200, 200 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Arabic Ordinal";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 180, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Arabic";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 180, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Arabic Reduction";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 235, 200, 200 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Arabic Ordinal";
            cipher.Category = "Experimental\\Foreign\\Arabic";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 180, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'ا', 'ب', 'ج', 'د', 'ه', 'و', 'ز', 'ح', 'ط', 'ي', 'ك', 'ل', 'م', 'ن', 'س', 'ع', 'ف', 'ص', 'ق', 'ر', 'ش', 'ت', 'ث', 'خ', 'ذ', 'ض', 'ظ', 'غ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            SumOfAllCiphersGematriaCipher sumOfAllHebrewsCipher = new SumOfAllCiphersGematriaCipher(
                new[] { hebrewReductionCipher, hebrewOrdinalCipher, hebrewGematriaCipher });

            sumOfAllHebrewsCipher.Name = "Sum of All Hebrews";
            sumOfAllHebrewsCipher.Category = "Experimental\\Foreign\\Hebrew";
            sumOfAllHebrewsCipher.Enabled = false;
            sumOfAllHebrewsCipher.IsForeign = true;
            sumOfAllHebrewsCipher.IsExperimental = true;
            sumOfAllHebrewsCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            sumOfAllHebrewsCipher.RGB_Color = new int[] { 235, 52, 158 };
            ciphers.Add(sumOfAllHebrewsCipher);

            cipher = new GematriaCipher();
            cipher.Name = "Mispar Kidmi";
            cipher.Category = "Experimental\\Foreign\\Hebrew";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            cipher.RGB_Color = new int[] { 235, 52, 158 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת' },
                                                            new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 75, 105, 145, 195, 255, 325, 405, 495, 595, 795, 1095, 1495 });
            ciphers.Add(cipher);

            GematriaCipher reverseHebrewReductionCipher = new GematriaCipher();
            reverseHebrewReductionCipher.Name = "Reverse Hebrew Reduction";
            reverseHebrewReductionCipher.Category = "Experimental\\Foreign\\Hebrew";
            reverseHebrewReductionCipher.Enabled = false;
            reverseHebrewReductionCipher.IsForeign = true;
            reverseHebrewReductionCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            reverseHebrewReductionCipher.RGB_Color = new int[] { 255, 189, 2 };
            reverseHebrewReductionCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 2, 4, 5, 8, 9 });
            reverseHebrewReductionCipher.ReverseOrder();
            ciphers.Add(reverseHebrewReductionCipher);

            GematriaCipher reverseHebrewOrdinalCipher = new GematriaCipher();
            reverseHebrewOrdinalCipher.Name = "Reverse Hebrew Ordinal";
            reverseHebrewOrdinalCipher.Category = "Experimental\\Foreign\\Hebrew";
            reverseHebrewOrdinalCipher.Enabled = false;
            reverseHebrewOrdinalCipher.IsForeign = true;
            reverseHebrewOrdinalCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            reverseHebrewOrdinalCipher.RGB_Color = new int[] { 255, 209, 36 };
            reverseHebrewOrdinalCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 11, 13, 14, 17, 18 });
            reverseHebrewOrdinalCipher.ReverseOrder();
            ciphers.Add(reverseHebrewOrdinalCipher);

            GematriaCipher reverseHebrewGematriaCipher = new GematriaCipher();
            reverseHebrewGematriaCipher.Name = "Reverse Hebrew Gematria";
            reverseHebrewGematriaCipher.Category = "Experimental\\Foreign\\Hebrew";
            reverseHebrewGematriaCipher.Enabled = false;
            reverseHebrewGematriaCipher.IsForeign = true;
            reverseHebrewGematriaCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            reverseHebrewGematriaCipher.RGB_Color = new int[] { 255, 227, 93 };
            reverseHebrewGematriaCipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 20, 40, 50, 80, 90 });
            reverseHebrewGematriaCipher.ReverseOrder();
            ciphers.Add(reverseHebrewGematriaCipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Hebrew Soffits";
            cipher.Category = "Experimental\\Foreign\\Hebrew";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            cipher.RGB_Color = new int[] { 255, 209, 36 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת', 'ך', 'ם', 'ן', 'ף', 'ץ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            SumOfAllCiphersGematriaCipher reverseSumOfAllHebrewsCipher = new SumOfAllCiphersGematriaCipher(new[] { reverseHebrewReductionCipher, reverseHebrewOrdinalCipher, reverseHebrewGematriaCipher });
            reverseSumOfAllHebrewsCipher.Name = "Reverse Sum of All Hebrews";
            reverseSumOfAllHebrewsCipher.Category = "Experimental\\Foreign\\Hebrew";
            reverseSumOfAllHebrewsCipher.Enabled = false;
            reverseSumOfAllHebrewsCipher.IsForeign = true;
            reverseSumOfAllHebrewsCipher.IsExperimental = true;
            reverseSumOfAllHebrewsCipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            reverseSumOfAllHebrewsCipher.RGB_Color = new int[] { 235, 52, 158 };
            ciphers.Add(reverseSumOfAllHebrewsCipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Mispar Kidmi";
            cipher.Category = "Experimental\\Foreign\\Hebrew";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.Language = LanguageDef.SupportedLanguage.Hewbrew;
            cipher.RGB_Color = new int[] { 235, 52, 158 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'א', 'ב', 'ג', 'ד', 'ה', 'ו', 'ז', 'ח', 'ט', 'י', 'כ', 'ל', 'מ', 'נ', 'ס', 'ע', 'פ', 'צ', 'ק', 'ר', 'ש', 'ת' },
                                                            new int[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 75, 105, 145, 195, 255, 325, 405, 495, 595, 795, 1095, 1495 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GreekGematriaCipher();
            cipher.Name = "Greek Reduction";
            cipher.Category = "Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 }); ; ;
            ciphers.Add(cipher);


            cipher = new GreekGematriaCipher();
            cipher.Name = "Greek Ordinal";
            cipher.Category = "Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.RGB_Color = new int[] { 149, 199, 139 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 17 });
            ciphers.Add(cipher);

            cipher = new GreekGematriaCipher();
            cipher.Name = "Greek Isopsephy";
            cipher.Category = "Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.RGB_Color = new int[] { 139, 200, 163 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            ciphers.Add(cipher);

            cipher = new GreekGematriaCipher();
            cipher.Name = "Reverse Greek Reduction";
            cipher.Category = "Experimental\\Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 }); ; ;
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GreekGematriaCipher();
            cipher.Name = "Reverse Greek Ordinal";
            cipher.Category = "Experimental\\Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.RGB_Color = new int[] { 149, 199, 139 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 17 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GreekGematriaCipher();
            cipher.Name = "Reverse Greek Isopsephy";
            cipher.Category = "Experimental\\Foreign\\Greek";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.RGB_Color = new int[] { 139, 200, 163 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'Α', 'Β', 'Γ', 'Δ', 'Ε', 'Ϝ', 'Ζ', 'Η', 'Θ', 'Ι', 'Κ', 'Λ', 'Μ', 'Ν', 'Ξ', 'Ο', 'Π', 'Ϙ', 'Ρ', 'Σ', 'Τ', 'Υ', 'Φ', 'Χ', 'Ψ', 'Ω', 'ϡ' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //exp Latin
            cipher = new GematriaCipher();
            cipher.Name = "Archaic Latin";
            cipher.Category = "Experimental\\Foreign\\Latin";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 66, 99 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'z', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'x' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Old Italic Latin";
            cipher.Category = "Experimental\\Foreign\\Latin";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 99, 66 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'v', 'z', 'h', 'θ', 'i', 'k', 'l', 'm', 'n', 'ξ', 'o', 'p', 'ś', 'q', 'r', 's', 't', 'y', 'x', 'φ', 'ψ', 'f' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 });
            ciphers.Add(cipher);


            //exp Polish Alphabet
            cipher = new GematriaCipher();
            cipher.Name = "Polish Ordinal";
            cipher.Category = "Experimental\\Foreign\\Polish";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 145, 78, 203 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' },
                                                            new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 10, 11, 12, 12, 13, 14, 14, 15, 15, 16, 17, 18, 19, 19, 20, 21, 22, 23, 24, 25, 26, 26, 26 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Polish Reduction";
            cipher.Category = "Experimental\\Foreign\\Polish";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 148, 78, 215 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' },
                                                            new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 1, 2, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 1, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Polish Ordinal";
            cipher.Category = "Experimental\\Foreign\\Polish";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 200, 78, 150 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' },
                                                            new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 1, 2, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 1, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Polish Reduction";
            cipher.Category = "Experimental\\Foreign\\Polish";
            cipher.Enabled = false;
            cipher.IsForeign = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 205, 78, 155 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'Ą', 'B', 'C', 'Ć', 'D', 'E', 'Ę', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'Ł', 'M', 'N', 'Ń', 'O', 'Ó', 'P', 'Q', 'R', 'S', 'Ś', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ź', 'Ż' },
                                                            new int[] { 1, 1, 2, 3, 3, 4, 5, 5, 6, 7, 8, 9, 1, 2, 3, 3, 4, 5, 5, 6, 6, 7, 8, 9, 1, 1, 2, 3, 4, 5, 6, 7, 8, 8, 8 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //russian
            cipher = new GematriaCipher();
            cipher.Name = "Russian Ordinal";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 204, 102, 153 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Full Reduction";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 255, 0, 102 };


            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Single Reduction";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 153, 51, 102 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 3, 4, 5, 6 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Sumerian";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 153, 51, 153 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 108, 114, 120, 126, 132, 138, 144, 150, 156, 162, 168, 174, 180, 186, 192, 198 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Reverse Ordinal";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 204, 0, 255 };


            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Reverse Full Reduction";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 255, 102, 204 };


            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Reverse Single Reduction";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 153, 51, 255 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 3, 4, 5, 6 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Russian Reverse Sumerian";
            cipher.Category = "Experimental\\Foreign\\Russian";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsForeign = true;
            cipher.Language = LanguageDef.SupportedLanguage.Russian;
            cipher.RGB_Color = new int[] { 255, 204, 204 };

            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' },
                                                            new int[] { 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84, 90, 96, 102, 108, 114, 120, 126, 132, 138, 144, 150, 156, 162, 168, 174, 180, 186, 192, 198 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Exp Geometry
            cipher = new GematriaCipher();
            cipher.Name = "Pentagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 12, 22, 35, 51, 70, 92, 117, 145, 176, 210, 247, 287, 330, 376, 425, 477, 532, 590, 651, 715, 782, 852, 925, 1001 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Pentagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 12, 22, 35, 51, 70, 92, 117, 145, 176, 210, 247, 287, 330, 376, 425, 477, 532, 590, 651, 715, 782, 852, 925, 1001 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Hexagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 51, 51 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 15, 28, 45, 66, 91, 120, 153, 190, 231, 276, 325, 378, 435, 496, 561, 630, 703, 780, 861, 946, 1035, 1128, 1225, 1326 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Hexagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 51, 51 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 15, 28, 45, 66, 91, 120, 153, 190, 231, 276, 325, 378, 435, 496, 561, 630, 703, 780, 861, 946, 1035, 1128, 1225, 1326 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Heptagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 150, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 7, 18, 34, 55, 81, 112, 148, 189, 235, 286, 342, 403, 469, 540, 616, 697, 783, 874, 970, 1071, 1177, 1288, 1404, 1525, 1651 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Heptagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 150, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 7, 18, 34, 55, 81, 112, 148, 189, 235, 286, 342, 403, 469, 540, 616, 697, 783, 874, 970, 1071, 1177, 1288, 1404, 1525, 1651 });
            cipher.ReverseOrder();

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Octagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 21, 40, 65, 96, 133, 176, 225, 280, 341, 408, 481, 560, 645, 736, 833, 936, 1045, 1160, 1281, 1408, 1541, 1680, 1825, 1976 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Octagonal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 21, 40, 65, 96, 133, 176, 225, 280, 341, 408, 481, 560, 645, 736, 833, 936, 1045, 1160, 1281, 1408, 1541, 1680, 1825, 1976 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Pentagram Star Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 11, 31, 61, 101, 151, 211, 281, 361, 451, 551, 661, 781, 911, 1051, 1201, 1361, 1531, 1711, 1901, 2101, 2311, 2531, 2761, 3001, 3251 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Pentagram Star Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 11, 31, 61, 101, 151, 211, 281, 361, 451, 551, 661, 781, 911, 1051, 1201, 1361, 1531, 1711, 1901, 2101, 2311, 2531, 2761, 3001, 3251 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Hexagram Star Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 218, 247, 166 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 13, 37, 73, 121, 181, 253, 337, 433, 541, 661, 793, 937, 1093, 1261, 1441, 1633, 1837, 2053, 2281, 2521, 2773, 3037, 3313, 3601, 3901 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Hexagram Star Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 218, 247, 166 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 13, 37, 73, 121, 181, 253, 337, 433, 541, 661, 793, 937, 1093, 1261, 1441, 1633, 1837, 2053, 2281, 2521, 2773, 3037, 3313, 3601, 3901 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Square Pyramidal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 14, 30, 55, 91, 140, 204, 285, 385, 506, 650, 819, 1015, 1240, 1496, 1785, 2109, 2470, 2870, 3311, 3795, 4324, 4900, 5525, 6201 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Square Pyramidal Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 14, 30, 55, 91, 140, 204, 285, 385, 506, 650, 819, 1015, 1240, 1496, 1785, 2109, 2470, 2870, 3311, 3795, 4324, 4900, 5525, 6201 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Tetrahedral Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 127, 80 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 10, 20, 35, 56, 84, 120, 165, 220, 286, 364, 455, 560, 680, 816, 969, 1140, 1330, 1540, 1771, 2024, 2300, 2600, 2925, 3276 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Tetrahedral Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 127, 80 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 10, 20, 35, 56, 84, 120, 165, 220, 286, 364, 455, 560, 680, 816, 969, 1140, 1330, 1540, 1771, 2024, 2300, 2600, 2925, 3276 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Cubes Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 250, 250 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000, 1331, 1728, 2197, 2744, 3375, 4096, 4913, 5832, 6859, 8000, 9261, 10648, 12167, 13824, 15625, 17576 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Cubes Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 250, 250 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 27, 64, 125, 216, 343, 512, 729, 1000, 1331, 1728, 2197, 2744, 3375, 4096, 4913, 5832, 6859, 8000, 9261, 10648, 12167, 13824, 15625, 17576 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Octahedral Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 19, 44, 85, 146, 231, 344, 489, 670, 891, 1156, 1469, 1834, 2255, 2736, 3281, 3894, 4579, 5340, 6181, 7106, 8119, 9224, 10425, 11726 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Octahedral Maximus";
            cipher.Category = "Experimental\\Geometry";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 19, 44, 85, 146, 231, 344, 489, 670, 891, 1156, 1469, 1834, 2255, 2736, 3281, 3894, 4579, 5340, 6181, 7106, 8119, 9224, 10425, 11726 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Geometry (up to 13th)
            cipher = new GematriaCipher();
            cipher.Name = "Hexagonal";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 128, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 15, 28, 45, 66, 91, 120, 153, 190, 231, 276, 325, 325, 276, 231, 190, 153, 120, 91, 66, 45, 28, 15, 6, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Heptagonal";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 150, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 7, 18, 34, 55, 81, 112, 148, 189, 235, 286, 342, 403, 403, 342, 286, 235, 189, 148, 112, 81, 55, 34, 18, 7, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Octagonal";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 8, 21, 40, 65, 96, 133, 176, 225, 280, 341, 408, 481, 481, 408, 341, 280, 225, 176, 133, 96, 65, 40, 21, 8, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Pentagram Star Numbers (Centered 10-gonal)";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 11, 31, 61, 101, 151, 211, 281, 361, 451, 551, 661, 781, 781, 661, 551, 451, 361, 281, 211, 151, 101, 61, 31, 11, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Hexagram Star Numbers (Centered 12 - gonal)";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 128, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 13, 37, 73, 121, 181, 253, 337, 433, 541, 661, 793, 937, 937, 793, 661, 541, 433, 337, 253, 181, 121, 73, 37, 13, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Square Pyramidal";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 14, 30, 55, 91, 140, 204, 285, 385, 506, 650, 819, 819, 650, 506, 385, 285, 204, 140, 91, 55, 30, 14, 5, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Tetrahedral";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 127, 80 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 10, 20, 35, 56, 84, 120, 165, 220, 286, 364, 455, 455, 364, 286, 220, 165, 120, 84, 56, 35, 20, 10, 4, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Octahedral Numbers";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 102 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 19, 44, 85, 146, 231, 344, 489, 670, 891, 1156, 1469, 1469, 1156, 891, 670, 489, 344, 231, 146, 85, 44, 19, 6, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "N'th N-gonal Numbers";
            cipher.Category = "Experimental\\Geometry2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 150, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 6, 16, 35, 66, 112, 176, 261, 370, 506, 672, 871, 871, 672, 506, 370, 261, 176, 112, 66, 35, 16, 6, 2, 1 });
            ciphers.Add(cipher);

            //experimental
            //Inversed
            cipher = new GematriaCipher();
            cipher.Name = "Bacon Inversed";
            cipher.Category = "Experimental\\Inversed";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsCapsMatter = true;
            cipher.RGB_Color = new int[] { 22, 130, 99 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Baconis Inversed";
            cipher.Category = "Experimental\\Inversed";
            cipher.Enabled = false;
            cipher.IsCapsMatter = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 99, 22, 188 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z', },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Bacon Inversed";
            cipher.Category = "Experimental\\Inversed";
            cipher.Enabled = false;
            cipher.IsCapsMatter = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 163, 88 };
            cipher.MappingAlphaNumeric = cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Jewish
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Jewish Reduction";
            cipher.Category = "Experimental\\Jewish";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 200, 120 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Jewish Ordinal";
            cipher.Category = "Experimental\\Jewish";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 200, 120 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Jewish";
            cipher.Category = "Experimental\\Jewish";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 80, 200, 120 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'x', 'y', 'z', 'j', 'v', '&', 'w' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 200, 300, 400, 500, 600, 700, 800, 900 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //kabbalah reverse

            cipher = new GematriaCipher();
            cipher.Name = "Reverse ALW Kabbalah";
            cipher.Category = "Experimental\\Kabbalah";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 64, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'l', 'w', 'h', 's', 'd', 'o', 'z', 'k', 'v', 'g', 'r', 'c', 'n', 'y', 'j', 'u', 'f', 'q', 'b', 'm', 'x', 'i', 't', 'e', 'p' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse KFW Kabbalah";
            cipher.Category = "Experimental\\Kabbalah";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.IsDefault = false;
            cipher.RGB_Color = new int[] { 255, 88, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'k', 'f', 'w', 'r', 'm', 'd', 'y', 't', 'a', 'v', 'q', 'h', 'c', 'x', 'o', 'j', 'e', 'l', 'g', 'b', 's', 'n', 'i', 'z', 'u', 'p' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse LCH Kabbalah";
            cipher.Category = "Experimental\\Kabbalah";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 93, 73 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'i', 'l', 'c', 'h', 'p', 'a', 'x', 'j', 'w', 't', 'o', 'g', 'f', 'e', 'r', 's', 'q', 'k', 'y', 'z', 'b', 'm', 'v', 'd', 'n', 'u' },
                                                            new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //exp keyboard
            cipher = new GematriaCipher();
            cipher.Name = "Qwerty";
            cipher.Category = "Experimental\\Keyboard";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 50, 128 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 24, 22, 13, 3, 14, 15, 16, 8, 17, 18, 19, 26, 25, 9, 10, 1, 4, 12, 5, 7, 23, 2, 21, 20, 6 });
            ciphers.Add(cipher);

            //exp keyboard
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Qwerty";
            cipher.Category = "Experimental\\Keyboard";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 50, 128 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 24, 22, 13, 3, 14, 15, 16, 8, 17, 18, 19, 26, 25, 9, 10, 1, 4, 12, 5, 7, 23, 2, 21, 20, 6 });

            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Azerty";
            cipher.Category = "Experimental\\Keyboard";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 25, 23, 13, 3, 14, 15, 16, 8, 17, 18, 19, 20, 26, 9, 10, 11, 4, 12, 5, 7, 24, 21, 22, 6, 2 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Azerty";
            cipher.Category = "Experimental\\Keyboard";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 25, 23, 13, 3, 14, 15, 16, 8, 17, 18, 19, 20, 26, 9, 10, 11, 4, 12, 5, 7, 24, 21, 22, 6, 2 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //kjv bible

            //https://oeis.org/A248688
            cipher = new GematriaCipher();
            cipher.Name = "KJV New-T Chap (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 242, 51 };
            cipher.Comment = "https://oeis.org/A248688";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1 });
            ciphers.Add(cipher);

            //https://oeis.org/A248688
            cipher = new GematriaCipher();
            cipher.Name = "Reverse KJV New-T Chap (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 242, 51 };
            cipher.Comment = "https://oeis.org/A248688";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A248689
            cipher = new GematriaCipher();
            cipher.Name = "KJV New-T Verses (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 51, 255, 242 };
            cipher.Comment = "https://oeis.org/A248689";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1071, 678, 1151, 879, 1007, 433, 437, 257, 149, 155, 104, 95, 89, 47, 113, 83, 46, 25, 303, 108, 105, 61, 105, 13, 14, 25 });
            ciphers.Add(cipher);

            //https://oeis.org/A248689
            cipher = new GematriaCipher();
            cipher.Name = "Reverse KJV New-T Verses (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 51, 255, 242 };
            cipher.Comment = "https://oeis.org/A248689";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1071, 678, 1151, 879, 1007, 433, 437, 257, 149, 155, 104, 95, 89, 47, 113, 83, 46, 25, 303, 108, 105, 61, 105, 13, 14, 25 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A248690
            cipher = new GematriaCipher();
            cipher.Name = "KJV New-T Words (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 242, 51, 255 };
            cipher.Comment = "https://oeis.org/A248690";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 23343, 14949, 25640, 18658, 24229, 9422, 9462, 6046, 3084, 3022, 2183, 1979, 1837, 1022, 2244, 1666, 896, 430, 6897, 2304, 2476, 1553, 2517, 298, 294, 608 });
            ciphers.Add(cipher);

            //https://oeis.org/A248690
            cipher = new GematriaCipher();
            cipher.Name = "Reverse KJV New-T Words (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 242, 51, 255 };
            cipher.Comment = "https://oeis.org/A248690";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 23343, 14949, 25640, 18658, 24229, 9422, 9462, 6046, 3084, 3022, 2183, 1979, 1837, 1022, 2244, 1666, 896, 430, 6897, 2304, 2476, 1553, 2517, 298, 294, 608 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A248691
            cipher = new GematriaCipher();
            cipher.Name = "KJV New-T Letters (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 217, 255, 51 };
            cipher.Comment = "https://oeis.org/A248691";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 96630, 61319, 104286, 75497, 101700, 39285, 37936, 24958, 12646, 12822, 9029, 8418, 7542, 4275, 10062, 7246, 4067, 1817, 29322, 9432, 10587, 6937, 9849, 1204, 1250, 2811 });
            ciphers.Add(cipher);

            //https://oeis.org/A248691
            cipher = new GematriaCipher();
            cipher.Name = "Reverse KJV New-T Letters (no rev)";
            cipher.Category = "Experimental\\KJV Bible";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 217, 255, 51 };
            cipher.Comment = "https://oeis.org/A248691";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 96630, 61319, 104286, 75497, 101700, 39285, 37936, 24958, 12646, 12822, 9029, 8418, 7542, 4275, 10062, 7246, 4067, 1817, 29322, 9432, 10587, 6937, 9849, 1204, 1250, 2811 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //exp mathematical
            // https://oeis.org/A018252
            cipher = new GematriaCipher();
            cipher.Name = "NonPrime Maximus";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 125, 66, 244 };
            cipher.Comment = "https://oeis.org/A018252";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse NonPrime Maximus";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 125, 66, 244 };
            cipher.Comment = "https://oeis.org/A018252";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Fixed Tesla 369 Cipher
            cipher = new GematriaCipher();
            cipher.Name = "Tesla Numbers 369";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 20, 120, 20 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Tesla Numbers 369";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 20, 120, 20 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6, 9, 3, 6 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GematriaCipher();
            cipher.Name = "Magic Square Maximus";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 15, 34, 65, 111, 175, 260, 369, 505, 671, 870, 1105, 1379, 1695, 2056, 2465, 2925, 3439, 4010, 4641, 5335, 6095, 6924, 7825, 8801 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Magic Square Maximus";
            cipher.Category = "Experimental\\Mathematical";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 15, 34, 65, 111, 175, 260, 369, 505, 671, 870, 1105, 1379, 1695, 2056, 2465, 2925, 3439, 4010, 4641, 5335, 6095, 6924, 7825, 8801 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Semiprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 199, 175, 33 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51, 55, 57, 58, 62, 65, 69, 74, 77 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Semiprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 199, 175, 33 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 6, 9, 10, 14, 15, 21, 22, 25, 26, 33, 34, 35, 38, 39, 46, 49, 51, 55, 57, 58, 62, 65, 69, 74, 77 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 11, 17, 31, 41, 59, 67, 83, 109, 127, 157, 179, 191, 211, 241, 277, 283, 331, 353, 367, 401, 431, 461, 509, 547 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 5, 11, 17, 31, 41, 59, 67, 83, 109, 127, 157, 179, 191, 211, 241, 277, 283, 331, 353, 367, 401, 431, 461, 509, 547 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GematriaCipher();
            cipher.Name = "Super-Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 5, 11, 31, 59, 127, 179, 277, 331, 431, 599, 709, 919, 1063, 1153, 1297, 1523, 1787, 1847, 2221, 2381, 2477, 2749, 3001, 3259, 3637, 3943 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Super-Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 5, 11, 31, 59, 127, 179, 277, 331, 431, 599, 709, 919, 1063, 1153, 1297, 1523, 1787, 1847, 2221, 2381, 2477, 2749, 3001, 3259, 3637, 3943 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Super-Super-Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                             new int[] { 11, 31, 127, 277, 709, 1063, 1787, 2221, 3001, 4397, 5381, 7193, 8527, 9319, 10631, 12763, 15299, 15823, 19577, 21179, 22093, 24859, 27457, 30133, 33967, 37217 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Super-Super-Superprimes Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                             new int[] { 11, 31, 127, 277, 709, 1063, 1787, 2221, 3001, 4397, 5381, 7193, 8527, 9319, 10631, 12763, 15299, 15823, 19577, 21179, 22093, 24859, 27457, 30133, 33967, 37217 });
            cipher.ReverseOrder();

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Fibonacci Maxiumus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 20, 60 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Fibonacci Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 20, 60 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Palindromic Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Palindromic Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Lucky Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 105, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99, 105, 111, 115 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Lucky Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 105, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99, 105, 111, 115 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Padovan Sequence Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 1, 1, 2, 2, 3, 4, 5, 7, 9, 12, 16, 21, 28, 37, 49, 65, 86, 114, 151, 200, 265, 351, 465, 616, 816 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Padovan Sequence Maximus";
            cipher.Category = "Experimental\\Mathematical2";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 255, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 1, 1, 2, 2, 3, 4, 5, 7, 9, 12, 16, 21, 28, 37, 49, 65, 86, 114, 151, 200, 265, 351, 465, 616, 816 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Mathematical2 (up to 13th)
            cipher = new GematriaCipher();
            cipher.Name = "Super-Superprimes";
            cipher.Category = "Experimental\\Mathematical3";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 5, 11, 31, 59, 127, 179, 277, 331, 431, 599, 709, 919, 1063, 1063, 919, 709, 599, 431, 331, 277, 179, 127, 59, 31, 11, 5 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Super-Superprimes";
            cipher.Category = "Experimental\\Mathematical3";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 5, 11, 31, 59, 127, 179, 277, 331, 431, 599, 709, 919, 1063, 1063, 919, 709, 599, 431, 331, 277, 179, 127, 59, 31, 11, 5 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Magic Square";
            cipher.Category = "Experimental\\Mathematical3";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 15, 34, 65, 111, 175, 260, 369, 505, 671, 870, 1105, 1105, 870, 671, 505, 369, 260, 175, 111, 65, 34, 15, 5, 1 });
            ciphers.Add(cipher);

            //exp numbers
            cipher = new GematriaCipher();
            cipher.Name = "Deficient Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 105, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 19, 21, 22, 23, 25, 26, 27, 29, 31, 32, 33 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Deficient Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 105, 180 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 19, 21, 22, 23, 25, 26, 27, 29, 31, 32, 33 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Happy Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 244, 169, 65 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 7, 10, 13, 19, 23, 28, 31, 32, 44, 49, 68, 70, 79, 82, 86, 91, 94, 97, 100, 103, 109, 129, 130, 133, 139 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Happy Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 244, 169, 65 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 7, 10, 13, 19, 23, 28, 31, 32, 44, 49, 68, 70, 79, 82, 86, 91, 94, 97, 100, 103, 109, 129, 130, 133, 139 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Untouchable Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 165, 211, 44 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 5, 52, 88, 96, 120, 124, 146, 162, 188, 206, 210, 216, 238, 246, 248, 262, 268, 276, 288, 290, 292, 304, 306, 322, 324 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Untouchable Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 165, 211, 44 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 5, 52, 88, 96, 120, 124, 146, 162, 188, 206, 210, 216, 238, 246, 248, 262, 268, 276, 288, 290, 292, 304, 306, 322, 324 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Smith Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 44, 169, 165 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 22, 27, 58, 85, 94, 121, 166, 202, 265, 274, 319, 346, 355, 378, 382, 391, 438, 454, 483, 517, 526, 535, 562, 576, 588 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Smith Maximus";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 44, 169, 165 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 22, 27, 58, 85, 94, 121, 166, 202, 265, 274, 319, 346, 355, 378, 382, 391, 438, 454, 483, 517, 526, 535, 562, 576, 588 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Magic Squares Up to 7th";
            cipher.Category = "Experimental\\Misc";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 0, 191, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 5, 15, 34, 65, 111, 175, 111, 65, 34, 15, 5, 1, 1, 5, 15, 34, 65, 111, 175, 111, 65, 34, 15, 5, 1 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "ASCII Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 10, 186, 10 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                                                            new int[] { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse ASCII Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 10, 186, 10 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' },
                                                            new int[] { 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Braille Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 15, 245, 245 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 2, 3, 2, 3, 4, 3, 2, 3, 2, 3, 3, 4, 3, 4, 5, 4, 3, 4, 3, 4, 4, 4, 4, 4 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Braille Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 15, 245, 245 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 2, 3, 2, 3, 4, 3, 2, 3, 2, 3, 3, 4, 3, 4, 5, 4, 3, 4, 3, 4, 4, 4, 4, 4 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A326736
            cipher = new GematriaCipher();
            cipher.Name = "Converge to Three Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 102, 204, 255 };
            cipher.Comment = "https://oeis.org/A326736";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 31, 103, 113, 123, 133, 143, 153, 163, 173, 183, 193, 203, 303, 311, 403, 503, 603, 703, 803, 903, 1031, 1131, 1231, 1331, 1431 });
            ciphers.Add(cipher);

            //https://oeis.org/A326736
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Converge to Three Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 102, 204, 255 };
            cipher.Comment = "https://oeis.org/A326736";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 31, 103, 113, 123, 133, 143, 153, 163, 173, 183, 193, 203, 303, 311, 403, 503, 603, 703, 803, 903, 1031, 1131, 1231, 1331, 1431 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Illuminati";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 20, 120, 20 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 12, 11, 10, 9, 8, 7, 6, 5, 4, 4, 3, 2, 1, 13, 14, 15, 16, 17, 18, 19, 20, 20, 21, 22, 23, 24 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Illuminati";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 20, 120, 20 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n', 'm', 'l', 'k', 'j', 'i', 'h', 'g', 'f', 'e', 'd', 'c', 'b', 'a' },
                                                            new int[] { 12, 11, 10, 9, 8, 8, 7, 6, 5, 4, 3, 2, 1, 13, 14, 15, 16, 16, 17, 18, 19, 20, 21, 22, 23, 24 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Inversed";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 210, 220, 240 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 21, 31, 41, 51, 61, 71, 81, 91, 2, 12, 22, 32, 42, 52, 62 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Inversed";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 210, 220, 240 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 11, 21, 31, 41, 51, 61, 71, 81, 91, 2, 12, 22, 32, 42, 52, 62 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GematriaCipher();
            cipher.Name = "Isisian Codes";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 255, 103 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Isisian Codes";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 220, 255, 103 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //https://oeis.org/A032917
            cipher = new GematriaCipher();
            cipher.Name = "One and Three Rule Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.Comment = "https://oeis.org/A032917";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 11, 13, 31, 33, 111, 113, 131, 133, 311, 313, 331, 333, 1111, 1113, 1131, 1133, 1311, 1313, 1331, 1333, 3111, 3113, 3131, 3133 });
            ciphers.Add(cipher);

            //exp Other
            cipher = new GematriaCipher();
            cipher.Name = "Number of a Man";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 11, 22, 33, 44, 55, 66, 77, 88, 99, 111, 222, 333, 333, 222, 111, 99, 88, 77, 66, 55, 44, 33, 22, 11, 0 });
            ciphers.Add(cipher);

            //https://oeis.org/A056524
            cipher = new GematriaCipher();
            cipher.Name = "Palindromes Maximus - even digits";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "https://oeis.org/A056524";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 1001, 1111, 1221, 1331, 1441, 1551, 1661, 1771, 1881, 1991, 2002, 2112, 2222, 2332, 2442, 2552, 2662 });
            ciphers.Add(cipher);

            //https://oeis.org/A056524
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Palindromes Maximus - even digits";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "https://oeis.org/A056524";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 11, 22, 33, 44, 55, 66, 77, 88, 99, 1001, 1111, 1221, 1331, 1441, 1551, 1661, 1771, 1881, 1991, 2002, 2112, 2222, 2332, 2442, 2552, 2662 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Randomized
            cipher = new RandomizedGematriaCipher(englishOrdinalCipher);
            cipher.Name = "Randomized";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = englishOrdinalCipher.RGB_Color;
            cipher.MappingAlphaNumeric = englishOrdinalCipher.MappingAlphaNumeric;

            ciphers.Add(cipher);

            //https://oeis.org/A032917
            cipher = new GematriaCipher();
            cipher.Name = "Reverse One and Three Rule Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 255, 255 };
            cipher.Comment = "https://oeis.org/A032917";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 3, 11, 13, 31, 33, 111, 113, 131, 133, 311, 313, 331, 333, 1111, 1113, 1131, 1133, 1311, 1313, 1331, 1333, 3111, 3113, 3131, 3133 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Chaldean";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 166, 166, 99 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 8, 3, 5, 1, 1, 2, 3, 4, 5, 7, 8, 1, 2, 3, 4, 6, 6, 6, 5, 1, 7 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);



            cipher = new GematriaCipher();
            cipher.Name = "Reverse Baconis Inversed";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsCapsMatter = true;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 111, 121 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z', },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 });

            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Keypad";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 126, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 9, 9 });

            //Experimental 
            //Other
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Septenary";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 153, 77 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 });
            cipher.ReverseOrder();


            cipher = new GematriaCipher();
            cipher.Name = "Roman Numberals";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 40, 235, 56 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 0, 100, 500, 0, 0, 0, 0, 1, 0, 0, 50, 1000, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10, 0, 0 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Roman Numberals";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsDefault = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 40, 235, 56 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 0, 0, 100, 500, 0, 0, 0, 0, 1, 0, 0, 50, 1000, 0, 0, 0, 0, 0, 0, 0, 0, 5, 0, 10, 0, 0 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //https://oeis.org/A001248
            cipher = new GematriaCipher();
            cipher.Name = "Square of Primes Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "https://oeis.org/A001248";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 9, 25, 49, 121, 169, 289, 361, 529, 841, 961, 1369, 1681, 1849, 2209, 2809, 3481, 3721, 4489, 5041, 5329, 6241, 6889, 7921, 9409, 10201 });
            ciphers.Add(cipher);

            //https://oeis.org/A001248
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Square of Primes Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 0 };
            cipher.Comment = "https://oeis.org/A001248";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 9, 25, 49, 121, 169, 289, 361, 529, 841, 961, 1369, 1681, 1849, 2209, 2809, 3481, 3721, 4489, 5041, 5329, 6241, 6889, 7921, 9409, 10201 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            cipher = new GematriaCipher();
            cipher.Name = "Tolvotea Key";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.Comment = "Discovered 1-26-03 by John Farthing II(Frater O.R)";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 22, 17, 16, 7, 10, 2, 29, 4, 24, 19, 18, 11, 12, 3, 31, 6, 26, 23, 20, 13, 14, 5, 28, 8, 0 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Tolvotea Key";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 0, 255 };
            cipher.Comment = "Discovered 1-26-03 by John Farthing II(Frater O.R)";
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 22, 17, 16, 7, 10, 2, 29, 4, 24, 19, 18, 11, 12, 3, 31, 6, 26, 23, 20, 13, 14, 5, 28, 8, 0 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Weird Numbers Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 188, 188, 188 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 70, 836, 4030, 5830, 7192, 7912, 9272, 10430, 10570, 10792, 10990, 11410, 11690, 12110, 12530, 12670, 13370, 13510, 13790, 13930, 14770, 15610, 15890, 16030, 16310, 16730 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Weird Numbers Maximus";
            cipher.Category = "Experimental\\Other";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 188, 188, 188 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 70, 836, 4030, 5830, 7192, 7912, 9272, 10430, 10570, 10792, 10990, 11410, 11690, 12110, 12530, 12670, 13370, 13510, 13790, 13930, 14770, 15610, 15890, 16030, 16310, 16730 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Pi (1 digit)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 3, 252, 169 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Pi (1 digit)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 128, 3, 252 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9, 3, 2, 3, 8, 4, 6, 2, 6, 4, 3, 3 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Pi (2 digits)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 3, 252, 252 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 2, 88, 41, 97, 16, 93, 99, 37, 51, 5 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Pi (2 digits)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 244, 3, 252 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 31, 41, 59, 26, 53, 58, 97, 93, 23, 84, 62, 64, 33, 83, 27, 95, 2, 88, 41, 97, 16, 93, 99, 37, 51, 5 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Pi (3 digits)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 3, 165, 252 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 314, 159, 265, 358, 979, 323, 846, 264, 338, 327, 950, 288, 419, 716, 939, 937, 510, 582, 97, 494, 459, 230, 781, 640, 628, 620 });

            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "Reverse Pi (3 digits)";
            cipher.Category = "Experimental\\Pi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 252, 3, 90 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 314, 159, 265, 358, 979, 323, 846, 264, 338, 327, 950, 288, 419, 716, 939, 937, 510, 582, 97, 494, 459, 230, 781, 640, 628, 620 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);


            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Phi (1 digit)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 204, 204 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 1, 8, 0, 3, 3, 9, 8, 8, 7, 4, 9, 8, 9, 4, 8, 4, 8, 2, 0, 4, 5, 8, 6, 8 });
            ciphers.Add(cipher);

            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Phi (1 digit)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 204, 204 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 6, 1, 8, 0, 3, 3, 9, 8, 8, 7, 4, 9, 8, 9, 4, 8, 4, 8, 2, 0, 4, 5, 8, 6, 8 });

            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Phi (2 digits)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 153, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 16, 18, 3, 39, 88, 74, 98, 94, 84, 82, 4, 58, 68, 34, 36, 56, 38, 11, 77, 20, 30, 91, 79, 80, 57, 62 });
            ciphers.Add(cipher);

            //Experimental
            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Phi (2 digits)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 255, 153, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 16, 18, 3, 39, 88, 74, 98, 94, 84, 82, 4, 58, 68, 34, 36, 56, 38, 11, 77, 20, 30, 91, 79, 80, 57, 62 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Phi (3 digits)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 230, 230, 250 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 161, 833, 988, 749, 894, 848, 245, 868, 343, 656, 381, 177, 203, 91, 798, 576, 286, 213, 544, 862, 270, 526, 462, 818, 902, 449 });
            ciphers.Add(cipher);

            //phi (Golden Ratio)
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Phi (3 digits)";
            cipher.Category = "Experimental\\Phi";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 230, 230, 250 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 161, 833, 988, 749, 894, 848, 245, 868, 343, 656, 381, 177, 203, 91, 798, 576, 286, 213, 544, 862, 270, 526, 462, 818, 902, 449 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            //Centered cube numbers: n^3 + (n+1)^3.
            cipher = new GematriaCipher();
            cipher.Name = "Centered Cube Maximus";
            cipher.Category = "Experimental\\Powerful";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 58, 51, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                              new int[] { 1, 9, 35, 91, 189, 341, 559, 855, 1241, 1729, 2331, 3059, 3925, 4941, 6119, 7471, 9009, 10745, 12691, 14859, 17261, 19909, 22815, 25991, 29449, 33201 });
            ciphers.Add(cipher);

            //Centered cube numbers: n^3 + (n+1)^3.
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Centered Cube Maximus";
            cipher.Category = "Experimental\\Powerful";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 58, 51, 255 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                              new int[] { 1, 9, 35, 91, 189, 341, 559, 855, 1241, 1729, 2331, 3059, 3925, 4941, 6119, 7471, 9009, 10745, 12691, 14859, 17261, 19909, 22815, 25991, 29449, 33201 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            /*

            //exp English Ordinal Custom 
            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 2";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 3";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 4";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 5";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 6";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 7";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 8";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 9";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34 });
            ciphers.Add(cipher);

            cipher = new GematriaCipher();
            cipher.Name = "English Ordinal Starting at 10";
            cipher.Category = "Experimental\\English Ordinal Custom";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 121, 22, 124 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 });
            ciphers.Add(cipher);

            */

            SumOfPrimeWithIndices sumOfPrimeWithIndices = new SumOfPrimeWithIndices();
            sumOfPrimeWithIndices.Name = "Sum of Prime/Subscript";
            sumOfPrimeWithIndices.Category = "Experimental\\Polymorphic";
            sumOfPrimeWithIndices.Enabled = false;
            sumOfPrimeWithIndices.IsBase = false;
            sumOfPrimeWithIndices.IsDefault = false;
            sumOfPrimeWithIndices.IsExperimental = true;

            sumOfPrimeWithIndices.RGB_Color = new int[] { 66, 135, 245 };
            sumOfPrimeWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(sumOfPrimeWithIndices);

            SumOfTriangularWithIndices sumOfTriangularWithIndices = new SumOfTriangularWithIndices();

            sumOfTriangularWithIndices.Name = "Sum of Triangular/Subscript";
            sumOfTriangularWithIndices.Category = "Experimental\\Polymorphic";
            sumOfTriangularWithIndices.Enabled = false;
            sumOfTriangularWithIndices.IsBase = false;
            sumOfTriangularWithIndices.IsDefault = false;
            sumOfTriangularWithIndices.IsExperimental = true;
            sumOfTriangularWithIndices.RGB_Color = new int[] { 245, 239, 66 };
            sumOfTriangularWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(sumOfTriangularWithIndices);

            SumOfFibonacciWithIndices sumOfFibonacciWithIndices = new SumOfFibonacciWithIndices();
            sumOfFibonacciWithIndices.Name = "Sum of Fibonacci/Subscript";
            sumOfFibonacciWithIndices.Category = "Experimental\\Polymorphic";
            sumOfFibonacciWithIndices.Enabled = false;
            sumOfFibonacciWithIndices.IsBase = false;
            sumOfFibonacciWithIndices.IsDefault = false;
            sumOfFibonacciWithIndices.IsExperimental = true;
            sumOfFibonacciWithIndices.RGB_Color = new int[] { 220, 20, 60 };
            sumOfFibonacciWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            ciphers.Add(sumOfFibonacciWithIndices);


            sumOfPrimeWithIndices = new SumOfPrimeWithIndices();
            sumOfPrimeWithIndices.Name = "Reverse Sum of Prime/Subscript";
            sumOfPrimeWithIndices.Category = "Experimental\\Polymorphic";
            sumOfPrimeWithIndices.Enabled = false;
            sumOfPrimeWithIndices.IsBase = false;
            sumOfPrimeWithIndices.IsDefault = false;
            sumOfPrimeWithIndices.IsExperimental = true;
            sumOfPrimeWithIndices.RGB_Color = new int[] { 66, 135, 245 };
            sumOfPrimeWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            sumOfPrimeWithIndices.ReverseOrder();
            ciphers.Add(sumOfPrimeWithIndices);

            sumOfTriangularWithIndices = new SumOfTriangularWithIndices();
            sumOfTriangularWithIndices.Name = "Reverse Sum of Triangular/Subscript";
            sumOfTriangularWithIndices.Category = "Experimental\\Polymorphic";
            sumOfTriangularWithIndices.Enabled = false;
            sumOfTriangularWithIndices.IsBase = false;
            sumOfTriangularWithIndices.IsDefault = false;
            sumOfTriangularWithIndices.IsExperimental = true;

            sumOfTriangularWithIndices.RGB_Color = new int[] { 245, 239, 66 };
            sumOfTriangularWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            sumOfTriangularWithIndices.ReverseOrder();
            ciphers.Add(sumOfTriangularWithIndices);

            sumOfFibonacciWithIndices = new SumOfFibonacciWithIndices();
            sumOfFibonacciWithIndices.Name = "Reverse Sum of Fibonacci/Subscript";
            sumOfFibonacciWithIndices.Category = "Experimental\\Polymorphic";
            sumOfFibonacciWithIndices.Enabled = false;
            sumOfFibonacciWithIndices.IsBase = false;
            sumOfFibonacciWithIndices.IsDefault = false;
            sumOfFibonacciWithIndices.IsExperimental = true;
            sumOfFibonacciWithIndices.RGB_Color = new int[] { 220, 20, 60 };
            sumOfFibonacciWithIndices.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 });
            sumOfFibonacciWithIndices.ReverseOrder();
            ciphers.Add(sumOfFibonacciWithIndices);


            //experimental Powerful Number


            /* had to removed (not enough memory in system to handle)
            
            //Armstrong (or pluperfect, or Plus Perfect, or narcissistic) numbers: m-digit positive numbers equal 
            //to sum of the m-th powers of their digits.
            cipher = new GematriaCipher();
            cipher.Name = "Narcissistic";
            cipher.Category = "Experimental\\Powerful";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 204, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474, 54748, 92727, 93084, 548834, 1741725, 4210818, 9800817, 9926315, 24678050, 24678051 });
            ciphers.Add(cipher);


            //Armstrong (or pluperfect, or Plus Perfect, or narcissistic) numbers: m-digit positive numbers equal 
            //to sum of the m-th powers of their digits.
            cipher = new GematriaCipher();
            cipher.Name = "Reverse Narcissistic";
            cipher.Category = "Experimental\\Powerful";
            cipher.Enabled = false;
            cipher.IsExperimental = true;
            cipher.RGB_Color = new int[] { 204, 0, 0 };
            cipher.MappingAlphaNumeric = new AlphNumMapping(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' },
                                                            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 153, 370, 371, 407, 1634, 8208, 9474, 54748, 92727, 93084, 548834, 1741725, 4210818, 9800817, 9926315, 24678050, 24678051 });
            cipher.ReverseOrder();
            ciphers.Add(cipher);

            */

        }
        public static CipherConfig Instance()
        {
            if (config == null)
            {

                if (File.Exists(GematriaFactory.Instance().GetConfigDir() + "\\Ciphers.xml"))
                {
                    config = (CipherConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\Ciphers.xml", typeof(CipherConfig));
                }
                else
                {
                    CipherConfig thisConfig = new CipherConfig();
                    thisConfig.SetDefaults();
                    SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\Ciphers.xml", thisConfig);
                    config = (CipherConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\Ciphers.xml", typeof(CipherConfig));
                }
            }

            return config;

        }
    }
}
