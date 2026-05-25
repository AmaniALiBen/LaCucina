using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public  class LoginLogic
    {
        User foundUser=null;
        public bool ConfirmLogin(string username, string password)
        {
            User foundUser = null;
            
            bool found =false;
            foreach (User u in DataBase.users.Values)
            {
                if (u.username == username && u.password == password && !u.isDeleted && u.isActive)
                {
                    this.foundUser =u;
                    foundUser = u;

                    break;
                }
            }

            if (foundUser != null)
            {
                Session.CurrentUser = foundUser;
              found = true; 
            }
            

            return found;
        }
        public   void ShowDialog(Form form ) {
            if (foundUser != null) {
                string role = foundUser.role.ToString();

                switch (role)
                {
                    case "Admin":
                        form.Hide();
                        ManagerForm showForm1 = new ManagerForm(form.FindForm());
                        showForm1.ShowDialog();
                        break;
                    case "Owner":
                        form.Hide();
                        ManagerForm showForm2 = new ManagerForm(form.FindForm());
                        showForm2.ShowDialog();
                        break;
                    case "Waiter":
                        form.Hide();
                        FloorPlanForm showForm3 = new FloorPlanForm(form.FindForm());
                        showForm3.ShowDialog();
                        break;
                    case "Chef":
                        form.Hide();
                        KDS showForm4 = new KDS(form.FindForm());
                        showForm4.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
        
            
        }

      
    }
}
