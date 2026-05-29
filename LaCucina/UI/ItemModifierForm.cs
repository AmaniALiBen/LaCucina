using LaCucina.Models;
using LaCucina.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina.UI
{
    public partial class ItemModifierForm : Form
    {
        private MemoryOrderItem _currentItem;
        public ItemModifierForm(MemoryOrderItem item)
        {

            InitializeComponent();
            this._currentItem = item;
        }

       
        
        private void ItemModifierForm_Load(object sender, EventArgs e)
        {
            ItemModifierService service = new ItemModifierService();
            ItemDetails itemdetail = service.GetItemCustomizationDetails(this._currentItem.MenuItemId);

            if (itemdetail != null)
            {
                lblItemName.Text = itemdetail.ItemName;

                pnlBase.Controls.Clear();
                foreach (var ing in itemdetail.MainIngredients)
                {
                    btnIngredient btn = new btnIngredient();
                    btn.btnName = ing.IngredientName;
                    pnlBase.Controls.Add(btn);
                }

                pnlOptional.Controls.Clear();
                foreach (var ing in itemdetail.ExtraIngredients)
                {
                    btnOptionalIngredient btn = new btnOptionalIngredient();
                    btn.btnName = ing.IngredientName;
                    btn.Tag = ing.IngredientId;
                    btn.btnClick = () => {  };
                    bool isAlreadyRemoved = _currentItem.RemovedIngredientIds.Contains(ing.IngredientId);
                    btn.isChecked = !isAlreadyRemoved;

                    pnlOptional.Controls.Add(btn);
                }
            }
        }

        private void smoothFlowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblItemName_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            _currentItem.RemovedIngredientIds.Clear();
            _currentItem.NoteText = txtNote.Text.Trim();
            foreach (Control ctrl in pnlOptional.Controls)
            {
                if (ctrl is btnOptionalIngredient btnOptional)
                {
                    if (!btnOptional.isChecked)
                    {
                        int ingredientId = Convert.ToInt32(btnOptional.Tag);
                        _currentItem.RemovedIngredientIds.Add(ingredientId);
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
