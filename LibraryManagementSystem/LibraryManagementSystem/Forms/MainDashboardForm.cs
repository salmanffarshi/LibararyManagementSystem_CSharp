using System;
using System.Windows.Forms;
using LibraryManagementSystem.UserControls.Admin;
using LibraryManagementSystem.UserControls.Librarian;
using LibraryManagementSystem.UserControls.Student;
using LibraryManagementSystem.UserControls.SuperAdmin;
using LibraryManagementSystem.Utils;

namespace LibraryManagementSystem.Forms
{
    public partial class MainDashboardForm : Form
    {
        public MainDashboardForm()
        {
            InitializeComponent();
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            LoadRoleDashboard();
        }

        private void LoadRoleDashboard()
        {
            if (!SessionManager.IsLoggedIn())
            {
                MessageBox.Show("Session expired. Please login again.");
                Application.Restart();
                return;
            }

            int roleId = SessionManager.CurrentUser.RoleId;

            UserControl dashboard = roleId switch
            {
                1 => new SuperAdminDashboardControl(),
                2 => new AdminDashboardControl(),
                3 => new LibrarianDashboardControl(),
                4 => new StudentDashboardControl(),
                _ => null
            };

            if (dashboard == null)
            {
                MessageBox.Show("Unauthorized role.");
                Application.Exit();
                return;
            }

            LoadDashboard(dashboard);
        }

        private void LoadDashboard(UserControl dashboard)
        {
            panelDashboardHost.Controls.Clear();
            dashboard.Dock = DockStyle.Fill;
            panelDashboardHost.Controls.Add(dashboard);
        }
    }
}
