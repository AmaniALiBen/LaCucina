using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCIngredientInItem : UserControl
    {
        
        public int itemId;
        public int ingredientId;
        public bool isMain;
        public string name;
      public string Name
        {
            get { return name; }
            set { name = value; 
            lblIngredient.Text = value;
            }
        }

        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
            }
        }

        public int IngredientId
        {
            get
            {
                return ingredientId;
            }
            set
            {
                ingredientId = value;
            }
        }

        public bool IsMain
        {
            get
            {
                return isMain;
            }
            set
            {
                isMain = value;
            }
        }
        public UCIngredientInItem()
        {
            InitializeComponent(); 

        }


        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
           

        }
    }
}
