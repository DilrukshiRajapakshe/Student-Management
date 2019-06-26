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
    public partial class Administrator_Login : Form
    {
        public Administrator_Login()
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
                new Administrator_Main_Menu().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Na = "Bright";
            String Pa = "12345";
            {
                {
                    if (txtNa.Text == Na && txtPa.Text == Pa)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("             Wrong Username or Password !    ");
                        txtNa.Clear();
                        txtPa.Clear();
                        txtNa.Focus();
                    }
                }
            }
        }
    }
}
