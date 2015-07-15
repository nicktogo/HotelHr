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
            employeePerform.DataSource = helper.showEmployeePerform();
            employeePerform.Columns[1].ReadOnly = true;
            employeePerform.Columns[4].Visible = false;
        }

        //Page Control
        //show employee info
        private void employPerform_Selecting(object sender, TabControlCancelEventArgs e)
        {
            employeeJobTitle.DataSource = helper.showEmployeeJobTitle();
            employeeJobTitle.Columns[0].ReadOnly = true;
            employeeJobTitle.Columns[1].ReadOnly = true;

            employeeSalary.DataSource = helper.showEmployeeSalary();
            employeeSalary.Columns[0].ReadOnly = true;
            employeeSalary.Columns[1].ReadOnly = true;

            employeeInfo.DataSource = helper.showEmployeeInfo();
            employeeInfo.Columns[0].ReadOnly = true;
            
        }

        //EmployeePerform Page
        //employeePerform update
        private void employeePerform_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (employeePerform.Rows.Count > 0)
            {
                int pos = e.ColumnIndex;

                if (e.ColumnIndex == 0 || e.ColumnIndex == 2)
                {
                    helper.updateEmployeePerform(pos, this.employeePerform.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                        int.Parse(this.employeePerform.Rows[e.RowIndex].Cells[4].Value.ToString()));
                }
                else if (e.ColumnIndex == 3)
                {
                    helper.updateEmployeePerform(pos, int.Parse(this.employeePerform.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()),
                       int.Parse(this.employeePerform.Rows[e.RowIndex].Cells[4].Value.ToString()));
                }

                else
                {

                }
                employeePerform.DataSource = helper.showEmployeePerform();
            }
        }

        //submit a new employee perform
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

                    //highlight and top the inserted record 
                    //refresh datasource
                    employeePerform.DataSource = helper.showEmployeePerform();

                    //get the behavior_id of the newest record
                    decimal behaviorid = helper.getBehaviorId();

                    //get the index of the newest record in DataGridView (using linq)
                    int index = -1;
                    DataGridViewRow row = employeePerform.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => decimal.Parse(r.Cells[4].Value.ToString()) == behaviorid)
                        .First();
                    index = row.Index;

                    //set it to the first one
                    employeePerform.FirstDisplayedScrollingRowIndex = index;

                    //highlight
                    employeePerform.ClearSelection();
                    employeePerform.Rows[index].Selected = true;


                    //
                    //foreach (DataGridViewRow row in employeePerform.Rows)
                    //{
                    //    string value = row.Cells[4].Value.ToString();
                    //    decimal valueDecimal = decimal.Parse(value);

                    //    if (valueDecimal == behaviorid)
                    //    {
                    //        employeePerform.FirstDisplayedScrollingRowIndex = row.Index;
                    //    }
                    //}

                }
            }
            else
            {

            }
        }



        //JobTitle Page
        //
        private void showAll_Click(object sender, EventArgs e)
        {
            employeeJobTitle.DataSource = helper.showEmployeeJobTitle();
        }

        //submitButton2_Click
        private void submitButton2_Click(object sender, EventArgs e)
        {
            employeeJobTitle.DataSource = helper.searchJobTitle(employeeIdBox2.Text);
        }

        //employeeJobTitle update
        private void employeeJobTitle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeJobTitle.Rows.Count > 0)
            {
                helper.updateEmployeeJobTitle(this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[2].Value.ToString());   
            }
        }


        //Salary Page
        //
        private void showAll2_Click(object sender, EventArgs e)
        {
            employeeSalary.DataSource = helper.showEmployeeSalary();
        }
        //submitButton3_Click
        private void submitButton3_Click(object sender, EventArgs e)
        {
            employeeSalary.DataSource = helper.searchSalary(employeeIdBox3.Text);
        }

        //employeeSalary update
        private void employeeSalary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeSalary.Rows.Count > 0)
            {
                helper.updateEmployeeSalary(this.employeeSalary.Rows[e.RowIndex].Cells[0].Value.ToString(), int.Parse(this.employeeSalary.Rows[e.RowIndex].Cells[2].Value.ToString()));
            }
        }

        //employeeInfo Page
        //update
        private void employeeInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            var result = MessageBox.Show("Sure to submit?", "",MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                if (employeeInfo.Rows.Count > 0)
                {
                    switch (e.ColumnIndex)
                    {
                        case 1: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[1].Value.ToString()); break;
                        case 2: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[2].Value.ToString()); break;
                        case 3: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[3].Value.ToString()); break;
                        case 4: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[4].Value.ToString()); break;
                        case 5: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[5].Value.ToString()); break;
                        case 6: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), int.Parse(this.employeeInfo.Rows[e.RowIndex].Cells[6].Value.ToString())); break;
                        case 7: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[7].Value.ToString()); break;
                        case 8: helper.updateEmployeeInfo(e.ColumnIndex, this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeInfo.Rows[e.RowIndex].Cells[8].Value.ToString()); break;
                    }
                }
                employeeInfo.DataSource = helper.showEmployeeInfo();
            }
            else
            {
                employeeInfo.DataSource = helper.showEmployeeInfo();
            }
        }
        //delete
        private void btn_infoDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                if (helper.deleteEmployeeInfo(tb_infoEMPLOY_ID2.Text))
                {
                    MessageBox.Show("Success!");
                    tb_infoEMPLOY_ID2.Text = "";
                    employeeInfo.DataSource = helper.showEmployeeInfo();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }
        //new
        private void btn_newInfo_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);


            //confirm to submit
            if (result == DialogResult.Yes)
            {
                DataTable allEmployeeId = helper.getAllEmployeeId();
                for (int i = 0; i < allEmployeeId.Rows.Count; i++)
                {
                    if (tb_infoEMPLOY_ID.Text.Equals(allEmployeeId.Rows[i][0].ToString()))
                    {
                        isExist = true;
                    }
                }

                if (!isExist && helper.insertEmployeeInfo(tb_infoEMPLOY_ID.Text, tb_infoEMPLOY_NAME.Text, tb_infoGENDER.Text, tb_infoADDRESS.Text,
                    tb_infoCITIZEN_ID.Text, tb_infoIN_DATE.Text, int.Parse(tb_infoWORK_YEAR.Text), tb_infoSTATUS.Text, tb_infoPASSWORD.Text))
                {
                    MessageBox.Show("Success!");
                    tb_infoEMPLOY_ID.Text = "";
                    tb_infoEMPLOY_NAME.Text = "";
                    tb_infoGENDER.Text = "";
                    tb_infoADDRESS.Text = "";
                    tb_infoCITIZEN_ID.Text = "";
                    tb_infoIN_DATE.Text = "";
                    tb_infoWORK_YEAR.Text = "";
                    tb_infoSTATUS.Text = "";
                    tb_infoPASSWORD.Text = "";
                    employeeInfo.DataSource = helper.showEmployeeInfo();
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }
        //private void submitButton_Click(object sender, EventArgs e)
        //{

        //    var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);

        //    //confirm to submit
        //    if (result == DialogResult.Yes)
        //    {
        //        if (helper.insertEmployeePerform(employeeIdBox.Text, reasonBox.Text, type))
        //        {
        //            MessageBox.Show("Success!");
        //            employeeIdBox.Text = "";
        //            reasonBox.Text = "";
        //            nagetiveRadio.Checked = false;
        //            positiveRadio.Checked = false;

        //            //highlight and top the inserted record 

        //            //refresh datasource
        //            employeePerform.DataSource = helper.showEmployeePerform();

        //            //get the index of 

        //        }
        //    }
        //    else
        //    {

        //    }
        //}
        //employeeInfo insert
        //private void employeeInfo_AllowUserToAddRowsChanged(object sender, EventArgs e)
        //{
        //    MessageBox.Show("failed");
        //    if (!helper.isEmployeeIdExist(this.employeeInfo.Rows[((DataGridViewCellEventArgs)e).RowIndex].Cells[0].Value.ToString()))
        //    //if (!helper.isEmployeeIdExist(this.employeeInfo.Columns)
        //    {
                
        //    }
        //    else
        //    { 
        //        MessageBox.Show("failed");
        //    }
            
        //}
        //private void employeeInfo_RowLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    if(this.employeeInfo.RowCount - 1 == e.RowIndex)
        //    {
        //        if (!helper.isEmployeeIdExist(this.employeeInfo.Rows[e.RowIndex].Cells[0].Value.ToString()))
        //        {

        //        }
        //        else
        //        {
        //            MessageBox.Show("failed");
        //        }
        //    }
            

        //}

        #region empty methods

        private void employPerform_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void employeeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void jobTitleMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region methods to be executed when tab-button MouseDown event occur
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoButton.FlatAppearance.BorderSize = 0;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.performButton.FlatAppearance.BorderSize = 1;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.jobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.jobButton.FlatAppearance.BorderSize = 1;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.salaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.salaryButton.FlatAppearance.BorderSize = 1;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 3;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.performButton.FlatAppearance.BorderSize = 0;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.infoButton.FlatAppearance.BorderSize = 1;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.jobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.jobButton.FlatAppearance.BorderSize = 1;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.salaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.salaryButton.FlatAppearance.BorderSize = 1;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 0;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.jobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jobButton.FlatAppearance.BorderSize = 0;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.performButton.FlatAppearance.BorderSize = 1;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.infoButton.FlatAppearance.BorderSize = 1;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.salaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.salaryButton.FlatAppearance.BorderSize = 1;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 1;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.salaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salaryButton.FlatAppearance.BorderSize = 0;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.performButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.performButton.FlatAppearance.BorderSize = 1;
            this.performButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.jobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.jobButton.FlatAppearance.BorderSize = 1;
            this.jobButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.infoButton.FlatAppearance.BorderSize = 1;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 2;
        }
        #endregion

    }
}
