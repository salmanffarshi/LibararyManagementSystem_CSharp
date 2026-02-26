using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementSystem.UserControls.Admin
{
    public partial class AdminDashboardControl : UserControl
    {
        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;

        private readonly BookService bookService = new BookService();
        private readonly UserService userService = new UserService();
        private readonly FineRepository reportService = new FineRepository();
        
        public AdminDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonViewBooks);
            ShowPanel(panelViewBooks); // default panel
            LoadBooks();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {
            if (panelViewBooks != null) panelViewBooks.Visible = false;
            if (panelManageStudents != null) panelManageStudents.Visible = false;
            if (panelManageLibrarian != null) panelManageLibrarian.Visible = false;
            if (panelReports != null) panelReports.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelViewBooks);
            LoadBooks();
        }

        private void buttonManageMembers_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageStudents);
            LoadStudents();
        }

        private void buttonManageLibrarian_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageLibrarian);
            LoadLibrarian();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelReports);
            LoadReports();
        }


        private void SetActiveMenuButton(Button? button)
        {
            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuNormalColor;
            }

            activeMenuButton = button;

            if (activeMenuButton != null)
            {
                activeMenuButton.BackColor = MenuActiveColor;
            }
        }

        // ================= CONTENT PANEL EVENTS =================


        // BOOKS PANEL EVENTS
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchBook.Text.Trim();

            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = null;

            if (string.IsNullOrEmpty(keyword))
            {
                dgvBooks.DataSource = bookService.GetAllBooks();
            }
            else
            {
                dgvBooks.DataSource = bookService.SearchBooks(keyword);
            }

        }
        private void LoadBooks()
        {
            dgvBooks.AutoGenerateColumns = true;
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = bookService.GetAllBooks();
        }

        // Manage Student PANEL EVENTS

        private void buttonMMSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxMMUsername.Text.Trim();

            dgvManageStudents.AutoGenerateColumns = true;
            dgvManageStudents.DataSource = null;

            dgvManageStudents.DataSource = userService.GetAllStudents(keyword);
        }


        private void LoadStudents()
        {
            dgvManageStudents.AutoGenerateColumns = true;
            dgvManageStudents.DataSource = null;
            dgvManageStudents.DataSource = userService.GetAllStudents();
        }

        private void buttonMMActive_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageStudents.CurrentRow.Cells["UserId"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected student.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Mark this student as Active?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            userService.SetStudentStatus(userId, "Active");
            LoadStudents();

        }

        private void buttonMMBlock_Click(object sender, EventArgs e)
        {
            if (dgvManageStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageStudents.CurrentRow.Cells["UserId"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected student.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Block this student?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            userService.SetStudentStatus(userId, "Blocked");
            LoadStudents();

        }


        // Manage Librarian PANEL EVENTS

        private void buttonMLAddLibrarian_Click(object sender, EventArgs e)
        {
            // Required fields check
            if (string.IsNullOrWhiteSpace(textBoxMLFullname.Text) ||
                string.IsNullOrWhiteSpace(textBoxMLUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxMLPassword.Text) ||
                textBoxMLFullname.Text == "Full Name" ||
                textBoxMLUsername.Text == "Username" ||
                textBoxMLPassword.Text == "Password"
                )
            {
                MessageBox.Show("All fields must be filled with valid data.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                userService.RegisterLibrarian(
                    textBoxMLFullname.Text,
                    textBoxMLUsername.Text,
                    textBoxMLPassword.Text

                );

                textBoxMLFullname.Text = "Full Name";
                textBoxMLFullname.ForeColor = Color.Gray;
                textBoxMLUsername.Text = "Username";
                textBoxMLUsername.ForeColor = Color.Gray;
                textBoxMLPassword.Text = "Password";
                textBoxMLPassword.ForeColor = Color.Gray;


                LoadLibrarian();
                MessageBox.Show("Librarian account created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadLibrarian()
        {
            dgvManageLibrarian.AutoGenerateColumns = true;
            dgvManageLibrarian.DataSource = null;
            dgvManageLibrarian.DataSource = userService.GetAllLibrarians();
        }

        

        private void buttonMLRemove_Click(object sender, EventArgs e)
        {
            if (dgvManageLibrarian.CurrentRow == null)
            {
                MessageBox.Show("Please select a librarian.");
                return;
            }

            object userIdValue = dgvManageLibrarian.CurrentRow.Cells["UserId"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected librarian.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "This will permanently delete the librarian account from the database. Continue?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                userService.DeleteLibrarian(userId);
                LoadLibrarian();
                MessageBox.Show("Librarian deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void textBoxMLFullname_Enter(object sender, EventArgs e)
        {
            if (textBoxMLFullname.Text == "Full Name")
            {
                textBoxMLFullname.Text = "";
                textBoxMLFullname.ForeColor = Color.Black;
            }
        }

        private void textBoxMLUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxMLUsername.Text == "Username")
            {
                textBoxMLUsername.Text = "";
                textBoxMLUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxMLPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxMLPassword.Text == "Password")
            {
                textBoxMLPassword.Text = "";
                textBoxMLPassword.ForeColor = Color.Black;
            }
        }



        // REPORTS PANEL EVENTS

        private void LoadReports()
        {
            dgvReports.AutoGenerateColumns = true;
            dgvReports.DataSource = null;
            dgvReports.DataSource = reportService.GetFineReport();
        }
        private void buttonRFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerRStart.Value.Date;
            DateTime endDate = dateTimePickerREnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.");
                return;
            }

            dgvReports.AutoGenerateColumns = true;
            dgvReports.DataSource = null;

            try
            {
                dgvReports.DataSource = reportService.GetFineReport(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ================= HEADER EVENTS =================

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Application.Restart();
        }

        
    }
}
