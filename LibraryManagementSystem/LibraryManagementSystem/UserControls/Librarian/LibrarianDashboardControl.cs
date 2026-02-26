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

namespace LibraryManagementSystem.UserControls.Librarian
{
    public partial class LibrarianDashboardControl : UserControl
    {
        public LibrarianDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;

        private readonly BookService bookService = new BookService();
        private readonly UserService userService = new UserService();
        private readonly FineRepository reportService = new FineRepository();



        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonManageBooks);
            ShowPanel(panelManageBooks); // default panel
            LoadBooks();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {
            if (panelManageBooks != null) panelManageBooks.Visible = false;
            if (panelActiveBorrows != null) panelActiveBorrows.Visible = false;
            if (panelOverdueFines != null) panelOverdueFines.Visible = false;

        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================



        private void buttonManageBooks_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageBooks);
            LoadBooks();
        }

        private void buttonActiveBorrows_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelActiveBorrows);
            LoadActiveBorrows();
        }


        private void buttonOverDueFines_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelOverdueFines);

            LoadOverdueFines();
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


        private void buttonMBSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxMBSearch.Text.Trim();

            dgvManageBooks.AutoGenerateColumns = true;
            dgvManageBooks.DataSource = null;

            if (string.IsNullOrEmpty(keyword))
            {
                dgvManageBooks.DataSource = bookService.GetAllBooks();
            }
            else
            {
                dgvManageBooks.DataSource = bookService.SearchBooks(keyword);
            }
        }
        private void LoadBooks()
        {
            dgvManageBooks.AutoGenerateColumns = true;
            dgvManageBooks.DataSource = null;
            dgvManageBooks.DataSource = bookService.GetAllBooks();
        }

        private void buttonMBAddBooks_Click(object sender, EventArgs e)
        {
            try
            {
                string title = textBoxBookTitle.Text.Trim();
                string author = textBoxAuthor.Text.Trim();
                string isbn = textBoxIsbn.Text.Trim();

                if (!int.TryParse(textBoxTotalCopies.Text.Trim(), out int totalCopies))
                {
                    MessageBox.Show("Invalid Total Copies.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(isbn))
                {
                    MessageBox.Show("Title, Author, and ISBN are required.");
                    return;
                }

                var book = new LibraryManagementSystem.Models.Book
                {
                    Title = title,
                    Author = author,
                    ISBN = isbn,
                    TotalCopies = totalCopies
                    // AvailableCopies will be set = TotalCopies inside BookService.AddBook(book)
                };

                bookService.AddBook(book);

                LoadBooks();

                textBoxBookTitle.Text = "";
                textBoxAuthor.Text = "";
                textBoxIsbn.Text = "";
                textBoxTotalCopies.Text = "";

                MessageBox.Show("Book added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMBUpdateInventory_Click(object sender, EventArgs e)
        {
            if (dgvManageBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book from the list.");
                return;
            }

            object bookIdValue = dgvManageBooks.CurrentRow.Cells["BookId"].Value;

            if (bookIdValue == null || !int.TryParse(bookIdValue.ToString(), out int bookId))
            {
                MessageBox.Show("Invalid selected book.");
                return;
            }

            if (!int.TryParse(textMBBoxAddCopies.Text.Trim(), out int addCopies) || addCopies <= 0)
            {
                MessageBox.Show("Enter a valid number of copies to add (greater than 0).");
                return;
            }

            try
            {
                var book = bookService.GetBookById(bookId);

                if (book == null)
                {
                    MessageBox.Show("Book not found.");
                    return;
                }

                checked
                {
                    book.TotalCopies += addCopies;
                    book.AvailableCopies += addCopies;
                }

                bookService.UpdateBook(book);

                textMBBoxAddCopies.Text = "";
                LoadBooks();

                MessageBox.Show("Inventory updated successfully.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMBDelete_Click(object sender, EventArgs e)
        {
            if (dgvManageBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a book.");
                return;
            }

            object bookIdValue = dgvManageBooks.CurrentRow.Cells["BookId"].Value;

            if (bookIdValue == null || !int.TryParse(bookIdValue.ToString(), out int bookId))
            {
                MessageBox.Show("Invalid selected book.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete (deactivate) this book?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bookService.DeleteBook(bookId);
                LoadBooks();
                MessageBox.Show("Book deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Manage Student PANEL EVENTS

        private void buttonMMSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxMBSearch.Text.Trim();

            dgvManageBooks.AutoGenerateColumns = true;
            dgvManageBooks.DataSource = null;

            dgvManageBooks.DataSource = userService.GetAllStudents(keyword);
        }


        private void LoadStudents()
        {
            dgvManageBooks.AutoGenerateColumns = true;
            dgvManageBooks.DataSource = null;
            dgvManageBooks.DataSource = userService.GetAllStudents();
        }

        private void buttonMMActive_Click(object sender, EventArgs e)
        {
            if (dgvManageBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageBooks.CurrentRow.Cells["UserId"].Value;

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
            if (dgvManageBooks.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            object userIdValue = dgvManageBooks.CurrentRow.Cells["UserId"].Value;

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
        // Active borrows panel events
        private void LoadActiveBorrows()
        {
            dgvActiveBorrows.AutoGenerateColumns = true;
            dgvActiveBorrows.DataSource = null;

            try
            {
                BorrowRepository borrowRepo = new BorrowRepository();
                dgvActiveBorrows.DataSource = borrowRepo.GetActiveBorrows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        //// overdue and fines PANEL EVENTS



        private void LoadOverdueFines()
        {
            dgvOverduesAndFines.AutoGenerateColumns = true;
            dgvOverduesAndFines.DataSource = null;
            try
            {
                DataTable table = reportService.GetFineReport();
                table.DefaultView.RowFilter = "IsPaid = false";
                dgvOverduesAndFines.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOFFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerOFStart.Value.Date;
            DateTime endDate = dateTimePickerOFEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be greater than end date.");
                return;
            }

            dgvOverduesAndFines.AutoGenerateColumns = true;
            dgvOverduesAndFines.DataSource = null;

            try
            {
                DataTable table = reportService.GetFineReport(startDate, endDate);
                table.DefaultView.RowFilter = "IsPaid = false";
                dgvOverduesAndFines.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMarkPaid_Click(object sender, EventArgs e)
        {
            if (dgvOverduesAndFines.CurrentRow == null)
            {
                MessageBox.Show("Please select a fine.");
                return;
            }

            object fineIdValue = dgvOverduesAndFines.CurrentRow.Cells["FineId"].Value;

            if (fineIdValue == null || !int.TryParse(fineIdValue.ToString(), out int fineId))
            {
                MessageBox.Show("Invalid selected fine.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Mark this fine as paid?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                reportService.MarkAsPaid(fineId);

                // refresh list; paid ones must not be visible
                DataTable table = reportService.GetFineReport();
                table.DefaultView.RowFilter = "IsPaid = false";
                dgvOverduesAndFines.DataSource = table;

                MessageBox.Show("Fine marked as paid.");
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
