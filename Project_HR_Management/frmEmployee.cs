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
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=HRM_DB;Integrated Security=True");
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void LoadCountry()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblCountry", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "Select Country";
            dt.Rows.InsertAt(dr, 0);
            cmbCountry.DataSource = dt;
            cmbCountry.DisplayMember = "countryName";
            cmbCountry.ValueMember = "countryId";
            con.Close();
        }
        private void LoadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblDesignation", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbDesignation.DisplayMember = ds.Tables[0].Columns["designationName"].ToString();
            cmbDesignation.ValueMember = ds.Tables[0].Columns["designationId"].ToString();
            cmbDesignation.DataSource = ds.Tables[0];

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
        private void LoadSection()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblSection", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbSection.DisplayMember = ds.Tables[0].Columns["sectionName"].ToString();
            cmbSection.ValueMember = ds.Tables[0].Columns["sectionId"].ToString();
            cmbSection.DataSource = ds.Tables[0];

            con.Close();
        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblGender", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbGender.DisplayMember = ds.Tables[0].Columns["genderName"].ToString();
            cmbGender.ValueMember = ds.Tables[0].Columns["genderId"].ToString();
            cmbGender.DataSource = ds.Tables[0];

            con.Close();
        }
        private void LoadReligion()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblReligion", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbReligion.DisplayMember = ds.Tables[0].Columns["religionName"].ToString();
            cmbReligion.ValueMember = ds.Tables[0].Columns["religionId"].ToString();
            cmbReligion.DataSource = ds.Tables[0];

            con.Close();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadCountry();
            LoadReligion();
            LoadGender();
            LoadSection();
            LoadDepartment();
            LoadDesignation();
            LoadGrid();
            //cmbDepartment.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            //cmbCountry.SelectedIndex = -1;
            //cmbDesignation.SelectedIndex = -1;
            //cmbGender.SelectedIndex = -1;
            //cmbReligion.SelectedIndex = -1;
            //cmbSection.SelectedIndex = -1;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is required!!");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required!!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required!!");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone No is required!!");
            }
            else if (txtSalary.Text == "")
            {
                MessageBox.Show("Salary is required!!");
            }
            else if (cmbCity.Text == "")
            {
                MessageBox.Show("City is required!!");
            }
            else if (cmbCountry.Text == "")
            {
                MessageBox.Show("Country is required!!");
            }
            else if (cmbDepartment.Text == "")
            {
                MessageBox.Show("Department is required!!");
            }
            else if (cmbDesignation.Text == "")
            {
                MessageBox.Show("Designation is required!!");
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required!!");
            }
            else if (cmbReligion.Text == "")
            {
                MessageBox.Show("Religion is required!!");
            }
            else if (cmbSection.Text == "")
            {
                MessageBox.Show("Section is required!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert Into tblEmployee Values('" + txtName.Text + "','" + txtAddress.Text + "','" + dtpDOB.Value.ToString() + "'," + txtPhone.Text + ",'" + txtEmail.Text + "','" + txtSalary.Text + "','" + dtpJoiningDate.Value.ToString() + "','" + cmbDesignation.SelectedValue + "','" + cmbSection.SelectedValue + "','" + cmbDepartment.SelectedValue + "','" + cmbGender.SelectedValue + "','" + cmbReligion.SelectedValue + "','" + cmbCity.SelectedValue + "','" + cmbCountry.SelectedValue + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully!!!");
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSalary.Clear();
                cmbDepartment.SelectedIndex = -1;
                cmbCity.SelectedIndex = -1;
                //cmbCountry.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtName.Focus();
                LoadGrid();
                con.Close();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmpIdSearch.Text == "")
            {
                MessageBox.Show("PLease Select an ID");
            }
            else
            {
                con.Open();
                string str = "select e.employeeName,e.employeeAddress,e.employeeDOB,e.employeePhone,e.employeeEmail,e.employeeCurrentSalary,e.employeeJoiningDate,dg.designationId,s.sectionId,de.departmentId,g.genderId,r.religionId,ci.cityId,c.countryId from tblEmployee e  join tblCity ci on e.cityId=ci.cityId  join tblCountry c on e.countryId=c.countryId  join tblDepartment de on e.departmentId=de.departmentId join tblDesignation dg on e.designationId=dg.designationId join tblGender g on e.genderId=g.genderId  join tblReligion r on e.religionId=r.religionId  join tblSection s on e.sectionId=s.sectionId   where e.employeeId=" + txtEmpIdSearch.Text + "";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["employeeName"].ToString();
                    txtAddress.Text = dr["employeeAddress"].ToString();
                    dtpDOB.Text = dr["employeeDOB"].ToString();
                    txtPhone.Text = dr["employeePhone"].ToString();
                    txtEmail.Text = dr["employeeEmail"].ToString();
                    txtSalary.Text = dr["employeeCurrentSalary"].ToString();
                    dtpJoiningDate.Text = dr["employeeJoiningDate"].ToString();
                    cmbDesignation.SelectedValue = dr["designationId"].ToString();
                    cmbSection.SelectedValue = dr["sectionId"].ToString();
                    cmbDepartment.SelectedValue = dr["departmentId"].ToString();
                    cmbGender.SelectedValue = dr["genderId"].ToString();
                    cmbReligion.SelectedValue = dr["religionId"].ToString();
                    //cmbCity.SelectedValue = dr["cityId"].ToString();
                    //cmbCountry.SelectedValue = dr["countryId"].ToString();
                }
                else
                {
                    MessageBox.Show("Data Not Found!!");
                }
            }
            con.Close();
            cmbCity.SelectedIndex = -1;
            LoadCountry();



        }
        private void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand(" select e.employeeId,e.employeeName,e.employeeAddress,e.employeeDOB,e.employeePhone,e.employeeEmail,e.employeeCurrentSalary,e.employeeJoiningDate,dg.designationName,s.sectionName,de.departmentName,g.genderName,r.religionName,ci.cityName,c.countryName from tblEmployee e  join tblCity ci on e.cityId=ci.cityId  join tblCountry c on e.countryId=c.countryId  join tblDepartment de on e.departmentId=de.departmentId join tblDesignation dg on e.designationId=dg.designationId join tblGender g on e.genderId=g.genderId  join tblReligion r on e.religionId=r.religionId  join tblSection s on e.sectionId=s.sectionId", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is required!!");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address is required!!");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email is required!!");
            }
            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Phone No is required!!");
            }
            else if (txtSalary.Text == "")
            {
                MessageBox.Show("Salary is required!!");
            }
            else if (cmbCity.Text == "")
            {
                MessageBox.Show("City is required!!");
            }
            else if (cmbCountry.Text == "")
            {
                MessageBox.Show("Country is required!!");
            }
            else if (cmbDepartment.Text == "")
            {
                MessageBox.Show("Department is required!!");
            }
            else if (cmbDesignation.Text == "")
            {
                MessageBox.Show("Designation is required!!");
            }
            else if (cmbGender.Text == "")
            {
                MessageBox.Show("Gender is required!!");
            }
            else if (cmbReligion.Text == "")
            {
                MessageBox.Show("Religion is required!!");
            }
            else if (cmbSection.Text == "")
            {
                MessageBox.Show("Section is required!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Update tblEmployee set employeeName='" + txtName.Text + "',employeeAddress='" + txtAddress.Text + "',employeeDOB='" + dtpDOB.Value + "',employeePhone='" + txtPhone.Text + "',employeeEmail='" + txtEmail.Text + "',employeeCurrentSalary= " + txtSalary.Text + ",employeeJoiningDate='" + dtpJoiningDate.Value + "',designationId=" + cmbDesignation.SelectedValue + ",sectionId=" + cmbSection.SelectedValue + ",departmentId=" + cmbDepartment.SelectedValue + ",genderId=" + cmbGender.SelectedValue + ",religionId=" + cmbReligion.SelectedValue + ",cityId=" + cmbCity.SelectedValue + ",countryId=" + cmbCountry.SelectedValue + " where employeeId=" + txtEmpIdSearch.Text + "";

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully!!!");
                txtName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtSalary.Clear();
                txtEmpIdSearch.Clear();
                //cmbDepartment.SelectedIndex = -1;
                cmbCity.SelectedIndex = -1;
                //cmbCountry.SelectedIndex = -1;
                cmbDesignation.SelectedIndex = -1;
                cmbGender.SelectedIndex = -1;
                cmbReligion.SelectedIndex = -1;
                cmbSection.SelectedIndex = -1;
                txtName.Focus();
                LoadGrid();
                con.Close();
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Delete from tblEmployee where employeeId=" + txtEmpIdSearch.Text + "";

            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully!!!");
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtSalary.Clear();
            txtEmpIdSearch.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            //cmbCountry.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbReligion.SelectedIndex = -1;
            cmbSection.SelectedIndex = -1;
            txtName.Focus();
            LoadGrid();
            con.Close();
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter(" Select * from tblCity where countryId=" + cmbCountry.SelectedValue + "", con);
            DataSet ds = new DataSet();

            sda.Fill(ds);

            cmbCity.DisplayMember = ds.Tables[0].Columns["cityName"].ToString();
            cmbCity.ValueMember = ds.Tables[0].Columns["cityId"].ToString();
            cmbCity.DataSource = ds.Tables[0];

            con.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsLetter(ab) == true || ab == 8 || ab == 32 || ab == 45 || ab == 46)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Text like space, text, notation sign are allowed!!");
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsDigit(ab) == true || ab == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Number Allowed!!");
                e.Handled = true;
            }
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ab = e.KeyChar;
            if (char.IsDigit(ab) == true || ab == 8 || ab == 46)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Only Numeric No is allowed!!");
                e.Handled = true;
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Fill up Name Field!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT e.EmployeeId AS ID, e.employeeName, d.departmentName, dg.designationName, e.employeeJoiningDate AS [Joining Date], CAST(e.employeeCurrentSalary AS NUMERIC(10,2)) AS Salary, e.employeeEmail, e.employeePhone [Mobile No.], e.employeeDOB AS [Date Of Birth]  FROM tblEmployee e INNER JOIN tblCountry co ON e.CountryId = co.CountryId INNER JOIN tblCity ci ON e.CityId = ci.CityId INNER JOIN tblDepartment d ON e.DepartmentId = d.DepartmentId INNER JOIN tblDesignation dg ON e.DesignationId = dg.DesignationId INNER JOIN tblSection s ON e.SectionId = s.SectionId WHERE e.employeeName LIKE '%" + txtName.Text + "%'", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Employee found");
                }
                con.Close();
            }
        }
    }
}
