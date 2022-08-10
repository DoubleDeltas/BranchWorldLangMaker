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

        public bool Equals(WordTriplet target)
        {
            return (this.Word == target.Word)
                && (this.Pronunciation == target.Pronunciation)
                && (this.Meaning == target.Meaning);
        }
    }
}
