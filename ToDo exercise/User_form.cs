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
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        public void btn_enter_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = textuser.Text;
            user.Password = textpassword.Text;

            if (user.Username == "neron" && user.Password == "1234")
            {
                Form anaform = Application.OpenForms["Form1"];
                Panel solpanel = (Panel)anaform.Controls["pnlİslemListesi"];
                GroupBox gbIslemListe = (GroupBox)solpanel.Controls["groupBox_islemListesi"];
                foreach(Control item in gbIslemListe.Controls)
                {
                    if(item is Button)
                    {
                        item.Enabled = true;
                    }
                }
                MessageBox.Show("Merhaba " +textuser.Text.ToUpper(),"Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void textuser_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void textuser_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }
    }
}
