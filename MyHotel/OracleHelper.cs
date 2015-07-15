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
        //updateEmployeePerform(0,2)
        public bool updateEmployeePerform(int pos, string newData, int behaviorId)
        {
            if (pos == 0)
            {
                cmd.CommandText = "update behavior set employ_id='" + newData +
                "' where behavior_id=" + behaviorId;
            }
            else if(pos == 2)
            {
                cmd.CommandText = "update behavior set reason='" + newData + "' where behavior_id=" + behaviorId;
            }
            else
            {
                //error
            }

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //updateEmployeePerform(3)
        public bool updateEmployeePerform(int pos, int newData, int behaviorId)
        {
            if (pos == 3)
            {
                cmd.CommandText = "update behavior set be_type=" + newData + " where behavior_id=" + behaviorId;
            }
            else
            {
                //error
            }

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //
        public DataTable showEmployeePerform()
        {
            DataTable PerformTable;

            cmd.CommandText = "select b.employ_id,employ_name,reason,be_type,behavior_id from behavior b,employ e where b.employ_id=e.employ_id";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            PerformTable = dataSet.Tables[0];

            return PerformTable;
        }

        //insertEmployeePerform
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

        //get the behavior_id of the new record
        public decimal getBehaviorId()
        {
            decimal behaviorId = -1;

            cmd.CommandText = "select count(behavior_id) from behavior";

            behaviorId = (decimal)cmd.ExecuteScalar() + 9;

            return behaviorId;

        }

        

        //JobTitle Page
        //SearchJobTitle
        public DataTable searchJobTitle(string employeeId)
        {
            DataTable SearchJobTitleTable;

            cmd.CommandText = "select e.employ_id,employ_name,position from employ e,works w where e.employ_id = w.employ_id and e.employ_id ='" + employeeId + "'";

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
        //SearchSalary
        public DataTable searchSalary(string employeeId)
        {
            DataTable SearchSalaryTable;

            cmd.CommandText = "select e.employ_id,employ_name,salary from employ e,works w where e.employ_id = w.employ_id and e.employ_id ='" + employeeId + "'";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            SearchSalaryTable = dataSet.Tables[0];

            return SearchSalaryTable;
        }

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

        //Info Page
        //update(1,2,3,4,5,7,8)
        public bool updateEmployeeInfo(int pos, string employeeId, string newData)
        {
            switch (pos)
            {
                case 1:
                    cmd.CommandText = "update employ set EMPLOY_NAME='" + newData + "' where employ_id=" + employeeId;
                    break;
                case 2:
                    cmd.CommandText = "update employ set GENDER='" + newData + "' where employ_id=" + employeeId;
                    break;
                case 3:
                    cmd.CommandText = "update employ set ADDRESS='" + newData + "' where employ_id=" + employeeId;
                    break;
                case 4:
                    cmd.CommandText = "update employ set CITIZEN_ID='" + newData + "' where employ_id=" + employeeId;
                    break;
                case 5:
                    string[] _newData = newData.Split(' ');
                    string[] date = _newData[0].Split('/');
                    string _date = date[2] + "-" + date[1] + "月-" + date[0].Substring(2, 2);
                    cmd.CommandText = "update employ set IN_DATE='" + _date + "' where employ_id=" + employeeId;
                    break;
                case 7:
                    cmd.CommandText = "update employ set STATUS='" + newData + "' where employ_id=" + employeeId;
                    break;
                case 8:
                    cmd.CommandText = "update employ set PASSWORD='" + newData + "' where employ_id=" + employeeId;
                    break;
            }
            
            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //update(6)
        public bool updateEmployeeInfo(int pos, string employeeId, int newData)
        {
            cmd.CommandText = "update employ set WORK_YEAR='" + newData + "' where employ_id=" + employeeId;

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //
        public DataTable getAllEmployeeId()
        {
            DataTable allEmployeeId;

            cmd.CommandText = "select employ_id from employ";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            allEmployeeId = dataSet.Tables[0];

            return allEmployeeId;
        }
        //
        public bool deleteEmployeeInfo(string employeeId)
        {
            cmd.CommandText = "delete from employ where EMPLOY_ID='" + employeeId + "'";

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //
        public bool insertEmployeeInfo(string employeeId, string employeeName, string gender, string address, string citizenId, string inDate, int workYear, string status, string password)
        {
            string[] date = inDate.Split('/');
            string _inDate =  date[2] +"-"+ date[1] +"月-"+  date[0].Substring(2,2);
            

            cmd.CommandText = "insert into employ(EMPLOY_ID,EMPLOY_NAME,GENDER,ADDRESS,CITIZEN_ID,IN_DATE,WORK_YEAR,STATUS,PASSWORD)"
                +"values('"+ employeeId +"','"+ employeeName +"','"+ gender +"','"+ address +"','"+ citizenId +"','"+ _inDate +"',"+ workYear +",'"+ status +"','"+ password +"')";

            if (cmd.ExecuteNonQuery() <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //insert check employeeId
        //public bool isEmployeeIdExist(string employeeId)
        //{
        //    cmd.CommandText = "select employ_id from employ where employ_id ='" + employeeId + "'";
        //    if (cmd.ExecuteScalar() == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }    
        //}
        //showEmployeeInfo
        public DataTable showEmployeeInfo()
        {
            DataTable infoTable;

           cmd.CommandText = "select * from employ";

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            infoTable = dataSet.Tables[0];

            return infoTable;
        }




        public void closeConn()
        {
            conn.Dispose();
        }

        //internal void UpdateEmployeeSalary(string p1, string p2)
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}



