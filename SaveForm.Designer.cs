
namespace BranchWordLangMaker
{
    partial class SaveForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_origin = new System.Windows.Forms.TextBox();
            this.tb_pronunciation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_meaning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "원어";
            // 
            // tb_origin
            // 
            this.tb_origin.Location = new System.Drawing.Point(55, 19);
            this.tb_origin.Name = "tb_origin";
            this.tb_origin.Size = new System.Drawing.Size(260, 25);
            this.tb_origin.TabIndex = 1;
            // 
            // tb_pronunciation
            // 
            this.tb_pronunciation.Location = new System.Drawing.Point(55, 50);
            this.tb_pronunciation.Name = "tb_pronunciation";
            this.tb_pronunciation.Size = new System.Drawing.Size(260, 25);
            this.tb_pronunciation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "발음";
            // 
            // tb_meaning
            // 
            this.tb_meaning.Location = new System.Drawing.Point(55, 81);
            this.tb_meaning.Name = "tb_meaning";
            this.tb_meaning.Size = new System.Drawing.Size(260, 25);
            this.tb_meaning.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "뜻";
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(70, 123);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(83, 35);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "확인";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(190, 123);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(83, 35);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "취소";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 177);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_meaning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pronunciation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_origin);
            this.Controls.Add(this.label1);
            this.Name = "SaveForm";
            this.Text = "단어 저장";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_origin;
        private System.Windows.Forms.TextBox tb_pronunciation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_meaning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
    }
}