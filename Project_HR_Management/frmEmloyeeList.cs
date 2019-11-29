using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_HR_Management
{
    public partial class frmEmloyeeList : Form
    {
        List<spEmployeeList_Result> list;
        public frmEmloyeeList(List<spEmployeeList_Result> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void frmShowEmployee_Load(object sender, EventArgs e)
        {
            EmployeeCrystalReport1.SetDataSource(list);
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
