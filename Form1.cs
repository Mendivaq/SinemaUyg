using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sineeema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sinema salon;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salon = new Sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text="Salon Oluşturuldu.Koltuk Sayısı:" + salon.BosKoltukOgren();
            }
            catch 
            {

                label3.Text="Salon Oluşturulamadı.Bilgileri kontrol ediniz.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletSat(radioButton1.Checked);
                label3.Text = "Bilet satıldı. Kalan koltuk sayısı:" + salon.BosKoltukOgren();
            }
            catch (NullReferenceException)
            {
                label3.Text = "Lütfen boş geçmeyiniz!";

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                salon.BiletIptal(radioButton1.Checked);
                label3.Text = "Bilet iptal edildi.Kalan koltuk sayısı:" + salon.BosKoltukOgren();
            }
            catch (NullReferenceException)
            {

                label3.Text = "Lütfen boş geçmeyiniz!";
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               label3.Text = "Boş Koltuk Sayısı" + salon.BosKoltukOgren();
            }
            catch (NullReferenceException hatas)
            {
                label3.Text = "Lütfen boş geçmeyiniz!";

            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "Şu anki bakiye:" + salon.bakiyeogren() + "TL";

            }
            catch (NullReferenceException hata)
            {
                label3.Text = "Lütfen boş geçmeyiniz!";

                
            }

            


            
        
       }
        


    }
}
