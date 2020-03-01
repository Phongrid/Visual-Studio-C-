using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace MVC_APP.Repositories
{
    public class ProductRepository
    {
        public DataSet getProducts()
        {   //create String gor keep ConnectionString
            string connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

            //create Object of sqlConnection
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //create dataset
            DataSet dataSet = new DataSet();

            //create command Text
            string command = "SELECT* from [products]";

            //create object sql Command
            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            //create sql adappter แปลงข้อมูลให้เข้ากัน
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //set data in sql
            sqlDataAdapter.Fill(dataSet);
            return dataSet;
        }
    }
}