using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleForms
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer Timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Start();
            label1.Text = "Zzzzzz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Elapsed;
        }

        private void Elapsed(object sender, EventArgs e)
        {
            DateTime actual = DateTime.Now;
            DateTime alarma = dateTimePicker1.Value;
            if(actual.Hour == alarma.Hour && actual.Minute == alarma.Minute && actual.Second == alarma.Second)
            {
                Timer.Stop();
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"C:\Windows\Media\Alarm01.wav";
                player.PlayLooping();
                var result = MessageBox.Show("DESPIERTA!!!!");
                if(result == DialogResult.OK)
                {
                    player.Stop();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            label1.Text = "Alarma detenida";
        }
    }
}
