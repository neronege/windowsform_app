using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_exercise
{
    public partial class Todo : Form
    {
      
        public Todo()
        {
            InitializeComponent();
        }

        private void button_kayit_Click(object sender, EventArgs e)
        {
            todoList todo = new todoList()
            {
                id = Guid.NewGuid(),
                Description = textDescription.Text,
                Title = textTitle.Text,
                Important =textImportant.Text,
                short_Description = textshorDescription.Text,
                Situtaion = comboBox_Sitution.Text

            };
            if(!string.IsNullOrEmpty(todo.Description) && !string.IsNullOrEmpty(todo.Title) && !string.IsNullOrEmpty(todo.short_Description))
            {
                SanalDatabase.ListEkle(todo);
                DialogResult result1 = MessageBox.Show("Yeni Kayıt Başarılı", "Başarılı",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result1 == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("Yeni Kayıt eklemek ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        foreach(Control item in this.Controls)
                        {
                            if(item is TextBox)
                            {
                                ((TextBox)item).Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        this.Close();
                        KayitListele kayitListele = new KayitListele();
                        kayitListele.MdiParent = Application.OpenForms["Form1"]; 
                        kayitListele.Show();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Kayıta başarasızdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textTitle_Enter(object sender, EventArgs e)
        {
           ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void textTitle_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        
    }
}
