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
    public partial class KayitListele : Form
    {
       
        public KayitListele()
        {
            InitializeComponent();
        }



        private void btn_alldata_Click(object sender, EventArgs e)
        {
            grdliste.DataSource = TumListe();
        }
        private List<todoList> TumListe()
        {
            return SanalDatabase.listele();
        }

        private void KayitListele_Load(object sender, EventArgs e)
        {
            grdliste.DataSource = TumListe();
        }
    }
}
