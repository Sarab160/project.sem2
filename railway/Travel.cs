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

namespace project
{
    public partial class Travel : Form
    {
        public Travel()
        {
            InitializeComponent();
            Populate();
            fillcode();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TAQI\OneDrive\Documents\Railway.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            string query = "Select * from travel";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            traveldv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillcode()
        {
            string status = "Available";
            con.Open();
            SqlCommand cmd = new SqlCommand("select Trainid from train where Trainstatus='" + status + "'", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Trainid", typeof(int));
            dt.Load(rdr);
            traincode.ValueMember = "trainid";
            traincode.DataSource = dt;
            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void changestatus()
        {
            string Trstatus = "Bussy";

            try
            {
                con.Open();
                string querry = "update train set Trainstatus='" + Trstatus + "'where Trainid= " + traincode.SelectedValue.ToString() + ";";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();
                //  MessageBox.Show("Train Updated Successfully");
                con.Close();
                Populate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (travelcost.Text == "" || traincode.SelectedIndex == -1 || source.SelectedIndex == -1 || destination.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    string querry = "insert into travel values('" + date.Value + "','" + traincode.SelectedValue.ToString() + "','" + source.SelectedItem.ToString() + "','" + destination.SelectedItem.ToString() + "','" + travelcost.Text + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Travel Added Successfully");
                    con.Close();
                    Populate();
                    changestatus();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
        private void Reset()
        {
            source.SelectedIndex = -1;
            destination.SelectedIndex = -1;
            // traincode.SelectedIndex = -1;
            travelcost.Text = "";
        }
        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int key = 0;
        private void traveldv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            date.Text = traveldv.SelectedRows[0].Cells[1].Value.ToString();
            traincode.Text = traveldv.SelectedRows[0].Cells[2].Value.ToString();
            source.SelectedItem = traveldv.SelectedRows[0].Cells[3].Value.ToString();
            destination.SelectedItem = traveldv.SelectedRows[0].Cells[4].Value.ToString();
            travelcost.Text = traveldv.SelectedRows[0].Cells[5].Value.ToString();


            if (traincode.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(traveldv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {

            if (travelcost.Text == "" || source.SelectedIndex == -1 || destination.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                try
                {
                    con.Open();
                    string query = "UPDATE travel SET " +
                "traveldate = '" + date.Text + "', " +
                "travelcost = '" + travelcost.Text + "', " +
                "source = '" + source.SelectedItem.ToString() + "', " +
                "destination = '" + destination.SelectedItem.ToString() + "', " +
                "traincode = '" + traincode.SelectedValue.ToString() + "' " +
                "WHERE travelcode = '" + key + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Travel Updated Successfully");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void Travel_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void traincode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void travelcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
