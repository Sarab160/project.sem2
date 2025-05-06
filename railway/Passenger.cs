using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace project
{
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TAQI\OneDrive\Documents\Railway.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            string query = "Select * from Passenger";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            pgdv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (pname.Text == "" || phone.Text == "" || padd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (male.Checked == true)
                {
                    gender = "Male";
                }
                else if (female.Checked == true)
                {
                    gender = "Female";
                }

                try
                {
                    con.Open();
                    string querry = "insert into Passenger values('" + pname.Text + "','" + padd.Text + "','" + gender + "','" + nat.SelectedItem.ToString() + "','" + phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Added Successfully");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }

        }


        private void Reset()
        {

            pname.Text = "";
            padd.Text = "";
            phone.Text = "";
            male.Checked = false;
            female.Checked = false;
            nat.SelectedIndex = -1;
            key = 0;
        }
        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void traingdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            pname.Text = pgdv.SelectedRows[0].Cells[1].Value.ToString();
            padd.Text = pgdv.SelectedRows[0].Cells[2].Value.ToString();
            nat.SelectedItem = pgdv.SelectedRows[0].Cells[4].Value.ToString();
            phone.Text = pgdv.SelectedRows[0].Cells[5].Value.ToString();

            if (pname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(pgdv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void guna2TileButton3_Click(object sender, EventArgs e)
        {

            if (key == 0)
            {
                MessageBox.Show("Select The Passenger To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string querry = "Delete from Passenger where passengerid = " + key + "";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (pname.Text == "" || phone.Text == "" || padd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (male.Checked == true)
                {
                    gender = "Male";
                }
                else if (female.Checked == true)
                {
                    gender = "Female";
                }

                try
                {
                    con.Open();
                    string query = "UPDATE passenger SET " +
               "passengername = '" + pname.Text + "', " +
               "passengeraddress = '" + padd.Text + "', " +
               "passengergender = '" + gender + "', " +
               "passengernat = '" + nat.SelectedItem.ToString() + "', " +
               "passengerphone = '" + phone.Text + "' " +
               "WHERE passengerid = '" + key + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    con.Close();
                    Populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Passenger_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
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
