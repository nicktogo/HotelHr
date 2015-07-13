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
            connectionString = "User id=scott;password=tjsselps;data source=localhost:1521/hotel;";
            conn = new OracleConnection(connectionString);
            conn.Open();

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        }

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
    }
}



