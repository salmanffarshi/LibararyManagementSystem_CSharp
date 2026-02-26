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

namespace LibraryManagementSystem.UserControls.Student
{

    public partial class StudentDashboardControl : UserControl
    {
        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;

        private readonly BookService bookService = new BookService();
        private readonly UserService userService = new UserService();
        private readonly FineRepository reportService = new FineRepository();
        public StudentDashboardControl()
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
            if (panelReturn1 != null) panelReturn1.Visible = false;
            if (panelBorrow != null) panelBorrow.Visible = false;
            if (panelViewBooks != null) panelViewBooks.Visible = false;
            if (panelProfileUpdate != null) panelProfileUpdate.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================


        private void buttonViewBooks_Click_1(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelViewBooks);
            LoadBooks();
        }
        
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelBorrow);

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);

            ShowPanel(panelReturn1);
            LoadBorrowedBooks();
        }

        private void buttonProfileUpdate_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelProfileUpdate);
            LoadProfileInfo();
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

        private void buttonVBSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxVBIsbn.Text.Trim();

            dgvViewBooks.AutoGenerateColumns = true;
            dgvViewBooks.DataSource = null;

            if (string.IsNullOrEmpty(keyword))
            {
                dgvViewBooks.DataSource = bookService.GetAllBooks();
            }
            else
            {
                dgvViewBooks.DataSource = bookService.SearchBooks(keyword);
            }
        }

        private void LoadBooks()
        {
            dgvViewBooks.AutoGenerateColumns = true;
            dgvViewBooks.DataSource = null;
            dgvViewBooks.DataSource = bookService.GetAllBooks();
        }

        // BORROW PANEL EVENTS

        private void buttonRequestBorrow_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            string isbn = textBoxEnterIsbn.Text.Trim();

            if (string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("Please enter an ISBN.");
                return;
            }

            try
            {
                var matches = bookService.SearchBooks(isbn);

                if (matches == null || matches.Count == 0)
                {
                    MessageBox.Show("No book found with this ISBN.");
                    return;
                }

                var book = matches.FirstOrDefault(b =>
                    string.Equals(b.ISBN, isbn, StringComparison.OrdinalIgnoreCase));

                book ??= matches.FirstOrDefault();

                if (book == null)
                {
                    MessageBox.Show("No book found with this ISBN.");
                    return;
                }

                if (!book.IsActive || book.AvailableCopies <= 0)
                {
                    MessageBox.Show("This book is not available right now.");
                    return;
                }

                int userId = SessionManager.CurrentUser.UserId;

                BorrowService borrowService = new BorrowService();
                borrowService.BorrowBook(userId, book.BookId);

                textBoxEnterIsbn.Text = "";
                MessageBox.Show("Borrow successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Return PANEL EVENTS

        private void LoadBorrowedBooks()
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            dgvBorrowedBooks.AutoGenerateColumns = true;
            dgvBorrowedBooks.DataSource = null;

            try
            {
                int userId = SessionManager.CurrentUser.UserId;

                BorrowRepository borrowRepo = new BorrowRepository();
                List<LibraryManagementSystem.Models.Borrow> activeBorrows = borrowRepo.GetActiveBorrowsByUserId(userId);

                dgvBorrowedBooks.DataSource = activeBorrows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRReturn_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            if (dgvBorrowedBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a borrowed book to return.");
                return;
            }

            object borrowIdValue = dgvBorrowedBooks.CurrentRow.Cells["BorrowId"].Value;

            if (borrowIdValue == null || !int.TryParse(borrowIdValue.ToString(), out int borrowId))
            {
                MessageBox.Show("Invalid selected borrow record.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Return this book?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                BorrowService borrowService = new BorrowService();
                borrowService.ReturnBook(borrowId);

                LoadBorrowedBooks();
                MessageBox.Show("Book returned successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // profile update panel events

        private void LoadProfileInfo()
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            try
            {
                int userId = SessionManager.CurrentUser.UserId;

                UserProfileRepository userProfileRepo = new UserProfileRepository();
                StudentProfileRepository studentProfileRepo = new StudentProfileRepository();

                var userProfile = userProfileRepo.GetByUserId(userId);
                var studentProfile = studentProfileRepo.GetByUserId(userId);

                if (userProfile == null || studentProfile == null)
                {
                    MessageBox.Show("Profile information not found.");
                    return;
                }

                textBoxPUUsername.Text = userProfile.FullName;
                textBoxPUEmail.Text = studentProfile.Email;
                textBoxPUMobile.Text = studentProfile.Mobile;
                textBoxPUDepartment.Text = studentProfile.Department;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPUAUpdateProfile_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            string fullName = textBoxPUUsername.Text.Trim();
            string email = textBoxPUEmail.Text.Trim();
            string mobile = textBoxPUMobile.Text.Trim();
            string department = textBoxPUDepartment.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(mobile) ||
                string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show("Name, Email, Mobile and Department are required.");
                return;
            }

            try
            {
                int userId = SessionManager.CurrentUser.UserId;

                UserProfileRepository userProfileRepo = new UserProfileRepository();
                StudentProfileRepository studentProfileRepo = new StudentProfileRepository();

                var currentUserProfile = userProfileRepo.GetByUserId(userId);
                var currentStudentProfile = studentProfileRepo.GetByUserId(userId);

                if (currentUserProfile == null || currentStudentProfile == null)
                {
                    MessageBox.Show("Profile information not found.");
                    return;
                }

                bool changed =
                    !string.Equals(currentUserProfile.FullName, fullName, StringComparison.Ordinal) ||
                    !string.Equals(currentStudentProfile.Email, email, StringComparison.Ordinal) ||
                    !string.Equals(currentStudentProfile.Mobile, mobile, StringComparison.Ordinal) ||
                    !string.Equals(currentStudentProfile.Department, department, StringComparison.Ordinal);

                if (!changed)
                {
                    MessageBox.Show("No changes detected.");
                    return;
                }

                userProfileRepo.Update(new LibraryManagementSystem.Models.UserProfile
                {
                    UserId = userId,
                    FullName = fullName
                });

                studentProfileRepo.Update(new LibraryManagementSystem.Models.StudentProfile
                {
                    UserId = userId,
                    Email = email,
                    Mobile = mobile,
                    Department = department,
                    DateOfBirth = currentStudentProfile.DateOfBirth // unchanged
                });

                MessageBox.Show("Profile updated successfully.");
                LoadProfileInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ================= HEADER EVENTS =================


        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Application.Restart();
        }

        
    }
}
