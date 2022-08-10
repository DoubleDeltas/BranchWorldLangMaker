
namespace BranchWordLangMaker
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.list_pronunciation = new System.Windows.Forms.ListBox();
            this.list_meaning = new System.Windows.Forms.ListBox();
            this.list_origin = new System.Windows.Forms.ListBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.bt_create);
            this.groupBox1.Controls.Add(this.tb_word);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "랜덤 단어 생성";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(290, 153);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(93, 30);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "저장";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(191, 153);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(93, 30);
            this.bt_create.TabIndex = 3;
            this.bt_create.Text = "생성";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // tb_word
            // 
            this.tb_word.Font = new System.Drawing.Font("맑은 고딕", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_word.Location = new System.Drawing.Point(16, 24);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(367, 127);
            this.tb_word.TabIndex = 2;
            this.tb_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "특수문자 키보드";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.list_pronunciation);
            this.groupBox3.Controls.Add(this.list_meaning);
            this.groupBox3.Controls.Add(this.list_origin);
            this.groupBox3.Controls.Add(this.bt_clear);
            this.groupBox3.Controls.Add(this.tb_keyword);
            this.groupBox3.Location = new System.Drawing.Point(420, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 426);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색";
            // 
            // list_pronunciation
            // 
            this.list_pronunciation.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_pronunciation.FormattingEnabled = true;
            this.list_pronunciation.ItemHeight = 20;
            this.list_pronunciation.Location = new System.Drawing.Point(103, 57);
            this.list_pronunciation.Name = "list_pronunciation";
            this.list_pronunciation.Size = new System.Drawing.Size(91, 364);
            this.list_pronunciation.TabIndex = 8;
            this.list_pronunciation.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // list_meaning
            // 
            this.list_meaning.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_meaning.FormattingEnabled = true;
            this.list_meaning.ItemHeight = 20;
            this.list_meaning.Location = new System.Drawing.Point(200, 57);
            this.list_meaning.Name = "list_meaning";
            this.list_meaning.Size = new System.Drawing.Size(162, 364);
            this.list_meaning.TabIndex = 7;
            this.list_meaning.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // list_origin
            // 
            this.list_origin.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.list_origin.FormattingEnabled = true;
            this.list_origin.ItemHeight = 20;
            this.list_origin.Location = new System.Drawing.Point(6, 57);
            this.list_origin.Name = "list_origin";
            this.list_origin.Size = new System.Drawing.Size(91, 364);
            this.list_origin.TabIndex = 6;
            this.list_origin.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(327, 23);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(35, 27);
            this.bt_clear.TabIndex = 5;
            this.bt_clear.Text = "×";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // tb_keyword
            // 
            this.tb_keyword.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_keyword.Location = new System.Drawing.Point(6, 24);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(315, 30);
            this.tb_keyword.TabIndex = 5;
            this.tb_keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_keyword.TextChanged += new System.EventHandler(this.tb_keyword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(12, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "가지세계 언어 생성기 v0.1.0 | Made by DoubleDeltas";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "가지세계 언어 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.ListBox list_meaning;
        private System.Windows.Forms.ListBox list_origin;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_pronunciation;
    }
}

