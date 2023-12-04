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
    public partial class Form1 : Form
    {
        Form T;
        public Form1()
        {

            InitializeComponent();
         

        }
      

     

        private void Form1_Load(object sender, EventArgs e)
        {

            User_form user_form = new User_form();
            user_form.MdiParent = this;
            user_form.StartPosition = FormStartPosition.CenterScreen;
            user_form.Show();
            ButtonAckapa(false);
        }
        public void ButtonAckapa(bool kontrol)
        {
            foreach(Control item in groupBox_islemListesi.Controls)
            {
                if(item is Button)
                {
                    ((Button)item).Enabled = kontrol;
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_yeniKayit_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Todo"] != null)
            {
                T = Application.OpenForms["Todo"];
                T.Focus();

            }
            else
            {
                T = new Todo();
                T.MdiParent = this;
                T.Show();
            }
        }

        private void btn_kayit_listele_Click(object sender, EventArgs e)
        {
            KayitListele listele = new KayitListele();
            listele.MdiParent = this;
            listele.Show();
        }
    }
}
