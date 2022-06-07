using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyWatch
{
    public partial class stop : Form
    {
        Stopwatch stopwatch;
        public stop()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            stopwatch.Restart();
            stopwatch.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();    

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void TIME_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}",stopwatch.Elapsed);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            

        }
    }
}
