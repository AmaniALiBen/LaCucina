using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public static class DiscountsManager
    {
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
                else if (c is RJDatePicker date)
                   date.Value=DateTime.Now;
                if (c.HasChildren)
                    clearFields(c);
            }
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
        public static bool DeleteDiscount(int key)
        {
            if (DataBase.discounts.ContainsKey(key))
            {
                Discounts d = DataBase.discounts[key];
                d.isDeleted = true;
                MessageBox.Show("Deleted successfully", "");
                return true;
            }
            return false;

        }
        public static bool UpdateDB(int key, Discounts discount)
        {
            if (discount == null)
                return false;
            if (key == 0) return  false;
            if (DataBase.discounts.ContainsKey(key))
            {
                Discounts d = DataBase.discounts[key];
                bool validDate=DateLogic(d.start_date, d.end_date);
                d.name = discount.name;
                d.value = discount.value;
                d.type = discount.type;
                d.isActive = discount.isActive;
                d.start_date = discount.start_date;
                d.end_date = discount.end_date;
                if (validDate)
                {
                    DataBase.discounts[key] = d;
                    MessageBox.Show("Updated Successfully", "");
                    return true;
                }
                else {
                    MessageBox.Show("invalid Date");
                        return false;

                }
            } else return false;
            
        }
        public static bool DateLogic(string startDate,string endDate)
        {
            string[] StartDate;
            string[] EndDate;
            StartDate = startDate.Split('/');
            EndDate = endDate.Split('/');
            bool ValidDate = false;
            if (Convert.ToInt32(StartDate[0]) > Convert.ToInt32(EndDate[0]))

                ValidDate = false;
            if (Convert.ToInt32(StartDate[0]) == Convert.ToInt32(EndDate[0]))
            {
                if (Convert.ToInt32(StartDate[1]) > Convert.ToInt32(EndDate[1]))
                    ValidDate = false;
                else if (Convert.ToInt32(StartDate[1]) < Convert.ToInt32(EndDate[1]))
                    ValidDate = true;
                else if (Convert.ToInt32(StartDate[1]) == Convert.ToInt32(EndDate[1]))
                {
                    if (Convert.ToInt32(StartDate[2]) <= Convert.ToInt32(EndDate[2]))
                        ValidDate = true;
                    else if (Convert.ToInt32(StartDate[2]) > Convert.ToInt32(EndDate[2]))
                        ValidDate = false;
                }
            }


            else if (Convert.ToInt32(StartDate[0]) < Convert.ToInt32(EndDate[0]))
            {
                ValidDate = true;
            }
            if(ValidDate) return true;
            else return false;
        }

        public static void AddDiscount(string name, Discounts.Type type, double value, string startDate, string endDate, bool isActive)
        {

            //string[] StartDate;
            //string[] EndDate;
            //StartDate = startDate.Split('/');
            //EndDate = endDate.Split('/');
            //bool ValidDate = false;
            //if (Convert.ToInt32(StartDate[0]) > Convert.ToInt32(EndDate[0]))

            //    ValidDate = false;
            //if (Convert.ToInt32(StartDate[0]) == Convert.ToInt32(EndDate[0]))
            //{
            //    if (Convert.ToInt32(StartDate[1]) > Convert.ToInt32(EndDate[1]))
            //        ValidDate = false;
            //    else if (Convert.ToInt32(StartDate[1]) < Convert.ToInt32(EndDate[1]))
            //        ValidDate = true;
            //    else if (Convert.ToInt32(StartDate[1]) == Convert.ToInt32(EndDate[1]))
            //    {
            //        if (Convert.ToInt32(StartDate[2]) <= Convert.ToInt32(EndDate[2]))
            //            ValidDate = true;
            //        else if (Convert.ToInt32(StartDate[2]) > Convert.ToInt32(EndDate[2]))
            //            ValidDate = false;
            //    }
            //}


            //else if (Convert.ToInt32(StartDate[0]) < Convert.ToInt32(EndDate[0]))
            //{
            //    ValidDate = true;
            //}
            bool validDate=DateLogic(startDate, endDate);
            if (!validDate)
            { 
            MessageBox.Show("invalid date", "");
            return; }
            
            else { 

            int nextId = DataBase.discounts.Count > 0 ? DataBase.discounts.Keys.Max() + 1 : 1;
            Discounts newDiscount = new Discounts(name, type,value, startDate,endDate,isActive,  false);
            DataBase.discounts.Add(nextId, newDiscount);
            MessageBox.Show("discount added", "");
            }
        }
    }
}
