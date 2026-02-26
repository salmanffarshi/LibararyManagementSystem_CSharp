namespace LibraryManagementSystem.UserControls.Admin
{
    partial class AdminDashboardControl
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
            buttonViewBooks = new Button();
            buttonManageMembers = new Button();
            buttonReports = new Button();
            buttonManageLibrarian = new Button();
            panelHeader = new Panel();
            buttonLogout = new Button();
            labelAdmin = new Label();
            labelLibraryManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelViewBooks = new Panel();
            panelVBHeader = new Panel();
            labelSearch = new Label();
            buttonSearch = new Button();
            textBoxSearchBook = new TextBox();
            dgvBooks = new DataGridView();
            panelManageStudents = new Panel();
            panelMSHeader = new Panel();
            buttonMMBlock = new Button();
            buttonMMActive = new Button();
            buttonMMSearch = new Button();
            labelMMSearch = new Label();
            textBoxMMUsername = new TextBox();
            dgvManageStudents = new DataGridView();
            panelManageLibrarian = new Panel();
            panelMLHeader = new Panel();
            textBoxMLPassword = new TextBox();
            textBoxMLUsername = new TextBox();
            textBoxMLFullname = new TextBox();
            buttonMLAddLibrarian = new Button();
            buttonMLRemove = new Button();
            dgvManageLibrarian = new DataGridView();
            panelReports = new Panel();
            panelRHeader = new Panel();
            buttonRFilter = new Button();
            dateTimePickerREnd = new DateTimePicker();
            dateTimePickerRStart = new DateTimePicker();
            labelREndDate = new Label();
            labelRStartDate = new Label();
            dgvReports = new DataGridView();
            panelHeader.SuspendLayout();
            tableLayoutPanelMenu.SuspendLayout();
            panelViewBooks.SuspendLayout();
            panelVBHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panelManageStudents.SuspendLayout();
            panelMSHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageStudents).BeginInit();
            panelManageLibrarian.SuspendLayout();
            panelMLHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageLibrarian).BeginInit();
            panelReports.SuspendLayout();
            panelRHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // buttonViewBooks
            // 
            buttonViewBooks.Anchor = AnchorStyles.None;
            buttonViewBooks.BackColor = Color.SteelBlue;
            buttonViewBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewBooks.ForeColor = SystemColors.ControlLightLight;
            buttonViewBooks.Location = new Point(3, 3);
            buttonViewBooks.Name = "buttonViewBooks";
            buttonViewBooks.Size = new Size(229, 44);
            buttonViewBooks.TabIndex = 1;
            buttonViewBooks.Text = "View Books";
            buttonViewBooks.UseVisualStyleBackColor = false;
            buttonViewBooks.Click += buttonViewBooks_Click;
            // 
            // buttonManageMembers
            // 
            buttonManageMembers.Anchor = AnchorStyles.None;
            buttonManageMembers.BackColor = Color.SteelBlue;
            buttonManageMembers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageMembers.ForeColor = SystemColors.ControlLightLight;
            buttonManageMembers.Location = new Point(238, 3);
            buttonManageMembers.Name = "buttonManageMembers";
            buttonManageMembers.Size = new Size(229, 44);
            buttonManageMembers.TabIndex = 2;
            buttonManageMembers.Text = "Manage Students";
            buttonManageMembers.UseVisualStyleBackColor = false;
            buttonManageMembers.Click += buttonManageMembers_Click;
            // 
            // buttonReports
            // 
            buttonReports.Anchor = AnchorStyles.None;
            buttonReports.BackColor = Color.SteelBlue;
            buttonReports.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReports.ForeColor = SystemColors.ControlLightLight;
            buttonReports.Location = new Point(708, 3);
            buttonReports.Name = "buttonReports";
            buttonReports.Size = new Size(229, 44);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "Reports";
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonManageLibrarian
            // 
            buttonManageLibrarian.Anchor = AnchorStyles.None;
            buttonManageLibrarian.BackColor = Color.SteelBlue;
            buttonManageLibrarian.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageLibrarian.ForeColor = SystemColors.ControlLightLight;
            buttonManageLibrarian.Location = new Point(473, 3);
            buttonManageLibrarian.Name = "buttonManageLibrarian";
            buttonManageLibrarian.Size = new Size(229, 44);
            buttonManageLibrarian.TabIndex = 3;
            buttonManageLibrarian.Text = "Manage Librarian";
            buttonManageLibrarian.UseVisualStyleBackColor = false;
            buttonManageLibrarian.Click += buttonManageLibrarian_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelAdmin);
            panelHeader.Controls.Add(labelLibraryManagement);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(940, 58);
            panelHeader.TabIndex = 4;
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
            buttonLogout.Location = new Point(837, 7);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelAdmin
            // 
            labelAdmin.Anchor = AnchorStyles.None;
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = SystemColors.ControlLightLight;
            labelAdmin.Location = new Point(472, 9);
            labelAdmin.Margin = new Padding(5, 0, 5, 0);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(84, 31);
            labelAdmin.TabIndex = 11;
            labelAdmin.Text = "Admin";
            // 
            // labelLibraryManagement
            // 
            labelLibraryManagement.Anchor = AnchorStyles.None;
            labelLibraryManagement.AutoSize = true;
            labelLibraryManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryManagement.ForeColor = SystemColors.ControlLightLight;
            labelLibraryManagement.Location = new Point(5, 9);
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
            tableLayoutPanelMenu.ColumnCount = 4;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelMenu.Controls.Add(buttonManageMembers, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageLibrarian, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonViewBooks, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonReports, 3, 0);
            tableLayoutPanelMenu.Location = new Point(0, 57);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(940, 50);
            tableLayoutPanelMenu.TabIndex = 6;
            // 
            // panelViewBooks
            // 
            panelViewBooks.Controls.Add(panelVBHeader);
            panelViewBooks.Controls.Add(dgvBooks);
            panelViewBooks.Location = new Point(0, 107);
            panelViewBooks.Name = "panelViewBooks";
            panelViewBooks.Size = new Size(940, 480);
            panelViewBooks.TabIndex = 7;
            // 
            // panelVBHeader
            // 
            panelVBHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelVBHeader.Controls.Add(labelSearch);
            panelVBHeader.Controls.Add(buttonSearch);
            panelVBHeader.Controls.Add(textBoxSearchBook);
            panelVBHeader.Location = new Point(1, 5);
            panelVBHeader.Name = "panelVBHeader";
            panelVBHeader.Size = new Size(939, 43);
            panelVBHeader.TabIndex = 17;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.None;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.ForeColor = SystemColors.ActiveCaptionText;
            labelSearch.Location = new Point(223, 8);
            labelSearch.Margin = new Padding(5, 0, 5, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(121, 21);
            labelSearch.TabIndex = 12;
            labelSearch.Text = "Search By ISBN";
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.BackColor = Color.Ivory;
            buttonSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.Desktop;
            buttonSearch.Location = new Point(592, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 31);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearchBook
            // 
            textBoxSearchBook.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearchBook.Location = new Point(351, 6);
            textBoxSearchBook.Name = "textBoxSearchBook";
            textBoxSearchBook.Size = new Size(221, 27);
            textBoxSearchBook.TabIndex = 0;
            textBoxSearchBook.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvBooks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(0, 48);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(934, 435);
            dgvBooks.TabIndex = 18;
            // 
            // panelManageStudents
            // 
            panelManageStudents.Controls.Add(panelMSHeader);
            panelManageStudents.Controls.Add(dgvManageStudents);
            panelManageStudents.Location = new Point(1, 107);
            panelManageStudents.Name = "panelManageStudents";
            panelManageStudents.Size = new Size(936, 480);
            panelManageStudents.TabIndex = 13;
            // 
            // panelMSHeader
            // 
            panelMSHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMSHeader.Controls.Add(buttonMMBlock);
            panelMSHeader.Controls.Add(buttonMMActive);
            panelMSHeader.Controls.Add(buttonMMSearch);
            panelMSHeader.Controls.Add(labelMMSearch);
            panelMSHeader.Controls.Add(textBoxMMUsername);
            panelMSHeader.Location = new Point(0, 3);
            panelMSHeader.Name = "panelMSHeader";
            panelMSHeader.Size = new Size(936, 43);
            panelMSHeader.TabIndex = 18;
            // 
            // buttonMMBlock
            // 
            buttonMMBlock.Anchor = AnchorStyles.None;
            buttonMMBlock.BackColor = Color.Ivory;
            buttonMMBlock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMMBlock.ForeColor = SystemColors.Desktop;
            buttonMMBlock.Location = new Point(768, 5);
            buttonMMBlock.Name = "buttonMMBlock";
            buttonMMBlock.Size = new Size(131, 31);
            buttonMMBlock.TabIndex = 16;
            buttonMMBlock.Text = "Block";
            buttonMMBlock.UseVisualStyleBackColor = false;
            buttonMMBlock.Click += buttonMMBlock_Click;
            // 
            // buttonMMActive
            // 
            buttonMMActive.Anchor = AnchorStyles.None;
            buttonMMActive.BackColor = Color.Ivory;
            buttonMMActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMMActive.ForeColor = SystemColors.Desktop;
            buttonMMActive.Location = new Point(622, 5);
            buttonMMActive.Name = "buttonMMActive";
            buttonMMActive.Size = new Size(131, 31);
            buttonMMActive.TabIndex = 15;
            buttonMMActive.Text = "Active";
            buttonMMActive.UseVisualStyleBackColor = false;
            buttonMMActive.Click += buttonMMActive_Click;
            // 
            // buttonMMSearch
            // 
            buttonMMSearch.Anchor = AnchorStyles.None;
            buttonMMSearch.BackColor = Color.Ivory;
            buttonMMSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMMSearch.ForeColor = SystemColors.Desktop;
            buttonMMSearch.Location = new Point(470, 5);
            buttonMMSearch.Name = "buttonMMSearch";
            buttonMMSearch.Size = new Size(131, 31);
            buttonMMSearch.TabIndex = 14;
            buttonMMSearch.Text = "Search";
            buttonMMSearch.UseVisualStyleBackColor = false;
            buttonMMSearch.Click += buttonMMSearch_Click;
            // 
            // labelMMSearch
            // 
            labelMMSearch.Anchor = AnchorStyles.None;
            labelMMSearch.AutoSize = true;
            labelMMSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMMSearch.ForeColor = SystemColors.ActiveCaptionText;
            labelMMSearch.Location = new Point(57, 9);
            labelMMSearch.Margin = new Padding(5, 0, 5, 0);
            labelMMSearch.Name = "labelMMSearch";
            labelMMSearch.Size = new Size(125, 21);
            labelMMSearch.TabIndex = 13;
            labelMMSearch.Text = "Search Student:";
            // 
            // textBoxMMUsername
            // 
            textBoxMMUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMMUsername.Location = new Point(224, 7);
            textBoxMMUsername.Name = "textBoxMMUsername";
            textBoxMMUsername.Size = new Size(221, 27);
            textBoxMMUsername.TabIndex = 0;
            textBoxMMUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvManageStudents
            // 
            dgvManageStudents.AllowUserToAddRows = false;
            dgvManageStudents.AllowUserToDeleteRows = false;
            dgvManageStudents.AllowUserToResizeColumns = false;
            dgvManageStudents.AllowUserToResizeRows = false;
            dgvManageStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageStudents.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageStudents.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageStudents.Location = new Point(2, 45);
            dgvManageStudents.MultiSelect = false;
            dgvManageStudents.Name = "dgvManageStudents";
            dgvManageStudents.ReadOnly = true;
            dgvManageStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageStudents.Size = new Size(934, 435);
            dgvManageStudents.TabIndex = 19;
            // 
            // panelManageLibrarian
            // 
            panelManageLibrarian.Controls.Add(panelMLHeader);
            panelManageLibrarian.Controls.Add(dgvManageLibrarian);
            panelManageLibrarian.Location = new Point(0, 107);
            panelManageLibrarian.Name = "panelManageLibrarian";
            panelManageLibrarian.Size = new Size(940, 480);
            panelManageLibrarian.TabIndex = 20;
            // 
            // panelMLHeader
            // 
            panelMLHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMLHeader.Controls.Add(textBoxMLPassword);
            panelMLHeader.Controls.Add(textBoxMLUsername);
            panelMLHeader.Controls.Add(textBoxMLFullname);
            panelMLHeader.Controls.Add(buttonMLAddLibrarian);
            panelMLHeader.Controls.Add(buttonMLRemove);
            panelMLHeader.Location = new Point(0, 6);
            panelMLHeader.Name = "panelMLHeader";
            panelMLHeader.Size = new Size(934, 115);
            panelMLHeader.TabIndex = 18;
            // 
            // textBoxMLPassword
            // 
            textBoxMLPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMLPassword.ForeColor = SystemColors.InactiveCaption;
            textBoxMLPassword.Location = new Point(335, 66);
            textBoxMLPassword.Name = "textBoxMLPassword";
            textBoxMLPassword.Size = new Size(221, 29);
            textBoxMLPassword.TabIndex = 23;
            textBoxMLPassword.Text = "Password";
            textBoxMLPassword.Enter += textBoxMLPassword_Enter;
            // 
            // textBoxMLUsername
            // 
            textBoxMLUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMLUsername.ForeColor = SystemColors.InactiveCaption;
            textBoxMLUsername.Location = new Point(58, 66);
            textBoxMLUsername.Name = "textBoxMLUsername";
            textBoxMLUsername.Size = new Size(221, 29);
            textBoxMLUsername.TabIndex = 22;
            textBoxMLUsername.Text = "Username";
            textBoxMLUsername.Enter += textBoxMLUsername_Enter;
            // 
            // textBoxMLFullname
            // 
            textBoxMLFullname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMLFullname.ForeColor = SystemColors.InactiveCaption;
            textBoxMLFullname.Location = new Point(198, 13);
            textBoxMLFullname.Name = "textBoxMLFullname";
            textBoxMLFullname.Size = new Size(221, 29);
            textBoxMLFullname.TabIndex = 21;
            textBoxMLFullname.Text = "Full Name";
            textBoxMLFullname.Enter += textBoxMLFullname_Enter;
            // 
            // buttonMLAddLibrarian
            // 
            buttonMLAddLibrarian.Anchor = AnchorStyles.None;
            buttonMLAddLibrarian.BackColor = Color.Ivory;
            buttonMLAddLibrarian.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMLAddLibrarian.ForeColor = SystemColors.Desktop;
            buttonMLAddLibrarian.Location = new Point(672, 4);
            buttonMLAddLibrarian.Name = "buttonMLAddLibrarian";
            buttonMLAddLibrarian.Size = new Size(131, 31);
            buttonMLAddLibrarian.TabIndex = 20;
            buttonMLAddLibrarian.Text = "Add Librarian";
            buttonMLAddLibrarian.UseVisualStyleBackColor = false;
            buttonMLAddLibrarian.Click += buttonMLAddLibrarian_Click;
            // 
            // buttonMLRemove
            // 
            buttonMLRemove.Anchor = AnchorStyles.None;
            buttonMLRemove.BackColor = Color.Ivory;
            buttonMLRemove.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMLRemove.ForeColor = SystemColors.Desktop;
            buttonMLRemove.Location = new Point(672, 57);
            buttonMLRemove.Name = "buttonMLRemove";
            buttonMLRemove.Size = new Size(131, 31);
            buttonMLRemove.TabIndex = 18;
            buttonMLRemove.Text = "Remove";
            buttonMLRemove.UseVisualStyleBackColor = false;
            buttonMLRemove.Click += buttonMLRemove_Click;
            // 
            // dgvManageLibrarian
            // 
            dgvManageLibrarian.AllowUserToAddRows = false;
            dgvManageLibrarian.AllowUserToDeleteRows = false;
            dgvManageLibrarian.AllowUserToResizeColumns = false;
            dgvManageLibrarian.AllowUserToResizeRows = false;
            dgvManageLibrarian.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageLibrarian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageLibrarian.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageLibrarian.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageLibrarian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageLibrarian.Location = new Point(0, 127);
            dgvManageLibrarian.MultiSelect = false;
            dgvManageLibrarian.Name = "dgvManageLibrarian";
            dgvManageLibrarian.ReadOnly = true;
            dgvManageLibrarian.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageLibrarian.Size = new Size(934, 353);
            dgvManageLibrarian.TabIndex = 19;
            // 
            // panelReports
            // 
            panelReports.Controls.Add(panelRHeader);
            panelReports.Controls.Add(dgvReports);
            panelReports.Location = new Point(0, 107);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(940, 480);
            panelReports.TabIndex = 21;
            // 
            // panelRHeader
            // 
            panelRHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRHeader.Controls.Add(buttonRFilter);
            panelRHeader.Controls.Add(dateTimePickerREnd);
            panelRHeader.Controls.Add(dateTimePickerRStart);
            panelRHeader.Controls.Add(labelREndDate);
            panelRHeader.Controls.Add(labelRStartDate);
            panelRHeader.Location = new Point(0, 6);
            panelRHeader.Name = "panelRHeader";
            panelRHeader.Size = new Size(934, 51);
            panelRHeader.TabIndex = 18;
            // 
            // buttonRFilter
            // 
            buttonRFilter.Anchor = AnchorStyles.None;
            buttonRFilter.BackColor = Color.Ivory;
            buttonRFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRFilter.ForeColor = SystemColors.Desktop;
            buttonRFilter.Location = new Point(663, 13);
            buttonRFilter.Name = "buttonRFilter";
            buttonRFilter.Size = new Size(91, 31);
            buttonRFilter.TabIndex = 18;
            buttonRFilter.Text = "Filter";
            buttonRFilter.UseVisualStyleBackColor = false;
            buttonRFilter.Click += buttonRFilter_Click;
            // 
            // dateTimePickerREnd
            // 
            dateTimePickerREnd.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerREnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerREnd.Format = DateTimePickerFormat.Short;
            dateTimePickerREnd.Location = new Point(454, 17);
            dateTimePickerREnd.Name = "dateTimePickerREnd";
            dateTimePickerREnd.Size = new Size(126, 27);
            dateTimePickerREnd.TabIndex = 17;
            // 
            // dateTimePickerRStart
            // 
            dateTimePickerRStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerRStart.Format = DateTimePickerFormat.Short;
            dateTimePickerRStart.Location = new Point(207, 16);
            dateTimePickerRStart.Name = "dateTimePickerRStart";
            dateTimePickerRStart.Size = new Size(126, 27);
            dateTimePickerRStart.TabIndex = 16;
            // 
            // labelREndDate
            // 
            labelREndDate.Anchor = AnchorStyles.None;
            labelREndDate.AutoSize = true;
            labelREndDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelREndDate.ForeColor = SystemColors.ActiveCaptionText;
            labelREndDate.Location = new Point(367, 18);
            labelREndDate.Margin = new Padding(5, 0, 5, 0);
            labelREndDate.Name = "labelREndDate";
            labelREndDate.Size = new Size(79, 21);
            labelREndDate.TabIndex = 15;
            labelREndDate.Text = "End Date:";
            // 
            // labelRStartDate
            // 
            labelRStartDate.Anchor = AnchorStyles.None;
            labelRStartDate.AutoSize = true;
            labelRStartDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRStartDate.ForeColor = SystemColors.ActiveCaptionText;
            labelRStartDate.Location = new Point(116, 16);
            labelRStartDate.Margin = new Padding(5, 0, 5, 0);
            labelRStartDate.Name = "labelRStartDate";
            labelRStartDate.Size = new Size(87, 21);
            labelRStartDate.TabIndex = 14;
            labelRStartDate.Text = "Start Date:";
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeColumns = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = SystemColors.ControlLightLight;
            dgvReports.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(1, 63);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(934, 418);
            dgvReports.TabIndex = 19;
            // 
            // AdminDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelManageStudents);
            Controls.Add(panelViewBooks);
            Controls.Add(panelReports);
            Controls.Add(panelManageLibrarian);
            Name = "AdminDashboardControl";
            Size = new Size(940, 590);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            tableLayoutPanelMenu.ResumeLayout(false);
            panelViewBooks.ResumeLayout(false);
            panelVBHeader.ResumeLayout(false);
            panelVBHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panelManageStudents.ResumeLayout(false);
            panelMSHeader.ResumeLayout(false);
            panelMSHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageStudents).EndInit();
            panelManageLibrarian.ResumeLayout(false);
            panelMLHeader.ResumeLayout(false);
            panelMLHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageLibrarian).EndInit();
            panelReports.ResumeLayout(false);
            panelRHeader.ResumeLayout(false);
            panelRHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonViewBooks;
        private Button buttonManageMembers;
        private Button buttonManageLibrarian;
        private Button buttonReports;
        private Panel panelHeader;
        private Label labelAdmin;
        private Label labelLibraryManagement;
        private Button buttonLogout;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelViewBooks;
        private Panel panelManageStudents;
        private Panel panelVBHeader;
        private TextBox textBoxSearchBook;
        private Button buttonSearch;
        private DataGridView dgvBooks;
        private Label labelSearch;
        private DataGridView dgvManageStudents;
        private Panel panelMSHeader;
        private Button buttonMMSearch;
        private Label labelMMSearch;
        private TextBox textBoxMMUsername;
        private Button buttonMMBlock;
        private Button buttonMMActive;
        private Panel panelManageLibrarian;
        private Panel panelMLHeader;
        private Button buttonMLRemove;
        private DataGridView dgvManageLibrarian;
        private Button buttonMLAddLibrarian;
        private TextBox textBoxMLFullname;
        private TextBox textBoxMLPassword;
        private TextBox textBoxMLUsername;
        private Panel panelReports;
        private Panel panelRHeader;
        private DataGridView dgvReports;
        private DateTimePicker dateTimePickerREnd;
        private DateTimePicker dateTimePickerRStart;
        private Label labelREndDate;
        private Label labelRStartDate;
        private Button buttonRFilter;
    }
}
