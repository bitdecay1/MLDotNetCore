using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLDotNetCore.ConsoleApp
{
    internal class AdoDotNetExample
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-8DIOOI6", // server name
            InitialCatalog = "DotNetTrainingBatch4", // database name
            UserID = "sa", // database credential
            Password = "sasa@123" // datatabase credential

            // notice that his closing bracket requires a semi-colon
        };
        public void Read()
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);

            connection.Open();
            Console.WriteLine("Connection open!");

            string query = "select * from tbl_blog";
            SqlCommand cmd = new SqlCommand(query, connection); // take the sql query from query and connect to the server using connection
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            connection.Close();
            Console.WriteLine("Connection close!");

            // dataset => datatable
            // datatable => datarow
            // datarow => datacolumn 
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Blog Id => " + dr["BlogId"]);
                Console.WriteLine("Blog Title => " + dr["BlogTitle"]);
                Console.WriteLine("Blog Author => " + dr["BlogAuthor"]);
                Console.WriteLine("Blog Content => " + dr["BlogContent"]);
                Console.WriteLine("---------------------");
            }
        }

        // Creating a funciton that can insert data to sql tables?
        public void Create(string title, string author, string content)
        {
            SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            connection.Open();

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
            VALUES
           (@BlogTitle,
            @BlogAuthor,
            @BlogContent)";
            SqlCommand cmd = new SqlCommand(query, connection);
            // **** DON"T KNOW WHAT THESE cmd.Parameters are.****
            cmd.Parameters.AddWithValue("@BlogTitle", title);
            cmd.Parameters.AddWithValue("@BlogAuthor", author);
            cmd.Parameters.AddWithValue("@BlogContent", content);
            int result = cmd.ExecuteNonQuery(); // this will execute the above sql query.

            connection.Close();
            string message = result > 0 ? "Saving Successful" : "Saving Failed";
            Console.WriteLine(message);

        }
    }
}
