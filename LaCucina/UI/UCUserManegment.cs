using CustomControls.RJControls;
using LaCucina;
using LaCucina.controls;
using System;
using LaCucina.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCUserManegment : UserControl
    {
        Control _selectedRow;
        UserManagementService Service = new UserManagementService();
        private List<User> allUsers;

        public void LoadData(List<User> users)
        {
            tblUsers.Controls.Clear();

            int i = 0;

            foreach (User user in users)
            {
                UCuserRow row = new UCuserRow();

                row.Tag = user.Id;

                row.Role = user.UserRole.ToString();

                row.Username = user.Username;

                row.isActive = user.IsActive;

                if (i % 2 == 0)
                    row.rjPanel1.BackColor = Color.FromArgb(10, 10, 10);
                else
                    row.rjPanel1.BackColor = Color.FromArgb(17, 17, 17);

                tblUsers.Controls.Add(row);

                i++;
            }
        }

        public UCUserManegment()
        {
            InitializeComponent();
            tblUsers.RowDoubleClicked += tblUsers_RowDoubleClicked;
        }

        private void USuserManegment_Load(object sender, EventArgs e)
        {
            allUsers = Service.GetAllUsers();
            LoadData(allUsers);
            FillRoles(cmbRoles, Session.CurrentUser.UserRole.ToString());
            FillRoles(cmbFilterRoles, Session.CurrentUser.UserRole.ToString());
            gradiantAddUser.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;
        }

        public void FillRoles(RJComboBox cmb, string currentUserRole)
        {
            cmb.Items.Clear();
            cmb.Items.Add("Waiter");
            cmb.Items.Add("Chef");

            if (cmb.Items.Count > 0) cmb.SelectedIndex = -1;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // ✅ FIXED: Changed User.Role to Role
            if (!Enum.TryParse(cmbRoles.Texts, out Role role))
                return;

            string result = Service.AddUser(
                txtUsername.Texts,
                txtPassword.Texts,
                txtPasswordVerification.Texts,
                role,
                switchIsActive.Checked
            );

            if (result != null)
            {
                MessageBox.Show(result);
                return;
            }

            MessageBox.Show("User added");

            clearFields(pnlAddUser);

            allUsers = Service.GetAllUsers();

            LoadData(allUsers);

            ResetPermissions(pnlAddUser);
        }

        public void ResetPermissions(Control ctr)
        {
            foreach (Control c in ctr.Controls)
            {
                c.Enabled = true;
                if (c.HasChildren)
                {
                    ResetPermissions(c);
                }
            }
        }

        public void clearFields(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                else if (c is RJComboBox cmb)
                    cmb.SelectedIndex = -1;
                else if (c is RJToggleButton togg)
                    togg.Checked = true;
                if (c.HasChildren)
                    clearFields(c);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields(pnlAddUser);
        }

        private void tblUsers_RowDoubleClicked(object sender, EventArgs e)
        {
            clearFields(pnlAddUser);

            ResetPermissions(pnlAddUser);

            Control selectedRow = (Control)sender;

            _selectedRow = selectedRow;

            if (selectedRow.Tag == null)
                return;

            int userId = Convert.ToInt32(selectedRow.Tag);

            User selectedUser = Service.GetUserById(userId);

            if (selectedUser == null)
                return;

            // ✅ FIXED: Changed User.Role.Admin to Role.Admin
            if (selectedUser.UserRole == Role.Admin)
            {
                cmbRoles.Visible = false;
                pnlActive.Visible = false;
                lblRole.Visible = false;
                btnDelete.Visible = false;
                cmbRoles.Texts = "Admin";
            }
            else
            {
                cmbRoles.Visible = true;
                pnlActive.Visible = true;
                lblRole.Visible = true;
                btnDelete.Visible = true;
            }

            txtUsername.Texts = selectedUser.Username;

            switchIsActive.Checked = selectedUser.IsActive;

            cmbRoles.SelectedItem = selectedUser.UserRole.ToString();

            gradiantAddUser.Visible = false;

            btnClear.Visible = false;

            gradiantSaveChanges.Visible = true;

            btnDelete.Visible = true;
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            gradiantAddUser.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;
            ResetPermissions(pnlAddUser);
            clearFields(pnlAddUser);
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Texts;

            List<User> filteredUsers = Service.SearchUsers(allUsers, search);

            LoadData(filteredUsers);
        }

        private void cmbFilterStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilterRoles.SelectedIndex = -1;

            List<User> users;

            if (cmbFilterStatus.SelectedIndex == -1)
                users = allUsers;
            else
                users = Service.FilterByStatus(
                    allUsers,
                    cmbFilterStatus.SelectedItem.ToString()
                );

            LoadData(users);
        }

        private void cmbFilterRoles_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = -1;

            List<User> users;

            if (cmbFilterRoles.SelectedIndex == -1)
                users = allUsers;
            else
                users = Service.FilterByRole(
                    allUsers,
                    cmbFilterRoles.SelectedItem.ToString()
                );

            LoadData(users);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_selectedRow?.Tag == null)
                return;

            int id = Convert.ToInt32(_selectedRow.Tag);

            // ✅ FIXED: Changed User.Role to Role
            User user = new User(
                id,
                txtUsername.Texts,
                txtPassword.Texts,
                (Role)Enum.Parse(typeof(Role), cmbRoles.Texts),
                switchIsActive.Checked
            );

            string confirmPassword = txtPasswordVerification.Texts;

            bool success = Service.UpdateUser(user, confirmPassword);

            if (success)
            {
                clearFields(pnlAddUser);

                MessageBox.Show("Updated Successfully");

                allUsers = Service.GetAllUsers();

                LoadData(allUsers);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRow == null || _selectedRow.Tag == null)
            {
                MessageBox.Show("Select a user first");
                return;
            }

            int id = Convert.ToInt32(_selectedRow.Tag.ToString());

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
                return;

            bool success = Service.DeleteUser(id);

            if (success)
            {
                MessageBox.Show("Deleted successfully");
                allUsers = Service.GetAllUsers();
                LoadData(allUsers);
                btnDiscard.PerformClick();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = -1;
            cmbFilterRoles.SelectedIndex = -1;
            LoadData(allUsers);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPasswordVerification.Focus();
            }
        }

        private void txtPasswordVerification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                cmbRoles.Focus();
                cmbRoles.Open();
            }
        }

        private void cmbRoles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnAddUser.Visible) { btnAddUser.PerformClick(); }
                else { btnSaveChanges.PerformClick(); }
            }
        }
    }
}