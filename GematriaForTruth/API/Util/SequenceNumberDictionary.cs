using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;

namespace GematriaForTruth.API.Util
{
    public abstract class SequenceNumberDictionary
    {
        public abstract string GetNumbericResourceTextFile();
        public abstract long GetNumericalConstantsLength();

        protected abstract bool IsNumberSequenceType(long value);

        protected Dictionary<long, int> NumberIndiciesDict;

        public int NumDigits { get; set; }

        public SequenceNumberDictionary()
        { }

        public SequenceNumberDictionary(int numDigits)
        {
            NumDigits = numDigits;
            NumberIndiciesDict = new Dictionary<long, int>();
            LoadSequence();
        }
        private void LoadSequence()
        {
            string file = GetNumbericResourceTextFile();

            string[] lines = file.Split(Environment.NewLine);
            foreach(string line in lines)
            {
                string[] pair = line.Split(' ');
                NumberIndiciesDict.Add(long.Parse(pair[1]), int.Parse(pair[0]));
            }
        }
        public void Dispose()
        {
            NumberIndiciesDict.Clear();
            GC.Collect();
        }
        public int GetNumberIndex(long number)
        {
            if (number == 0 || IsNumberSequenceType(number) == false)
                return -1;
            try
            {
                return NumberIndiciesDict[number];
            }

            catch (KeyNotFoundException)
            {
                return -1;
            }
        }
    }
}
