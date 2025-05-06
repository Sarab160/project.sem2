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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            Populate();
            fillpid();
            filltc();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TAQI\OneDrive\Documents\Railway.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            con.Open();
            string query = "Select * from reservation";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            reserdv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void fillpid()
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select passengerid from Passenger", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("passengerid", typeof(int));
            dt.Load(rdr);
            pid.ValueMember = "passengerid";
            pid.DataSource = dt;
            con.Close();
        }
        private void filltc()
        {
            string status = "Busy";
            con.Open();
            SqlCommand cmd = new SqlCommand("select travelcode from travel", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("travelcode", typeof(int));
            dt.Load(rdr);
            travco.ValueMember = "travelcode";
            travco.DataSource = dt;
            con.Close();
        }
        string pname;
        private void getpname()
        {
            con.Open();
            string mysql = "Select * from Passenger where passengerid=" + pid.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pname = dr["passengername"].ToString();
            }
            con.Close();
        }
        string date, src, dest;
        int cost;
        private void gettravel()
        {
            con.Open();
            string mysql = "Select * from travel where travelcode=" + travco.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                // pname = dr["passengername"].ToString();
                date = dr["traveldate"].ToString();
                src = dr["source"].ToString();
                dest = dr["destination"].ToString();
                cost = Convert.ToInt32(dr["travelcost"].ToString());
            }
            con.Close();
            // MessageBox.Show(date + src + dest + cost);

        }
        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void pid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getpname();
        }

        private void travco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gettravel();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (travco.SelectedIndex == -1 || pid.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {


                try
                {
                    con.Open();
                    string querry = "insert into reservation values('" + pid.SelectedValue.ToString() + "','" + pname + "','" + travco.SelectedValue.ToString() + "','" + date + "','" + src + "','" + dest + "','" + cost + "')";
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reservation Accepted");
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

        private void reset_Click(object sender, EventArgs e)
        {
            Mainform Main = new Mainform();
            Main.Show();
            this.Hide();
        }

        private void reserdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
