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
    public partial class Student_Register : Form
    {
        public Student_Register()
        {
            InitializeComponent();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Student_Register_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("   Do you really want to Exit From The program ?", "Exit", MessageBoxButtons.YesNo);

            if (Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Dialog == DialogResult.No)
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Personal_Details_Registation().Show();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new Qualifications_Details_Registation().Show();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer3.Enabled = false;
                new Main_Menu().Show();
            }
        }

    }
}
