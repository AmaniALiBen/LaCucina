using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public static class UserManagement
    {
        public static bool AddUser(string username ,string password, string ConfirmPassword, User.Role role , bool isActive,bool isDeleted)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(ConfirmPassword)) {
                MessageBox.Show("fill all fields", "");
                return false;
            }

            foreach (var u in DataBase.users.Values)
            {

                if (u.username == username&&!u.isDeleted)
                {
                    MessageBox.Show("invalid username", "");
                    return false;
                }
            }
            if (password != ConfirmPassword)
            {
                MessageBox.Show("password mismatch", "");
                return false;
            }

            int nextId = DataBase.users.Count > 0 ? DataBase.users.Keys.Max() + 1 : 1;
            User newUser = new User(username, password, isActive, role,false);
            DataBase.users.Add(nextId, newUser);
            MessageBox.Show("user added", "");
            return true;
        }
        public static void FillRoles(RJComboBox cmb, string currentUserRole)
        {
            cmb.Items.Clear();
            cmb.Items.Add("Waiter");
            cmb.Items.Add("Chef");


            if (currentUserRole.ToLower() == "owner")
            {
                cmb.Items.Add("Admin");
            }

            if (cmb.Items.Count > 0) cmb.SelectedIndex = -1;
        }
        public static bool AdminPermission(Control ctrl)
        {
            if (Session.CurrentUser.role == User.Role.Admin)
            {
                ctrl.Visible = false;
                return false;
            }
            else return true;
        }
        public static bool OwnerPermission(Control ctrl, RJToggleButton sw, RJComboBox cmb)
        {
            if (Session.CurrentUser.role == User.Role.Owner)
            {
                cmb.SelectedIndex = 0;
                ctrl.Enabled = false;
                cmb.Enabled = false;
                sw.Enabled = false;
                return false;
            }
            else return true;
        }
        public static void ResetPermissions(Control ctr)
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
        public static void DeleteUser(int key)
        {
            if (DataBase.users.ContainsKey(key))
            {
                User u = DataBase.users[key];
                u.isDeleted = true;
                MessageBox.Show("Deleted successfully", "");
            }

        }
        public static void clearFields(Control ctrl)
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
        public static bool UpdateDB(int key, User user)
        {
            bool updated = false;
            if (user == null)
                return false;
            if (key == 0) return false;
            if (DataBase.users.ContainsKey(key))
            {
                User u = DataBase.users[key];
                u.username = user.username;
                u.role = user.role;
                u.password = user.password;
                u.isActive = user.isActive;
                DataBase.users[key] = u;
                updated = true;
            }
            return updated;
        }
    }
}
