using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

using OracleDBHelper;

namespace HotelHR
{
    public partial class HrManage : Form
    {
        private OracleHelper helper;

        public HrManage()
        {
            InitializeComponent();
            helper = new OracleHelper();
        }

        //submit a employee perform
        private void submitButton_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Sure to submit?", "",MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                int type = 0;
                if (positiveRadio.Checked)
                {
                    type = 1;
                }
                else if (nagetiveRadio.Checked)
                {
                    type = -1;
                }

                if (helper.insertEmployeePerform(employeeIdBox.Text, reasonBox.Text, type))
                {
                    MessageBox.Show("Success!");
                    employeeIdBox.Text = "";
                    reasonBox.Text = "";
                    nagetiveRadio.Checked = false;
                    positiveRadio.Checked = false;
                }
            }
            else
            {

            }


        }

        //show employee info
        private void employPerform_Selecting(object sender, TabControlCancelEventArgs e)
        {
            employeeInfo.DataSource = helper.showEmployeePerform();

            employeeJobTitle.DataSource = helper.showEmployeeJobTitle();
            employeeJobTitle.Columns[0].ReadOnly = true;
            employeeJobTitle.Columns[1].ReadOnly = true;

            employeeSalary.DataSource = helper.showEmployeeSalary();
            this.employeeSalary.Columns[0].ReadOnly = true;
            this.employeeSalary.Columns[1].ReadOnly = true;
        }

        private void employeeJobTitle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeJobTitle.Rows.Count > 0)
            {
                helper.UpdateEmployeeJobTitle(this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[2].Value.ToString());   
            }
        }






        private void promoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employPerform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //-K salary
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        

       
        
        //K-
    }
}
