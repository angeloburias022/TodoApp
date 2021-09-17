using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList.Repository
{
    public class Database : IDatabase
    {

        private static string ConString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        SqlConnection connection = new SqlConnection();
        public bool CheckConnection()
        { 
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }
            

         return false;
        }

        // checks the device if there is an existing database already 
        public bool CheckDatabaseExists(SqlConnection tmpConn, string databaseName)
        {
            string sqlCreateDBQuery;
            bool result = false;
            if (CheckConnection() == true) 
            { 
                try
                {
                    sqlCreateDBQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", databaseName);
                    using (SqlCommand sqlCmd = new SqlCommand(sqlCreateDBQuery, tmpConn))
                    {
                        tmpConn.Open();
                        object resultObj = sqlCmd.ExecuteScalar();
                        int databaseID = 0;
                        if (resultObj != null)
                        {
                            int.TryParse(resultObj.ToString(), out databaseID);
                        }
                        tmpConn.Close();
                        result = (databaseID > 0);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Something went wrong" + error);
                    result = false;
                }
            }
           

            return result;
        }

        // Grants access to this app 
        public bool GrantAccess(string fullPath)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(fullPath);
                WindowsIdentity self = System.Security.Principal.WindowsIdentity.GetCurrent();
                DirectorySecurity ds = info.GetAccessControl();
                ds.AddAccessRule(new FileSystemAccessRule(self.Name,
                FileSystemRights.FullControl,
                InheritanceFlags.ObjectInherit |
                InheritanceFlags.ContainerInherit,
                PropagationFlags.None,
                AccessControlType.Allow));
                info.SetAccessControl(ds);
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong" + error);

                return false;
            }


            return true;
        }
        public bool CreateDatabase(SqlConnection connection, string txtDatabase)
        {
            //  String CreateDatabase;
           
            // Gets the path of this application
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Pass the value inside the GrantAccess function in order to be allow in creating database
            GrantAccess(appPath); //Need to assign the permission for current application to allow create database on server (if you are in domain).

            // Store the CheckDatabaseExists inside a boolean 
            bool IsExist = CheckDatabaseExists(connection, txtDatabase); //Check database exists in sql server.
            if (!IsExist)
            {
                //  string script = File.ReadAllText(@"C:\Users\home pc\source\repos\RFBDesktopSystem\RFBScript.sql");


                string script = File.ReadAllText(@"\RFBDesktopSystem\sql_script\9421RFBScript.sql");

                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);

                try
                {
                    foreach (string commandString in commandStrings)
                    {
                        using (SqlConnection con = new SqlConnection(ConString))
                        {
                            con.Open();
                            if (commandString.Trim() != "")
                            {
                                new SqlCommand(commandString, connection).ExecuteNonQuery();
                            }
                            con.Close();
                        }
                    }
                    //    CreateDatabase = ex.Execute(script, ConString);

                }


                catch (System.Exception exx)
                {
                    string Text = "hey";
                    MessageBox.Show("Please Check Server and Database name.Server and Database name are incorrect .'" + exx + "'", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                using (SqlCommand com = new SqlCommand("[SpCreateTable]", connection))
                {
                    com.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    com.ExecuteNonQuery();

                }

                return true;
            }
            return true;
        }

    }
}
