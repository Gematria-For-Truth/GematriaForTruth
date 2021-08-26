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
    [Serializable]
    public class MatchValueConfig : GematriaToolsXmlConfig
    {
        public List<MatchValue> MatchValues { get; set; }
        public ConfigType CurrentConfigType { get; set; }
        public enum ConfigType
        {
            IsDefault,
            IsAllExperimental,
            IsAll,
            IsAllUserDefined,
            IsUserDefined
        }

        private static MatchValueConfig Config = null;

        public MatchValueConfig()
        {

        }

        public static void SaveMatchValueConfig()
        {
            SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\MatchValues.xml", Instance());
        }

        public void SetDefaults()
        {
            CurrentConfigType = ConfigType.IsDefault;

            MatchValues = new List<MatchValue>();

            //111 Releated
            MatchValue matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Primes" },
                                                          607,
                                                         "111th Prime",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Digits Alike" },
                                                          1111,
                                                         "1's to the fourth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //111th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "111 Related", "Triangulars" },
                                                          6216,
                                                          "111th Triangular",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            //111th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                       new string[] { "111 Related", "Primes" },
                                                       8933,
                                                       "1111th Prime",
                                                       new List<GematriaCipher>(),
                                                       true,
                                                       false,
                                                       true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Digits Alike" },
                                                          11111,
                                                         "1's to the fifth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //1111th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                        new string[] { "111 Related", "Triangulars" },
                                                        617716,
                                                        "1111th Triangular",
                                                        new List<GematriaCipher>(),
                                                        true,
                                                        false,
                                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Digits Alike", "Six Digit Value" },
                                                          111111,
                                                         "1's to the sixth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Digits Alike", "Seven Digit Value" },
                                                          1111111,
                                                         "1's to the Seventh digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "111 Related", "Digits Alike", "Eight Digit Value" },
                                                          11111111,
                                                         "1's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //222 Releated
            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "222 Related", "Digits Alike" },
                                                           222,
                                                          "2's to the third digit",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "222 Related", "Primes" },
                                                           1399,
                                                          "222nd Prime",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "222 Related" },
                                                           2022,
                                                          "Next Year",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "222 Related", "Digits Alike" },
                                                          2222,
                                                         "2's to the fourth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //2202 Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                        new string[] { "222 Related", "Primes" },
                                                         19429,
                                                        "2202 Prime",
                                                        new List<GematriaCipher>(),
                                                        true,
                                                        false,
                                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                        new string[] { "222 Related", "Digits Alike" },
                                                         22222,
                                                        "2's to the fifth digit",
                                                        new List<GematriaCipher>(),
                                                        true,
                                                        false,
                                                        true);
            MatchValues.Add(matchValue);

            //222th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                            new string[] { "222 Related", "Triangulars" },
                                                            24753,
                                                            "222th Triangular",
                                                            new List<GematriaCipher>(),
                                                            true,
                                                            false,
                                                            true);
            MatchValues.Add(matchValue);

            // 222th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                            new string[] { "222 Related", "Primes" },
                                                            19583,
                                                            "222th Prime",
                                                            new List<GematriaCipher>(),
                                                            true,
                                                            false,
                                                            true);
            MatchValues.Add(matchValue);

            //2222th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "222 Related", "Triangulars", "Six Digit Value" },
                                                           2469753,
                                                           "2222th Triangular",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            //222 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "222 Related", "Digits Alike", "Six Digit Value" },
                                                          222222,
                                                         "2's to the sixth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                       new string[] { "222 Related", "Digits Alike", "Seven Digit Value" },
                                                        2222222,
                                                       "2's to the Seventh digit",
                                                       new List<GematriaCipher>(),
                                                       true,
                                                       false,
                                                       true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "222 Related", "Digits Alike", "Eight Digit Value" },
                                                          22222222,
                                                         "2's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //333 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "333 Related", "Digits Alike" },
                                                            333,
                                                           "3's to the third digit",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            //333th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "333 Related", "Primes" },
                                                            2239,
                                                           "333th Prime",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "333 Related", "Digits Alike" },
                                                           3333,
                                                          "333 Related and Also FDR's New Deal date forwards and backwards 3/3/33",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            //333rd Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "333 Related", "Triangulars" },
                                                           55611,
                                                           "333rd Triangular",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            //3333rd Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                        new string[] { "333 Related", "Primes" },
                                                        30911,
                                                        "3333rd Prime",
                                                        new List<GematriaCipher>(),
                                                        true,
                                                        false,
                                                        true);
            MatchValues.Add(matchValue);

            //333 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "333 Related", "Digits Alike" },
                                                          33333,
                                                         "3's to the fifth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //333rd Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "333 Related", "Triangulars", "Six Digit Value" },
                                                          5556111,
                                                         "333rd Triangular",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //333 Related"
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "333 Related", "Digits Alike", "Six Digit Value" },
                                                          333333,
                                                         "3's to the sixth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                     new string[] { "333 Related", "Digits Alike", "Seven Digit Value" },
                                                      3333333,
                                                     "3's to the Seventh digit",
                                                     new List<GematriaCipher>(),
                                                     true,
                                                     false,
                                                     true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "333 Related", "Digits Alike", "Eight Digit Value" },
                                                          33333333,
                                                         "3's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //444th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "444 Related", "Digits Alike" },
                                                           444,
                                                          "4's to the third digit",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "444 Related", "Primes" },
                                                           3119,
                                                           "444th Prime",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "444 Related", "Digits Alike" },
                                                           4444,
                                                          "4's to the fourth digit",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            //444th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                        new string[] { "444 Related", "Triangulars" },
                                                        98790,
                                                        "444th Triangular",
                                                        new List<GematriaCipher>(),
                                                        true,
                                                        false,
                                                        true);
            MatchValues.Add(matchValue);

            //4444th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                     new string[] { "444 Related", "Primes" },
                                                     42473,
                                                     "4444th Prime",
                                                     new List<GematriaCipher>(),
                                                     true,
                                                     false,
                                                     true);
            MatchValues.Add(matchValue);

            //444 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "444 Related", "Digits Alike" },
                                                          44444,
                                                         "4's to the fifth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //4444th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                       new string[] { "444 Related", "Triangulars", "Six Digit Value" },
                                                        9876790,
                                                       "4444th Triangular",
                                                       new List<GematriaCipher>(),
                                                       true,
                                                       false,
                                                       true);
            MatchValues.Add(matchValue);
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "444 Related", "Digits Alike", "Six Digit Value" },
                                                          444444,
                                                         "4's to the sixth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                    new string[] { "444 Related", "Digits Alike", "Seven Digit Value" },
                                                     4444444,
                                                    "4's to the Seventh digit",
                                                    new List<GematriaCipher>(),
                                                    true,
                                                    false,
                                                    true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "444 Related", "Digits Alike", "Eight Digit Value" },
                                                          44444444,
                                                         "4's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);


            //555 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "555 Related", "Digits Alike" },
                                                            555,
                                                           "5's to the third digit",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            //555th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "555 Related", "Primes" },
                                                            4019,
                                                           "555th Prime",
                                                           new List<GematriaCipher>(),
                                                           true,
                                                           false,
                                                           true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                          new string[] { "555 Related", "Digits Alike" },
                                                           5555,
                                                          "5's to the forth digit",
                                                          new List<GematriaCipher>(),
                                                          true,
                                                          false,
                                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "555 Related", "Digits Alike" },
                                                          55555,
                                                         "5's to the fifth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //5555th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "555 Related", "Primes" },
                                                          54581,
                                                         "5555th Prime",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //555th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                            new string[] { "555 Related", "Triangulars" },
                                                            154290,
                                                            "555th Triangular",
                                                            new List<GematriaCipher>(),
                                                            true,
                                                            false,
                                                            true);
            MatchValues.Add(matchValue);

            //5555th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "555 Related", "Triangulars", "Seven Digit Value" },
                                                          15431790,
                                                         "5555th Triangular",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //555 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "555 Related", "Digits Alike", "Six Digit Value" },
                                                          555555,
                                                         "5's to the sixth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                   new string[] { "555 Related", "Digits Alike", "Seven Digit Value" },
                                                    5555555,
                                                   "5's to the Seventh digit",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "555 Related", "Digits Alike", "Eight Digit Value" },
                                                          55555555,
                                                         "5's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                           new string[] { "666 Related", "Digits Alike" },
                                                            666,
                                                            "Mark of the Beast",
                                                            new List<GematriaCipher>(),
                                                            true,
                                                            false,
                                                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                               new string[] { "666 Related" },
                                                1666,
                                                "Relates to The Cestui que Vie Act 1666, Great Fire of London, and the Great Plague of London",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            //1666th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "1666th Prime", "Primes" },
                                             14153,
                                             "1666th Prime - Relates to The Cestui que Vie Act 1666",
                                             new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true);
            MatchValues.Add(matchValue);

            //1666th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                            new string[] { "666 Related", "Triangulars", "Six Digit Value" },
                                             1388611,
                                             "1666th Triangular - Relates to The Cestui que Vie Act 1666",
                                             new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true);
            MatchValues.Add(matchValue);

            //666th Prime Number
            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "666 Related", "Primes" },
                                                 4973,
                                                 "666th Prime",
                                                 new List<GematriaCipher>(),
                                                 true,  //IsDefault 
                                                 false, //IsExperimental
                                                 true); //IsEnabled
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                               new string[] { "666 Related", "Digits Alike" },
                                                6606,
                                                "Six's for first, second, and fourth digits",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                              new string[] { "666 Related", "Digits Alike" },
                                               6660,
                                               "Six's for first, second, and third digits",
                                               new List<GematriaCipher>(),
                                               true,
                                               false,
                                               true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "666 Related", "Digits Alike" },
                                                   6666,
                                                   "6's to the fourth digit",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "666 Related", "Digits Alike" },
                                              60066,
                                              "Six's for first, fourth, and fifth digits",
                                              new List<GematriaCipher>(),
                                              true,
                                              false,
                                              true);
            MatchValues.Add(matchValue);

            //666th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                            new string[] { "666 Related", "Primes" },
                                             60091,
                                             "6066th Prime",
                                             new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "666 Related", "Digits Alike" },
                                                   60606,
                                                   "Inserting zeros between the sixes in 666 gives the number 60606",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "666 Related", "Digits Alike" },
                                          66006,
                                          "Six's for first, second, and fifth digits",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                           new string[] { "666 Related", "Digits Alike" },
                                            66066,
                                            "Six's for first, second, forth, and fifth digits",
                                            new List<GematriaCipher>(),
                                            true,
                                            false,
                                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                           new string[] { "666 Related", "Digits Alike" },
                                            66600,
                                            "Six's for first, second, and third digits",
                                            new List<GematriaCipher>(),
                                            true,
                                            false,
                                            true);
            MatchValues.Add(matchValue);



            matchValue = new MatchValue(MatchValue.Type.System,
                                               new string[] { "666 Related", "Digits Alike" },
                                                66666,
                                                "6's to the fifth decimal place",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            //6666th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "666 Related", "Primes" },
                                              66889,
                                              "6666th prime",
                                              new List<GematriaCipher>(),
                                              true,
                                              false,
                                              true);
            MatchValues.Add(matchValue);

            //6666th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                            new string[] { "666 Related", "Triangulars", "Seven Digit Value" },
                                             22221111,
                                             "6666th Triangular",
                                             new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true);
            MatchValues.Add(matchValue);

            //6660th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "666 Related", "Primes" },
                                              66841,
                                              "6660th prime",
                                              new List<GematriaCipher>(),
                                              true,
                                              false,
                                              true);
            MatchValues.Add(matchValue);

            //Is the 666th Triangular Number
            matchValue = new MatchValue(MatchValue.Type.System,
                                              new string[] { "666 Related", "Triangulars" },
                                               222111,
                                               "666th Triangular",
                                               new List<GematriaCipher>(),
                                               true,
                                               false,
                                               true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "666 Related", "Digits Alike", "Six Digit Value" },
                                                  666666,
                                                  "There are only two known Pythagorean triangles whose area is a repdigit number: (3, 4, 5) with area 6(693, 1924, 2045) with area 666666",
                                                  new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "666 Related", "Digits Alike", "Seven Digit Value" },
                                                  6666666,
                                                 "6's to the Seventh digit",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "666 Related", "Digits Alike", "Eight Digit Value" },
                                                          66666666,
                                                         "6's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //777 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                           new string[] { "777 Related", "Digits Alike" },
                                            777,
                                            "7's to the third digit",
                                            new List<GematriaCipher>(),
                                            true,
                                            false,
                                            true);
            MatchValues.Add(matchValue);

            //777th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "777 Related", "Primes" },
                                          5903,
                                          "777th Prime",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "777 Related", "Digits Alike" },
                                          7777,
                                          "7's to the fourth digit",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            //7777th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "777 Related", "Primes" },
                                          79357,
                                          "7777th prime",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "777 Related", "Digits Alike" },
                                          77777,
                                          "7's to the fifth digit",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            //777th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "777 Related", "Triangulars" },
                                      302253,
                                      "777th Triangular",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);
            MatchValues.Add(matchValue);

            //7777th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                    new string[] { "777 Related", "Triangulars", "Seven Digit Value" },
                                     30244753,
                                     "7777th Triangular",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "777 Related", "Digits Alike", "Six Digit Value" },
                                       777777,
                                       "7's to the six digit",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "777 Related", "Digits Alike", "Seven Digit Value" },
                                                  7777777,
                                                 "7's to the Seventh digit",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "777 Related", "Digits Alike", "Eight Digit Value" },
                                                          77777777,
                                                         "7's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);


            ///888 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                          new string[] { "888 Related", "Digits Alike" },
                                          888,
                                          "8's to the third digit",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "888 Related", "Digits Alike" },
                                         8880,
                                         "The Mystery of the Raised Jesus 888 x 10) = 8880",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "888 Related", "Digits Alike" },
                                         8888,
                                         "8's to the fourth digit",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            //888th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "888 Related", "Primes" },
                                         92003,
                                         "888th Prime",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "888 Related", "Digits Alike" },
                                     88888,
                                     "8's to the fifth digit",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);
            MatchValues.Add(matchValue);

            //8888th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "888 Related", "Primes" },
                                  92003,
                                  "8888th Prime",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                  true);
            MatchValues.Add(matchValue);

            //888th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "888 Related" },
                                  394716,
                                  "888th Triangular",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                  true);
            MatchValues.Add(matchValue);

            ///8888th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "888 Related", "Triangulars", "Seven Digit Value" },
                                  39502716,
                                  "8888th Triangular",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                  true);
            MatchValues.Add(matchValue);

            //888 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                    new string[] { "888 Related", "Digits Alike", "Six Digit Value" },
                                    888888,
                                    "8's to the sixth digit",
                                    new List<GematriaCipher>(),
                                    true,
                                    false,
                                    true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "888 Related", "Digits Alike", "Seven Digit Value" },
                                                  8888888,
                                                 "8's to the Seventh digit",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "888 Related", "Digits Alike", "Eight Digit Value" },
                                                          888888888,
                                                         "8's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);


            //911 Related
            matchValue = new MatchValue(MatchValue.Type.System,
                                                   new string[] { "911 Related" },
                                                   911,
                                                   "September 11, 2001",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);

            //911 mirror
            matchValue = new MatchValue(MatchValue.Type.System,
                                                   new string[] { "911 Related" },
                                                   119,
                                                   "Mirror of 911",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);


            //911th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                   new string[] { "911 Related", "Primes" },
                                                   7109,
                                                   "911th Prime",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);

            //9110th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "911 Related", "Primes" },
                                                  278687,
                                                  "9110th Prime",
                                                  new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related", "Triangulars" },
                                                 415416,
                                                 "911th Triangular",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            //9110th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related", "Triangulars", "Seven Digit Value" },
                                                41500605,
                                                "9110th Triangular",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "911 Related" },
                                                  911911,
                                                  "911 Twice",
                                                  new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related" },
                                                 119119,
                                                 "Reverse 911 twice",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            //999 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "999 Related", "Digits Alike" },
                                         999,
                                         "9's to the third digit",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);

            MatchValues.Add(matchValue);

            //999th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "999 Related", "Primes" },
                                     7907,
                                     "999th prime",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "999 Related", "Digits Alike" },
                                   9999,
                                   "9's to the fourth digit",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);

            MatchValues.Add(matchValue);

            //9999th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "999 Related", "Primes" },
                                        104723,
                                        "9999th prime",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);

            MatchValues.Add(matchValue);

            //999th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                       new string[] { "999 Related", "Triangulars" },
                                       394716,
                                       "999th Triangular",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);

            MatchValues.Add(matchValue);

            //9999th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "999 Related", "Triangulars", "Seven Digit Value" },
                                     49995000,
                                     "9999th Triangular",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "999 Related", "Digits Alike" },
                               99999,
                               "9's to fifth digit",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "999 Related", "Digits Alike", "Six Digit Value" },
                            999999,
                            "9's to the sixth digit",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "999 Related", "Digits Alike", "Seven Digit Value" },
                             9999999,
                            "9's to the Seventh digit",
                             new List<GematriaCipher>(),
                             true,
                             false,
                             true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                         new string[] { "999 Related", "Digits Alike", "Eight Digit Value" },
                                                          99999999,
                                                         "9's to the Eighth digit",
                                                         new List<GematriaCipher>(),
                                                         true,
                                                         false,
                                                         true);
            MatchValues.Add(matchValue);

            //10000 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                       new string[] { "10000 Related" },
                                       10000,
                                       "High Rounded Value",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);

            MatchValues.Add(matchValue);

            //10000th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "10000 Related", "Primes" },
                                      104729,
                                      "10000th prime",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);

            MatchValues.Add(matchValue);

            //1000th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "1000 Related" },
                                   500500,
                                   "1000th Triangular",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);

            MatchValues.Add(matchValue);

            //10000th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "10000 Related", "Triangulars", "Seven Digit Value" },
                                  50005000,
                                  "10000th Triangular",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                  true);

            MatchValues.Add(matchValue);

            //10001 related
            matchValue = new MatchValue(MatchValue.Type.System,
                                       new string[] { "10001 Related" },
                                       10001,
                                       "You Tell Me :)",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);

            MatchValues.Add(matchValue);

            //10001th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                    new string[] { "10001 Related", "Primes" },
                                    104743,
                                    "10001th Prime",
                                    new List<GematriaCipher>(),
                                    true,
                                    false,
                                    true);

            MatchValues.Add(matchValue);

            //1001th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "10001 Related", "Triangulars" },
                                 501501,
                                 "1001th Triangular",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);

            MatchValues.Add(matchValue);

            //10001th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "10001 Related", "Triangulars", "Seven Digit Value" },
                                 50015001,
                                 "10001th Triangular",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);

            MatchValues.Add(matchValue);


            //freemason
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Freemasonry", "Primes" },
                                        137,
                                        "33rd Prime",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "Freemasonry" },
                                      1089,
                                      "Square Root of 33",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);
            MatchValues.Add(matchValue);

            //33rd Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "Freemasonry", "Triangulars" },
                                     561,
                                     "33rd Triangular (Freemasonry)",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "Freemasonry" },
                                   35937,
                                   "33 x 33 x 33 (Freemasonry)",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "Freemasonry", "Six Digit Value" },
                                 1185921,
                                 "33 x 33 x 33 x 33 (Freemasonry)",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);
            MatchValues.Add(matchValue);

            //occult related
            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related" },
                                         322,
                                         "Skull and Bones",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related" },
                                         1331,
                                         "Kaballah Related",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        1377,
                                        "Revelation 8:11 Ordinal value",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related", "Primes" },
                                         2137,
                                         "322nd prime (Skull and Bones)",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related", "Triangulars" },
                                         52003,
                                         "322nd Triangular (Skull and Bones)",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related", "Primes" },
                                        10957,
                                        "1331st prime (Kaballah)",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "Occult Related", "Triangulars" },
                                     886446,
                                     "1331st Triangular (Kaballah)",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        3313,
                                        "24th Star Number",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            //3313th prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related", "Primes" },
                                        30707,
                                        "3313th prime",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            // 3313th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related", "Triangulars", "Six Digit Value" },
                                        5489641,
                                        "3313th Triangular",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "Occult Related" },
                                      6361,
                                      "Octal of 3313",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                       true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        1776,
                                        "Birth Year of USA and Illuminati",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        6771,
                                        "Mirror of 1776. Birth Year of USA and Illuminati",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            //1776th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related", "Primes" },
                                        15217,
                                        "1776th Prime",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            //1776th Prime
            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related", "Primes" },
                                        71251,
                                        "Mirror of 15217, 1776th Prime",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            //1776th Triangular
            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "Occult Related", "Triangulars", "Six Digit Value" },
                                      1577976,
                                      "1776th Triangular",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "Occult Related", "Triangulars", "Six Digit Value" },
                                     6797751,
                                     "Mirror of 1577976, 1776th Triangular",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        10776,
                                        "Birth Year of USA and Illuminati",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                        new string[] { "Occult Related" },
                                        17076,
                                        "Birth Year of USA and Illuminati",
                                        new List<GematriaCipher>(),
                                        true,
                                        false,
                                        true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                       new string[] { "Occult Related" },
                                       17706,
                                       "Birth Year of USA and Illuminati",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                    new string[] { "Occult Related" },
                                    17760,
                                    "Birth Year of USA and Illuminati",
                                    new List<GematriaCipher>(),
                                    true,
                                    false,
                                    true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "Occult Related" },
                                   177600,
                                   "Birth Year of USA and Illuminati",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "Occult Related" },
                                 170076,
                                 "Birth Year of USA and Illuminati",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "Occult Related", "Six Digit Value" },
                                 1700076,
                                 "Birth Year of USA and Illuminati",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "Occult Related", "Six Digit Value" },
                               1070706,
                               "Birth Year of USA and Illuminati",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "Occult Related", "Seven Digit Value" },
                             10700706,
                             "Birth Year of USA and Illuminati",
                             new List<GematriaCipher>(),
                             true,
                             false,
                             true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "Occult Related", "Eight Digit Value" },
                             107000706,
                             "Birth Year of USA and Illuminati",
                             new List<GematriaCipher>(),
                             true,
                             false,
                             true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Occult Related", "Eight Digit Value" },
                            10700706,
                            "Birth Year of USA and Illuminati",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related" },
                                         9669,
                                         "Saturn's Rings",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                         new string[] { "Occult Related", "Primes" },
                                         100943,
                                         "9669th See Prime(Saturn's Rings)",
                                         new List<GematriaCipher>(),
                                         true,
                                         false,
                                         true);
            MatchValues.Add(matchValue);

            //9669th Triangular (9669 saturns rings)
            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "Occult Related", "Triangulars", "Seven Digit Value" },
                                      46749615,
                                      "9669th Triangular",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                               new string[] { "666 Related", "Primes" },
                                                3794,
                                                "mirror of 4973, the 666th Prime Number.",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "666 Related" },
                                                   14706,
                                                   "(666)49 = 14706 = T(171)",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "666 Related", "Primes" },
                                                  40973,
                                                  "4973, 666th Prime Number when second digit is 0.",
                                                  new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "666 Related" },
                                                 49073,
                                                 "4973, 666th Prime Number when third digit is 0.",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                              new string[] { "666 Related", "Primes" },
                                               49703,
                                               "4973, 666th Prime Number when fourth digit is 0.",
                                               new List<GematriaCipher>(),
                                               true,
                                               false,
                                               true);
            MatchValues.Add(matchValue);


            //666 experimental
            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "666 Related" },
                                              49730,
                                              "4973, 666th Prime Number when fifth digit is 0.",
                                              new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "666 Related", "Primes" },
                                                  66659,
                                                  "The sum of the first 666 primes contains 666: 2 + 3 + 5 + 7 + 11 � � � +4969 + 4973 = 1533157 = 23 � 66659",
                                                  new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "666 Related" },
                                                 355680,
                                                 "The sum of all devisors for 222111.  Which is the 666th Triangular number.",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);






            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "666 Related", "Primes", "Seven Digit Value" },
                                                 20772200,
                                                 "The smallest integer with the property that the sum of the prime factors of n and the sum of the prime factors of n+1 are both equal to 666: 20772200 = 2x2x2x5x5x283x367, and 2+2+2+5+5+283+367 = 666",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "666 Related", "Eight Digit Value" },
                                                   295408296,
                                                   "666 = 443556 x 443556 x 443556",
                                                   new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);
            MatchValues.Add(matchValue);

            //999 experimental
            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related" },
                                                 911119,
                                                 "911 combination",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);


            //perfect numbers
            matchValue = new MatchValue(MatchValue.Type.System,
                                          new string[] { "Perfect Number" },
                                          496,
                                          "Perfect Number, n=3, Pn=5",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                       new string[] { "Perfect Number" },
                                       8128,
                                       "Perfect Number, n=4, Pn=7",
                                       new List<GematriaCipher>(),
                                       true,
                                       false,
                                       true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "Perfect Number" },
                                      33550336,
                                      "Perfect Number, n=5, Pn=13",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                    new string[] { "Perfect Number" },
                                    8589869056,
                                    "Perfect Number, n=6, Pn=17",
                                    new List<GematriaCipher>(),
                                    true,
                                    false,
                                    true);
            MatchValues.Add(matchValue);

            //pi

            matchValue = new MatchValue(MatchValue.Type.System,
                                           new string[] { "PI Related" },
                                           31415,
                                           "First 5 Digits of PI",
                                           new List<GematriaCipher>(),
                                           true,
                                           false,
                                           true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "PI Related" },
                                 314159,
                                 "First 6 Digits of PI",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                new string[] { "PI Related", "Six Digit Value" },
                                3141592,
                                "First 7 Digits of PI",
                                new List<GematriaCipher>(),
                               true,
                               false,
                               true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "PI Related" },
                             252499,
                             "The string 666666 occurs at position 252499",
                             new List<GematriaCipher>(),
                             true,
                             false,
                             true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "PI Related" },
                            130927,
                            "The string 130927 occurs at position 1 Mil",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "PI Related" },
                            13092,
                            "The string 13092 occurs at position 1 Mil",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "PI Related" },
                            432460,
                            "The string 432460 occurs at position 777777",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "PI Related" },
                            43246,
                            "The string 43246 occurs at position 777777",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "PI Related" },
                            513092,
                            "The string 513092 occurs at position 999999",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                          new string[] { "PI Related" },
                          51309,
                          "The string 4324 occurs at position 999999",
                          new List<GematriaCipher>(),
                          true,
                          false,
                          true);
            MatchValues.Add(matchValue);



            //phi
            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "PHI Related" },
                              16180,
                              "First 5 Digits of PHI",
                              new List<GematriaCipher>(),
                              true,
                              false,
                              true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                new string[] { "PHI Related" },
                                 161803,
                                 "First 6 Digits of PHI",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "PHI Related", "Six Digit Value" },
                               1618033,
                               "First 7 Digits of PHI",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);


            //911 experimental
            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "911 Related" },
                                   119911,
                                   "911 combination",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related", "Six Digit Value" },
                                                 9110911,
                                                 "911 combination",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);




            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related", "Six Digit Value" },
                                                 9110119,
                                                 "911 combination",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related" },
                                                1190911,
                                                "911 combination",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related", "Six Digit Value" },
                                                1190119,
                                                "911 combination",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related", "Six Digit Value" },
                                                1191190,
                                                "911 combination",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related", "Six Digit Value" },
                                                1190911,
                                                "911 combination",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);
            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                                                   new string[] { "911 Related" },
                                                   12119,
                                                   "911 Reversed where 21 is 2001",
                                                   new List<GematriaCipher>(),
                                                   true,
                                                   false,
                                                   true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                  new string[] { "911 Related" },
                                                  91121,
                                                  "mirror of 12119",
                                                  new List<GematriaCipher>(),
                                                  true,
                                                  false,
                                                  true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                 new string[] { "911 Related" },
                                                 12911,
                                                 "12 is 21 reversed which is 2001 and 911",
                                                 new List<GematriaCipher>(),
                                                 true,
                                                 false,
                                                 true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related" },
                                                11921,
                                                "Mirror of 12911",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                                new string[] { "911 Related" },
                                                101921,
                                                "911 where 21 is 2001",
                                                new List<GematriaCipher>(),
                                                true,
                                                false,
                                                true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                              new string[] { "911 Related" },
                                              129101,
                                              "Mirror of 101921",
                                              new List<GematriaCipher>(),
                                              true,
                                              false,
                                              true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                             new string[] { "911 Related" },
                                             110921,
                                             "911 where 21 is 2001",
                                             new List<GematriaCipher>(),
                                             true,
                                             false,
                                             true); ;

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                          new string[] { "911 Related" },
                                          129011,
                                          "Mirror of 110921",
                                          new List<GematriaCipher>(),
                                          true,
                                          false,
                                          true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                            new string[] { "911 Related" },
                                            119021,
                                            "911 where 21 is 2001",
                                            new List<GematriaCipher>(),
                                            true,
                                            false,
                                            true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                           new string[] { "911 Related" },
                                           120911,
                                           "Mirror if 119021",
                                           new List<GematriaCipher>(),
                                           true,
                                           false,
                                           true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "911 Related" },
                                      119201,
                                      "911 where 21 is 2001",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                      new string[] { "911 Related" },
                                      119201,
                                      "Mirror of 119201",
                                      new List<GematriaCipher>(),
                                      true,
                                      false,
                                      true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "911 Related" },
                                     119210,
                                     "911 where 21 is 2001",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "911 Related" },
                                   119210,
                                   "Mirror  of 119210",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                     new string[] { "911 Related" },
                                     901121,
                                     "911 where 21 is 2001",
                                     new List<GematriaCipher>(),
                                     true,
                                     false,
                                     true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "911 Related" },
                                 121109,
                                 "Mirror  of 901121",
                                 new List<GematriaCipher>(),
                                 true,
                                 false,
                                 true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                   new string[] { "911 Related" },
                                   910121,
                                   "911 where 21 is 2001",
                                   new List<GematriaCipher>(),
                                   true,
                                   false,
                                   true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "911 Related" },
                               121019,
                               "Mirror  of 910121",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "911 Related" },
                                  911021,
                                  "911 where 21 is 2001",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                  true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "911 Related" },
                              120119,
                              "Mirror  of 911021",
                              new List<GematriaCipher>(),
                              true,
                            false,
                            true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                  new string[] { "911 Related" },
                                  911201,
                                  "911 where 21 is 2001",
                                  new List<GematriaCipher>(),
                                  true,
                                  false,
                                   true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "911 Related" },
                            102119,
                            "Mirror  of 911201",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                 new string[] { "911 Related" },
                                 911210,
                                 "911 where 21 is 2001",
                                 new List<GematriaCipher>(),
                                 true,
                                false,
                                true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                                new string[] { "911 Related" },
                                911210,
                                "911 where 21 is 2001",
                                new List<GematriaCipher>(),
                                 true,
                                false,
                                true);

            MatchValues.Add(matchValue);

            

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "Primes", "Large Primes" },
                              117763,
                              "The 11,111th Prime",
                              new List<GematriaCipher>(),
                               true,
                              false,
                              true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "Primes", "Large Primes" },
                              252233,
                              "The 22,222th Prime",
                              new List<GematriaCipher>(),
                               true,
                              false,
                              true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                new string[] { "Primes", "Large Primes" },
                378779,
                "The 32,200th Prime",
                new List<GematriaCipher>(),
                true,
                false,
                true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Primes", "Large Primes" },
                        393191,
                        "The 33,333th Prime",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);

   

            matchValue = new MatchValue(MatchValue.Type.System,
                    new string[] { "Primes", "Large Primes" },
                    538259,
                    "The 44,444th Prime",
                    new List<GematriaCipher>(),
                    true,
                    false,
                    true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "Primes", "Large Primes" },
                              611953,
                              "The 50,000th Prime",
                              new List<GematriaCipher>(),
                               true,
                              false,
                              true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "Primes", "Large Primes" },
                             686671,
                             "The 55,555th Prime",
                             new List<GematriaCipher>(),
                              true,
                             false,
                             true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                             new string[] { "Primes", "Large Primes" },
                             835951,
                             "The 66,600th Prime",
                             new List<GematriaCipher>(),
                              true,
                             false,
                             true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Primes", "Large Primes" },
                        836833,
                        "The 66,666th Prime",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                      new string[] { "Primes", "Large Primes" },
                      989999,
                      "The 77,777th Prime",
                      new List<GematriaCipher>(),
                      true,
                      false,
                      true);

            MatchValues.Add(matchValue);

            

            matchValue = new MatchValue(MatchValue.Type.System,
                    new string[] { "Primes", "Large Primes" },
                    1144153,
                    "The 88,888th Prime",
                    new List<GematriaCipher>(),
                    true,
                    false,
                    true);

            MatchValues.Add(matchValue);

           matchValue = new MatchValue(MatchValue.Type.System,
                    new string[] { "Primes", "Large Primes" },
                    1174727,
                    "The 91,000th Prime",
                    new List<GematriaCipher>(),
                    true,
                    false,
                    true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "Primes", "Large Primes" },
                              1299689,
                              "The 99,999th Prime",
                              new List<GematriaCipher>(),
                               true,
                              false,
                              true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                              new string[] { "Primes", "Large Primes" },
                              1299709,
                              "The 100,000th Prime",
                              new List<GematriaCipher>(),
                               true,
                              false,
                              true);

            MatchValues.Add(matchValue);

            

            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "Planetary Alignments" },
                               10759,
                               "1 Saturn year in days",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "Planetary Alignments" },
                               10760,
                               "1 Saturn year in days",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                               new string[] { "Planetary Alignments" },
                               21518,
                               "2 Saturn years in days",
                               new List<GematriaCipher>(),
                               true,
                               false,
                               true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Planetary Alignments" },
                            32277,
                            "3 Saturn years in days",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Planetary Alignments" },
                            24491,
                            "Saturn solar days in each year",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Planetary Alignments" },
                            4332,
                            "1 Jupiter year in days",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Planetary Alignments" },
                            4333,
                            "1 Jupiter year in days",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                            new string[] { "Planetary Alignments" },
                            8665,
                            "2 Jupiter years in days",
                            new List<GematriaCipher>(),
                            true,
                            false,
                            true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                           new string[] { "Planetary Alignments" },
                           17330,
                           "4 Jupiter years in days",
                           new List<GematriaCipher>(),
                           true,
                           false,
                           true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                           new string[] { "Planetary Alignments" },
                           21662,
                           "5 Jupiter years in days",
                           new List<GematriaCipher>(),
                           true,
                           false,
                           true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                           new string[] { "Planetary Alignments" },
                           25995,
                           "6 Jupiter years in days",
                           new List<GematriaCipher>(),
                           true,
                           false,
                           true);

            MatchValues.Add(matchValue);



            matchValue = new MatchValue(MatchValue.Type.System,
                           new string[] { "Planetary Alignments" },
                           30328,
                           "7 Jupiter years in days",
                           new List<GematriaCipher>(),
                           true,
                           false,
                           true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                         new string[] { "Planetary Alignments" },
                         34660,
                         "8 Jupiter years in days",
                         new List<GematriaCipher>(),
                         true,
                         false,
                         true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Planetary Alignments" },
                        10475,
                        "Jupiter solar days in each year",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Planetary Alignments" },
                        10476,
                        "Jupiter solar days in each year",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Planetary Alignments" },
                        30687,
                        "1 Uranus year in days",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);


            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Planetary Alignments" },
                        60190,
                        "1 Neptune year in days",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);

            matchValue = new MatchValue(MatchValue.Type.System,
                        new string[] { "Planetary Alignments" },
                        10476,
                        "Jupiter solar days in each year",
                        new List<GematriaCipher>(),
                        true,
                        false,
                        true);

            MatchValues.Add(matchValue);
        }

        public static MatchValueConfig Instance()
        {
            if (Config == null)
            {
                if (File.Exists(GematriaFactory.Instance().GetConfigDir() + "\\MatchValues.xml"))
                {
                    Config = (MatchValueConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\MatchValues.xml", typeof(MatchValueConfig));
                }
                else
                {
                    MatchValueConfig thisConfig = new MatchValueConfig();
                    thisConfig.SetDefaults();
                    SaveConfig(GematriaFactory.Instance().GetConfigDir() + "\\MatchValues.xml", thisConfig);
                    Config = (MatchValueConfig)LoadConfig(GematriaFactory.Instance().GetConfigDir() + "\\MatchValues.xml", typeof(MatchValueConfig));
                }
            }
            return Config;
        }
    }
}
