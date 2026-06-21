using CustomControls.RJControls;
using System;
using System.Windows.Forms;

namespace LaCucina
{
    public  class DiscountsManager
    {
        DiscountRepository discountRepository = new DiscountRepository();
        public virtual void clearFields(Control ctrl)
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
                    date.Value = DateTime.Now;

                if (c.HasChildren)
                    clearFields(c);
            }
        }

        public virtual bool DateLogic(string startDate, string endDate)
        {
            if (DateTime.TryParse(startDate, out DateTime start) && DateTime.TryParse(endDate, out DateTime end))
            {
                return end.Date >= start.Date;
            }
            return false;
        }

        public virtual bool AddDiscount(string name, Discounts.Type type, double value, string startDate, string endDate, bool isActive)
        {
            if (!DateLogic(startDate, endDate))
            {
                MessageBox.Show("Invalid date: End date must be after or equal to start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            Discounts newDiscount = new Discounts(name, type, value, startDate, endDate, isActive, false);
            discountRepository.Add(newDiscount);
            MessageBox.Show("Discount added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public virtual bool UpdateDB(int key, Discounts discount)
        {
            if (key == 0 || discount == null) return false;

            if (!DateLogic(discount.start_date, discount.end_date))
            {
                MessageBox.Show("Invalid date: End date must be after or equal to start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            discountRepository.Update(key, discount);
            MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public virtual bool DeleteDiscount(int key)
        {
            if (key == 0) return false;

            discountRepository.Delete(key);
            MessageBox.Show("Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}