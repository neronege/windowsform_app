namespace ToDo_exercise
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_islemListesi = new System.Windows.Forms.GroupBox();
            this.btn_yeniKayit = new System.Windows.Forms.Button();
            this.btn_kayit_listele = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnlİslemListesi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_islemListesi.SuspendLayout();
            this.pnlİslemListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox_islemListesi
            // 
            this.groupBox_islemListesi.Controls.Add(this.btn_close);
            this.groupBox_islemListesi.Controls.Add(this.btn_kayit_listele);
            this.groupBox_islemListesi.Controls.Add(this.btn_yeniKayit);
            this.groupBox_islemListesi.Location = new System.Drawing.Point(12, 161);
            this.groupBox_islemListesi.Name = "groupBox_islemListesi";
            this.groupBox_islemListesi.Size = new System.Drawing.Size(172, 194);
            this.groupBox_islemListesi.TabIndex = 5;
            this.groupBox_islemListesi.TabStop = false;
            this.groupBox_islemListesi.Text = "İşlem Listesi";
            // 
            // btn_yeniKayit
            // 
            this.btn_yeniKayit.Location = new System.Drawing.Point(19, 37);
            this.btn_yeniKayit.Name = "btn_yeniKayit";
            this.btn_yeniKayit.Size = new System.Drawing.Size(132, 23);
            this.btn_yeniKayit.TabIndex = 0;
            this.btn_yeniKayit.Text = "Yeni Kayıt";
            this.btn_yeniKayit.UseVisualStyleBackColor = true;
            this.btn_yeniKayit.Click += new System.EventHandler(this.btn_yeniKayit_Click);
            // 
            // btn_kayit_listele
            // 
            this.btn_kayit_listele.Location = new System.Drawing.Point(19, 84);
            this.btn_kayit_listele.Name = "btn_kayit_listele";
            this.btn_kayit_listele.Size = new System.Drawing.Size(132, 23);
            this.btn_kayit_listele.TabIndex = 0;
            this.btn_kayit_listele.Text = "Kayıt Listele";
            this.btn_kayit_listele.UseVisualStyleBackColor = true;
            this.btn_kayit_listele.Click += new System.EventHandler(this.btn_kayit_listele_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(19, 141);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(132, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Uygulama Kapat";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnlİslemListesi
            // 
            this.pnlİslemListesi.Controls.Add(this.pictureBox1);
            this.pnlİslemListesi.Controls.Add(this.groupBox_islemListesi);
            this.pnlİslemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlİslemListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlİslemListesi.Margin = new System.Windows.Forms.Padding(1);
            this.pnlİslemListesi.Name = "pnlİslemListesi";
            this.pnlİslemListesi.Size = new System.Drawing.Size(209, 573);
            this.pnlİslemListesi.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 573);
            this.Controls.Add(this.pnlİslemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_islemListesi.ResumeLayout(false);
            this.pnlİslemListesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox_islemListesi;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_kayit_listele;
        private System.Windows.Forms.Button btn_yeniKayit;
        private System.Windows.Forms.Panel pnlİslemListesi;
    }
}

