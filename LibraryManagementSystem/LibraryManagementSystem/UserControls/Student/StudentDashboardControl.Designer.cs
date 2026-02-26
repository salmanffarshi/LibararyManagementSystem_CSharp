namespace LibraryManagementSystem.UserControls.Student
{
    partial class StudentDashboardControl
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
            tableLayoutPanelMenu = new TableLayoutPanel();
            buttonBorrow = new Button();
            buttonReturn = new Button();
            buttonViewBooks = new Button();
            buttonProfileUpdate = new Button();
            panelHeader = new Panel();
            buttonLogout = new Button();
            labelStudent = new Label();
            labelLibraryManagement = new Label();
            panelReturn1 = new Panel();
            panelRHeader = new Panel();
            buttonRReturn = new Button();
            dgvBorrowedBooks = new DataGridView();
            panelBorrow = new Panel();
            buttonRequestBorrow = new Button();
            textBoxEnterIsbn = new TextBox();
            labelEnterIsbn = new Label();
            panelViewBooks = new Panel();
            panel2 = new Panel();
            labelVBIsbn = new Label();
            buttonVBSearch = new Button();
            textBoxVBIsbn = new TextBox();
            dgvViewBooks = new DataGridView();
            panelProfileUpdate = new Panel();
            labelPUDepartment = new Label();
            textBoxPUDepartment = new TextBox();
            labelPUMobile = new Label();
            textBoxPUMobile = new TextBox();
            labelPUEmail = new Label();
            textBoxPUEmail = new TextBox();
            buttonPUAUpdateProfile = new Button();
            labelPUName = new Label();
            textBoxPUUsername = new TextBox();
            tableLayoutPanelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            panelReturn1.SuspendLayout();
            panelRHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            panelBorrow.SuspendLayout();
            panelViewBooks.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooks).BeginInit();
            panelProfileUpdate.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanelMenu.Controls.Add(buttonBorrow, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonReturn, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonViewBooks, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonProfileUpdate, 3, 0);
            tableLayoutPanelMenu.Location = new Point(0, 58);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(940, 50);
            tableLayoutPanelMenu.TabIndex = 15;
            // 
            // buttonBorrow
            // 
            buttonBorrow.Anchor = AnchorStyles.None;
            buttonBorrow.BackColor = Color.SteelBlue;
            buttonBorrow.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBorrow.ForeColor = SystemColors.ControlLightLight;
            buttonBorrow.Location = new Point(238, 3);
            buttonBorrow.Name = "buttonBorrow";
            buttonBorrow.Size = new Size(229, 44);
            buttonBorrow.TabIndex = 2;
            buttonBorrow.Text = "Borrow";
            buttonBorrow.UseVisualStyleBackColor = false;
            buttonBorrow.Click += buttonBorrow_Click;
            // 
            // buttonReturn
            // 
            buttonReturn.Anchor = AnchorStyles.None;
            buttonReturn.BackColor = Color.SteelBlue;
            buttonReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReturn.ForeColor = SystemColors.ControlLightLight;
            buttonReturn.Location = new Point(473, 3);
            buttonReturn.Name = "buttonReturn";
            buttonReturn.Size = new Size(229, 44);
            buttonReturn.TabIndex = 3;
            buttonReturn.Text = "Return";
            buttonReturn.UseVisualStyleBackColor = false;
            buttonReturn.Click += buttonReturn_Click;
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
            buttonViewBooks.Click += buttonViewBooks_Click_1;
            // 
            // buttonProfileUpdate
            // 
            buttonProfileUpdate.Anchor = AnchorStyles.None;
            buttonProfileUpdate.BackColor = Color.SteelBlue;
            buttonProfileUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProfileUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonProfileUpdate.Location = new Point(709, 3);
            buttonProfileUpdate.Name = "buttonProfileUpdate";
            buttonProfileUpdate.Size = new Size(226, 44);
            buttonProfileUpdate.TabIndex = 4;
            buttonProfileUpdate.Text = "ProfileUpdate";
            buttonProfileUpdate.UseVisualStyleBackColor = false;
            buttonProfileUpdate.Click += buttonProfileUpdate_Click;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelStudent);
            panelHeader.Controls.Add(labelLibraryManagement);
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(940, 58);
            panelHeader.TabIndex = 14;
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
            buttonLogout.Location = new Point(841, 12);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // labelStudent
            // 
            labelStudent.Anchor = AnchorStyles.None;
            labelStudent.AutoSize = true;
            labelStudent.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudent.ForeColor = SystemColors.ControlLightLight;
            labelStudent.Location = new Point(440, 14);
            labelStudent.Margin = new Padding(5, 0, 5, 0);
            labelStudent.Name = "labelStudent";
            labelStudent.Size = new Size(97, 31);
            labelStudent.TabIndex = 11;
            labelStudent.Text = "Student";
            // 
            // labelLibraryManagement
            // 
            labelLibraryManagement.Anchor = AnchorStyles.None;
            labelLibraryManagement.AutoSize = true;
            labelLibraryManagement.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLibraryManagement.ForeColor = SystemColors.ControlLightLight;
            labelLibraryManagement.Location = new Point(5, 14);
            labelLibraryManagement.Margin = new Padding(5, 0, 5, 0);
            labelLibraryManagement.Name = "labelLibraryManagement";
            labelLibraryManagement.Size = new Size(315, 31);
            labelLibraryManagement.TabIndex = 10;
            labelLibraryManagement.Text = "Library Management System";
            // 
            // panelReturn1
            // 
            panelReturn1.Controls.Add(panelRHeader);
            panelReturn1.Controls.Add(dgvBorrowedBooks);
            panelReturn1.Location = new Point(0, 109);
            panelReturn1.Name = "panelReturn1";
            panelReturn1.Size = new Size(940, 480);
            panelReturn1.TabIndex = 16;
            // 
            // panelRHeader
            // 
            panelRHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelRHeader.Controls.Add(buttonRReturn);
            panelRHeader.Location = new Point(1, 5);
            panelRHeader.Name = "panelRHeader";
            panelRHeader.Size = new Size(933, 49);
            panelRHeader.TabIndex = 17;
            // 
            // buttonRReturn
            // 
            buttonRReturn.Anchor = AnchorStyles.None;
            buttonRReturn.BackColor = Color.Ivory;
            buttonRReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRReturn.ForeColor = SystemColors.Desktop;
            buttonRReturn.Location = new Point(405, 10);
            buttonRReturn.Name = "buttonRReturn";
            buttonRReturn.Size = new Size(131, 31);
            buttonRReturn.TabIndex = 4;
            buttonRReturn.Text = "Return";
            buttonRReturn.UseVisualStyleBackColor = false;
            buttonRReturn.Click += buttonRReturn_Click;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AllowUserToAddRows = false;
            dgvBorrowedBooks.AllowUserToDeleteRows = false;
            dgvBorrowedBooks.AllowUserToResizeColumns = false;
            dgvBorrowedBooks.AllowUserToResizeRows = false;
            dgvBorrowedBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvBorrowedBooks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(0, 61);
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(934, 420);
            dgvBorrowedBooks.TabIndex = 18;
            // 
            // panelBorrow
            // 
            panelBorrow.Controls.Add(buttonRequestBorrow);
            panelBorrow.Controls.Add(textBoxEnterIsbn);
            panelBorrow.Controls.Add(labelEnterIsbn);
            panelBorrow.Location = new Point(0, 107);
            panelBorrow.Name = "panelBorrow";
            panelBorrow.Size = new Size(940, 480);
            panelBorrow.TabIndex = 19;
            // 
            // buttonRequestBorrow
            // 
            buttonRequestBorrow.Anchor = AnchorStyles.None;
            buttonRequestBorrow.BackColor = Color.Ivory;
            buttonRequestBorrow.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRequestBorrow.ForeColor = SystemColors.Desktop;
            buttonRequestBorrow.Location = new Point(420, 235);
            buttonRequestBorrow.Name = "buttonRequestBorrow";
            buttonRequestBorrow.Size = new Size(141, 31);
            buttonRequestBorrow.TabIndex = 15;
            buttonRequestBorrow.Text = "Request Borrow";
            buttonRequestBorrow.UseVisualStyleBackColor = false;
            buttonRequestBorrow.Click += buttonRequestBorrow_Click;
            // 
            // textBoxEnterIsbn
            // 
            textBoxEnterIsbn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEnterIsbn.Location = new Point(420, 139);
            textBoxEnterIsbn.Name = "textBoxEnterIsbn";
            textBoxEnterIsbn.Size = new Size(221, 27);
            textBoxEnterIsbn.TabIndex = 14;
            textBoxEnterIsbn.TextAlign = HorizontalAlignment.Center;
            // 
            // labelEnterIsbn
            // 
            labelEnterIsbn.Anchor = AnchorStyles.None;
            labelEnterIsbn.AutoSize = true;
            labelEnterIsbn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEnterIsbn.ForeColor = SystemColors.ActiveCaptionText;
            labelEnterIsbn.Location = new Point(303, 141);
            labelEnterIsbn.Margin = new Padding(5, 0, 5, 0);
            labelEnterIsbn.Name = "labelEnterIsbn";
            labelEnterIsbn.Size = new Size(92, 21);
            labelEnterIsbn.TabIndex = 13;
            labelEnterIsbn.Text = "Enter ISBN:";
            // 
            // panelViewBooks
            // 
            panelViewBooks.Controls.Add(panel2);
            panelViewBooks.Controls.Add(dgvViewBooks);
            panelViewBooks.Location = new Point(0, 107);
            panelViewBooks.Name = "panelViewBooks";
            panelViewBooks.Size = new Size(940, 480);
            panelViewBooks.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelVBIsbn);
            panel2.Controls.Add(buttonVBSearch);
            panel2.Controls.Add(textBoxVBIsbn);
            panel2.Location = new Point(1, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 49);
            panel2.TabIndex = 17;
            // 
            // labelVBIsbn
            // 
            labelVBIsbn.Anchor = AnchorStyles.None;
            labelVBIsbn.AutoSize = true;
            labelVBIsbn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVBIsbn.ForeColor = SystemColors.ActiveCaptionText;
            labelVBIsbn.Location = new Point(206, 16);
            labelVBIsbn.Margin = new Padding(5, 0, 5, 0);
            labelVBIsbn.Name = "labelVBIsbn";
            labelVBIsbn.Size = new Size(121, 21);
            labelVBIsbn.TabIndex = 12;
            labelVBIsbn.Text = "Search By ISBN";
            // 
            // buttonVBSearch
            // 
            buttonVBSearch.Anchor = AnchorStyles.None;
            buttonVBSearch.BackColor = Color.Ivory;
            buttonVBSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVBSearch.ForeColor = SystemColors.Desktop;
            buttonVBSearch.Location = new Point(577, 12);
            buttonVBSearch.Name = "buttonVBSearch";
            buttonVBSearch.Size = new Size(75, 31);
            buttonVBSearch.TabIndex = 4;
            buttonVBSearch.Text = "Search";
            buttonVBSearch.UseVisualStyleBackColor = false;
            buttonVBSearch.Click += buttonVBSearch_Click;
            // 
            // textBoxVBIsbn
            // 
            textBoxVBIsbn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxVBIsbn.Location = new Point(335, 12);
            textBoxVBIsbn.Name = "textBoxVBIsbn";
            textBoxVBIsbn.Size = new Size(221, 27);
            textBoxVBIsbn.TabIndex = 0;
            textBoxVBIsbn.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvViewBooks
            // 
            dgvViewBooks.AllowUserToAddRows = false;
            dgvViewBooks.AllowUserToDeleteRows = false;
            dgvViewBooks.AllowUserToResizeColumns = false;
            dgvViewBooks.AllowUserToResizeRows = false;
            dgvViewBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvViewBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvViewBooks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewBooks.Location = new Point(0, 61);
            dgvViewBooks.MultiSelect = false;
            dgvViewBooks.Name = "dgvViewBooks";
            dgvViewBooks.ReadOnly = true;
            dgvViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvViewBooks.Size = new Size(937, 420);
            dgvViewBooks.TabIndex = 18;
            // 
            // panelProfileUpdate
            // 
            panelProfileUpdate.Controls.Add(labelPUDepartment);
            panelProfileUpdate.Controls.Add(textBoxPUDepartment);
            panelProfileUpdate.Controls.Add(labelPUMobile);
            panelProfileUpdate.Controls.Add(textBoxPUMobile);
            panelProfileUpdate.Controls.Add(labelPUEmail);
            panelProfileUpdate.Controls.Add(textBoxPUEmail);
            panelProfileUpdate.Controls.Add(buttonPUAUpdateProfile);
            panelProfileUpdate.Controls.Add(labelPUName);
            panelProfileUpdate.Controls.Add(textBoxPUUsername);
            panelProfileUpdate.Location = new Point(0, 107);
            panelProfileUpdate.Name = "panelProfileUpdate";
            panelProfileUpdate.Size = new Size(940, 480);
            panelProfileUpdate.TabIndex = 19;
            // 
            // labelPUDepartment
            // 
            labelPUDepartment.Anchor = AnchorStyles.None;
            labelPUDepartment.AutoSize = true;
            labelPUDepartment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUDepartment.ForeColor = SystemColors.ActiveCaptionText;
            labelPUDepartment.Location = new Point(238, 294);
            labelPUDepartment.Margin = new Padding(5, 0, 5, 0);
            labelPUDepartment.Name = "labelPUDepartment";
            labelPUDepartment.Size = new Size(98, 21);
            labelPUDepartment.TabIndex = 22;
            labelPUDepartment.Text = "Department";
            // 
            // textBoxPUDepartment
            // 
            textBoxPUDepartment.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUDepartment.Location = new Point(374, 294);
            textBoxPUDepartment.Name = "textBoxPUDepartment";
            textBoxPUDepartment.Size = new Size(221, 27);
            textBoxPUDepartment.TabIndex = 21;
            textBoxPUDepartment.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPUMobile
            // 
            labelPUMobile.Anchor = AnchorStyles.None;
            labelPUMobile.AutoSize = true;
            labelPUMobile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUMobile.ForeColor = SystemColors.ActiveCaptionText;
            labelPUMobile.Location = new Point(238, 235);
            labelPUMobile.Margin = new Padding(5, 0, 5, 0);
            labelPUMobile.Name = "labelPUMobile";
            labelPUMobile.Size = new Size(66, 21);
            labelPUMobile.TabIndex = 20;
            labelPUMobile.Text = "Mobile:";
            // 
            // textBoxPUMobile
            // 
            textBoxPUMobile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUMobile.Location = new Point(374, 235);
            textBoxPUMobile.Name = "textBoxPUMobile";
            textBoxPUMobile.Size = new Size(221, 27);
            textBoxPUMobile.TabIndex = 19;
            textBoxPUMobile.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPUEmail
            // 
            labelPUEmail.Anchor = AnchorStyles.None;
            labelPUEmail.AutoSize = true;
            labelPUEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUEmail.ForeColor = SystemColors.ActiveCaptionText;
            labelPUEmail.Location = new Point(238, 165);
            labelPUEmail.Margin = new Padding(5, 0, 5, 0);
            labelPUEmail.Name = "labelPUEmail";
            labelPUEmail.Size = new Size(52, 21);
            labelPUEmail.TabIndex = 18;
            labelPUEmail.Text = "Email:";
            // 
            // textBoxPUEmail
            // 
            textBoxPUEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUEmail.Location = new Point(374, 165);
            textBoxPUEmail.Name = "textBoxPUEmail";
            textBoxPUEmail.Size = new Size(221, 27);
            textBoxPUEmail.TabIndex = 17;
            textBoxPUEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonPUAUpdateProfile
            // 
            buttonPUAUpdateProfile.Anchor = AnchorStyles.None;
            buttonPUAUpdateProfile.BackColor = Color.Ivory;
            buttonPUAUpdateProfile.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPUAUpdateProfile.ForeColor = SystemColors.Desktop;
            buttonPUAUpdateProfile.Location = new Point(388, 363);
            buttonPUAUpdateProfile.Name = "buttonPUAUpdateProfile";
            buttonPUAUpdateProfile.Size = new Size(131, 31);
            buttonPUAUpdateProfile.TabIndex = 16;
            buttonPUAUpdateProfile.Text = "Update Profile";
            buttonPUAUpdateProfile.UseVisualStyleBackColor = false;
            buttonPUAUpdateProfile.Click += buttonPUAUpdateProfile_Click;
            // 
            // labelPUName
            // 
            labelPUName.Anchor = AnchorStyles.None;
            labelPUName.AutoSize = true;
            labelPUName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPUName.ForeColor = SystemColors.ActiveCaptionText;
            labelPUName.Location = new Point(238, 106);
            labelPUName.Margin = new Padding(5, 0, 5, 0);
            labelPUName.Name = "labelPUName";
            labelPUName.Size = new Size(57, 21);
            labelPUName.TabIndex = 14;
            labelPUName.Text = "Name:";
            // 
            // textBoxPUUsername
            // 
            textBoxPUUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPUUsername.Location = new Point(374, 106);
            textBoxPUUsername.Name = "textBoxPUUsername";
            textBoxPUUsername.Size = new Size(221, 27);
            textBoxPUUsername.TabIndex = 1;
            textBoxPUUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelViewBooks);
            Controls.Add(panelBorrow);
            Controls.Add(panelProfileUpdate);
            Controls.Add(panelReturn1);
            Name = "StudentDashboardControl";
            Size = new Size(940, 590);
            tableLayoutPanelMenu.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelReturn1.ResumeLayout(false);
            panelRHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            panelBorrow.ResumeLayout(false);
            panelBorrow.PerformLayout();
            panelViewBooks.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooks).EndInit();
            panelProfileUpdate.ResumeLayout(false);
            panelProfileUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelMenu;
        private Button buttonBorrow;
        private Button buttonReturn;
        private Button buttonViewBooks;
        private Button buttonProfileUpdate;
        private Panel panelHeader;
        private Button buttonLogout;
        private Label labelStudent;
        private Label labelLibraryManagement;
        private Panel panelReturn1;
        private Panel panelRHeader;
        private Label labelSearch;
        private Button buttonRReturn;
        private TextBox textBoxSearchBook;
        private DataGridView dgvBorrowedBooks;
        private Panel panelBorrow;
        private Label labelEnterIsbn;
        private TextBox textBoxEnterIsbn;
        private Button buttonRequestBorrow;
        private Panel panelViewBooks;
        private Panel panel2;
        private Label labelVBIsbn;
        private Button buttonVBSearch;
        private TextBox textBoxVBIsbn;
        private DataGridView dgvViewBooks;
        private Panel panelProfileUpdate;
        private TextBox textBoxPUUsername;
        private Label labelPUName;
        private Label labelPUEmail;
        private TextBox textBoxPUEmail;
        private Button buttonPUAUpdateProfile;
        private Label labelPUDepartment;
        private TextBox textBoxPUDepartment;
        private Label labelPUMobile;
        private TextBox textBoxPUMobile;
    }
}
