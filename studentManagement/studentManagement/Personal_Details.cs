using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagement
{
    public partial class Personal_Details : Form
    {
        public Personal_Details()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= C:\Users\User\Desktop\StudentManagement-C#\studentManagement\studentManagement\db\DB.mdf;Integrated Security = True");

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String Re = txtSRegNo.Text;

                string deletesql = "delete FROM Personal_Details WHERE Register_No= '" + Re + "'";
                SqlCommand cmnd = new SqlCommand(deletesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error whiling Delete" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Re = txtSRegNo.Text;

            string query_serch = "SELECT * FROM personal_Details WHERE Register_No = '" + Re + "'";
            SqlCommand cmnd = new SqlCommand(query_serch, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from personal_Details  ", con);

            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void Personal_Details_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
            this.MaximizeBox = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer1.Enabled = false;
                new Main_Menu().Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.10;
            if (this.Opacity <= 0)
            {
                this.Visible = false;
                timer2.Enabled = false;
                new Student_Details().Show();
            }
        }
    }
}
