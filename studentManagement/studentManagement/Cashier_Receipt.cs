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
    public partial class Cashier_Receipt : Form
    {
        public Cashier_Receipt()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= C:\Users\User\Desktop\StudentManagement-C#\studentManagement\studentManagement\db\DB.mdf;Integrated Security = True");

        private void button2_Click(object sender, EventArgs e)
        {
            int V2, V3, T;
            V2 = int.Parse(texP.Text);
            V3 = int.Parse(texCf.Text);
            T = V2 - V3;
            texDb.Text = T.ToString();
        }

        private void button3_Click(object sender, EventArgs e)//save
        {
            try
            {

                int Re = int.Parse(txtRno.Text);
                String Br = texB.Text;
                int Reg = int.Parse(texReNo.Text);
                String St = texSn.Text;
                String Co = texCn.Text;
                int Ba = int.Parse(texBn.Text);
                int Cou = int.Parse(texCf.Text);
                int Pa = int.Parse(texP.Text);
                int Du = int.Parse(texDb.Text);
                String query_insert = "INSERT INTO Bill VALUES('" + Re + "','" + Br + "','" + Reg + "','" + St + "','" + Co + "','" + Ba + "','" + Cou + "','" + Pa + "','" + Du + "')";

                SqlCommand cmnd = new SqlCommand(query_insert, con);
                con.Open();
                cmnd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error whiling saving" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                int Re = int.Parse(txtRno.Text);
                String Br = texB.Text;
                int Reg = int.Parse(texReNo.Text);
                String St = texSn.Text;
                String Co = texCn.Text;
                int Ba = int.Parse(texBn.Text);
                int Cou = int.Parse(texCf.Text);
                int Pa = int.Parse(texP.Text);
                int Du = int.Parse(texDb.Text);

                string updatesql = "update Bill set Receipt_No ='" + Re + "',Branch ='" + Br + "', Register_No ='" + Reg + "',Student_Name ='" + St + "',Course_Name ='" + Co + "',Batch_No ='" + Ba + "',Course_Fee ='" + Cou + "',Payment ='" + Pa + "',Due_Balanse ='" + Du + "'";

                SqlCommand cmnd = new SqlCommand(updatesql, con);
                con.Open();
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Update Successfully !");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error while Updating" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRno.Clear();
            texB.Clear();
            texReNo.Clear();
            texSn.Clear();
            texCn.Clear();
            texBn.Clear();
            texCf.Clear();
            texP.Clear();
            texDb.Clear();
            txtPrice.Clear();
            texCNO.Clear();
            txtSRegNo.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Do you really want to Exit From The program ?", "Exit", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (Dialog == DialogResult.No)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Re = txtSRegNo.Text;

                string query_serch = "SELECT * FROM Bill WHERE Register_No= '" + Re + "'";
                SqlCommand cmnd = new SqlCommand(query_serch, con);
                con.Open();
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtRno.Text = r[0].ToString();
                    texB.Text = r[1].ToString();
                    texReNo.Text = r[2].ToString();
                    texSn.Text = r[3].ToString();
                    texCn.Text = r[4].ToString();
                    texBn.Text = r[5].ToString();
                    texCf.Text = r[6].ToString();
                    texP.Text = r[7].ToString();
                    texDb.Text = r[8].ToString();

                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error while Searching" + ex);
            }
            finally
            {
                con.Close();
            }
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
    }
}
