
namespace TodoList
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_Task = new Guna.UI2.WinForms.Guna2Button();
            this.btn_taskfinished = new Guna.UI2.WinForms.Guna2Button();
            this.btn_markdone = new Guna.UI2.WinForms.Guna2Button();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_markasdone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_addnew = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.todolist_datagrid = new System.Windows.Forms.DataGridView();
            this.tb_title_changes = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_task_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_when_changes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_desc_changes = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.tb_id);
            this.dataGridPanel.Controls.Add(this.btn_clear);
            this.dataGridPanel.Controls.Add(this.btn_Task);
            this.dataGridPanel.Controls.Add(this.btn_taskfinished);
            this.dataGridPanel.Controls.Add(this.btn_markdone);
            this.dataGridPanel.Controls.Add(this.btn_save);
            this.dataGridPanel.Controls.Add(this.lbl_markasdone);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel6);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel5);
            this.dataGridPanel.Controls.Add(this.btn_addnew);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel4);
            this.dataGridPanel.Controls.Add(this.todolist_datagrid);
            this.dataGridPanel.Controls.Add(this.tb_title_changes);
            this.dataGridPanel.Controls.Add(this.cmb_task_status);
            this.dataGridPanel.Controls.Add(this.cmb_when_changes);
            this.dataGridPanel.Controls.Add(this.tb_desc_changes);
            this.dataGridPanel.Location = new System.Drawing.Point(12, 12);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.ShadowDecoration.Parent = this.dataGridPanel;
            this.dataGridPanel.Size = new System.Drawing.Size(482, 480);
            this.dataGridPanel.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(193, 225);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(51, 20);
            this.tb_id.TabIndex = 11;
            this.tb_id.Visible = false;
            // 
            // btn_Task
            // 
            this.btn_Task.BackColor = System.Drawing.Color.Transparent;
            this.btn_Task.BorderRadius = 4;
            this.btn_Task.CheckedState.Parent = this.btn_Task;
            this.btn_Task.CustomImages.Parent = this.btn_Task;
            this.btn_Task.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Task.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Task.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Task.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Task.DisabledState.Parent = this.btn_Task;
            this.btn_Task.FillColor = System.Drawing.Color.Red;
            this.btn_Task.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_Task.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Task.ForeColor = System.Drawing.Color.White;
            this.btn_Task.HoverState.Parent = this.btn_Task;
            this.btn_Task.Location = new System.Drawing.Point(370, 224);
            this.btn_Task.Name = "btn_Task";
            this.btn_Task.ShadowDecoration.Parent = this.btn_Task;
            this.btn_Task.Size = new System.Drawing.Size(94, 45);
            this.btn_Task.TabIndex = 10;
            this.btn_Task.Text = "TASK";
            this.btn_Task.Click += new System.EventHandler(this.btn_Task_Click);
            // 
            // btn_taskfinished
            // 
            this.btn_taskfinished.BackColor = System.Drawing.Color.Transparent;
            this.btn_taskfinished.BorderRadius = 4;
            this.btn_taskfinished.CheckedState.Parent = this.btn_taskfinished;
            this.btn_taskfinished.CustomImages.Parent = this.btn_taskfinished;
            this.btn_taskfinished.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_taskfinished.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_taskfinished.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_taskfinished.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_taskfinished.DisabledState.Parent = this.btn_taskfinished;
            this.btn_taskfinished.FillColor = System.Drawing.Color.Red;
            this.btn_taskfinished.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_taskfinished.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_taskfinished.ForeColor = System.Drawing.Color.White;
            this.btn_taskfinished.HoverState.Parent = this.btn_taskfinished;
            this.btn_taskfinished.Location = new System.Drawing.Point(370, 169);
            this.btn_taskfinished.Name = "btn_taskfinished";
            this.btn_taskfinished.ShadowDecoration.Parent = this.btn_taskfinished;
            this.btn_taskfinished.Size = new System.Drawing.Size(94, 45);
            this.btn_taskfinished.TabIndex = 10;
            this.btn_taskfinished.Text = "FINISHED TASK";
            this.btn_taskfinished.Click += new System.EventHandler(this.btn_taskfinished_Click);
            // 
            // btn_markdone
            // 
            this.btn_markdone.BackColor = System.Drawing.Color.Transparent;
            this.btn_markdone.BorderRadius = 4;
            this.btn_markdone.CheckedState.Parent = this.btn_markdone;
            this.btn_markdone.CustomImages.Parent = this.btn_markdone;
            this.btn_markdone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_markdone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_markdone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_markdone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_markdone.DisabledState.Parent = this.btn_markdone;
            this.btn_markdone.FillColor = System.Drawing.Color.Red;
            this.btn_markdone.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_markdone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_markdone.ForeColor = System.Drawing.Color.White;
            this.btn_markdone.HoverState.Parent = this.btn_markdone;
            this.btn_markdone.Location = new System.Drawing.Point(370, 64);
            this.btn_markdone.Name = "btn_markdone";
            this.btn_markdone.ShadowDecoration.Parent = this.btn_markdone;
            this.btn_markdone.Size = new System.Drawing.Size(94, 45);
            this.btn_markdone.TabIndex = 10;
            this.btn_markdone.Text = "MARK AS DONE";
            this.btn_markdone.Click += new System.EventHandler(this.btn_markdone_Click);
            this.btn_markdone.DoubleClick += new System.EventHandler(this.btn_markdone_DoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BorderRadius = 4;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.DisabledState.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.Red;
            this.btn_save.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(370, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(94, 45);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "SAVE";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_markasdone
            // 
            this.lbl_markasdone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_markasdone.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_markasdone.Location = new System.Drawing.Point(290, 327);
            this.lbl_markasdone.Name = "lbl_markasdone";
            this.lbl_markasdone.Size = new System.Drawing.Size(131, 29);
            this.lbl_markasdone.TabIndex = 6;
            this.lbl_markasdone.Text = "Is it done?";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(290, 398);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(75, 29);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "When:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 292);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(149, 29);
            this.guna2HtmlLabel5.TabIndex = 7;
            this.guna2HtmlLabel5.Text = "Description:";
            // 
            // btn_addnew
            // 
            this.btn_addnew.BackColor = System.Drawing.Color.Transparent;
            this.btn_addnew.BorderRadius = 4;
            this.btn_addnew.CheckedState.Parent = this.btn_addnew;
            this.btn_addnew.CustomImages.Parent = this.btn_addnew;
            this.btn_addnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addnew.DisabledState.Parent = this.btn_addnew;
            this.btn_addnew.FillColor = System.Drawing.Color.Red;
            this.btn_addnew.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_addnew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addnew.ForeColor = System.Drawing.Color.White;
            this.btn_addnew.HoverState.Parent = this.btn_addnew;
            this.btn_addnew.Location = new System.Drawing.Point(370, 13);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.ShadowDecoration.Parent = this.btn_addnew;
            this.btn_addnew.Size = new System.Drawing.Size(94, 45);
            this.btn_addnew.TabIndex = 10;
            this.btn_addnew.Text = "ADD NEW";
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 222);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(65, 29);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "Title:";
            // 
            // todolist_datagrid
            // 
            this.todolist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todolist_datagrid.Location = new System.Drawing.Point(12, 12);
            this.todolist_datagrid.Name = "todolist_datagrid";
            this.todolist_datagrid.Size = new System.Drawing.Size(331, 202);
            this.todolist_datagrid.TabIndex = 0;
            this.todolist_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todolist_datagrid_CellDoubleClick);
            // 
            // tb_title_changes
            // 
            this.tb_title_changes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_title_changes.BorderColor = System.Drawing.Color.Transparent;
            this.tb_title_changes.BorderRadius = 4;
            this.tb_title_changes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_title_changes.DefaultText = "";
            this.tb_title_changes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_title_changes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_title_changes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_title_changes.DisabledState.Parent = this.tb_title_changes;
            this.tb_title_changes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_title_changes.FillColor = System.Drawing.Color.Azure;
            this.tb_title_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_title_changes.FocusedState.Parent = this.tb_title_changes;
            this.tb_title_changes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tb_title_changes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_title_changes.HoverState.Parent = this.tb_title_changes;
            this.tb_title_changes.Location = new System.Drawing.Point(12, 252);
            this.tb_title_changes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_title_changes.Name = "tb_title_changes";
            this.tb_title_changes.PasswordChar = '\0';
            this.tb_title_changes.PlaceholderText = "Title";
            this.tb_title_changes.SelectedText = "";
            this.tb_title_changes.ShadowDecoration.Parent = this.tb_title_changes;
            this.tb_title_changes.Size = new System.Drawing.Size(261, 36);
            this.tb_title_changes.TabIndex = 5;
            // 
            // cmb_task_status
            // 
            this.cmb_task_status.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmb_task_status.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_task_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_task_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_task_status.FillColor = System.Drawing.Color.Azure;
            this.cmb_task_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_task_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_task_status.FocusedState.Parent = this.cmb_task_status;
            this.cmb_task_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_task_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_task_status.HoverState.Parent = this.cmb_task_status;
            this.cmb_task_status.ItemHeight = 30;
            this.cmb_task_status.Items.AddRange(new object[] {
            "Done",
            "Ongoing",
            "To be done"});
            this.cmb_task_status.ItemsAppearance.Parent = this.cmb_task_status;
            this.cmb_task_status.Location = new System.Drawing.Point(290, 362);
            this.cmb_task_status.Name = "cmb_task_status";
            this.cmb_task_status.ShadowDecoration.Parent = this.cmb_task_status;
            this.cmb_task_status.Size = new System.Drawing.Size(172, 36);
            this.cmb_task_status.TabIndex = 9;
            // 
            // cmb_when_changes
            // 
            this.cmb_when_changes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmb_when_changes.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_when_changes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_when_changes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_when_changes.FillColor = System.Drawing.Color.Azure;
            this.cmb_when_changes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_when_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_when_changes.FocusedState.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_when_changes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_when_changes.HoverState.Parent = this.cmb_when_changes;
            this.cmb_when_changes.ItemHeight = 30;
            this.cmb_when_changes.Items.AddRange(new object[] {
            "Today",
            "Tomorrow",
            "Upcoming",
            "Someday"});
            this.cmb_when_changes.ItemsAppearance.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Location = new System.Drawing.Point(290, 433);
            this.cmb_when_changes.Name = "cmb_when_changes";
            this.cmb_when_changes.ShadowDecoration.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Size = new System.Drawing.Size(172, 36);
            this.cmb_when_changes.TabIndex = 9;
            // 
            // tb_desc_changes
            // 
            this.tb_desc_changes.BackColor = System.Drawing.Color.Silver;
            this.tb_desc_changes.BorderColor = System.Drawing.Color.Transparent;
            this.tb_desc_changes.BorderRadius = 4;
            this.tb_desc_changes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_desc_changes.DefaultText = "";
            this.tb_desc_changes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_desc_changes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_desc_changes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc_changes.DisabledState.Parent = this.tb_desc_changes;
            this.tb_desc_changes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc_changes.FillColor = System.Drawing.Color.Azure;
            this.tb_desc_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_desc_changes.FocusedState.Parent = this.tb_desc_changes;
            this.tb_desc_changes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_desc_changes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_desc_changes.HoverState.Parent = this.tb_desc_changes;
            this.tb_desc_changes.Location = new System.Drawing.Point(12, 327);
            this.tb_desc_changes.Multiline = true;
            this.tb_desc_changes.Name = "tb_desc_changes";
            this.tb_desc_changes.PasswordChar = '\0';
            this.tb_desc_changes.PlaceholderText = "Description";
            this.tb_desc_changes.SelectedText = "";
            this.tb_desc_changes.ShadowDecoration.Parent = this.tb_desc_changes;
            this.tb_desc_changes.Size = new System.Drawing.Size(261, 132);
            this.tb_desc_changes.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 29);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Title:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(19, 107);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(149, 29);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Description:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 261);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 29);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "When:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BorderRadius = 4;
            this.btn_clear.CheckedState.Parent = this.btn_clear;
            this.btn_clear.CustomImages.Parent = this.btn_clear;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.DisabledState.Parent = this.btn_clear;
            this.btn_clear.FillColor = System.Drawing.Color.Red;
            this.btn_clear.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(368, 276);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(94, 45);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(507, 520);
            this.Controls.Add(this.dataGridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.dataGridPanel.ResumeLayout(false);
            this.dataGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dataGridPanel;
        private System.Windows.Forms.TextBox tb_id;
        private Guna.UI2.WinForms.Guna2Button btn_Task;
        private Guna.UI2.WinForms.Guna2Button btn_taskfinished;
        private Guna.UI2.WinForms.Guna2Button btn_markdone;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_markasdone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btn_addnew;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.DataGridView todolist_datagrid;
        private Guna.UI2.WinForms.Guna2TextBox tb_title_changes;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_task_status;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_when_changes;
        private Guna.UI2.WinForms.Guna2TextBox tb_desc_changes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
    }
}

