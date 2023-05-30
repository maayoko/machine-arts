using System.Data.OleDb;
namespace Machine_arts.UtilitiesHelpers
{
    public class ConnectionHelper
    {
        public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database\\Machine_arts.accdb";



        [System.Runtime.Versioning.SupportedOSPlatform("windows")]
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(ConnectionString);
        }
    }
}
