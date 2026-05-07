using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UCManagerItemCard : UserControl
    {
        private double price;
        private string name;
        private int id;
        public Action Delete;

        public double Price
        {
            get { return price; }   
            set { price = value; 
            lblPrice.Text = price.ToString()+" LYD";

            }
        }
        public int Id
        {
            get { return id; }
            set { id = value;
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{id}.png");
                if (File.Exists(imagePath))
                    picboxImage.Image = Image.FromFile(imagePath);

            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value;
            
            lblName.Text = name;}
        }

       
        public UCManagerItemCard()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete?.Invoke();
            //this.Parent.Controls.Remove(this);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            EditItem editItem = new EditItem();
            editItem.ShowDialog();
            if (editItem.DialogResult == DialogResult.Cancel || editItem.DialogResult == DialogResult.OK)
            {
                editItem.Close();
            }


        }
    }
}
