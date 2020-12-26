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
        public Form2()
        {
            InitializeComponent();
            userControl11.BringToFront();
            timer2.Start();
            selectmenu = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            panelBtn.Top = button1.Top;
            selectmenu = 1;
            kampanyacontrol = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBtn.Top = button2.Top;
            selectmenu = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
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
            if(selectmenu == 1)
            {
                if (kampanyacontrol == 1)
                    userControl11.BringToFront();
                if (kampanyacontrol == 2)
                    userControl21.BringToFront();
                if (kampanyacontrol == 3)
                {
                    userControl31.BringToFront();
                    kampanyacontrol = 0;
                }
                kampanyacontrol++;

            }
        }
    }
}
