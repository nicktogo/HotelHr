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
            employeeSalary.Columns[0].ReadOnly = true;
            employeeSalary.Columns[1].ReadOnly = true;
        }

        //employeeJobTitle update
        private void employeeJobTitle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeJobTitle.Rows.Count > 0)
            {
                helper.UpdateEmployeeJobTitle(this.employeeJobTitle.Rows[e.RowIndex].Cells[0].Value.ToString(), this.employeeJobTitle.Rows[e.RowIndex].Cells[2].Value.ToString());   
            }
        }

        //employeeSalary update
        private void employeeSalary_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeSalary.Rows.Count > 0)
            {
                helper.UpdateEmployeeSalary(this.employeeSalary.Rows[e.RowIndex].Cells[0].Value.ToString(), int.Parse(this.employeeSalary.Rows[e.RowIndex].Cells[2].Value.ToString()));
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

        private void jobTitleMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button2.FlatAppearance.BorderSize = 1;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button3.FlatAppearance.BorderSize = 1;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 3;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button4.FlatAppearance.BorderSize = 1;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button2.FlatAppearance.BorderSize = 1;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button3.FlatAppearance.BorderSize = 1;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 0;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button4.FlatAppearance.BorderSize = 1;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button3.FlatAppearance.BorderSize = 1;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 1;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button1.FlatAppearance.BorderSize = 1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button2.FlatAppearance.BorderSize = 1;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Tile;
            this.button4.FlatAppearance.BorderSize = 1;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.employPerform.SelectedIndex = 2;
        }
        

       
        
        //K-
    }
}
