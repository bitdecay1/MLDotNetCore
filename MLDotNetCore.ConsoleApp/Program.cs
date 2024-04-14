// See https://aka.ms/new-console-template for more information
using MLDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

/*SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "DESKTOP-8DIOOI6"; // server name
stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; // database name
stringBuilder.UserID = "sa"; // database credential
stringBuilder.Password = "sasa@123"; // datatabase credential

SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
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
}*/

// Ado.Net Read
// CRUD

// using above code in a method.
AdoDotNetExample adoDotNetExample= new AdoDotNetExample();
// let's call the Read function from AdoDotNetExample as a method
// adoDotNetExample.Read();

// Creating new data
//adoDotNetExample.Create("title", "author", "content");

// Updating existing data
// adoDotNetExample.Update(6, "title", "taaest", "content");

// Deleting by id
// adoDotNetExample.Delete(10);
adoDotNetExample.Edit(1);
adoDotNetExample.Edit(3);

Console.ReadLine();