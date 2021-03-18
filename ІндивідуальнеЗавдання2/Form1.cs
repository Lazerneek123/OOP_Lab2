using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ІндивідуальнеЗавдання2
{
    delegate void MyDelegate(object sender, MouseEventArgs e);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Opacit_y_MouseClick(object sender, MouseEventArgs e)
        {
            if (Opacity == 1D)
            {
                Opacity = 0.5D;
            }
            else
            {
                Opacity = 1D;
            }
            
        }

        private void ColorFon_MouseClick(object sender, MouseEventArgs e)
        {
            if (BackColor == SystemColors.ControlLight)
            {
                BackColor = Color.Lime;
            }
            else
            {
                BackColor = SystemColors.ControlLight;
            }

        }

        private void HelloWorld_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void SuperMegaButton_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SuperMegaButton.MouseClick += new MouseEventHandler(Opacit_y_MouseClick);
            }

            else
            {
                SuperMegaButton.MouseClick -= new MouseEventHandler(Opacit_y_MouseClick);
            }
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SuperMegaButton.MouseClick += new MouseEventHandler(ColorFon_MouseClick);
            }

            else
            {
                SuperMegaButton.MouseClick -= new MouseEventHandler(ColorFon_MouseClick);
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SuperMegaButton.MouseClick += new MouseEventHandler(HelloWorld_MouseClick);
            }

            else
            {
                SuperMegaButton.MouseClick -= new MouseEventHandler(HelloWorld_MouseClick);
            }

        }
    }
}
