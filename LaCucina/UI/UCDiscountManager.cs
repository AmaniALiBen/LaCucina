using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LaCucina
{
    public partial class UCDiscountManager : UserControl
    {
        public void LoadData()
        {
            tblDiscounts.Controls.Clear();
           foreach( var entry in DataBase.discounts)
            {
                var key = entry.Key;
                var d = entry.Value;
                
                UCRowDiscount row = new UCRowDiscount();
                row.Tag = key;
                row.name = d.name;
                row.type = d.type.ToString();
                if(d.type==Discounts.Type.Percentage)
                row.value = d.value + "%";
                else row.value = d.value +"LYD";
                row.isActive=d.isActive;
                row.startDate = d.start_date;
                row.endtDate = d.end_date;
                if (d.isDeleted)
                    continue;
                tblDiscounts.Controls.Add(row);
            }
        }
        public UCDiscountManager()
        {
            InitializeComponent();
        }

       

        private void UCDiscountManager_Load(object sender, EventArgs e)
        {
            LoadData();
            tblDiscounts.RowDoubleClicked += tblDiscounts_RowDoubleClicked;
            

        }

        Control _selectedRow;

        private void tblDiscounts_RowDoubleClicked(object sender, EventArgs e)
        {
            DiscountsManager.clearFields(pnlAddDiscount);

            Control selectedRow = (Control)sender;
            _selectedRow = (Control)sender;

            if (selectedRow.Tag != null)
           {
                int discountKey = Convert.ToInt32(selectedRow.Tag);
                if (DataBase.discounts.ContainsKey(discountKey))
                {
                    var selectedDiscount = DataBase.discounts[discountKey];


                    txtDiscountName.Texts = selectedDiscount.name;
                    switchisActive.Checked = selectedDiscount.isActive;
                    
                    cmbType.SelectedItem = selectedDiscount.type.ToString();
                    txtValue.Texts = selectedDiscount.value.ToString();
                    pickStartDate.Text = selectedDiscount.start_date;
                    pickEndDate.Text = selectedDiscount.end_date;


                    gradiantAddDiscount.Visible = false;
                    btnClear.Visible = false;
                    gradiantSaveChanges.Visible = true;
                    btnDelete.Visible = true;
                   
                    

                }



            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DiscountsManager.clearFields(pnlAddDiscount);
        }

        

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DiscountsManager.clearFields(pnlAddDiscount);
            gradiantAddDiscount.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;
        }



      

        private void txtValue__TextChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1) return;
            if (cmbType.SelectedItem.ToString() == "Percentage")
            {
                if (double.TryParse(txtValue.Texts, out double val))
                {
                    if (val > 100)
                    {
                        txtValue.Texts = "100";

                    }
                }
            }
            else return;
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

           
            if ((e.KeyChar == '.') && (txtValue.Texts.IndexOf('.') > -1)|| (e.KeyChar == '.') && txtValue.Texts.Length==0)
            {
                e.Handled = true;
            }
        }

        private void cmbType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Enabled = false;
            txtValue.Texts = "";
            if (cmbType.SelectedIndex > -1)
            txtValue.Enabled = true;
            else txtValue.Enabled = false;
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountName.Texts) ||  cmbType.SelectedIndex<0||string.IsNullOrEmpty(txtValue.Texts))
            {
                MessageBox.Show("fill all fields", "");
                return;

            }
            if (Enum.TryParse(cmbType.SelectedItem.ToString(), out Discounts.Type type))
            {
                if (double.TryParse(txtValue.Texts, out double value))
                    DiscountsManager.AddDiscount(txtDiscountName.Texts, type, value, pickStartDate.Text, pickEndDate.Text, switchisActive.Checked);
                LoadData();
               btnDiscard.PerformClick();
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                int key = Convert.ToInt32(_selectedRow.Tag);
                Discounts d = DataBase.discounts[key];
                if (!string.IsNullOrEmpty(txtDiscountName.Texts) && !string.IsNullOrEmpty(txtValue.Texts) && cmbType.SelectedIndex != -1)
                {
                    d.name = txtDiscountName.Texts;
                    d.end_date = pickEndDate.Text.ToString();
                    d.start_date = pickStartDate.Text.ToString();
                    d.type = (Discounts.Type)Enum.Parse(typeof(Discounts.Type), cmbType.SelectedItem.ToString());
                    d.value = Convert.ToDouble(txtValue.Texts);
                    d.isActive = switchisActive.Checked;
                   bool updated= DiscountsManager.UpdateDB(key, d);
                    if (updated) {  LoadData();
                        btnDiscard.PerformClick();
                    }
                }
                else MessageBox.Show("fill all fields", "");

                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int key= Convert.ToInt32(_selectedRow.Tag);
           bool deleted= DiscountsManager.DeleteDiscount(key);
            if(deleted) { btnDiscard.PerformClick();
            
            LoadData();}
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length > 0)
            {
                string search = txtSearch.Texts.ToLower().Trim();
                LoadData();
                for (int i = tblDiscounts.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblDiscounts.Controls[i] is UCRowDiscount ucdiscount)
                    {
                        string name = ucdiscount.name.ToLower().Trim();


                        if (!name.StartsWith(search))
                        {
                            tblDiscounts.Controls.RemoveAt(i);
                        }
                    }
                }
            }
            else LoadData();
        }

        private void cmbFilterStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterStatus.SelectedIndex > -1)
            {
                cmbType.SelectedIndex = -1;
                string Status = cmbFilterStatus.SelectedItem.ToString();
                LoadData();
                for (int i = tblDiscounts.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblDiscounts.Controls[i] is UCRowDiscount ucdiscount)
                    {
                        if (Status == "Active" && !ucdiscount.isActive)
                            tblDiscounts.Controls.RemoveAt(i);

                        else if (Status == "inActive" && ucdiscount.isActive)
                            tblDiscounts.Controls.RemoveAt(i);
                    }
                }
            }
            else LoadData();
        }

        private void cmbFilterType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterType.SelectedIndex > -1)
            {
                cmbFilterStatus.SelectedIndex = -1;
                string type = cmbFilterType.SelectedItem.ToString();
                LoadData();
                for (int i = tblDiscounts.Controls.Count - 1; i >= 0; i--)
                {
                    if (tblDiscounts.Controls[i] is UCRowDiscount ucdiscount)
                    {
                        if (type == "Percentage" && ucdiscount.type==Discounts.Type.Fixed.ToString())
                            tblDiscounts.Controls.RemoveAt(i);

                        else if (type == "Fixed" && ucdiscount.type == Discounts.Type.Percentage.ToString())
                            tblDiscounts.Controls.RemoveAt(i);
                    }
                }
            }
            else LoadData();
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = -1;
            cmbFilterStatus.SelectedIndex= -1;
            LoadData();
        }
    }
}
