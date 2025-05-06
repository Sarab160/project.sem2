using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TAQI\OneDrive\Documents\Railway.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            string query = "Select * from train";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            traingdv.DataSource = ds.Tables[0];
            con.Close();
        }


        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            string Trstatus = "";
            if (Trainname.Text == "" || traincap.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (Bussy.Checked == true)
                {
                    Trstatus = "Busy";
                }
                else if (available.Checked == true)
                {
                    Trstatus = "Available";
                }

                try
                {
                    con.Open();
                    string querry = "insert into train values('" + Trainname.Text + "','" + traincap.Text + "','" + Trstatus + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Added Successfully");
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

            Trainname.Text = "";
            traincap.Text = "";
            Bussy.Checked = false;
            available.Checked = false;
            key = 0;

        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;
        private void traingdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Trainname.Text = traingdv.SelectedRows[0].Cells[1].Value.ToString();
            traincap.Text = traingdv.SelectedRows[0].Cells[2].Value.ToString();

            if (Trainname.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(traingdv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Train To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string querry = "Delete from train where Trainid = " + key + "";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Deleted Successfully");
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
            string Trstatus = "";
            if (Trainname.Text == "" || traincap.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if (Bussy.Checked == true)
                {
                    Trstatus = "Bussy";
                }
                else if (available.Checked == true)
                {
                    Trstatus = "Available";
                }

                try
                {
                    con.Open();
                    string query = "UPDATE train SET " +
               "Trainname = '" + Trainname.Text + "', " +
               "Traincap = '" + traincap.Text + "', " +
               "Trainstatus = '" + Trstatus + "' " +
               "WHERE Trainid = '" + key + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Train Updated Successfully");
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

        private void Train_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void Bussy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void traincap_KeyPress(object sender, KeyPressEventArgs e)
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
