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
    public partial class UCIngredientInItem : UserControl
    {
        public int id;
        public int itemId;
        public int ingredientId;
        public bool isMain;
        public UCIngredientInItem(int id,int itemId,int ingredientId,bool isMain)
        {
            InitializeComponent();
            this.id = id;
            this.itemId = itemId;
            this.ingredientId = ingredientId;
            this.isMain = isMain;
            lblIngredient.Text = DataBase.ingredients[ingredientId].name;

        }


        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
             DataBase.ingredientInItem.Remove(id);
            this.Dispose();
           

        }
    }
}
