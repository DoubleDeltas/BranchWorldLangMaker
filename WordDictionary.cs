using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BranchWordLangMaker
{
    class WordDictionary
    {
        /* SINGLETON */
        private static WordDictionary instance;

        public List<WordTriplet> Item { get; private set; }

        private const string FILE_PATH = "./BranchWorldLangMaker.dat";

        private WordDictionary() {

            Load();
        }

        public static WordDictionary Instance()
        {
            if (instance == null)
                instance = new WordDictionary();
            return instance;
        }

        public void Load() {
            Item = new List<WordTriplet>();

            try
            {
                if (!File.Exists(FILE_PATH))
                    File.Create(FILE_PATH);

                string[] lines = File.ReadAllLines(FILE_PATH);
                foreach (string line in lines)
                {
                    if (line.TrimEnd() == "")
                        continue;
                    string[] words = line.Split(' ');
                    Item.Add(new WordTriplet(words[0], words[1], words[2]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + ex.StackTrace);
            }
        }

        private int FindTripletIndex(WordTriplet triplet)
        {
            for (int i=0; i < Item.Count; i++)
            {
                if (Item[i].Equals(triplet))
                    return i;
            }
            return -1;
        }

        public void Add(WordTriplet triplet)
        {
            Item.Add(triplet);

            try
            {
                StreamWriter writer = new StreamWriter(FILE_PATH, append: true);

                writer.WriteLine(triplet.Word + ' ' + triplet.Pronunciation + ' ' + triplet.Meaning);
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + ex.Message);
            }
        }

        public void Add(string word, string pronunciation, string meaning)
        {
            Add(new WordTriplet(word, pronunciation, meaning));
        }

        public void Edit (WordTriplet oldTriplet, WordTriplet newTriplet)
        {
            int index = FindTripletIndex(oldTriplet);
            
            if (index == -1)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + "Edit 찾기 실패");
                return;
            }

            Item[index] = newTriplet;

            try
            {
                string[] lines = File.ReadAllLines(FILE_PATH);
                lines[index] = newTriplet.Word + ' ' + newTriplet.Pronunciation + ' ' + newTriplet.Meaning;
                File.WriteAllLines(FILE_PATH, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + ex.Message);
            }
        }

        public void Edit(string oldWord, string oldPronunciation, string oldMeaning, string word, string pronunciation, string meaning)
        {
            Edit(new WordTriplet(oldWord, oldPronunciation, oldMeaning), new WordTriplet(word, pronunciation, meaning));
        }

        public void Delete(WordTriplet oldTriplet)
        {
            int index = FindTripletIndex(oldTriplet);

            if (index == -1)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + "Delete 찾기 실패");
                return;
            }

            Item.RemoveAt(index);

            try
            {
                List<string> lineList = new List<string>(File.ReadAllLines(FILE_PATH));
                lineList.RemoveAt(index);
                File.WriteAllLines(FILE_PATH, lineList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다!\n\n" + ex.Message);
            }
        }

        public void Delete(string oldWord, string oldPronunciation, string oldMeaning)
        {
            Delete(new WordTriplet(oldWord, oldPronunciation, oldMeaning));
        }
    }
}
