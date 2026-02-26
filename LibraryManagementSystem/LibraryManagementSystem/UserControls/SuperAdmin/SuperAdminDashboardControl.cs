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

namespace LibraryManagementSystem.UserControls.SuperAdmin
{
    public partial class SuperAdminDashboardControl : UserControl
    {
        public SuperAdminDashboardControl()
        {
            InitializeComponent();
            InitializeDashboard();
        }

        private Button? activeMenuButton;
        private static readonly Color MenuNormalColor = Color.SteelBlue;
        private static readonly Color MenuActiveColor = Color.DodgerBlue;


        private readonly UserService userService = new UserService();
        private readonly AuditService auditService = new AuditService();



        // ================= INITIALIZATION =================

        private void InitializeDashboard()
        {
            HideAllContentPanels();
            SetActiveMenuButton(buttonManageAdmin);
            ShowPanel(panelManageAdmin); // default panel
            LoadAdmin();
        }

        // ================= PANEL MANAGEMENT =================

        private void HideAllContentPanels()
        {

            if (panelManageAdmin != null) panelManageAdmin.Visible = false;
            if (panelSystemLogs != null) panelSystemLogs.Visible = false;
        }

        private void ShowPanel(Panel panel)
        {
            if (panel == null) return;

            HideAllContentPanels();
            panel.Visible = true;
        }

        // ================= MENU BUTTON EVENTS =================





        private void buttonManageAdmin_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelManageAdmin);
            LoadAdmin();
        }


        private void buttonSystemLog_Click(object sender, EventArgs e)
        {
            SetActiveMenuButton(sender as Button);
            ShowPanel(panelSystemLogs);
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





        // Manage Librarian PANEL EVENTS


        private void buttonMLAddAdmin_Click(object sender, EventArgs e)
        {
            // Required fields check
            if (string.IsNullOrWhiteSpace(textBoxMAFullname.Text) ||
                string.IsNullOrWhiteSpace(textBoxMAUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxMAPassword.Text) ||
                textBoxMAFullname.Text == "Full Name" ||
                textBoxMAUsername.Text == "Username" ||
                textBoxMAPassword.Text == "Password"
                )
            {
                MessageBox.Show("All fields must be filled with valid data.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                userService.RegisterAdmin(
                    textBoxMAFullname.Text,
                    textBoxMAUsername.Text,
                    textBoxMAPassword.Text

                );

                textBoxMAFullname.Text = "Full Name";
                textBoxMAFullname.ForeColor = Color.Gray;
                textBoxMAUsername.Text = "Username";
                textBoxMAUsername.ForeColor = Color.Gray;
                textBoxMAPassword.Text = "Password";
                textBoxMAPassword.ForeColor = Color.Gray;


                LoadAdmin();
                MessageBox.Show("Admin account created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void LoadAdmin()
        {
            dgvManageAdmin.AutoGenerateColumns = true;
            dgvManageAdmin.DataSource = null;
            dgvManageAdmin.DataSource = userService.GetAllAdmins();
        }


        private void buttonMLRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvManageAdmin.CurrentRow == null)
            {
                MessageBox.Show("Please select an Admin.");
                return;
            }

            object userIdValue = dgvManageAdmin.CurrentRow.Cells["UserId"].Value;

            if (userIdValue == null || !int.TryParse(userIdValue.ToString(), out int userId))
            {
                MessageBox.Show("Invalid selected Admin.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "This will permanently delete the Admin account from the database. Continue?",
                "Confirm delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                userService.DeleteAdmin(userId);
                LoadAdmin();
                MessageBox.Show("Admin deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBoxMAFullname_Enter(object sender, EventArgs e)
        {
            if (textBoxMAFullname.Text == "Full Name")
            {
                textBoxMAFullname.Text = "";
                textBoxMAFullname.ForeColor = Color.Black;
            }
        }

        private void textBoxMAUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxMAUsername.Text == "Username")
            {
                textBoxMAUsername.Text = "";
                textBoxMAUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxMAPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxMAPassword.Text == "Password")
            {
                textBoxMAPassword.Text = "";
                textBoxMAPassword.ForeColor = Color.Black;
            }
        }
 



        // REPORTS PANEL EVENTS

        private void LoadReports()
        {
            dgvSystemLogs.AutoGenerateColumns = true;
            dgvSystemLogs.DataSource = null;
            dgvSystemLogs.DataSource = auditService.GetAllLogs();
        }



        // ================= HEADER EVENTS =================



        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Application.Restart();
        }

        
    }
}
