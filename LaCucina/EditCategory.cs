using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class EditCategory : Form
    {
       UCcategoryRow _selectedRow=null;


        public void loadCategories()
        {
            tblCategories.Controls.Clear();
            foreach(var entry in DataBase.category)
            {
                var value = entry.Value;
                var key = entry.Key;
                UCcategoryRow row = new UCcategoryRow();
                row.name = value.name;
                row.Tag = key;
                row.Edit = () =>
                { //تحفظ الصف المرصوص
                    _selectedRow = row;
                    foreach(UCcategoryRow r in tblCategories.Controls )
                    {
                        r.pnlCategoryRow.BackColor = Color.FromArgb(28,28,28);
                    }
                    row.pnlCategoryRow.BackColor = Color.FromArgb(35,35,35);
                    txtAddCategory.Texts=row.name;
                    btnAddCategory.Visible = false;
                    btnSave.Visible = true;
                   
                   
                };
                row.Delete = () => { 
                    ManagerMenu.DeleteCategory(key);
                    loadCategories() ;
                };
                tblCategories.Controls.Add(row);
                
            }
        }
        public EditCategory()
        {
            InitializeComponent();
            loadCategories();
        }

        private void btnUpdateToppings_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                int key = Convert.ToInt32(_selectedRow.Tag);
               bool Saved= ManagerMenu.EditCategory(key, txtAddCategory.Texts);
                if (Saved)
                {
                    btnAddCategory.Visible = true;
                    btnSave.Visible = false;
                    txtAddCategory.Texts = "";
                    loadCategories();
                }
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddCategory.Texts))
            {
                ManagerMenu.AddCategory(txtAddCategory.Texts);
                loadCategories();
                txtAddCategory.Texts = "";
            }
            else MessageBox.Show("Enter Category");
        }

        private void rjPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                _selectedRow.pnlCategoryRow.BackColor = Color.FromArgb(28, 28, 28);
                txtAddCategory.Texts = "";
                btnAddCategory.Visible = true;
                btnSave.Visible = false;
                pnlMain.Focus();
            }
        }
    }
}
