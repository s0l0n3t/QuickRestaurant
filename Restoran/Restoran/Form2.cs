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
    public partial class Form2 : Form
    {
        int selectmenu = 0;
        int kampanyacontrol = 2;
        int hangimasa = 0;
        public Form2()
        {
            InitializeComponent();
            timer2.Start();
            selectmenu = 1;
            pnlKkampanya1.Show();
            pnlKampanya2.Hide();
            pnlMasaSec.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlKkampanya1.Show();
            pnlKampanya2.Hide();
            pnlMasaSec.Hide();
            panelBtn.Top = button1.Top;
            selectmenu = 1;
            kampanyacontrol = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlKkampanya1.Hide();
            pnlKampanya2.Hide();
            pnlMasaSec.Show();
            panelBtn.Top = button2.Top;
            selectmenu = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Yeni_form3 = new Form3();
            Yeni_form3.Show();
            //formgecis.Show();

            panelBtn.Top = button4.Top;
            selectmenu = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelBtn.Top = button3.Top;
            selectmenu = 4;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(selectmenu==1)
            {
                kampanyacontrol++;
                if(kampanyacontrol%2==1)
                {
                    pnlKkampanya1.Hide();
                    pnlKampanya2.Show();
                }
                else
                {
                    pnlKkampanya1.Show();
                    pnlKampanya2.Hide();
                }

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // kampanya 1 button
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // kampanya 2 button
        }

        private void pbMasa2_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 2;
            formgecis.Show();
        }

        private void pbMasa6_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 6;
            formgecis.Show();
        }

        private void pbMasa5_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 5;
            formgecis.Show();
        }

        private void pbMasa4_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 4;
            formgecis.Show();
        }

        private void pbMasa1_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 1;
            formgecis.Show();
        }

        private void pbMasa3_Click(object sender, EventArgs e)
        {
            Form3 formgecis = new Form3();
            hangimasa = 3;
            formgecis.Show();
        }
    }
}
