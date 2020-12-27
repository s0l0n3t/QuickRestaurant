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
    public partial class Form3 : Form
    {
        public string Masano_;
        int[] diziMenu = new int[12];
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size (818,500);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diziMenu[0]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            diziMenu[1]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diziMenu[2]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            diziMenu[3]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            diziMenu[4]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            diziMenu[5]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            diziMenu[6]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            diziMenu[7]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            diziMenu[8]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            diziMenu[9]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            diziMenu[10]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            diziMenu[11]++;
            MessageBox.Show("Siparişiniz Eklendi");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form4 formgecis = new Form4();
            formgecis.dizisepet = diziMenu;
            formgecis.MasaNO_ = Masano_;
            formgecis.Show();
            this.Hide();
        }
    }
}
