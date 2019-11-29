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
    public partial class frmDesignation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmDesignation()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into tblDesignation values('"+txtDesigName.Text+"',"+cmbDepartment.SelectedValue+")";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully!!!");
            txtDesigName.Clear();
            txtDesigName.Focus();
            LoadGrid();
            con.Close();
          
            


        }

        private void frmDesignation_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadDepartment();
        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblDesignation", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void LoadDepartment()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblDepartment", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDepartment.DisplayMember = ds.Tables[0].Columns["departmentName"].ToString();
            cmbDepartment.ValueMember = ds.Tables[0].Columns["departmentId"].ToString();
            cmbDepartment.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
