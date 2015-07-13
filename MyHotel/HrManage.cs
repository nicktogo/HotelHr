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
        }

        private void promoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
