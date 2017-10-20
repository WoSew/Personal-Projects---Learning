using System.Collections.Generic;

namespace WoSew.TrainingLibrary.Common.Base.Inheritance
{
    public abstract class StringDictionary<T> : Dictionary<string, T>
    {
        public abstract List<T> GetAnagramSet(string anagramCandidate); // radar - raadr

        public abstract List<T> GetPalindromSet(); // kajak, aabbccbbaa, cyc

        public abstract List<T> GetWildcardSet(string wildcard); // test*    : testasd, test123123, testcvxx

    }
}