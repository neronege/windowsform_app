namespace ToDo_exercise
{
    partial class Todo
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
            this.label_title = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label_shorDescription = new System.Windows.Forms.Label();
            this.textshorDescription = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label_important = new System.Windows.Forms.Label();
            this.textImportant = new System.Windows.Forms.TextBox();
            this.label_stution = new System.Windows.Forms.Label();
            this.button_kayit = new System.Windows.Forms.Button();
            this.comboBox_Sitution = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(26, 26);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(44, 16);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Başlık";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(144, 26);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(144, 22);
            this.textTitle.TabIndex = 0;
            this.textTitle.Enter += new System.EventHandler(this.textTitle_Enter);
            this.textTitle.Leave += new System.EventHandler(this.textTitle_Leave);
            // 
            // label_shorDescription
            // 
            this.label_shorDescription.AutoSize = true;
            this.label_shorDescription.Location = new System.Drawing.Point(26, 96);
            this.label_shorDescription.Name = "label_shorDescription";
            this.label_shorDescription.Size = new System.Drawing.Size(92, 16);
            this.label_shorDescription.TabIndex = 0;
            this.label_shorDescription.Text = "Kısa Açıklama";
            // 
            // textshorDescription
            // 
            this.textshorDescription.Location = new System.Drawing.Point(144, 93);
            this.textshorDescription.Multiline = true;
            this.textshorDescription.Name = "textshorDescription";
            this.textshorDescription.Size = new System.Drawing.Size(144, 77);
            this.textshorDescription.TabIndex = 1;
            this.textshorDescription.Enter += new System.EventHandler(this.textTitle_Enter);
            this.textshorDescription.Leave += new System.EventHandler(this.textTitle_Leave);
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(26, 217);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(63, 16);
            this.label_description.TabIndex = 0;
            this.label_description.Text = "Açıklama";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(144, 217);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(144, 129);
            this.textDescription.TabIndex = 2;
            this.textDescription.Enter += new System.EventHandler(this.textTitle_Enter);
            this.textDescription.Leave += new System.EventHandler(this.textTitle_Leave);
            // 
            // label_important
            // 
            this.label_important.AutoSize = true;
            this.label_important.Location = new System.Drawing.Point(26, 352);
            this.label_important.Name = "label_important";
            this.label_important.Size = new System.Drawing.Size(49, 16);
            this.label_important.TabIndex = 0;
            this.label_important.Text = "Önemli";
            // 
            // textImportant
            // 
            this.textImportant.Location = new System.Drawing.Point(144, 352);
            this.textImportant.Name = "textImportant";
            this.textImportant.Size = new System.Drawing.Size(144, 22);
            this.textImportant.TabIndex = 3;
            this.textImportant.Enter += new System.EventHandler(this.textTitle_Enter);
            this.textImportant.Leave += new System.EventHandler(this.textTitle_Leave);
            // 
            // label_stution
            // 
            this.label_stution.AutoSize = true;
            this.label_stution.Location = new System.Drawing.Point(26, 400);
            this.label_stution.Name = "label_stution";
            this.label_stution.Size = new System.Drawing.Size(46, 16);
            this.label_stution.TabIndex = 0;
            this.label_stution.Text = "Durum";
            // 
            // button_kayit
            // 
            this.button_kayit.Location = new System.Drawing.Point(144, 445);
            this.button_kayit.Name = "button_kayit";
            this.button_kayit.Size = new System.Drawing.Size(144, 28);
            this.button_kayit.TabIndex = 5;
            this.button_kayit.Text = "Kaydet";
            this.button_kayit.UseVisualStyleBackColor = true;
            this.button_kayit.Click += new System.EventHandler(this.button_kayit_Click);
            // 
            // comboBox_Sitution
            // 
            this.comboBox_Sitution.FormattingEnabled = true;
            this.comboBox_Sitution.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal Edildi",
            "Ertelendi"});
            this.comboBox_Sitution.Location = new System.Drawing.Point(144, 400);
            this.comboBox_Sitution.Name = "comboBox_Sitution";
            this.comboBox_Sitution.Size = new System.Drawing.Size(144, 24);
            this.comboBox_Sitution.TabIndex = 4;
            // 
            // Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 498);
            this.Controls.Add(this.comboBox_Sitution);
            this.Controls.Add(this.button_kayit);
            this.Controls.Add(this.textImportant);
            this.Controls.Add(this.label_stution);
            this.Controls.Add(this.label_important);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textshorDescription);
            this.Controls.Add(this.label_shorDescription);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Todo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label_shorDescription;
        private System.Windows.Forms.TextBox textshorDescription;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label_important;
        private System.Windows.Forms.TextBox textImportant;
        private System.Windows.Forms.Label label_stution;
        private System.Windows.Forms.Button button_kayit;
        private System.Windows.Forms.ComboBox comboBox_Sitution;
    }
}