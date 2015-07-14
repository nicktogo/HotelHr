using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

using System.Data;

namespace OracleDBHelper
{
    class OracleHelper
    {
        private string connectionString;

        //Oracle Connection
        private OracleConnection conn;

        //Command to be executed
        private OracleCommand cmd;

        public OracleHelper()
        {
            //-修改过
            //connectionString = "User id=scott;password=0000;data source=localhost:1521/orcl;";
            connectionString = "User id=scott;password=tjsselps;data source=221.239.198.134:1521/hotel;";
            //修改过-
            conn = new OracleConnection(connectionString);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        }

        //EmployeePerform Page
        public bool insertEmployeePerform(string employeeId,string reason, int type)
        {
            OracleParameter pID = new OracleParameter("id", employeeId);
            OracleParameter pReason = new OracleParameter("reason", reason);
            OracleParameter pType = new OracleParameter("type", type);

            cmd.Parameters.Add(pID);
            cmd.Parameters.Add(pReason);
            cmd.Parameters.Add(pType);

            cmd.CommandText = "INSERT INTO Behavior" +
                " (EMPLOY_ID,REASON,BE_TYPE)" + 
                " VALUES(:id,:reason,:type)";

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //-K

        //JobTitle Page
        //SearchJobTitle
        public DataTable searchJobTitle(string employeeId)
        {
            DataTable SearchJobTitleTable;

            cmd.CommandText = "select e.employ_id,employ_name,position from employ e,works w where e.employ_id = w.employ_id and e.employ_id ='" + employeeId + "'";

            
                //employeeJobTitle.DataSource = this.showEmployeeJobTitle();
            
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);

                DataSet dataSet = new DataSet();

            
                adapter.Fill(dataSet);

                SearchJobTitleTable = dataSet.Tables[0];

                return SearchJobTitleTable;
            
        }

        //UpdateEmployeeJobTitle
        public bool updateEmployeeJobTitle(string employeeId,string newPosition)
        {
            cmd.CommandText = "update works set position='" + newPosition + "' where employ_id=" + employeeId;
            
            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable showEmployeeJobTitle()
        {
            DataTable JobTitleTable;

            cmd.CommandText = "select e.employ_id,employ_name,position " +
               "from employ e,works w " +
               "where e.employ_id=w.employ_id";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            JobTitleTable = dataSet.Tables[0];

            return JobTitleTable;
        }

        //Salary Page
        //UpdateEmployeeSalary
        public bool updateEmployeeSalary(string employeeId, int newSalary)
        {
            cmd.CommandText = "update works set salary=" + newSalary + "  where employ_id=" + employeeId;

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable showEmployeeSalary()
        {
            DataTable SalaryTable;

            cmd.CommandText = "select e.employ_id,employ_name,salary " +
                "from employ e,works w " +
                "where e.employ_id=w.employ_id";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            SalaryTable = dataSet.Tables[0];

            return SalaryTable;
        }
        //K-

        //Info Page
        public DataTable showEmployeePerform()
        {
            DataTable infoTable;

            cmd.CommandText = "select * from employ";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            infoTable = dataSet.Tables[0];

            return infoTable;
        }




        public void closeCon()
        {
            conn.Dispose();
        }

        //internal void UpdateEmployeeSalary(string p1, string p2)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}



