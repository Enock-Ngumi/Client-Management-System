using Client_Management_System;
using System.Configuration;
using System.Data.SqlClient;

namespace CRUDApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            EnsureAdminExists();

            Application.Run(new Login());
        }
        static void EnsureAdminExists()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["personsConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string check = "SELECT COUNT(*) FROM LoginUser WHERE Role = 'Admin'";
                SqlCommand cmdCheck = new SqlCommand(check, con);

                int count = (int)cmdCheck.ExecuteScalar();

                if (count == 0)
                {
                    string username = "admin";
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword("2000");

                    string insert = @"INSERT INTO LoginUser (Username, PasswordHash, Role)
                              VALUES (@u, @p, 'Admin')";

                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", passwordHash);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
                