using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Завдання_2F
{
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

        private Button[,] buttons = new Button[3, 3];

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = timer.QuantitySeconds();
            timer1.Start();           
        }

        private Timer timer = new Timer(1000);   // кількість мсек
        private int k = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {  
            k += 60;
            Button buttons = new Button();
            buttons.Location = new Point(k, k);
            buttons.Size = new Size(60, 60);
            buttons.FlatStyle = FlatStyle.Flat;            
            buttons.Name = "button";
            Controls.Add(buttons);

            if (k == 420)
            {
                timer1.Stop();
            }
        }
    }

    public delegate int Seconds();        

    class Timer
    {        
        private int seconds { get; set; }
        
        public Timer() { }

        public Timer(int seconds)
        {            
            this.seconds = seconds;            
        }       
                
        public int Second_s()
        {           
            return seconds;
        }

        public int QuantitySeconds()
        {
            Seconds quantitySeconds = Second_s;
            return quantitySeconds.Invoke();
        }        

    }
}
