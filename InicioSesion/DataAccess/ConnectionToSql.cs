using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace DataAcces
{
    public abstract class ConnectionToSql
    {


        private string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database = MyCompany;Integrated Security=True";
            //connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database = MyCompany;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }

        protected SqlConnection GetConnection()
        {

            return new SqlConnection(connectionString);

        }

        //cnn.Open();
        //MessageBox.Show("Connection Open  !");
        //cnn.Close();

    }
}
