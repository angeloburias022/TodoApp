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

namespace TodoList
{
    public partial class DashBoard : Form
    {
        //DataSet ds = new DataSet();
        //DataTable dt = new DataTable();

        //SqlConnection connection;

        //TodoApp_connectionString

        //private static string constring = ConfigurationManager.ConnectionStrings["TodoApp_connectionString"].ConnectionString;

        TodoController tc = new TodoController();



        public DashBoard()
        {

            InitializeComponent();
            cmb_task_status.Visible = false;
            lbl_markasdone.Visible = false;
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
           todolist_datagrid.DataSource = GetTodoList(); 
        }

        private DataTable GetTodoList()
        {
                return tc.GetTodo();
        }


        // pops the add todo list form 
        // then hides the grid
        private void btn_addnew_Click(object sender, EventArgs e)
        {
            var add = new Todo()
            {
                Title = tb_title_changes.Text,
                Description = tb_title_changes.Text,
                When_Todo = cmb_when_changes.Text,
                Task_Status = "none"
            };
            TodoController tc = new TodoController();
            tc.AddNewTodo(add);


            // automatically updates the grid
            todolist_datagrid.DataSource = GetTodoList();
            todolist_datagrid.Update();
            
        }


     

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {

                var NewUpdate = new Todo_Model()
                {
                    TodoID = Convert.ToInt32(tb_id.Text),
                    Title = tb_title_changes.Text,
                    Description = tb_desc_changes.Text,
                    When_Todo = cmb_when_changes.Text,
                    Task_Status = cmb_task_status.Text
                };
                // TODO: 1 finished this logic
                if (MessageBox.Show("Save changes?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {

                    tc.UpdateTodo(NewUpdate);



                    todolist_datagrid.DataSource = GetTodoList();

                    todolist_datagrid.Update();
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

        private void btn_markdone_Click(object sender, EventArgs e)
        {


            cmb_task_status.Visible = true;
            lbl_markasdone.Visible = true;


            
        }

        private void todolist_datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if(this.todolist_datagrid.CurrentRow.Cells.Count >= 5)
            {
                tb_id.Text = this.todolist_datagrid.CurrentRow.Cells[0].Value.ToString();
                tb_title_changes.Text = this.todolist_datagrid.CurrentRow.Cells[1].Value.ToString();
                tb_desc_changes.Text = this.todolist_datagrid.CurrentRow.Cells[2].Value.ToString();
                cmb_when_changes.Text = this.todolist_datagrid.CurrentRow.Cells[3].Value.ToString();

                cmb_task_status.Text = this.todolist_datagrid.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {
                tb_id.Text = this.todolist_datagrid.CurrentRow.Cells[0].Value.ToString();
                tb_title_changes.Text = this.todolist_datagrid.CurrentRow.Cells[1].Value.ToString();
                tb_desc_changes.Text = this.todolist_datagrid.CurrentRow.Cells[2].Value.ToString();
                cmb_when_changes.Text = this.todolist_datagrid.CurrentRow.Cells[3].Value.ToString();

            }


        }

        private void btn_taskfinished_Click(object sender, EventArgs e)
        {
            // updates the datagrid when this handler is called
            todolist_datagrid.Update();
            // pass the finished task method to the datasource
            todolist_datagrid.DataSource = tc.GetFinishedTask();

            HideMarkStatus();
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            // updates the datagrid when this handler is called
            todolist_datagrid.Update();
            // pass the finished task method to the datasource
            todolist_datagrid.DataSource = tc.GetTodo();

            HideMarkStatus();
          
        }


        private void HideMarkStatus()
        {
            lbl_markasdone.Visible = false;
            cmb_task_status.Visible = false;

        }

       

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_title_changes.Clear();
            tb_desc_changes.Clear();
            tb_id.Clear();
        }

        private void btn_markdone_DoubleClick(object sender, EventArgs e)
        {
            Save();
            todolist_datagrid.Update();
            todolist_datagrid.DataSource = tc.GetFinishedTask();
        }
    }
}
