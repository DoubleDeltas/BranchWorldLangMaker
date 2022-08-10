using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranchWordLangMaker
{
    public partial class FormEdit : Form
    {
        public string Word { get; private set; }
        public string Pronunciation { get; private set; }
        public string Meaning { get; private set; }

        public FormEdit(string word, string pronunciation = "", string meaning = "")
        {
            InitializeComponent();

            tb_origin.Text = this.Word = word;
            tb_pronunciation.Text = this.Pronunciation = pronunciation;
            tb_meaning.Text = this.Meaning = meaning;

            tb_pronunciation.Select();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            Word = tb_origin.Text;
            Pronunciation = tb_pronunciation.Text;
            Meaning = tb_meaning.Text;
        }
    }
}
