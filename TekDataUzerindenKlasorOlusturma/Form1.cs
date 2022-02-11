using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekDataUzerindenKlasorOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kisi> liste = new List<Kisi>();
        private void btnkisigetir_Click(object sender, EventArgs e)
        {
            DataIslemleri di = new DataIslemleri();
             liste = di.KisiGetir();
            lstKisiler.DataSource=liste;
        }

        private void btnklasorolustur_Click(object sender, EventArgs e)
        {
            DataIslemleri ds = new DataIslemleri();
            ds.KlasorOlusturma(liste);

        }
    }
}
