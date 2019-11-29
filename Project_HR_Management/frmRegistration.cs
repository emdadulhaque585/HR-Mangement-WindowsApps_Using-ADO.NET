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
    public partial class frmRegistration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert Into tblUser Values('"+txtName.Text+"','"+txtEmail.Text+"','"+txtpassword.Text+"','"+txtContact.Text+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("You are succesfully registered.!!!");
            con.Close();
            txtName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtpassword.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
