using System;

namespace GematriaForTruth.API.Cipher
{
    [Serializable]
    public abstract class PolymorphicCipher : GematriaCipher
    {
        public bool HasMorphed { get; set; }
        public PolymorphicCipher() : base()
        {
            HasMorphed = false;
        }

        public override long Decode(string phrase)
        {
            return base.Decode(phrase);
        }
    }
}
