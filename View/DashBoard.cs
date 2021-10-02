using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Controller;
using TodoList.Model;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace TodoList
{
    public partial class DashBoard : Form
    {
        //DataSet ds = new DataSet();
        //DataTable dt = new DataTable();

        //SqlConnection connection;

        //TodoApp_connectionString


        System.Timers.Timer t;
        int h, m, s;

        private static string constring = ConfigurationManager.ConnectionStrings["TodoApp_connectionString"].ConnectionString;


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn
          (
           int nLeftRect, // x-coordinate of upper-left corner
           int nTopRect, // y-coordinate of upper-left corner
           int nRightRect, // x-coordinate of lower-right corner
           int nBottomRect, // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
          );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);


        TodoController tc = new TodoController();

        public DashBoard()
        {
            InitializeComponent();
            timer_panel.Visible = false;
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
           todolist_datagrid.DataSource = GetTodoList(); // loads data into the grid

            t = new System.Timers.Timer();
            t.Interval = 1000; // ls
            t.Elapsed += OnTimeEvent;


        }
        // timer
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if(s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if(m== 60)
                {
                    m = 0;
                    h += 1;
                }

                tb_timer.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2,'0'), m.ToString().PadLeft(2,'0'), s.ToString().PadLeft(2,'0'));
            }));
        }


        // get the current task
        private DataTable GetTodoList()
        {
                return tc.GetTodo(); 
        }

        // clear txtboxes
        private void ClearTxtBoxes()
        {


            todolist_datagrid.Update();
            tb_title_changes.Clear();
            tb_desc_changes.Clear();
            tb_id.Clear();
        }

        // pass data into the txtbox
        private void todolist_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if(this.todolist_datagrid.CurrentRow.Cells.Count >= 5) // if cells is greater than or equl to 5 then it will be considered as            
            {
                                                                   
                cmb_when_changes.Text = this.todolist_datagrid.CurrentRow.Cells[0].Value.ToString();
                tb_title_changes.Text = this.todolist_datagrid.CurrentRow.Cells[1].Value.ToString();
                tb_desc_changes.Text = this.todolist_datagrid.CurrentRow.Cells[2].Value.ToString();
                tb_id.Text = this.todolist_datagrid.CurrentRow.Cells[3].Value.ToString();

                rd_done.Text = this.todolist_datagrid.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                 cmb_when_changes.Text = this.todolist_datagrid.CurrentRow.Cells[0].Value.ToString();
                tb_title_changes.Text = this.todolist_datagrid.CurrentRow.Cells[1].Value.ToString();
                tb_desc_changes.Text = this.todolist_datagrid.CurrentRow.Cells[2].Value.ToString();
                tb_id.Text = this.todolist_datagrid.CurrentRow.Cells[3].Value.ToString();


            }


        }

        // get the task finished
        private void btn_taskfinished_Click(object sender, EventArgs e)
        {
            // updates the datagrid when this handler is called
            todolist_datagrid.Update();
            // pass the finished task method to the datasource
            todolist_datagrid.DataSource = tc.GetFinishedTask();

            
        }

        // get current task
        private void btn_Task_Click(object sender, EventArgs e)
        {

            // pass the finished task method to the datasource
            todolist_datagrid.DataSource = tc.GetTodo();


            // updates the datagrid when this handler is called
            todolist_datagrid.Update();

            
          
        }

        private string CheckRadioDone()
        {

            if (rd_done.Checked)
            {
                return rd_done.Text = "Done";
            }
            else if(rd_notDone.Checked)
            {
                return rd_notDone.Text = "Not Done";
            }else
            {
                return rd_done.Text = "Done";
            }
        }


        // clears txtboxes
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_title_changes.Clear();
            tb_desc_changes.Clear();
            tb_id.Clear();
        }

        // makes the edge of the form more rounder
        private void DashBoard_Paint(object sender, PaintEventArgs e)
        {
            System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 12, 12); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }

        // adding and saving
        private void Save()
        {
            try
            {
                if (MessageBox.Show("Save?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // if radio button done is check then the task changes will be saved
                    if (rd_done.Checked || rd_notDone.Checked)
                    {
                        var NewUpdate = new Todo_Model()
                        {
                            TodoID = Convert.ToInt32(tb_id.Text),
                            Title = tb_title_changes.Text,
                            Description = tb_desc_changes.Text,
                            When_Todo = cmb_when_changes.Text,
                            Task_Status = CheckRadioDone()
                        };

                        tc.UpdateTodo(NewUpdate);
                        UpdateGrid();

                        ClearTxtBoxes();


                        // if radio button not done is checked, then it will be considered as new task
                    }
                    else
                    {
                        MessageBox.Show("Mark it as done or leave it as not done");
                    }

                }
                else
                {
                    MessageBox.Show("Cancelled Successfully");
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("something went wrong here code[btn_save_Click]" + error);
            }
        }
        private void Add()
        {
            if (rd_notDone.Checked)
            {
                var AddNew = new Todo()
                {
                    Title = tb_title_changes.Text,
                    Description = tb_desc_changes.Text,
                    When_Todo = cmb_when_changes.Text,
                    Task_Status = CheckRadioDone()
                };
                if (MessageBox.Show("Add new?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    tc.AddNewTodo(AddNew);

                }

                UpdateGrid();


                ClearTxtBoxes();
            }
            else
            {
                MessageBox.Show("Dont Add it if its already done!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Cmb_one_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_one.Text == "SAVE")
            {
                Save();
            }
            
            else if(Cmb_one.Text == "ADD")
            {
                Add();
            }
        }

        private void cmb_two_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_two.Text == "COMPLETED")
            {

                todolist_datagrid.Update();
                todolist_datagrid.DataSource = tc.GetFinishedTask();
                todolist_datagrid.Update();
                todolist_datagrid.Refresh();
                


            }else if(cmb_two.Text == "TASK")
            {
                todolist_datagrid.Update();
                
                todolist_datagrid.DataSource = tc.GetTodo();
                todolist_datagrid.Update();
                todolist_datagrid.Refresh();
            }
        }


        // delete

        private void DeleteTask(Todo id)
        {

            using (TodoListAppEntities db = new TodoListAppEntities())
            { 
                try
                {
                    if (MessageBox.Show("You sure you want to Delete this?", "This cannot be undo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                    {

                        //var ID = from data in db.Todoes
                        //         where data.TodoID == id
                        //         select db;


                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            string DeleteQuery = "DELETE FROM Todo WHERE TodoID='"+tb_id.Text+"'";

                            using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                            {
                                con.Open();
                                com.ExecuteNonQuery();
                                MessageBox.Show("Deleted successfully! ", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateGrid();
                                con.Close();
                            }
                        }

                      
                    }
                    else
                    {
                        MessageBox.Show("Cancelled successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Something went wrong" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }


            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            tb_id.Text = Convert.ToString(0);

            if (tb_id.Text == Convert.ToString(0))
            {
                MessageBox.Show("You have not selected anything", "Blank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var id = new Todo()
                {
                    TodoID = Convert.ToInt32(tb_id.Text)
                };
                DeleteTask(id);
            }
        }

        private void todolist_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        tb_id.Text = this.todolist_datagrid.CurrentRow.Cells[3].Value.ToString();  
        }

       

        private void UpdateGrid()
        {
            if (rd_done.Checked)
            {
                todolist_datagrid.DataSource = tc.GetFinishedTask();

                todolist_datagrid.Update();

            }
            else if (rd_notDone.Checked)
            {
                todolist_datagrid.DataSource = tc.GetTodo();

                todolist_datagrid.Update();
            }
        }

        private void btn_resetTimer_Click(object sender, EventArgs e)
        {
            tb_timer.Text = "00:00:00";
            t.Stop();
            h = 0; 
            m = 0;  
            s = 0;

         
        }

        private void tb_callTimer_Click(object sender, EventArgs e)
        {
            timer_panel.Visible = true;
        }

        private void btn_saveTaskTimer_Click(object sender, EventArgs e)
        {
            timer_panel.Visible = false;
        }

        private void btn_startTimer_Click(object sender, EventArgs e)
        {
            t.Start();
        }

        private void btn_stopTimer_Click(object sender, EventArgs e)
        {
            t.Stop();
        }
    }
}
