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
    public partial class UCIngredient : UserControl
    {
        public int id;
        public string name;
        public static UCIngredient lastSelectedIngredient=null;
        public Action OnIngredientDeleted { get; set; }
        public int Id
        {
            get { return id; }
            set { id = value; }

        }
        public string Name
        {
            get { return name; }
            set { name = value; 
            lblIngredient.Text = name;
            }
        }
        public UCIngredient()
        {
            InitializeComponent();
           
        }

        private void pnlIngredient_Click(object sender, EventArgs e)
        {

            if (lastSelectedIngredient != null)
            {
                lastSelectedIngredient.pnlIngredient.BackColor = Color.FromArgb(23, 23, 23);
            }

            lastSelectedIngredient = this;
            lastSelectedIngredient.pnlIngredient.BackColor = Color.FromArgb(35, 35, 35);



        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            //DataBase.ingredients.Remove(this.id);
            //List<int> remove = new List<int>();

            //foreach (var ingredientInItem in DataBase.ingredientInItem)
            //{
            //    if (ingredientInItem.Value.ingredientId == this.id)
            //    {
            //        remove.Add(ingredientInItem.Key);
            //    }
            //}

            //foreach (int id in remove)
            //{
            //    DataBase.ingredientInItem.Remove(id);
            //}
            //this.Dispose();
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete '{this.name}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                
                    // 2. استدعاء اللوجيك المفسول تماماً 🔥
                    bool isDeleted = IngredientsRepository.DeleteIngredient(this.id);

                    if (isDeleted)
                    {
                        // 3. وظيفة الـ UI: تحديث الشاشة وتنبيه العناصر الأخرى
                        OnIngredientDeleted?.Invoke();
                        this.Dispose(); // إخفاء العنصر
                    }
                
               
            }


        }
    }
}
