using System.Data.SqlClient;
using System;
using System.Windows.Forms;


namespace Just_Test
{
    /// <summary>
    ///  This is just an simple SQL Database connection Program, 
    ///  
    /// First we need to use nuget Package to download SQL Data client and then only we can use SqlConnection 
    /// 
    /// after downloading it we can create a connection string with all server and database details, 
    /// 
    /// then using SqlConnection we create a new connection and open the connetion
    /// 
    /// below code didnt have try method please add try and catch to get error message in connection 
    /// 
    /// example try { }
    /// catch(Exception ex) {MessageBox.Show($"Connection failed {ex.message}")}
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = $"server=.; Database=MVC; Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show("Connection Established");
            }

        }
    }

    
}