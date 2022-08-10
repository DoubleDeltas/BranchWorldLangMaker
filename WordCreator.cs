using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchWordLangMaker
{
    public class WordCreator
    {
        private static WordCreator instance;
        private static Random random;

        private static readonly char[] ALLOW_CHARS = (
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            + "abcdefghijklmnopqrstuvwxyz"
            + "ᚠᚡᚢᚣᚤᚥᚦᚧᚨᚩᚪᚫᚬᚭᚮᚯᚰᚱᚲᚳᚴᚵᚶᚷᚸᚹᚺᚻᚼᚽᚾᚿᛀᛁᛂᛃᛄᛅᛆᛇᛈᛉᛊᛋᛌᛍᛎᛏᛐᛑᛒᛓᛔᛕᛖᛗᛘᛙᛚᛛᛜᛝᛞᛟᛠᛡᛢᛣᛤᛥᛦᛧᛨᛩᛪ᛫᛬᛭ᛮᛯ"
            + "àáâãäåæçèéêëìíîïðñòóôõöøùúûüýß"
            + "\'"
            ).ToCharArray();

        private WordCreator() {
            random = new Random();
        }

        public static WordCreator Instance()
        {
            if (instance == null)
                instance = new WordCreator();
            return instance;
        }

        public string Create()
        {
            return Create(2, 6);
        }

        public string Create(int min, int max)
        {
            string ret = "";

            int len = random.Next(min, max);

            for (int i = 0; i < len; i++)
                ret += ALLOW_CHARS[random.Next(ALLOW_CHARS.Length)];

            return ret;
        }
    }
}
