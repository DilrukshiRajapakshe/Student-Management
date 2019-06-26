using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagement
{
    public partial class Administrator_Main_Menu : Form
    {
        public Administrator_Main_Menu()
        {
            InitializeComponent();
        }
        private void educationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            timer4.Start();
        }

        private void cashierReceipitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void studentRagistationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
            timer6.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            timer5.Enabled = true;
            timer5.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Cashier_Receipt().Show();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new Student_Register().Show();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer3.Enabled = false;
                new Education_Details_Register().Show();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer4.Enabled = false;
                new Reenter_Password().Show();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer5.Enabled = false;
                new About().Show();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer6.Enabled = false;
                new Help().Show();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer7.Enabled = false;
                new Chooser_Menu().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer7.Enabled = true;
            timer7.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("         Do you really want to Exit From The program ?", "Exit", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Dialog == DialogResult.No)
            {
            }
        }

        private void Administrator_Main_Menu_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }
    }
}
