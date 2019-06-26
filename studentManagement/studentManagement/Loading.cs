using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace studentManagement
{
    public partial class Loading : Form
    {
        
        bool flag;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Loading()
        {
            InitializeComponent();
            player.URL = "audio/hr.mp3";
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            flag = true;
            timer1.Enabled = true;
            player.controls.play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 99)
            {
                if (flag)
                {
                    flag = false;
                    lblLoading.Text = "Loading..";
                }
                else
                {
                    flag = true;
                    lblLoading.Text = "Loading...";
                }

                progressBar1.Value += 10;
                if (progressBar1.Value > 90)
                {
                    timer2.Enabled = true;
                    timer2.Start();
                }
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.025;

            if (this.Opacity <= 0)
            {
                timer2.Enabled = false;
                this.Visible = false;
                new Chooser_Menu().Show();
            }

        }
    }
}
