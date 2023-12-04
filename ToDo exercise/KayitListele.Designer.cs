namespace ToDo_exercise
{
    partial class KayitListele
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
            this.grp_islemListesi = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_uncomplete = new System.Windows.Forms.Button();
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_alldata = new System.Windows.Forms.Button();
            this.groupBox_liste = new System.Windows.Forms.GroupBox();
            this.grdliste = new System.Windows.Forms.DataGridView();
            this.grp_islemListesi.SuspendLayout();
            this.groupBox_liste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdliste)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_islemListesi
            // 
            this.grp_islemListesi.Controls.Add(this.btn_cancel);
            this.grp_islemListesi.Controls.Add(this.btn_uncomplete);
            this.grp_islemListesi.Controls.Add(this.btn_complete);
            this.grp_islemListesi.Controls.Add(this.btn_alldata);
            this.grp_islemListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.grp_islemListesi.Location = new System.Drawing.Point(0, 0);
            this.grp_islemListesi.Name = "grp_islemListesi";
            this.grp_islemListesi.Size = new System.Drawing.Size(200, 361);
            this.grp_islemListesi.TabIndex = 3;
            this.grp_islemListesi.TabStop = false;
            this.grp_islemListesi.Text = "İşlem Listesi";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(25, 270);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(142, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "iptal Edildi";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_uncomplete
            // 
            this.btn_uncomplete.Location = new System.Drawing.Point(25, 241);
            this.btn_uncomplete.Name = "btn_uncomplete";
            this.btn_uncomplete.Size = new System.Drawing.Size(142, 23);
            this.btn_uncomplete.TabIndex = 4;
            this.btn_uncomplete.Text = "Tamamlanmadı";
            this.btn_uncomplete.UseVisualStyleBackColor = true;
            // 
            // btn_complete
            // 
            this.btn_complete.Location = new System.Drawing.Point(25, 212);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(142, 23);
            this.btn_complete.TabIndex = 5;
            this.btn_complete.Text = "Tamamlandı\r\n";
            this.btn_complete.UseVisualStyleBackColor = true;
            // 
            // btn_alldata
            // 
            this.btn_alldata.Location = new System.Drawing.Point(25, 183);
            this.btn_alldata.Name = "btn_alldata";
            this.btn_alldata.Size = new System.Drawing.Size(142, 23);
            this.btn_alldata.TabIndex = 6;
            this.btn_alldata.Text = "Tüm Kayıtlar";
            this.btn_alldata.UseVisualStyleBackColor = true;
            this.btn_alldata.Click += new System.EventHandler(this.btn_alldata_Click);
            // 
            // groupBox_liste
            // 
            this.groupBox_liste.Controls.Add(this.grdliste);
            this.groupBox_liste.Location = new System.Drawing.Point(220, 21);
            this.groupBox_liste.Name = "groupBox_liste";
            this.groupBox_liste.Size = new System.Drawing.Size(450, 334);
            this.groupBox_liste.TabIndex = 4;
            this.groupBox_liste.TabStop = false;
            this.groupBox_liste.Text = "Liste";
            // 
            // grdliste
            // 
            this.grdliste.AllowUserToAddRows = false;
            this.grdliste.AllowUserToDeleteRows = false;
            this.grdliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdliste.Location = new System.Drawing.Point(3, 18);
            this.grdliste.Name = "grdliste";
            this.grdliste.ReadOnly = true;
            this.grdliste.RowHeadersWidth = 51;
            this.grdliste.RowTemplate.Height = 24;
            this.grdliste.Size = new System.Drawing.Size(444, 313);
            this.grdliste.TabIndex = 0;
            // 
            // KayitListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 361);
            this.Controls.Add(this.groupBox_liste);
            this.Controls.Add(this.grp_islemListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KayitListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo KayitListele";
            this.Load += new System.EventHandler(this.KayitListele_Load);
            this.grp_islemListesi.ResumeLayout(false);
            this.groupBox_liste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdliste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_islemListesi;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_uncomplete;
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_alldata;
        private System.Windows.Forms.GroupBox groupBox_liste;
        private System.Windows.Forms.DataGridView grdliste;
    }
}