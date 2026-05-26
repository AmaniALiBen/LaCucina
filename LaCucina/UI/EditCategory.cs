using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LaCucina.Models;     
using LaCucina.DataLink;   

namespace LaCucina
{
    public partial class EditCategory : Form
    {
       
        private List<Categories> _localCategories = new List<Categories>();
        private List<int> _categoriesToDelete = new List<int>();

        private UCcategoryRow _selectedRow = null;
        private int _temporaryIdCounter = -1;

       // public Action Done { get; set; }

        public EditCategory()
        {
            InitializeComponent();

          
            LoadInitialData();
        }

       
        private void LoadInitialData()
        {
            _localCategories = CategoryRepository.GetAll();

            RefreshCategoryTable();
        }

        public void RefreshCategoryTable()
        {
            tblCategories.Controls.Clear();

            foreach (var category in _localCategories)
            {
                UCcategoryRow row = new UCcategoryRow();
                row.name = category.name;
                row.Tag = category.id; 

               
                row.Edit = () =>
                {
                    _selectedRow = row;
                    foreach (UCcategoryRow r in tblCategories.Controls)
                    {
                        r.pnlCategoryRow.BackColor = Color.FromArgb(28, 28, 28);
                    }
                    row.pnlCategoryRow.BackColor = Color.FromArgb(35, 35, 35);
                    txtAddCategory.Texts = row.name;
                    btnAddCategory.Visible = false;
                    btnSave.Visible = true;
                };

               
                row.Delete = () =>
                {
                    int id = Convert.ToInt32(row.Tag);

                    if (id > 0)
                    {
                        _categoriesToDelete.Add(id);
                    }

                    _localCategories.RemoveAll(c => c.id == id);

                    RefreshCategoryTable();
                    ResetInputFields();
                };

                tblCategories.Controls.Add(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null && !string.IsNullOrWhiteSpace(txtAddCategory.Texts))
            {
                int key = Convert.ToInt32(_selectedRow.Tag);

                var categoryToUpdate = _localCategories.FirstOrDefault(c => c.id == key);
                if (categoryToUpdate != null)
                {
                    categoryToUpdate.name = txtAddCategory.Texts.Trim();
                }

                ResetInputFields();
                RefreshCategoryTable(); 
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAddCategory.Texts))
            {
                Categories newCategory = new Categories
                (
                     _temporaryIdCounter--,
                     txtAddCategory.Texts.Trim()
                );

                _localCategories.Add(newCategory);

                RefreshCategoryTable(); 
                txtAddCategory.Texts = "";
            }
            else
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
                foreach (int deleteId in _categoriesToDelete)
                {
                    CategoryRepository.Delete(deleteId);
                }

                foreach (var category in _localCategories)
                {
                    if (category.id < 0)
                    {
                        CategoryRepository.Add(category.name);
                    }
                    else
                    {
                       CategoryRepository.Update(category);
                    }
                }

                MessageBox.Show("All changes have been successfully committed to the database!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

               
              //  Done?.Invoke();
                this.Close();
            
           
        }

        private void ResetInputFields()
        {
            _selectedRow = null;
            btnAddCategory.Visible = true;
            btnSave.Visible = false;
            txtAddCategory.Texts = "";
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                foreach (UCcategoryRow r in tblCategories.Controls)
                {
                    r.pnlCategoryRow.BackColor = Color.FromArgb(28, 28, 28);
                }
                ResetInputFields();
                pnlMain.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}