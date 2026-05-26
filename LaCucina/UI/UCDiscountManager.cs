using System;
using System.Data;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCDiscountManager : UserControl
    {
        Control _selectedRow;

        public UCDiscountManager()
        {
            InitializeComponent();
        }

        // 🚀 الطريقة الشغالة والمضمونة: الشحن المباشر من الـ DataTable لربط الـ ID الحقيقي بالأسطر
        public void LoadData()
        {
            tblDiscounts.Controls.Clear();

            // استدعاء دالة الـ DataTable الأصلية من الريبو لقراءة الـ IDs بشكل صحيح
            DataTable dt = DiscountRepository.GetAllDiscountsTable();

            foreach (DataRow row in dt.Rows)
            {
                UCRowDiscount ucrow = new UCRowDiscount();

                ucrow.Tag = Convert.ToInt32(row["discount_id"]);
                ucrow.name = row["discount_name"].ToString();

                int typeVal = Convert.ToInt32(row["discount_type"]);
                double amount = Convert.ToDouble(row["discount_amount"]);

                if (typeVal == 0)
                {
                    ucrow.type = "Percentage";
                    ucrow.value = amount + "%";
                }
                else
                {
                    ucrow.type = "Fixed";
                    ucrow.value = amount + " LYD";
                }

                ucrow.isActive = Convert.ToBoolean(row["is_active"]);
                ucrow.startDate = row["start_date"] != DBNull.Value ? Convert.ToDateTime(row["start_date"]).ToString("yyyy-MM-dd") : DateTime.Today.ToString("yyyy-MM-dd");
                ucrow.endtDate = row["end_date"] != DBNull.Value ? Convert.ToDateTime(row["end_date"]).ToString("yyyy-MM-dd") : DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");

                tblDiscounts.Controls.Add(ucrow);
            }
        }

        private void UCDiscountManager_Load(object sender, EventArgs e)
        {
            LoadData();
            // ربط الحدث الأصلي للجدول كما كان تماماً
            tblDiscounts.RowDoubleClicked += tblDiscounts_RowDoubleClicked;
        }

        // 🎯 حدث النقر المزدوج الأصلي المستقر
        private void tblDiscounts_RowDoubleClicked(object sender, EventArgs e)
        {
            txtDiscountName.Texts = "";
            txtValue.Texts = "";

            Control selectedRow = (Control)sender;
            _selectedRow = (Control)sender;

            if (selectedRow.Tag != null)
            {
                int dbId = Convert.ToInt32(selectedRow.Tag);

                // جلب بيانات الخصم الفردية حياً من الداتابيز
                DataTable dt = DatabaseHelper.ExecuteQuery($"SELECT discount_name, discount_type, discount_amount, start_date, end_date, is_active FROM discounts WHERE discount_id = {dbId}");

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtDiscountName.Texts = row["discount_name"].ToString();
                    switchisActive.Checked = Convert.ToBoolean(row["is_active"]);

                    int typeVal = Convert.ToInt32(row["discount_type"]);
                    cmbType.SelectedItem = (typeVal == 0) ? "Percentage" : "Fixed";

                    txtValue.Texts = row["discount_amount"].ToString();

                    if (row["start_date"] != DBNull.Value) pickStartDate.Text = Convert.ToDateTime(row["start_date"]).ToString("yyyy-MM-dd");
                    if (row["end_date"] != DBNull.Value) pickEndDate.Text = Convert.ToDateTime(row["end_date"]).ToString("yyyy-MM-dd");

                    // تبديل الأزرار الفخمة في الواجهة
                    gradiantAddDiscount.Visible = false;
                    btnClear.Visible = false;
                    gradiantSaveChanges.Visible = true;
                    btnDelete.Visible = true;
                }
            }
        }

        // ➕ إضافة خصم جديد باستخدام اللوجيك وفحص التواريخ
        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountName.Texts) || cmbType.SelectedIndex < 0 || string.IsNullOrEmpty(txtValue.Texts))
            {
                MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Enum.TryParse(cmbType.SelectedItem.ToString(), out Discounts.Type type))
            {
                if (double.TryParse(txtValue.Texts, out double value))
                {
                    // استدعاء دالة اللوجيك الحية التي تضيف لقاعدة البيانات مباشرة
                    bool success = DiscountsManager.AddDiscount(
                        txtDiscountName.Texts,
                        type,
                        value,
                        pickStartDate.Text,
                        pickEndDate.Text,
                        switchisActive.Checked
                    );

                    if (success)
                    {
                        LoadData();
                        btnDiscard.PerformClick();
                    }
                }
            }
        }

        // 💾 حفظ التعديلات المستقرة
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                int dbId = Convert.ToInt32(_selectedRow.Tag);

                if (string.IsNullOrEmpty(txtDiscountName.Texts) || string.IsNullOrEmpty(txtValue.Texts) || cmbType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Discounts.Type type = (Discounts.Type)Enum.Parse(typeof(Discounts.Type), cmbType.SelectedItem.ToString());
                double value = Convert.ToDouble(txtValue.Texts);

                Discounts updatedDiscount = new Discounts(
                    txtDiscountName.Texts,
                    type,
                    value,
                    pickStartDate.Text,
                    pickEndDate.Text,
                    switchisActive.Checked,
                    false
                );

                // استدعاء اللوجيك للتحديث
                bool success = DiscountsManager.UpdateDB(dbId, updatedDiscount);

                if (success)
                {
                    LoadData();
                    btnDiscard.PerformClick();
                }
            }
        }

        // ❌ حذف الخصم
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                int dbId = Convert.ToInt32(_selectedRow.Tag);

                bool success = DiscountsManager.DeleteDiscount(dbId);

                if (success)
                {
                    btnDiscard.PerformClick();
                    LoadData();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DiscountsManager.clearFields(this);
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DiscountsManager.clearFields(this);
            gradiantAddDiscount.Visible = true;
            btnClear.Visible = true;
            gradiantSaveChanges.Visible = false;
            btnDelete.Visible = false;
            _selectedRow = null;
        }

        private void txtValue__TextChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1) return;
            if (cmbType.SelectedItem.ToString() == "Percentage")
            {
                if (double.TryParse(txtValue.Texts, out double val))
                {
                    if (val > 100) txtValue.Texts = "100";
                }
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (txtValue.Texts.IndexOf('.') > -1) || (e.KeyChar == '.') && txtValue.Texts.Length == 0)
            {
                e.Handled = true;
            }
        }

        private void cmbType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtValue.Enabled = cmbType.SelectedIndex > -1;
            txtValue.Texts = "";
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
                cmbFilterType.SelectedIndex = -1;
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
                        if (type == "Percentage" && ucdiscount.type == "Fixed")
                            tblDiscounts.Controls.RemoveAt(i);
                        else if (type == "Fixed" && ucdiscount.type == "Percentage")
                            tblDiscounts.Controls.RemoveAt(i);
                    }
                }
            }
            else LoadData();
        }

        private void btnNoFilter_Click(object sender, EventArgs e)
        {
            cmbFilterType.SelectedIndex = -1;
            cmbFilterStatus.SelectedIndex = -1;
            LoadData();
        }
    }
}