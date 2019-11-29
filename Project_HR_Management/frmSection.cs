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
namespace Project_HR_Management
{
    public partial class frmSection : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmSection()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblSection Values('" + txtSectionName.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully!!!");
            txtSectionName.Clear();
            txtSectionName.Focus();
            LoadGrid();
            con.Close();
        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblSection", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
