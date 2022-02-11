using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasorVeDosyaOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnklasor_Click(object sender, EventArgs e)
        {
        
           bool kontrol= Directory.Exists("C:\\Sınıf403");
            if (kontrol == false)
            {
                Directory.CreateDirectory("C:\\Sınıf403");
                MessageBox.Show("Klasör Oluşturuldu");
            }
            else
            {
                DialogResult cevap=
                MessageBox.Show("Klasör daha önce oluşturulmuş.Yeniden oluşturmak istermisiniz?",
                    "KLASÖR OLUŞTURMA"
                    ,MessageBoxButtons.YesNoCancel
                    ,MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    Directory.Delete("C:\\Sınıf403", true);
                    Directory.CreateDirectory("C:\\Sınıf403");
                }
               
            }
                
        }

        private void btnKlasorTasi_Click(object sender, EventArgs e)
        {
            DirectoryInfo info= Directory.CreateDirectory("C:\\Sınıf403");
            
           
            if(info.Exists)
            {
                Directory.Move("C:\\Sınıf403", "C:\\Deneme\\Sınıf403");
                MessageBox.Show("Klasör Taşındı.");
            }

           

        }

        private void btndosya_Click(object sender, EventArgs e)
        {
            bool kontrol = File.Exists("C:\\Sınıf403\\deneme.txt");

            if(kontrol==false)
            {
                FileStream fs= File.Create("C:\\Sınıf403\\deneme.txt");
                fs.Close();
                MessageBox.Show("Dosya Oluşturdu.");
            }
            else
            {
                File.AppendAllText("C:\\Sınıf403\\deneme.txt", "Merhaba istanbul");
                MessageBox.Show("Dosya içine metin yazıldı");
               
            }
            

        }

        private void btnDosyaKopyala_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\Sınıf403\\deneme.txt", "C:\\Deneme\\deneme.txt");
            MessageBox.Show("Dosya Kopyalanadı.");
        }

        private void btnDosyaSil_Click(object sender, EventArgs e)
        {

            File.Delete("C:\\Deneme\\deneme.txt");
            MessageBox.Show("Dosya Silindi.");

        }

        private void btnDosyaOku_Click(object sender, EventArgs e)
        {
            string icerik = File.ReadAllText("C:\\Deneme\\deneme.txt");
            MessageBox.Show(icerik);
        }
    }
}
