using Devart.Data.Universal;
using System.Text;

namespace RelationalCustomerProduct
{
    static class DatabaseConnection
    {       
        public static UniConnection MakeConnection()
        {
            StringBuilder connectionStr = new StringBuilder("Provider=PostgreSQL");

            connectionStr.Append(";host=" + "localhost");
            connectionStr.Append(";port=" + 5432);
            connectionStr.Append(";user=" + "postgres");
            connectionStr.Append(";password=" + "password");
            connectionStr.Append(";database=" + "RelationalCustomerProduct_db");
            connectionStr.Append(";Pooling=false");
            connectionStr.Append(";Unicode=true");

            UniConnection conn = new UniConnection(connectionStr.ToString());                       
            return conn;
        }           
    }
}