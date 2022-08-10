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
    public partial class FormMain : Form
    {
        WordDictionary dict;
        WordCreator creator;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dict = WordDictionary.Instance();
            creator = WordCreator.Instance();

            if (dict == null)
            {
                MessageBox.Show(
                    "단어 데이터 파일을 불러오는 중 오류가 발생했습니다!",
                    "오류!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
            }

            foreach (WordTriplet triplet in dict.Item)
            {
                list_origin.Items.Add(triplet.Word);
                list_pronunciation.Items.Add(triplet.Pronunciation);
                list_meaning.Items.Add(triplet.Meaning);
            }
        }

        private void RefreshList(List<WordTriplet> list)
        {
            list_origin.Items.Clear();
            list_pronunciation.Items.Clear();
            list_meaning.Items.Clear();

            foreach (WordTriplet triplet in list)
            {
                list_origin.Items.Add(triplet.Word);
                list_pronunciation.Items.Add(triplet.Pronunciation);
                list_meaning.Items.Add(triplet.Meaning);
            }
        }

        private void RefreshList()
        {
            RefreshList(dict.Item);
        }

        private void tb_keyword_TextChanged(object sender, EventArgs e)
        {
            List<WordTriplet> result;

            if (tb_keyword.Text.Length == 0)
            {
                result = dict.Item;
            }
            else
            {
                result = new List<WordTriplet>();
                foreach (WordTriplet triplet in dict.Item)
                {
                    if (triplet.Word.Contains(tb_keyword.Text)
                        || triplet.Pronunciation.Contains(tb_keyword.Text)
                        || triplet.Meaning.Contains(tb_keyword.Text))
                    {
                        result.Add(triplet);
                    }
                }
            }
            RefreshList(result);
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = (sender as ListBox).SelectedIndex;
            list_origin.SelectedIndex = idx;
            list_pronunciation.SelectedIndex = idx;
            list_meaning.SelectedIndex = idx;
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            tb_word.Text = creator.Create();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            SaveForm dialog = new SaveForm(tb_word.Text);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                dict.Add(dialog.Word, dialog.Pronunciation, dialog.Meaning);
                RefreshList();
            }
        }
    }
}
