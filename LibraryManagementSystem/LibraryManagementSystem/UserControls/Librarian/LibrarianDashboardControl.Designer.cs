namespace LibraryManagementSystem.UserControls.Librarian
{
    partial class LibrarianDashboardControl
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
            buttonActiveBorrows = new Button();
            buttonOverDueFines = new Button();
            buttonManageBooks = new Button();
            buttonLogout = new Button();
            labelLIbrarian = new Label();
            labelLibraryManagement = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            panelHeader = new Panel();
            panelManageBooks = new Panel();
            buttonMBUpdateInventory = new Button();
            labelMBAddCopies = new Label();
            textMBBoxAddCopies = new TextBox();
            labelMBTotalCopies = new Label();
            buttonMBAddBooks = new Button();
            textBoxTotalCopies = new TextBox();
            labelISBN = new Label();
            textBoxIsbn = new TextBox();
            labelMBAuthor = new Label();
            textBoxAuthor = new TextBox();
            labelMBBookTitle = new Label();
            textBoxBookTitle = new TextBox();
            panelMSHeader = new Panel();
            buttonMBDelete = new Button();
            buttonMBSearch = new Button();
            labelMBSearch = new Label();
            textBoxMBSearch = new TextBox();
            dgvManageBooks = new DataGridView();
            panelActiveBorrows = new Panel();
            dgvActiveBorrows = new DataGridView();
            panelOverdueFines = new Panel();
            panelOFHeader = new Panel();
            buttonMarkPaid = new Button();
            buttonOFFilter = new Button();
            dateTimePickerOFEnd = new DateTimePicker();
            dateTimePickerOFStart = new DateTimePicker();
            labelOFEnd = new Label();
            labelOFStart = new Label();
            dgvOverduesAndFines = new DataGridView();
            tableLayoutPanelMenu.SuspendLayout();
            panelHeader.SuspendLayout();
            panelManageBooks.SuspendLayout();
            panelMSHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageBooks).BeginInit();
            panelActiveBorrows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrows).BeginInit();
            panelOverdueFines.SuspendLayout();
            panelOFHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverduesAndFines).BeginInit();
            SuspendLayout();
            // 
            // buttonActiveBorrows
            // 
            buttonActiveBorrows.Anchor = AnchorStyles.None;
            buttonActiveBorrows.BackColor = Color.SteelBlue;
            buttonActiveBorrows.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonActiveBorrows.ForeColor = SystemColors.ControlLightLight;
            buttonActiveBorrows.Location = new Point(314, 3);
            buttonActiveBorrows.Name = "buttonActiveBorrows";
            buttonActiveBorrows.Size = new Size(305, 43);
            buttonActiveBorrows.TabIndex = 2;
            buttonActiveBorrows.Text = "Active Borrows";
            buttonActiveBorrows.UseVisualStyleBackColor = false;
            buttonActiveBorrows.Click += buttonActiveBorrows_Click;
            // 
            // buttonOverDueFines
            // 
            buttonOverDueFines.Anchor = AnchorStyles.None;
            buttonOverDueFines.BackColor = Color.SteelBlue;
            buttonOverDueFines.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOverDueFines.ForeColor = SystemColors.ControlLightLight;
            buttonOverDueFines.Location = new Point(625, 3);
            buttonOverDueFines.Name = "buttonOverDueFines";
            buttonOverDueFines.Size = new Size(308, 43);
            buttonOverDueFines.TabIndex = 3;
            buttonOverDueFines.Text = "Overdue And Fines";
            buttonOverDueFines.UseVisualStyleBackColor = false;
            buttonOverDueFines.Click += buttonOverDueFines_Click;
            // 
            // buttonManageBooks
            // 
            buttonManageBooks.Anchor = AnchorStyles.None;
            buttonManageBooks.BackColor = Color.SteelBlue;
            buttonManageBooks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonManageBooks.ForeColor = SystemColors.ControlLightLight;
            buttonManageBooks.Location = new Point(3, 3);
            buttonManageBooks.Name = "buttonManageBooks";
            buttonManageBooks.Size = new Size(305, 43);
            buttonManageBooks.TabIndex = 1;
            buttonManageBooks.Text = "Manage Books";
            buttonManageBooks.UseVisualStyleBackColor = false;
            buttonManageBooks.Click += buttonManageBooks_Click;
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
            buttonLogout.Location = new Point(836, 10);
            buttonLogout.Margin = new Padding(5);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(93, 38);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // labelLIbrarian
            // 
            labelLIbrarian.Anchor = AnchorStyles.None;
            labelLIbrarian.AutoSize = true;
            labelLIbrarian.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLIbrarian.ForeColor = SystemColors.ControlLightLight;
            labelLIbrarian.Location = new Point(452, 12);
            labelLIbrarian.Margin = new Padding(5, 0, 5, 0);
            labelLIbrarian.Name = "labelLIbrarian";
            labelLIbrarian.Size = new Size(110, 31);
            labelLIbrarian.TabIndex = 11;
            labelLIbrarian.Text = "Librarian";
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
            tableLayoutPanelMenu.ColumnCount = 3;
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMenu.Controls.Add(buttonActiveBorrows, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonOverDueFines, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonManageBooks, 0, 0);
            tableLayoutPanelMenu.Location = new Point(1, 62);
            tableLayoutPanelMenu.Margin = new Padding(1);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.RowCount = 1;
            tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMenu.Size = new Size(936, 49);
            tableLayoutPanelMenu.TabIndex = 23;
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(buttonLogout);
            panelHeader.Controls.Add(labelLIbrarian);
            panelHeader.Controls.Add(labelLibraryManagement);
            panelHeader.Location = new Point(3, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(934, 58);
            panelHeader.TabIndex = 22;
            // 
            // panelManageBooks
            // 
            panelManageBooks.Controls.Add(buttonMBUpdateInventory);
            panelManageBooks.Controls.Add(labelMBAddCopies);
            panelManageBooks.Controls.Add(textMBBoxAddCopies);
            panelManageBooks.Controls.Add(labelMBTotalCopies);
            panelManageBooks.Controls.Add(buttonMBAddBooks);
            panelManageBooks.Controls.Add(textBoxTotalCopies);
            panelManageBooks.Controls.Add(labelISBN);
            panelManageBooks.Controls.Add(textBoxIsbn);
            panelManageBooks.Controls.Add(labelMBAuthor);
            panelManageBooks.Controls.Add(textBoxAuthor);
            panelManageBooks.Controls.Add(labelMBBookTitle);
            panelManageBooks.Controls.Add(textBoxBookTitle);
            panelManageBooks.Controls.Add(panelMSHeader);
            panelManageBooks.Controls.Add(dgvManageBooks);
            panelManageBooks.Location = new Point(1, 110);
            panelManageBooks.Name = "panelManageBooks";
            panelManageBooks.Size = new Size(936, 480);
            panelManageBooks.TabIndex = 24;
            // 
            // buttonMBUpdateInventory
            // 
            buttonMBUpdateInventory.Anchor = AnchorStyles.None;
            buttonMBUpdateInventory.BackColor = Color.Ivory;
            buttonMBUpdateInventory.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMBUpdateInventory.ForeColor = SystemColors.Desktop;
            buttonMBUpdateInventory.Location = new Point(741, 384);
            buttonMBUpdateInventory.Name = "buttonMBUpdateInventory";
            buttonMBUpdateInventory.Size = new Size(158, 31);
            buttonMBUpdateInventory.TabIndex = 30;
            buttonMBUpdateInventory.Text = "Update Inventory";
            buttonMBUpdateInventory.UseVisualStyleBackColor = false;
            buttonMBUpdateInventory.Click += buttonMBUpdateInventory_Click;
            // 
            // labelMBAddCopies
            // 
            labelMBAddCopies.Anchor = AnchorStyles.None;
            labelMBAddCopies.AutoSize = true;
            labelMBAddCopies.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMBAddCopies.ForeColor = SystemColors.ActiveCaptionText;
            labelMBAddCopies.Location = new Point(603, 336);
            labelMBAddCopies.Margin = new Padding(5, 0, 5, 0);
            labelMBAddCopies.Name = "labelMBAddCopies";
            labelMBAddCopies.Size = new Size(99, 21);
            labelMBAddCopies.TabIndex = 29;
            labelMBAddCopies.Text = "Add Copies:";
            // 
            // textMBBoxAddCopies
            // 
            textMBBoxAddCopies.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textMBBoxAddCopies.Location = new Point(714, 334);
            textMBBoxAddCopies.Name = "textMBBoxAddCopies";
            textMBBoxAddCopies.Size = new Size(206, 27);
            textMBBoxAddCopies.TabIndex = 28;
            textMBBoxAddCopies.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMBTotalCopies
            // 
            labelMBTotalCopies.Anchor = AnchorStyles.None;
            labelMBTotalCopies.AutoSize = true;
            labelMBTotalCopies.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMBTotalCopies.ForeColor = SystemColors.ActiveCaptionText;
            labelMBTotalCopies.Location = new Point(603, 212);
            labelMBTotalCopies.Margin = new Padding(5, 0, 5, 0);
            labelMBTotalCopies.Name = "labelMBTotalCopies";
            labelMBTotalCopies.Size = new Size(103, 21);
            labelMBTotalCopies.TabIndex = 27;
            labelMBTotalCopies.Text = "Total Copies:";
            // 
            // buttonMBAddBooks
            // 
            buttonMBAddBooks.Anchor = AnchorStyles.None;
            buttonMBAddBooks.BackColor = Color.Ivory;
            buttonMBAddBooks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMBAddBooks.ForeColor = SystemColors.Desktop;
            buttonMBAddBooks.Location = new Point(741, 253);
            buttonMBAddBooks.Name = "buttonMBAddBooks";
            buttonMBAddBooks.Size = new Size(131, 31);
            buttonMBAddBooks.TabIndex = 15;
            buttonMBAddBooks.Text = "Add Books";
            buttonMBAddBooks.UseVisualStyleBackColor = false;
            buttonMBAddBooks.Click += buttonMBAddBooks_Click;
            // 
            // textBoxTotalCopies
            // 
            textBoxTotalCopies.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxTotalCopies.Location = new Point(714, 210);
            textBoxTotalCopies.Name = "textBoxTotalCopies";
            textBoxTotalCopies.Size = new Size(206, 27);
            textBoxTotalCopies.TabIndex = 26;
            textBoxTotalCopies.TextAlign = HorizontalAlignment.Center;
            // 
            // labelISBN
            // 
            labelISBN.Anchor = AnchorStyles.None;
            labelISBN.AutoSize = true;
            labelISBN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelISBN.ForeColor = SystemColors.ActiveCaptionText;
            labelISBN.Location = new Point(603, 169);
            labelISBN.Margin = new Padding(5, 0, 5, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(50, 21);
            labelISBN.TabIndex = 25;
            labelISBN.Text = "ISBN:";
            // 
            // textBoxIsbn
            // 
            textBoxIsbn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxIsbn.Location = new Point(714, 167);
            textBoxIsbn.Name = "textBoxIsbn";
            textBoxIsbn.Size = new Size(206, 27);
            textBoxIsbn.TabIndex = 24;
            textBoxIsbn.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMBAuthor
            // 
            labelMBAuthor.Anchor = AnchorStyles.None;
            labelMBAuthor.AutoSize = true;
            labelMBAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMBAuthor.ForeColor = SystemColors.ActiveCaptionText;
            labelMBAuthor.Location = new Point(603, 129);
            labelMBAuthor.Margin = new Padding(5, 0, 5, 0);
            labelMBAuthor.Name = "labelMBAuthor";
            labelMBAuthor.Size = new Size(66, 21);
            labelMBAuthor.TabIndex = 23;
            labelMBAuthor.Text = "Author:";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAuthor.Location = new Point(714, 127);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(206, 27);
            textBoxAuthor.TabIndex = 22;
            textBoxAuthor.TextAlign = HorizontalAlignment.Center;
            // 
            // labelMBBookTitle
            // 
            labelMBBookTitle.Anchor = AnchorStyles.None;
            labelMBBookTitle.AutoSize = true;
            labelMBBookTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMBBookTitle.ForeColor = SystemColors.ActiveCaptionText;
            labelMBBookTitle.Location = new Point(603, 92);
            labelMBBookTitle.Margin = new Padding(5, 0, 5, 0);
            labelMBBookTitle.Name = "labelMBBookTitle";
            labelMBBookTitle.Size = new Size(88, 21);
            labelMBBookTitle.TabIndex = 21;
            labelMBBookTitle.Text = "Book Title:";
            // 
            // textBoxBookTitle
            // 
            textBoxBookTitle.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxBookTitle.Location = new Point(714, 90);
            textBoxBookTitle.Name = "textBoxBookTitle";
            textBoxBookTitle.Size = new Size(206, 27);
            textBoxBookTitle.TabIndex = 20;
            textBoxBookTitle.TextAlign = HorizontalAlignment.Center;
            // 
            // panelMSHeader
            // 
            panelMSHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMSHeader.Controls.Add(buttonMBDelete);
            panelMSHeader.Controls.Add(buttonMBSearch);
            panelMSHeader.Controls.Add(labelMBSearch);
            panelMSHeader.Controls.Add(textBoxMBSearch);
            panelMSHeader.Location = new Point(2, 4);
            panelMSHeader.Name = "panelMSHeader";
            panelMSHeader.Size = new Size(928, 54);
            panelMSHeader.TabIndex = 18;
            // 
            // buttonMBDelete
            // 
            buttonMBDelete.Anchor = AnchorStyles.None;
            buttonMBDelete.BackColor = Color.Ivory;
            buttonMBDelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMBDelete.ForeColor = SystemColors.Desktop;
            buttonMBDelete.Location = new Point(712, 9);
            buttonMBDelete.Name = "buttonMBDelete";
            buttonMBDelete.Size = new Size(131, 31);
            buttonMBDelete.TabIndex = 16;
            buttonMBDelete.Text = "Delete";
            buttonMBDelete.UseVisualStyleBackColor = false;
            buttonMBDelete.Click += buttonMBDelete_Click;
            // 
            // buttonMBSearch
            // 
            buttonMBSearch.Anchor = AnchorStyles.None;
            buttonMBSearch.BackColor = Color.Ivory;
            buttonMBSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMBSearch.ForeColor = SystemColors.Desktop;
            buttonMBSearch.Location = new Point(409, 9);
            buttonMBSearch.Name = "buttonMBSearch";
            buttonMBSearch.Size = new Size(131, 31);
            buttonMBSearch.TabIndex = 14;
            buttonMBSearch.Text = "Search";
            buttonMBSearch.UseVisualStyleBackColor = false;
            buttonMBSearch.Click += buttonMBSearch_Click;
            // 
            // labelMBSearch
            // 
            labelMBSearch.Anchor = AnchorStyles.None;
            labelMBSearch.AutoSize = true;
            labelMBSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMBSearch.ForeColor = SystemColors.ActiveCaptionText;
            labelMBSearch.Location = new Point(19, 15);
            labelMBSearch.Margin = new Padding(5, 0, 5, 0);
            labelMBSearch.Name = "labelMBSearch";
            labelMBSearch.Size = new Size(112, 21);
            labelMBSearch.TabIndex = 13;
            labelMBSearch.Text = "Search Books:";
            // 
            // textBoxMBSearch
            // 
            textBoxMBSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxMBSearch.Location = new Point(139, 13);
            textBoxMBSearch.Name = "textBoxMBSearch";
            textBoxMBSearch.Size = new Size(206, 27);
            textBoxMBSearch.TabIndex = 0;
            textBoxMBSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvManageBooks
            // 
            dgvManageBooks.AllowUserToAddRows = false;
            dgvManageBooks.AllowUserToDeleteRows = false;
            dgvManageBooks.AllowUserToResizeColumns = false;
            dgvManageBooks.AllowUserToResizeRows = false;
            dgvManageBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvManageBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManageBooks.BackgroundColor = SystemColors.ControlLightLight;
            dgvManageBooks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvManageBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageBooks.Location = new Point(0, 63);
            dgvManageBooks.MultiSelect = false;
            dgvManageBooks.Name = "dgvManageBooks";
            dgvManageBooks.ReadOnly = true;
            dgvManageBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvManageBooks.Size = new Size(595, 414);
            dgvManageBooks.TabIndex = 19;
            // 
            // panelActiveBorrows
            // 
            panelActiveBorrows.Controls.Add(dgvActiveBorrows);
            panelActiveBorrows.Location = new Point(0, 114);
            panelActiveBorrows.Name = "panelActiveBorrows";
            panelActiveBorrows.Size = new Size(936, 473);
            panelActiveBorrows.TabIndex = 31;
            // 
            // dgvActiveBorrows
            // 
            dgvActiveBorrows.AllowUserToAddRows = false;
            dgvActiveBorrows.AllowUserToDeleteRows = false;
            dgvActiveBorrows.AllowUserToResizeColumns = false;
            dgvActiveBorrows.AllowUserToResizeRows = false;
            dgvActiveBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvActiveBorrows.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveBorrows.BackgroundColor = SystemColors.ControlLightLight;
            dgvActiveBorrows.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvActiveBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveBorrows.Location = new Point(0, 9);
            dgvActiveBorrows.MultiSelect = false;
            dgvActiveBorrows.Name = "dgvActiveBorrows";
            dgvActiveBorrows.ReadOnly = true;
            dgvActiveBorrows.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvActiveBorrows.Size = new Size(931, 467);
            dgvActiveBorrows.TabIndex = 19;
            // 
            // panelOverdueFines
            // 
            panelOverdueFines.Controls.Add(panelOFHeader);
            panelOverdueFines.Controls.Add(dgvOverduesAndFines);
            panelOverdueFines.Location = new Point(0, 107);
            panelOverdueFines.Name = "panelOverdueFines";
            panelOverdueFines.Size = new Size(940, 480);
            panelOverdueFines.TabIndex = 31;
            // 
            // panelOFHeader
            // 
            panelOFHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOFHeader.Controls.Add(buttonMarkPaid);
            panelOFHeader.Controls.Add(buttonOFFilter);
            panelOFHeader.Controls.Add(dateTimePickerOFEnd);
            panelOFHeader.Controls.Add(dateTimePickerOFStart);
            panelOFHeader.Controls.Add(labelOFEnd);
            panelOFHeader.Controls.Add(labelOFStart);
            panelOFHeader.Location = new Point(0, 9);
            panelOFHeader.Name = "panelOFHeader";
            panelOFHeader.Size = new Size(934, 51);
            panelOFHeader.TabIndex = 18;
            // 
            // buttonMarkPaid
            // 
            buttonMarkPaid.Anchor = AnchorStyles.None;
            buttonMarkPaid.BackColor = Color.Ivory;
            buttonMarkPaid.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMarkPaid.ForeColor = SystemColors.Desktop;
            buttonMarkPaid.Location = new Point(730, 16);
            buttonMarkPaid.Name = "buttonMarkPaid";
            buttonMarkPaid.Size = new Size(91, 31);
            buttonMarkPaid.TabIndex = 19;
            buttonMarkPaid.Text = "Mark Paid";
            buttonMarkPaid.UseVisualStyleBackColor = false;
            buttonMarkPaid.Click += buttonMarkPaid_Click;
            // 
            // buttonOFFilter
            // 
            buttonOFFilter.Anchor = AnchorStyles.None;
            buttonOFFilter.BackColor = Color.Ivory;
            buttonOFFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOFFilter.ForeColor = SystemColors.Desktop;
            buttonOFFilter.Location = new Point(601, 16);
            buttonOFFilter.Name = "buttonOFFilter";
            buttonOFFilter.Size = new Size(91, 31);
            buttonOFFilter.TabIndex = 18;
            buttonOFFilter.Text = "Filter";
            buttonOFFilter.UseVisualStyleBackColor = false;
            buttonOFFilter.Click += buttonOFFilter_Click;
            // 
            // dateTimePickerOFEnd
            // 
            dateTimePickerOFEnd.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerOFEnd.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerOFEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerOFEnd.Location = new Point(454, 17);
            dateTimePickerOFEnd.Name = "dateTimePickerOFEnd";
            dateTimePickerOFEnd.Size = new Size(126, 27);
            dateTimePickerOFEnd.TabIndex = 17;
            // 
            // dateTimePickerOFStart
            // 
            dateTimePickerOFStart.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerOFStart.Format = DateTimePickerFormat.Short;
            dateTimePickerOFStart.Location = new Point(207, 16);
            dateTimePickerOFStart.Name = "dateTimePickerOFStart";
            dateTimePickerOFStart.Size = new Size(126, 27);
            dateTimePickerOFStart.TabIndex = 16;
            // 
            // labelOFEnd
            // 
            labelOFEnd.Anchor = AnchorStyles.None;
            labelOFEnd.AutoSize = true;
            labelOFEnd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOFEnd.ForeColor = SystemColors.ActiveCaptionText;
            labelOFEnd.Location = new Point(367, 21);
            labelOFEnd.Margin = new Padding(5, 0, 5, 0);
            labelOFEnd.Name = "labelOFEnd";
            labelOFEnd.Size = new Size(79, 21);
            labelOFEnd.TabIndex = 15;
            labelOFEnd.Text = "End Date:";
            // 
            // labelOFStart
            // 
            labelOFStart.Anchor = AnchorStyles.None;
            labelOFStart.AutoSize = true;
            labelOFStart.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOFStart.ForeColor = SystemColors.ActiveCaptionText;
            labelOFStart.Location = new Point(110, 20);
            labelOFStart.Margin = new Padding(5, 0, 5, 0);
            labelOFStart.Name = "labelOFStart";
            labelOFStart.Size = new Size(87, 21);
            labelOFStart.TabIndex = 14;
            labelOFStart.Text = "Start Date:";
            // 
            // dgvOverduesAndFines
            // 
            dgvOverduesAndFines.AllowUserToAddRows = false;
            dgvOverduesAndFines.AllowUserToDeleteRows = false;
            dgvOverduesAndFines.AllowUserToResizeColumns = false;
            dgvOverduesAndFines.AllowUserToResizeRows = false;
            dgvOverduesAndFines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOverduesAndFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOverduesAndFines.BackgroundColor = SystemColors.ControlLightLight;
            dgvOverduesAndFines.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvOverduesAndFines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverduesAndFines.Location = new Point(1, 63);
            dgvOverduesAndFines.MultiSelect = false;
            dgvOverduesAndFines.Name = "dgvOverduesAndFines";
            dgvOverduesAndFines.ReadOnly = true;
            dgvOverduesAndFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOverduesAndFines.Size = new Size(933, 418);
            dgvOverduesAndFines.TabIndex = 19;
            // 
            // LibrarianDashboardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(panelHeader);
            Controls.Add(panelActiveBorrows);
            Controls.Add(panelOverdueFines);
            Controls.Add(panelManageBooks);
            Name = "LibrarianDashboardControl";
            Size = new Size(940, 590);
            tableLayoutPanelMenu.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelManageBooks.ResumeLayout(false);
            panelManageBooks.PerformLayout();
            panelMSHeader.ResumeLayout(false);
            panelMSHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvManageBooks).EndInit();
            panelActiveBorrows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActiveBorrows).EndInit();
            panelOverdueFines.ResumeLayout(false);
            panelOFHeader.ResumeLayout(false);
            panelOFHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOverduesAndFines).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonActiveBorrows;
        private Button buttonOverDueFines;
        private Button buttonManageBooks;
        private Button buttonLogout;
        private Label labelLIbrarian;
        private Label labelLibraryManagement;
        private TableLayoutPanel tableLayoutPanelMenu;
        private Panel panelHeader;
        private Panel panelManageBooks;
        private Panel panelMSHeader;
        private Button buttonMBDelete;
        private Button buttonMBAddBooks;
        private Button buttonMBSearch;
        private Label labelMBSearch;
        private TextBox textBoxMBSearch;
        private DataGridView dgvManageBooks;
        private TextBox textBoxBookTitle;
        private Label labelISBN;
        private TextBox textBoxIsbn;
        private Label labelMBAuthor;
        private TextBox textBoxAuthor;
        private Label labelMBBookTitle;
        private Label labelMBTotalCopies;
        private TextBox textBoxTotalCopies;
        private Button buttonMBUpdateInventory;
        private Label labelMBAddCopies;
        private TextBox textMBBoxAddCopies;
        private Panel panelActiveBorrows;
        private DataGridView dgvActiveBorrows;
        private Panel panelOverdueFines;
        private Panel panelOFHeader;
        private Button buttonOFFilter;
        private DateTimePicker dateTimePickerOFEnd;
        private DateTimePicker dateTimePickerOFStart;
        private Label labelOFEnd;
        private Label labelOFStart;
        private DataGridView dgvOverduesAndFines;
        private Button buttonMarkPaid;
    }
}
