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

            employeeHRSwitch.DataSource = helper.showEmployeeSalary();
            employeeHRSwitch.Columns[0].ReadOnly = true;
            employeeHRSwitch.Columns[1].ReadOnly = true;

            employeeInfo.DataSource = helper.showEmployeeInfo();
            employeeInfo.Columns[0].ReadOnly = true;
            
        }

        //EmployeePerform Page
        private void btn_performSubmit_Click(object sender, EventArgs e)
        {
            //DataTable perform = helper.getPerformByEmployId(tb_performEmployId.Text);
            int favourableReviewCount = helper.getFavourableReviewCountByEmployId(tb_performEmployId.Text);
            int negetiveReviewCount = helper.getNegativeReviewCountByEmployId(tb_performEmployId.Text);
            l_performFavourableReviewCountData.Text = favourableReviewCount.ToString();
            l_performFavourableReviewRateData.Text = ((((float)favourableReviewCount) / ((float)(favourableReviewCount + negetiveReviewCount))) * 100).ToString("F2") + "%";
            l_performNegativeReviewCountData.Text = negetiveReviewCount.ToString();
            l_performNegativeReviewRateData.Text = ((((float)negetiveReviewCount) / ((float)(favourableReviewCount + negetiveReviewCount))) * 100).ToString("F2") + "%";
        }

        //Comment Page
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



        //JobTitle Page(无效)
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
        private void employeeJobTitle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                if (employeeJobTitle.Rows.Count > 0)
                {
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            //helper.updateEmployeeJobTitle(e.ColumnIndex, this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[2].Value.ToString());
                            helper.updateEmployeeJobTitle(e.ColumnIndex, this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[2].Value.ToString());
                            break;
                        case 3:
                            helper.updateEmployeeJobTitle(e.ColumnIndex, this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[3].Value.ToString());
                            break;
                    }
                }
                employeeJobTitle.DataSource = helper.showEmployeeJobTitle();
            }
            else
            {
                employeeJobTitle.DataSource = helper.showEmployeeJobTitle();
            }
        }


        //Salary Page(HR Switch Page)
        private void btn_HRSwitchSubmit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                if (employeeHRSwitch.Rows.Count > 0)
                {
                    helper.HRSwitchSalaryChange(cb_HRSwitchPosition.Text, int.Parse(tb_HRSwitchSalaryChange.Text));
                }
                employeeHRSwitch.DataSource = helper.showEmployeeSalary();
            }
            else
            {
                employeeHRSwitch.DataSource = helper.showEmployeeSalary();
            }
        }
        //showAll
        private void showAll2_Click(object sender, EventArgs e)
        {
            employeeHRSwitch.DataSource = helper.showEmployeeSalary();
        }
        //search
        private void submitButton3_Click(object sender, EventArgs e)
        {
            employeeHRSwitch.DataSource = helper.searchHRSwitch(employeeIdBox3.Text);
        }

        //employeeSalary update
        private void employeeSalary_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("Sure to submit?", "", MessageBoxButtons.YesNo);

            //confirm to submit
            if (result == DialogResult.Yes)
            {
                if (employeeHRSwitch.Rows.Count > 0)
                {
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            helper.updateHRSwitch(this.employeeHRSwitch.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeHRSwitch.Rows[e.RowIndex].Cells[2].Value.ToString());
                            break;
                        case 3:
                            helper.updateHRSwitch(this.employeeHRSwitch.Rows[e.RowIndex].Cells[0].Value.ToString(), int.Parse(this.employeeHRSwitch.Rows[e.RowIndex].Cells[3].Value.ToString()));
                            break;
                    }
                }
                employeeHRSwitch.DataSource = helper.showEmployeeSalary();
            }
            else
            {
                employeeHRSwitch.DataSource = helper.showEmployeeSalary();
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
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info.FlatAppearance.BorderSize = 0;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_perform.FlatAppearance.BorderSize = 1;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_comment.FlatAppearance.BorderSize = 1;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 1;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 3;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_perform.FlatAppearance.BorderSize = 0;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_info.FlatAppearance.BorderSize = 1;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_comment.FlatAppearance.BorderSize = 1;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 1;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 4;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comment.FlatAppearance.BorderSize = 0;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_perform.FlatAppearance.BorderSize = 1;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_info.FlatAppearance.BorderSize = 1;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 1;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 0;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 0;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_perform.FlatAppearance.BorderSize = 1;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_comment.FlatAppearance.BorderSize = 1;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_info.FlatAppearance.BorderSize = 1;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 2;
        }
        

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 1;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_perform.FlatAppearance.BorderSize = 1;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_comment.FlatAppearance.BorderSize = 1;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_info.FlatAppearance.BorderSize = 1;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 1;
        }
       

      

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pipeline.FlatAppearance.BorderSize = 0;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button5.FlatAppearance.BorderSize = 1;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_HRSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_HRSwitch.FlatAppearance.BorderSize = 1;
            this.btn_HRSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_perform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_perform.FlatAppearance.BorderSize = 1;
            this.btn_perform.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_comment.FlatAppearance.BorderSize = 1;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_info.FlatAppearance.BorderSize = 1;
            this.btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 5;
        }

 #endregion

        

        






    }
}
