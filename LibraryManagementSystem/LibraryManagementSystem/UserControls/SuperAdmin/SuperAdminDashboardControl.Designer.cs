namespace LibraryManagementSystem.UserControls.SuperAdmin
{
    partial class SuperAdminDashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelManageAdmin = new Panel();
            panelMLHeader = new Panel();
            textBoxMAPassword = new TextBox();
            textBoxMAUsername = new TextBox();
            textBoxMAFullname = new TextBox();
            buttonMLAddAdmin = new Button();
            buttonMLRemove = new Button();
            dgvManageAdmin = new DataGridView();
            panelSystemLogs = new Panel();
            dgvSystemLogs = new DataGridView();
            buttonManageAdmin = new Button();
            buttonSystemLog = new Button();
            buttonLogout = new Button();
            labelSuperAdmin = new Label();
            labelLibraryManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelHeader = new Panel();
            panelManageAdmin.SuspendLayout();
            panelMLHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageAdmin).BeginInit();
            panelSystemLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSystemLogs).BeginInit();
            tableLayoutPanelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelManageAdmin
            // 
            panelManageAdmin.Controls.Add(panelMLHeader);
            panelManageAdmin.Controls.Add(dgvManageAdmin);
            panelManageAdmin.Location = new Point(0, 109);
            panelManageAdmin.Name = "panelManageAdmin";
            panelManageAdmin.Size = new Size(940, 480);
            panelManageAdmin.TabIndex = 26;
            // 
            // panelMLHeader
            // 
            panelMLHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMLHeader.Controls.Add(textBoxMAPassword);
            panelMLHeader.Controls.Add(textBoxMAUsername);
            panelMLHeader.Controls.Add(textBoxMAFullname);
            panelMLHeader.Controls.Add(buttonMLAddAdmin);
            panelMLHeader.Controls.Add(buttonMLRemove);
            panelMLHeader.Location = new Point(0, 6);
            panelMLHeader.Name = "panelMLHeader";
            panelMLHeader.Size = new Size(928, 115);
            panelMLHeader.TabIndex = 18;
            // 
            // textBoxMAPassword
            // 
            textBoxMAPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMAPassword.ForeColor = SystemColors.InactiveCaption;
            textBoxMAPassword.Location = new Point(335, 66);
            textBoxMAPassword.Name = "textBoxMAPassword";
            textBoxMAPassword.Size = new Size(221, 29);
            textBoxMAPassword.TabIndex = 23;
            textBoxMAPassword.Text = "Password";
            textBoxMAPassword.Enter += textBoxMAPassword_Enter;
            // 
            // textBoxMAUsername
            // 
            textBoxMAUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMAUsername.ForeColor = SystemColors.InactiveCaption;
            textBoxMAUsername.Location = new Point(58, 66);
            textBoxMAUsername.Name = "textBoxMAUsername";
            textBoxMAUsername.Size = new Size(221, 29);
            textBoxMAUsername.TabIndex = 22;
            textBoxMAUsername.Text = "Username";
            textBoxMAUsername.Enter += textBoxMAUsername_Enter;
            // 
            // textBoxMAFullname
            // 
            textBoxMAFullname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMAFullname.ForeColor = SystemColors.InactiveCaption;
            textBoxMAFullname.Location = new Point(198, 13);
            textBoxMAFullname.Name = "textBoxMAFullname";
            textBoxMAFullname.Size = new Size(221, 29);
            textBoxMAFullname.TabIndex = 21;
            textBoxMAFullname.Text = "Full Name";
            textBoxMAFullname.Enter += textBoxMAFullname_Enter;
            // 
            // buttonMLAddAdmin
            // 
            buttonMLAddAdmin.Anchor = AnchorStyles.None;
            buttonMLAddAdmin.BackColor = Color.Ivory;
            buttonMLAddAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMLAddAdmin.ForeColor = SystemColors.Desktop;
            buttonMLAddAdmin.Location = new Point(711, 17);
            buttonMLAddAdmin.Name = "buttonMLAddAdmin";
            buttonMLAddAdmin.Size = new Size(131, 31);
            buttonMLAddAdmin.TabIndex = 20;
            buttonMLAddAdmin.Text = "Add Admin";
            buttonMLAddAdmin.UseVisualStyleBackColor = false;
            buttonMLAddAdmin.Click += buttonMLAddAdmin_Click;
            // 
            // buttonMLRemove
            // 
            buttonMLRemove.Anchor = AnchorStyles.None;
            buttonMLRemove.BackColor = Color.Ivory;
            buttonMLRemove.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMLRemove.ForeColor = SystemColors.Desktop;
            buttonMLRemove.Location = new Point(711, 64);
            buttonMLRemove.Name = "buttonMLRemove";
            buttonMLRemove.Size = new Size(131, 31);
            buttonMLRemove.TabIndex = 18;
            buttonMLRemove.Text = "Remove";
            buttonMLRemove.UseVisualStyleBackColor = false;
            buttonMLRemove.Click += buttonMLRemove_Click_1;
            // 
            // dgvManageAdmin
            // 
            dgvManageAdmin.AllowUserToAddRows = false;
            dgvManageAdmin.AllowUserToDeleteRows = false;
            dgvManageAdmin.AllowUserToResizeColumns = false;
            dgvManageAdmin.AllowUserToResizeRows = false;
            dgvManageAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageAdmin.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageAdmin.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageAdmin.Location = new Point(0, 127);
            dgvManageAdmin.MultiSelect = false;
            dgvManageAdmin.Name = "dgvManageAdmin";
            dgvManageAdmin.ReadOnly = true;
            dgvManageAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageAdmin.Size = new Size(928, 353);
            dgvManageAdmin.TabIndex = 19;
            // 
            // panelSystemLogs
            // 
            panelSystemLogs.Controls.Add(dgvSystemLogs);
            panelSystemLogs.Location = new Point(0, 109);
            panelSystemLogs.Name = "panelSystemLogs";
            panelSystemLogs.Size = new Size(940, 480);
            panelSystemLogs.TabIndex = 27;
            // 
            // dgvSystemLogs
            // 
            dgvSystemLogs.AllowUserToAddRows = false;
            dgvSystemLogs.AllowUserToDeleteRows = false;
            dgvSystemLogs.AllowUserToResizeColumns = false;
            dgvSystemLogs.AllowUserToResizeRows = false;
            dgvSystemLogs.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvSystemLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSystemLogs.BackgroundColor = SystemColors.ControlLightLight;
            dgvSystemLogs.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvSystemLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSystemLogs.Location = new Point(1, 9);
            dgvSystemLogs.MultiSelect = false;
            dgvSystemLogs.Name = "dgvSystemLogs";
            dgvSystemLogs.ReadOnly = true;
            dgvSystemLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSystemLogs.Size = new Size(927, 472);
            dgvSystemLogs.TabIndex = 19;
            // 
            // buttonManageAdmin
            // 
            buttonManageAdmin.Anchor = AnchorStyles.None;
            buttonManageAdmin.BackColor = Color.SteelBlue;
            buttonManageAdmin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageAdmin.ForeColor = SystemColors.ControlLightLight;
            buttonManageAdmin.Location = new Point(3, 3);
            buttonManageAdmin.Name = "buttonManageAdmin";
            buttonManageAdmin.Size = new Size(464, 44);
            buttonManageAdmin.TabIndex = 3;
            buttonManageAdmin.Text = "Manage Admin";
            buttonManageAdmin.UseVisualStyleBackColor = false;
            buttonManageAdmin.Click += buttonManageAdmin_Click;
            // 
            // buttonSystemLog
            // 
            buttonSystemLog.Anchor = AnchorStyles.None;
            buttonSystemLog.BackColor = Color.SteelBlue;
            buttonSystemLog.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSystemLog.ForeColor = SystemColors.ControlLightLight;
            buttonSystemLog.Location = new Point(473, 3);
            buttonSystemLog.Name = "buttonSystemLog";
            buttonSystemLog.Size = new Size(464, 44);
            buttonSystemLog.TabIndex = 4;
            buttonSystemLog.Text = "System Log";
            buttonSystemLog.UseVisualStyleBackColor = false;
            buttonSystemLog.Click += buttonSystemLog_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.None;
            buttonLogout.BackColor = Color.DodgerBlue;
            buttonLogout.BackgroundImageLayout = ImageLayout.None;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = SystemColors.ControlLightLight;
            buttonLogout.Location = new Point(835, 10);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // labelSuperAdmin
            // 
            labelSuperAdmin.Anchor = AnchorStyles.None;
            labelSuperAdmin.AutoSize = true;
            labelSuperAdmin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuperAdmin.ForeColor = SystemColors.ControlLightLight;
            labelSuperAdmin.Location = new Point(472, 12);
            labelSuperAdmin.Margin = new Padding(5, 0, 5, 0);
            labelSuperAdmin.Name = "labelSuperAdmin";
            labelSuperAdmin.Size = new Size(154, 31);
            labelSuperAdmin.TabIndex = 11;
            labelSuperAdmin.Text = "Super Admin";
            // 
            // labelLibraryManagement
            // 
            labelLibraryManagement.Anchor = AnchorStyles.None;
            labelLibraryManagement.AutoSize = true;
            labelLibraryManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryManagement.ForeColor = SystemColors.ControlLightLight;
            labelLibraryManagement.Location = new Point(5, 12);
            labelLibraryManagement.Margin = new Padding(5, 0, 5, 0);
            labelLibraryManagement.Name = "labelLibraryManagement";
            labelLibraryManagement.Size = new Size(315, 31);
            labelLibraryManagement.TabIndex = 10;
            labelLibraryManagement.Text = "Library Management System";
            // 
            // tableLayoutPanelMenu
            // 
            tableLayoutPanelMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMenu.BackColor = Color.DodgerBlue;
            tableLayoutPanelMenu.ColumnCount = 2;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.Controls.Add(buttonManageAdmin, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonSystemLog, 1, 0);
            tableLayoutPanelMenu.Location = new Point(0, 59);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(940, 50);
            tableLayoutPanelMenu.TabIndex = 23;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelSuperAdmin);
            panelHeader.Controls.Add(labelLibraryManagement);
            panelHeader.Location = new Point(0, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(940, 58);
            panelHeader.TabIndex = 22;
            // 
            // SuperAdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelManageAdmin);
            Controls.Add(panelSystemLogs);
            Name = "SuperAdminDashboardControl";
            Size = new Size(940, 590);
            panelManageAdmin.ResumeLayout(false);
            panelMLHeader.ResumeLayout(false);
            panelMLHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageAdmin).EndInit();
            panelSystemLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSystemLogs).EndInit();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelRStartDate;
        private Panel panelManageAdmin;
        private Panel panelMLHeader;
        private TextBox textBoxMAPassword;
        private TextBox textBoxMAUsername;
        private TextBox textBoxMAFullname;
        private Button buttonMLAddAdmin;
        private Button buttonMLRemove;
        private DataGridView dgvManageAdmin;
        private Panel panelSystemLogs;
        private Panel panelRHeader;
        private Button buttonRFilter;
        private DateTimePicker dateTimePickerREnd;
        private DateTimePicker dateTimePickerRStart;
        private Label labelREndDate;
        private DataGridView dgvSystemLogs;
        private Button buttonManageAdmin;
        private Button buttonSystemLog;
        private Button buttonLogout;
        private Label labelSuperAdmin;
        private Label labelLibraryManagement;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelHeader;
    }
}
