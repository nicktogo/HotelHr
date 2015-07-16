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
            employeeComment.DataSource = helper.showEmployeePerform();
            employeeComment.Columns[1].ReadOnly = true;
            employeeComment.Columns[4].Visible = false;


            bool isLatest = true;
            string[] dateNow = System.DateTime.Now.ToShortDateString().ToString().Split('/');
            DataTable allSalaryTypeAccountTime = helper.getAllSalaryTypeAccountTime();
            for (int i = 0; i < allSalaryTypeAccountTime.Rows.Count; i++)
            {
                string[] dateExist = allSalaryTypeAccountTime.Rows[i][0].ToString().Split('/');

                if (int.Parse(dateNow[0]) < int.Parse(dateExist[0]))
                {
                    isLatest = false;
                    break;
                }
                else if (int.Parse(dateNow[0]) == int.Parse(dateExist[0]) && int.Parse(dateNow[1]) <= int.Parse(dateExist[1]))
                {
                    isLatest = false;
                    break;
                }
                else
                {
                    //isLatest
                }
            }
            if (isLatest == true)
            {
                helper.newSalaryTypeAccount(helper.getSalarySum(), System.DateTime.Now.ToLocalTime().ToString());
            }
        }

        //Page Control
        //employPerform_Selecting
        private void employPerform_Selecting(object sender, TabControlCancelEventArgs e)
        {
            employeeHRSwitch.DataSource = helper.showEmployeeSalary();
            employeeHRSwitch.Columns[0].ReadOnly = true;
            employeeHRSwitch.Columns[1].ReadOnly = true;

            employeeInfo.DataSource = helper.showEmployeeInfo();
            employeeInfo.Columns[0].ReadOnly = true;
            
        }

        //------------------------------------------------

        //EmployeePerform Page
        private void btn_performSubmit_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            DataTable allEmployeeId = helper.getAllEmployeeId();
            for (int i = 0; i < allEmployeeId.Rows.Count; i++)
            {
                if (tb_performEmployId.Text.Equals(allEmployeeId.Rows[i][0].ToString()))
                {
                    int favourableReviewCount = helper.getFavourableReviewCountByEmployId(tb_performEmployId.Text);
                    int negetiveReviewCount = helper.getNegativeReviewCountByEmployId(tb_performEmployId.Text);
                    l_performFavourableReviewCountData.Text = favourableReviewCount.ToString();
                    if (favourableReviewCount == 0)
                    {
                        l_performFavourableReviewRateData.Text = "0%";
                    }
                    else
                    {
                        l_performFavourableReviewRateData.Text = ((((float)favourableReviewCount) / ((float)(favourableReviewCount + negetiveReviewCount))) * 100).ToString("F2") + "%";
                    }
                    l_performNegativeReviewCountData.Text = negetiveReviewCount.ToString();
                    if (negetiveReviewCount == 0)
                    {
                        l_performNegativeReviewRateData.Text = "0%";
                    }
                    else
                    {
                        l_performNegativeReviewRateData.Text = ((((float)negetiveReviewCount) / ((float)(favourableReviewCount + negetiveReviewCount))) * 100).ToString("F2") + "%";
                    }
                    isExist = true;
                }
            }
            if (isExist == false)
            {
                MessageBox.Show("The employee is NOT exist!", "", MessageBoxButtons.YesNo);
            }
        }

        //------------------------------------------------

        //Comment Page
        //employeePerform update
        private void employeePerform_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeComment.Rows.Count > 0)
            {
                int pos = e.ColumnIndex;

                if (e.ColumnIndex == 0 || e.ColumnIndex == 2)
                {
                    helper.updateEmployeePerform(pos, this.employeeComment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),
                        int.Parse(this.employeeComment.Rows[e.RowIndex].Cells[4].Value.ToString()));
                }
                else if (e.ColumnIndex == 3)
                {
                    helper.updateEmployeePerform(pos, int.Parse(this.employeeComment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()),
                       int.Parse(this.employeeComment.Rows[e.RowIndex].Cells[4].Value.ToString()));
                }
                else
                {

                }
                employeeComment.DataSource = helper.showEmployeePerform();
            }
        }
        //submit a new employee perform
        private void btn_commentSubmit_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            DataTable allEmployeeId = helper.getAllEmployeeId();
            for (int i = 0; i < allEmployeeId.Rows.Count; i++)
            {
                if (tb_commentEmployeeId.Text.Equals(allEmployeeId.Rows[i][0].ToString()))
                {
                    isExist = true;
                    break;
                }
            }

            if (isExist == true)
            {
                var result = MessageBox.Show("Sure to submit?", "",MessageBoxButtons.YesNo);

                //confirm to submit
                if (result == DialogResult.Yes)
                {
                    int type = 0;
                    if (rbtn_commentFavourable.Checked)
                    {
                        type = 1;
                    }
                    else if (rbtn_commentNagetive.Checked)
                    {
                        type = -1;
                    }

                    if (helper.insertEmployeePerform(tb_commentEmployeeId.Text, tb_commentReason.Text, type))
                    {
                        MessageBox.Show("Success!");
                        tb_commentEmployeeId.Text = "";
                        tb_commentReason.Text = "";
                        rbtn_commentNagetive.Checked = false;
                        rbtn_commentFavourable.Checked = false;

                        //highlight and top the inserted record 
                        //refresh datasource
                        employeeComment.DataSource = helper.showEmployeePerform();

                        //get the behavior_id of the newest record
                        decimal behaviorid = helper.getBehaviorId();

                        //get the index of the newest record in DataGridView (using linq)
                        int index = -1;
                        DataGridViewRow row = employeeComment.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => decimal.Parse(r.Cells[4].Value.ToString()) == behaviorid)
                            .First();
                        index = row.Index;

                        //set it to the first one
                        employeeComment.FirstDisplayedScrollingRowIndex = index;

                        //highlight
                        employeeComment.ClearSelection();
                        employeeComment.Rows[index].Selected = true;

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
            }
            else
            {
                MessageBox.Show("The employee is NOT exist!", "", MessageBoxButtons.YesNo);
            }
        }

        //------------------------------------------------

        //HR Switch Page
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
        private void btn_HRSwitchShowAll_Click(object sender, EventArgs e)
        {
            employeeHRSwitch.DataSource = helper.showEmployeeSalary();
        }
        //search
        private void btn_HRSwitchSearch_Click(object sender, EventArgs e)
        {
            employeeHRSwitch.DataSource = helper.searchHRSwitch(tb_HRSwitchEmployeeId.Text);
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

        //------------------------------------------------

        //pipeline Page

        //------------------------------------------------

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
        

        private void btn_perform_MouseDown(object sender, MouseEventArgs e)
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
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tc_employPerform.SelectedIndex = 0;
        }

        private void btn_comment_MouseDown(object sender, MouseEventArgs e)
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
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tc_employPerform.SelectedIndex = 1;
        }

        private void btn_HRSwitch_MouseDown(object sender, MouseEventArgs e)
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
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tc_employPerform.SelectedIndex = 2;
        }

        private void btn_pipeline_MouseDown(object sender, MouseEventArgs e)
        {
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pipeline.FlatAppearance.BorderSize = 0;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.tc_employPerform.SelectedIndex = 3;
        }

        private void btn_info_MouseDown(object sender, MouseEventArgs e)
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
            this.btn_pipeline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.btn_pipeline.FlatAppearance.BorderSize = 1;
            this.btn_pipeline.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tc_employPerform.SelectedIndex = 4;
        }

 #endregion

    }
}
