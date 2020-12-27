using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form4 : Form
    {
        public int[] dizisepet = new int[12];
        public string MasaNO_;
        public Form4()
        {
            InitializeComponent();
        }
        string SiparisOzet;
        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = dizisepet[0].ToString();
            double fiyat;
            double toplamfiyat = 0;
            if (dizisepet[0] > 0)
            {
                SiparisOzet = dizisepet[0].ToString() + " adet Et Döner";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 25 * dizisepet[0];
                toplamfiyat = fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[1] > 0)
            {
                SiparisOzet = dizisepet[1].ToString() + " adet Et Döner Ekmek";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 20 * dizisepet[1];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[2] > 0)
            {
                SiparisOzet = dizisepet[2].ToString() + " adet Tombik Et Döner";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 22 * dizisepet[2];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[3] > 0)
            {
                SiparisOzet = dizisepet[3].ToString() + " adet Peynirli Tost";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 11 * dizisepet[3];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[4] > 0)
            {
                SiparisOzet = dizisepet[4].ToString() + " adet Porsiyon Döner";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 27 * dizisepet[4];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[5] > 0)
            {
                SiparisOzet = dizisepet[5].ToString() + " adet Tavuk Döner";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 17 * dizisepet[5];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[6] > 0)
            {
                SiparisOzet = dizisepet[6].ToString() + " adet Sucuklu Tost";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 17 * dizisepet[6];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[7] > 0)
            {
                SiparisOzet = dizisepet[7].ToString() + " adet Kaşarlı Tost";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 10 * dizisepet[7];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);

            }
            if (dizisepet[8] > 0)
            {
                SiparisOzet = dizisepet[8].ToString() + " adet Sucuklu Kaşarlı";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 20 * dizisepet[8];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[9] > 0)
            {
                SiparisOzet = dizisepet[9].ToString() + " adet Ayran";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 7.99 * dizisepet[9];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[10] > 0)
            {
                SiparisOzet = dizisepet[10].ToString() + " adet Portakal Suyu";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 7.99 * dizisepet[10];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            if (dizisepet[11] > 0)
            {
                SiparisOzet = dizisepet[11].ToString() + " adet Limonata";
                listBox1.Items.Add(SiparisOzet);
                fiyat = 7.99 * dizisepet[11];
                toplamfiyat = toplamfiyat + fiyat;
                SiparisOzet = fiyat.ToString() + " ₺";
                listBox2.Items.Add(SiparisOzet);
            }
            label1.Text = "Toplam : " + toplamfiyat.ToString();
            label2.Text = MasaNO_;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
