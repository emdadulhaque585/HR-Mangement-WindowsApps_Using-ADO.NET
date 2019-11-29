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
    
    public partial class frmCity : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmCity()
        {
            InitializeComponent();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCountry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblCity Values('"+txtCityName.Text+"','"+cmbCountry.SelectedValue+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            txtCityName.Clear();
            txtCityName.Focus();
            con.Close();
            LoadGrid();


        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tblCity", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void LoadCountry()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbCountry.DisplayMember = ds.Tables[0].Columns["countryName"].ToString();
            cmbCountry.ValueMember = ds.Tables[0].Columns["countryId"].ToString();
            cmbCountry.DataSource = ds.Tables[0];

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
