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
    public partial class frmReligion : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmReligion()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblReligion Values('" + txtReligionName.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully!!!");
            txtReligionName.Clear();
            txtReligionName.Focus();
            LoadGrid();
            con.Close();
            
        }

        private void frmReligion_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblReligion", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
