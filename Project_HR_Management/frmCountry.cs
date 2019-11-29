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

namespace Project_HR_Management
{
    public partial class frmCountry : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");

        public frmCountry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblCountry Values('" + txtCountry.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            lblMsgShow.Text = "Data Inserted Successfully";
            txtCountry.Clear();
            txtCountry.Focus();
            LoadGrid();
            con.Close();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblCountry", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
