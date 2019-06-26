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
    public partial class Reenter_Password : Form
    {
        public Reenter_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Pa = "12345";
            {
                {
                    if (txtPa.Text == Pa)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("             Wrong Username or Password !    ");

                        txtPa.Clear();
                        txtPa.Focus();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Student_Details().Show();
            }
        }

        private void Reenter_Password_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }
    }
}
