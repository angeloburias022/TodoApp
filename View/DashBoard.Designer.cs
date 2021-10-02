
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
            this.rd_notDone = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rd_done = new Guna.UI2.WinForms.Guna2RadioButton();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.todolist_datagrid = new System.Windows.Forms.DataGridView();
            this.tb_title_changes = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_two = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cmb_one = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_when_changes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tb_desc_changes = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_start = new Guna.UI2.WinForms.Guna2Button();
            this.btn_stop = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridPanel.Controls.Add(this.panel1);
            this.dataGridPanel.Controls.Add(this.rd_notDone);
            this.dataGridPanel.Controls.Add(this.rd_done);
            this.dataGridPanel.Controls.Add(this.tb_id);
            this.dataGridPanel.Controls.Add(this.btn_delete);
            this.dataGridPanel.Controls.Add(this.btn_clear);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel6);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel9);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel5);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel7);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel8);
            this.dataGridPanel.Controls.Add(this.guna2HtmlLabel4);
            this.dataGridPanel.Controls.Add(this.todolist_datagrid);
            this.dataGridPanel.Controls.Add(this.tb_title_changes);
            this.dataGridPanel.Controls.Add(this.cmb_two);
            this.dataGridPanel.Controls.Add(this.Cmb_one);
            this.dataGridPanel.Controls.Add(this.cmb_when_changes);
            this.dataGridPanel.Controls.Add(this.tb_desc_changes);
            this.dataGridPanel.Location = new System.Drawing.Point(22, 15);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.ShadowDecoration.Parent = this.dataGridPanel;
            this.dataGridPanel.Size = new System.Drawing.Size(500, 479);
            this.dataGridPanel.TabIndex = 1;
            // 
            // rd_notDone
            // 
            this.rd_notDone.AutoSize = true;
            this.rd_notDone.Checked = true;
            this.rd_notDone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_notDone.CheckedState.BorderThickness = 0;
            this.rd_notDone.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rd_notDone.CheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rd_notDone.CheckedState.InnerOffset = -4;
            this.rd_notDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rd_notDone.Location = new System.Drawing.Point(290, 349);
            this.rd_notDone.Name = "rd_notDone";
            this.rd_notDone.Size = new System.Drawing.Size(141, 33);
            this.rd_notDone.TabIndex = 12;
            this.rd_notDone.TabStop = true;
            this.rd_notDone.Text = "Not Done";
            this.rd_notDone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd_notDone.UncheckedState.BorderThickness = 2;
            this.rd_notDone.UncheckedState.FillColor = System.Drawing.Color.Snow;
            this.rd_notDone.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // rd_done
            // 
            this.rd_done.AutoSize = true;
            this.rd_done.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rd_done.CheckedState.BorderThickness = 0;
            this.rd_done.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rd_done.CheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rd_done.CheckedState.InnerOffset = -4;
            this.rd_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rd_done.Location = new System.Drawing.Point(290, 319);
            this.rd_done.Name = "rd_done";
            this.rd_done.Size = new System.Drawing.Size(93, 33);
            this.rd_done.TabIndex = 12;
            this.rd_done.Text = "Done";
            this.rd_done.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rd_done.UncheckedState.BorderThickness = 2;
            this.rd_done.UncheckedState.FillColor = System.Drawing.Color.Snow;
            this.rd_done.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(411, 268);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(51, 20);
            this.tb_id.TabIndex = 11;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 4;
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.DisabledState.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(353, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(136, 36);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_clear.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.HoverState.Parent = this.btn_clear;
            this.btn_clear.Location = new System.Drawing.Point(353, 198);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.ShadowDecoration.Parent = this.btn_clear;
            this.btn_clear.Size = new System.Drawing.Size(136, 36);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(290, 388);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(75, 29);
            this.guna2HtmlLabel6.TabIndex = 6;
            this.guna2HtmlLabel6.Text = "When:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(12, 216);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(65, 29);
            this.guna2HtmlLabel9.TabIndex = 7;
            this.guna2HtmlLabel9.Text = "Title:";
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
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(302, 259);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(102, 29);
            this.guna2HtmlLabel7.TabIndex = 8;
            this.guna2HtmlLabel7.Text = "Task ID:";
            this.guna2HtmlLabel7.Visible = false;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(388, 85);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(64, 26);
            this.guna2HtmlLabel8.TabIndex = 8;
            this.guna2HtmlLabel8.Text = "TASK";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(361, 14);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(128, 26);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "ADD/SAVE";
            // 
            // todolist_datagrid
            // 
            this.todolist_datagrid.AllowUserToAddRows = false;
            this.todolist_datagrid.AllowUserToDeleteRows = false;
            this.todolist_datagrid.AllowUserToOrderColumns = true;
            this.todolist_datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.todolist_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todolist_datagrid.Location = new System.Drawing.Point(12, 14);
            this.todolist_datagrid.Name = "todolist_datagrid";
            this.todolist_datagrid.ReadOnly = true;
            this.todolist_datagrid.Size = new System.Drawing.Size(331, 204);
            this.todolist_datagrid.TabIndex = 0;
            this.todolist_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todolist_datagrid_CellClick);
            this.todolist_datagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todolist_datagrid_CellDoubleClick);
            // 
            // tb_title_changes
            // 
            this.tb_title_changes.BackColor = System.Drawing.Color.Transparent;
            this.tb_title_changes.BorderColor = System.Drawing.Color.Transparent;
            this.tb_title_changes.BorderRadius = 4;
            this.tb_title_changes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_title_changes.DefaultText = "";
            this.tb_title_changes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_title_changes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_title_changes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_title_changes.DisabledState.Parent = this.tb_title_changes;
            this.tb_title_changes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_title_changes.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_title_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_title_changes.FocusedState.Parent = this.tb_title_changes;
            this.tb_title_changes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tb_title_changes.ForeColor = System.Drawing.Color.White;
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
            // cmb_two
            // 
            this.cmb_two.BackColor = System.Drawing.Color.Transparent;
            this.cmb_two.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_two.BorderRadius = 4;
            this.cmb_two.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_two.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_two.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_two.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_two.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_two.FocusedState.Parent = this.cmb_two;
            this.cmb_two.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_two.ForeColor = System.Drawing.Color.White;
            this.cmb_two.HoverState.Parent = this.cmb_two;
            this.cmb_two.ItemHeight = 30;
            this.cmb_two.Items.AddRange(new object[] {
            "COMPLETED",
            "TASK"});
            this.cmb_two.ItemsAppearance.Parent = this.cmb_two;
            this.cmb_two.Location = new System.Drawing.Point(353, 114);
            this.cmb_two.Name = "cmb_two";
            this.cmb_two.ShadowDecoration.Parent = this.cmb_two;
            this.cmb_two.Size = new System.Drawing.Size(136, 36);
            this.cmb_two.TabIndex = 9;
            this.cmb_two.SelectedIndexChanged += new System.EventHandler(this.cmb_two_SelectedIndexChanged);
            // 
            // Cmb_one
            // 
            this.Cmb_one.BackColor = System.Drawing.Color.Transparent;
            this.Cmb_one.BorderColor = System.Drawing.Color.Transparent;
            this.Cmb_one.BorderRadius = 4;
            this.Cmb_one.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Cmb_one.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_one.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cmb_one.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_one.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cmb_one.FocusedState.Parent = this.Cmb_one;
            this.Cmb_one.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Cmb_one.ForeColor = System.Drawing.Color.White;
            this.Cmb_one.HoverState.Parent = this.Cmb_one;
            this.Cmb_one.ItemHeight = 30;
            this.Cmb_one.Items.AddRange(new object[] {
            "ADD",
            "SAVE"});
            this.Cmb_one.ItemsAppearance.Parent = this.Cmb_one;
            this.Cmb_one.Location = new System.Drawing.Point(353, 43);
            this.Cmb_one.Name = "Cmb_one";
            this.Cmb_one.ShadowDecoration.Parent = this.Cmb_one;
            this.Cmb_one.Size = new System.Drawing.Size(136, 36);
            this.Cmb_one.TabIndex = 9;
            this.Cmb_one.SelectedIndexChanged += new System.EventHandler(this.Cmb_one_SelectedIndexChanged);
            // 
            // cmb_when_changes
            // 
            this.cmb_when_changes.BackColor = System.Drawing.Color.Transparent;
            this.cmb_when_changes.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_when_changes.BorderRadius = 4;
            this.cmb_when_changes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_when_changes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_when_changes.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmb_when_changes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_when_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_when_changes.FocusedState.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_when_changes.ForeColor = System.Drawing.Color.White;
            this.cmb_when_changes.HoverState.Parent = this.cmb_when_changes;
            this.cmb_when_changes.ItemHeight = 30;
            this.cmb_when_changes.Items.AddRange(new object[] {
            "Today",
            "Tomorrow",
            "Upcoming",
            "Someday"});
            this.cmb_when_changes.ItemsAppearance.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Location = new System.Drawing.Point(290, 423);
            this.cmb_when_changes.Name = "cmb_when_changes";
            this.cmb_when_changes.ShadowDecoration.Parent = this.cmb_when_changes;
            this.cmb_when_changes.Size = new System.Drawing.Size(199, 36);
            this.cmb_when_changes.TabIndex = 9;
            // 
            // tb_desc_changes
            // 
            this.tb_desc_changes.BackColor = System.Drawing.Color.Transparent;
            this.tb_desc_changes.BorderColor = System.Drawing.Color.Transparent;
            this.tb_desc_changes.BorderRadius = 4;
            this.tb_desc_changes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_desc_changes.DefaultText = "";
            this.tb_desc_changes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_desc_changes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_desc_changes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc_changes.DisabledState.Parent = this.tb_desc_changes;
            this.tb_desc_changes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_desc_changes.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_desc_changes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_desc_changes.FocusedState.Parent = this.tb_desc_changes;
            this.tb_desc_changes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desc_changes.ForeColor = System.Drawing.Color.White;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.guna2TextBox2);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Location = new System.Drawing.Point(36, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 221);
            this.panel1.TabIndex = 13;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox2.BorderRadius = 8;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(113, 83);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "      0:00";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(98, 36);
            this.guna2TextBox2.TabIndex = 5;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BorderRadius = 4;
            this.btn_start.CheckedState.Parent = this.btn_start;
            this.btn_start.CustomImages.Parent = this.btn_start;
            this.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_start.DisabledState.Parent = this.btn_start;
            this.btn_start.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_start.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.HoverState.Parent = this.btn_start;
            this.btn_start.Location = new System.Drawing.Point(52, 136);
            this.btn_start.Name = "btn_start";
            this.btn_start.ShadowDecoration.Parent = this.btn_start;
            this.btn_start.Size = new System.Drawing.Size(97, 36);
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "START";
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Transparent;
            this.btn_stop.BorderRadius = 4;
            this.btn_stop.CheckedState.Parent = this.btn_stop;
            this.btn_stop.CustomImages.Parent = this.btn_stop;
            this.btn_stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_stop.DisabledState.Parent = this.btn_stop;
            this.btn_stop.FillColor = System.Drawing.Color.Red;
            this.btn_stop.FocusedColor = System.Drawing.Color.LimeGreen;
            this.btn_stop.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.HoverState.Parent = this.btn_stop;
            this.btn_stop.Location = new System.Drawing.Point(176, 136);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.ShadowDecoration.Parent = this.btn_stop;
            this.btn_stop.Size = new System.Drawing.Size(97, 36);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "STOP";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 4;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(28, 16);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "TASK";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(262, 36);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(547, 506);
            this.Controls.Add(this.dataGridPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toudo App";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DashBoard_Paint);
            this.dataGridPanel.ResumeLayout(false);
            this.dataGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todolist_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel dataGridPanel;
        private System.Windows.Forms.TextBox tb_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private System.Windows.Forms.DataGridView todolist_datagrid;
        private Guna.UI2.WinForms.Guna2TextBox tb_title_changes;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_when_changes;
        private Guna.UI2.WinForms.Guna2TextBox tb_desc_changes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2RadioButton rd_done;
        private Guna.UI2.WinForms.Guna2RadioButton rd_notDone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_two;
        private Guna.UI2.WinForms.Guna2ComboBox Cmb_one;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button btn_stop;
        private Guna.UI2.WinForms.Guna2Button btn_start;
    }
}

