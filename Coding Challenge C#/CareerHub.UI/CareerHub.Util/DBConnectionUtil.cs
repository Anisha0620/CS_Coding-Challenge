using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CareerHub.Util
{
	public static class DBConnectionUtil
	{
		public static SqlConnection GetConnection()
		{
			try
			{
				// Retrieve the connection string from the configuration file
				string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

				// Create a new SQL connection using the connection string
				SqlConnection conn = new SqlConnection(connectionString);

				

				return conn; // Return the opened connection
			}
			catch (SqlException ex)
			{
				// Handle SQL exceptions
				Console.WriteLine("Database connection error: " + ex.Message);
				throw; // Re-throw the exception to be handled at a higher level
			}
			catch (Exception ex)
			{
				// Handle any other exceptions
				Console.WriteLine("An error occurred: " + ex.Message);
				throw; // Re-throw the exception
			}
		}
	}
}
