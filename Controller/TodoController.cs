using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Model;

namespace TodoList.Controller
{
    public class TodoController
    {
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private static string constring = ConfigurationManager.ConnectionStrings["TodoApp_connectionString"].ConnectionString;

        SqlConnection connection = new SqlConnection(constring);
        private bool CheckConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable GetTodo()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                string GetQuery = "SELECT When_Todo, Title, Description, TodoID FROM Todo where Task_status !='Done' ";
                using (SqlCommand com = new SqlCommand(GetQuery, con))
                {
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        con.Open();
                        ds.Clear();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        con.Close();
                        return dt;
                        
                    }
                    
                }


            }

        }
        public  DataTable GetFinishedTask()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {

                string GetQuery = "SELECT TodoID,Task_Status, Title, Description, When_Todo FROM Todo WHERE Task_Status='Done' ";
                using (SqlCommand com = new SqlCommand(GetQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        con.Open();
                        ds.Clear();
                        adapter.Fill(ds);

                        dt = ds.Tables[0];
                        con.Close();
                        return dt;
                    }
                    
                }


            }

        }

        // has add new task and save updates functionality
        public void AddNewTodo(Todo add)
        {
            try
            {
                //if (MessageBox.Show("Add?", "Add to Todo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.OK)
                //{
                    using (TodoListAppEntities db = new TodoListAppEntities())
                    {
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            using (SqlCommand checkCommand = new SqlCommand("SELECT * FROM Todo WHERE ([TodoID] = '" + add.TodoID + "')", con))
                            {
                                con.Open();
                                SqlDataReader reader = checkCommand.ExecuteReader();
                                if (reader.HasRows)
                                {

                                    // if record exist
                                    MessageBox.Show("Task Already Exists.");
                                    con.Close();
                                }
                                else
                                {
                                    db.Todoes.Add(add);
                                    db.SaveChanges();
                                    MessageBox.Show("Added successfully!");
                                }
                            }
                        }
                      
                    }
                //}
                //else
                //{       
                //   MessageBox.Show("Cancelled successfully");           
                //}
               
            }
            catch(Exception error)
            {
                MessageBox.Show("Something went wrong " + error);
            }
             
        }
        public void UpdateTodo(Todo_Model update)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    con.Open();



                    string updateQuery = "UPDATE Todo SET Title = '" + update.Title + "',Description='" + update.Description + "', When_Todo='" + update.When_Todo + "',Task_Status='"+update.Task_Status+"' where TodoID ='" + update.TodoID + "'  ";

                    using (SqlCommand com = new SqlCommand(updateQuery, con))
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Update Changes", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("something is wrong " + error);
            }

        }
    }
}
