using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace timerMinutesPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stopwatch = new System.Diagnostics.Stopwatch();
            label5.Text = "00:00:00.00";
            label5.ForeColor = Color.LightGray;
            
        }

        private void start_Click(object sender, EventArgs e)
        {
            miliseconds.Start();
            stopwatch.Start();
            label5.ForeColor = Color.FromArgb(80, 171, 47); 
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                label5.ForeColor = Color.FromArgb(185, 62, 62);
            }
            
        }

        private void miliseconds_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            label5.Text=elapsedTime.ToString();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            label5.ForeColor = Color.LightGray;
        }
    }
}
