using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project
{
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
            Populate();
            fillticketid();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TAQI\OneDrive\Documents\Railway.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            string query = "Select * from cancel";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            cagdv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillticketid()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select Ticketid from reservation", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ticketid", typeof(int));
            dt.Load(rdr);
            Ticid.ValueMember = "Ticketid";
            Ticid.DataSource = dt;
            con.Close();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            if (Ticid.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {


                try
                {
                    con.Open();
                    string querry = "insert into cancel values(" + Ticid.SelectedValue.ToString() + ",'" + DateTime.Today.Date + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled");
                    con.Close();
                    Populate();
                    remove();
                    fillticketid();
                    Ticid.SelectedIndex = -1;

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }
        }
        private void remove()
        {


            try
            {
                con.Open();
                string querry = "Delete from reservation where Ticketid = " + Ticid.SelectedValue.ToString() + "";
                SqlCommand cmd = new SqlCommand(querry, con);
                cmd.ExecuteNonQuery();

                con.Close();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
      
        }
    
}
