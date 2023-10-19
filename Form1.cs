using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Voice_Recorder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetrno, int MciRetrnoLeng, int CallBack);
        string record = " ";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bRecord_Click(object sender, EventArgs e)
        {
            mciSendString("open new type waveaudio alias Som", null, 0, 0);
            mciSendString("record Som", null, 0, 0);
            lRec.Text = "Recording...";
            lRec.ForeColor = System.Drawing.Color.Red;
            timer1.Start();
            Count_Down.Start();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            mciSendString("pause Som", null, 0, 0);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MP3|*.mp3";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                mciSendString("save Som" + sfd.FileName, null, 0, 0);
                mciSendString("close Som", null, 0, 0);
            }
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (record == "")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MP3|*mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    record = ofd.FileName;
                }
            }
            mciSendString("play" + record, null, 0, 0);
            lRec.Text = "Playing...";
        }
        System.Diagnostics.Stopwatch Count_Down = new System.Diagnostics.Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = Count_Down.Elapsed;
            lTimer.Text = "Duration : " + string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds);
        }
    }
}
