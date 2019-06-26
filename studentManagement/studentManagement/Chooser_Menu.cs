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
    public partial class Chooser_Menu : Form
    {
        public Chooser_Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Administrator_Login().Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new User_Loging().Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void adminbutton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void Chooser_Menu_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }

    }
}
