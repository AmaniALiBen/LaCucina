using CustomControls.RJControls;
using LaCucina;
using LaCucina.controls;
using System;
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
       
        public void LoadData()
        {
           tblUsers.Controls.Clear();
            int i = 0;
            foreach (var entry in DataBase.users)
            {   
                var key = entry.Key;
                var user = entry.Value;
             UCuserRow row = new UCuserRow();
                row.Tag = key;
                row.Role = user.role.ToString();
                row.Username = user.username.ToString();
                row.isActive = user.isActive;
                
                    if (i % 2 == 0)

                        row.rjPanel1.BackColor = Color.FromArgb(10, 10, 10);

                    else row.rjPanel1.BackColor = Color.FromArgb(17, 17, 17);
                if (Session.CurrentUser.role == User.Role.Admin &&( user.role == User.Role.Admin||user.role == User.Role.Owner )||user.isDeleted)
                    continue;
                 tblUsers.Controls.Add(row);
                    i++; 

            }
            






            
        }
        public UCUserManegment()
        {
            InitializeComponent();
            tblUsers.RowDoubleClicked += tblUsers_RowDoubleClicked;
        }

        
        private void smoothFlowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void USuserManegment_Load(object sender, EventArgs e)
        {
            
            LoadData();
            UserManagement.FillRoles(cmbRoles, Session.CurrentUser.role.ToString());
            UserManagement.FillRoles(cmbFilterRoles, Session.CurrentUser.role.ToString());
            gradiantAddUser.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;



        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

        }

        private void rjPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

            if (Enum.TryParse(cmbRoles.Texts, out User.Role role))
            {
                bool status = UserManagement.AddUser(txtUsername.Texts, txtPassword.Texts, txtPasswordVerification.Texts, role, switchIsActive.Checked, false);
                if (status)
                {

                    UserManagement.clearFields(pnlAddUser);
                    LoadData();
                    UserManagement.ResetPermissions(pnlAddUser);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            UserManagement.clearFields(pnlAddUser);
        }

        

        private void label12_Click(object sender, EventArgs e)
        {

        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }
        Control _selectedRow;
        private void tblUsers_RowDoubleClicked(object sender, EventArgs e)
        {
            UserManagement.clearFields(pnlAddUser);
            UserManagement.ResetPermissions(pnlAddUser);
           
            Control selectedRow = (Control)sender;
            _selectedRow = (Control)sender;
            
            if (selectedRow.Tag != null)
            {
                int userKey = Convert.ToInt32(selectedRow.Tag);
                if (DataBase.users.ContainsKey(userKey))
                {
                    var selectedUser = DataBase.users[userKey];
                   
                   
                    txtUsername.Texts = selectedUser.username;
                   switchIsActive.Checked = selectedUser.isActive;
                    cmbRoles.SelectedItem=selectedUser.role.ToString();

                   gradiantAddUser.Visible = false;
                   btnClear.Visible = false;    
                   gradiantSaveChanges.Visible = true;
                    btnDelete.Visible = true;
                    UserManagement.AdminPermission(btnDelete);
                    if(selectedUser.role==User.Role.Owner)
                    UserManagement.OwnerPermission(btnDelete, switchIsActive, cmbRoles);

                }



            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
           
           gradiantAddUser.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;
            UserManagement.ResetPermissions(pnlAddUser);
            UserManagement.clearFields(pnlAddUser);
        }



        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length > 0) {
                string search = txtSearch.Texts.ToLower().Trim();
                LoadData();
                for (int i = tblUsers.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblUsers.Controls[i] is UCuserRow ucuser)
                    {
                        string name = ucuser.Username.ToLower().Trim();

                       
                        if (!name.StartsWith(search))
                        {
                            tblUsers.Controls.RemoveAt(i);
                        }
                    }
                }
            }
            else LoadData();
             
        }

        private void cmbFilterStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterStatus.SelectedIndex> -1)
            {
                cmbFilterRoles.SelectedIndex = -1;
                string Status = cmbFilterStatus.SelectedItem.ToString();
                LoadData();
                for (int i = tblUsers.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblUsers.Controls[i] is UCuserRow ucuser)
                    {
                        if(Status=="Active"&&!ucuser.isActive)
                            tblUsers.Controls.RemoveAt(i);

                        else if(Status == "inActive" && ucuser.isActive)
                            tblUsers.Controls.RemoveAt(i);
                    }
                }
            }
            else LoadData();
        }

        private void cmbFilterRoles_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterRoles.SelectedIndex>-1)
            {
                cmbFilterStatus.SelectedIndex = -1;
                string Role = cmbFilterRoles.SelectedItem.ToString();
                LoadData();
                for (int i = tblUsers.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblUsers.Controls[i] is UCuserRow ucuser)
                    {
                        if(ucuser.Role!=Role)
                            tblUsers.Controls.RemoveAt(i);
                    }
                }
            }
            else LoadData();
        }

       

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            
            if (_selectedRow.Tag != null) {
                int key = Convert.ToInt32(_selectedRow.Tag);
                User u = DataBase.users[key];
                if (!string.IsNullOrEmpty(txtUsername.Texts) && cmbRoles.SelectedIndex != -1)
                {
                    u.username = txtUsername.Texts;
                    if(u.role!=User.Role.Owner)
                    u.role = (User.Role)Enum.Parse(typeof(User.Role), cmbRoles.Texts);
                    u.isActive = switchIsActive.Checked;
                    if (!string.IsNullOrEmpty(txtPassword.Texts))
                    {
                        if (string.IsNullOrEmpty(txtPasswordVerification.Texts))
                            MessageBox.Show("Fill Password verification", "Warning");
                       
                        else if(txtPassword.Texts!=txtPasswordVerification.Texts)
                            MessageBox.Show("Password Mismatch", "Warning");
                        else u.password = txtPassword.Texts;

                    }
                  bool success= UserManagement.UpdateDB(key, u);
                    if (success) {
                        UserManagement.clearFields(pnlAddUser);
                        MessageBox.Show("Updated Successfully", "");
                        LoadData();
                    }


                }
               else MessageBox.Show("Fill All Fields ", "Warning");
            }
            
        }

        private void rJgradiantPanal2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if(_selectedRow.Tag!=null)
            {
                int key =Convert.ToInt32(_selectedRow.Tag.ToString()) ;
                UserManagement.DeleteUser(key);
                btnDiscard_Click(sender, e);
                LoadData();
            }

          }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            cmbFilterStatus.SelectedIndex = -1;
            cmbFilterRoles.SelectedIndex = -1;
            LoadData();
        }
    }
}
