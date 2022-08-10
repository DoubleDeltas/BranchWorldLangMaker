namespace BranchWordLangMaker
{
    public class WordTriplet
    {
        public string Word { get; private set; }
        public string Pronunciation { get; private set; }
        public string Meaning { get; private set; }

        public WordTriplet(string word, string pronunciation, string meaning)
        {
            this.Word = word;
            this.Pronunciation = pronunciation;
            this.Meaning = meaning;
        }
    }
}
