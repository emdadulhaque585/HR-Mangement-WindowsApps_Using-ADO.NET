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
    public partial class frmDesignationWiseEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmDesignationWiseEmployee()
        {
            InitializeComponent();
        }

        private void frmDesignationWiseEmployee_Load(object sender, EventArgs e)
        {

            LoadDesignation();
          
        } 
        private void LoadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Distinct * from tblDesignation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDesignation.DisplayMember = ds.Tables[0].Columns["designationName"].ToString();
            cmbDesignation.ValueMember = ds.Tables[0].Columns["designationId"].ToString();
            cmbDesignation.DataSource = ds.Tables[0];

            con.Close();
        }
       

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            List<spEmployeeList_Result> list = spEmployeeListResultBindingSource.DataSource as List<spEmployeeList_Result>;
            if (list !=null)
            {
                using(frmEmloyeeList frm=new frmEmloyeeList(list))
                {
                    frm.ShowDialog();
                }
            }

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (HRM_DBEntities2 db = new HRM_DBEntities2())
            {
                int ab = Convert.ToInt32(cmbDesignation.SelectedValue);
                spEmployeeListResultBindingSource.DataSource = db.spEmployeeList(ab).ToList();
            }

        }
    }
}
