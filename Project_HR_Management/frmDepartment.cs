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
    public partial class frmDepartment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void btnDepInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into tblDepartment Values('"+txtDepName.Text+"')";
            cmd.ExecuteNonQuery();
            lblMsgShow.Text="Data Insert Successfully";
            txtDepName.Clear();
            txtDepName.Focus();
            LoadGrid();
            con.Close();
           
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblDepartment", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
