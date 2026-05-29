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
    public partial class UC_ProductCard : UserControl
    {
        //public string ItemName { get => lblName.Text; set => lblName.Text = value; }
        //public string ItemPrice { get => lblPrice.Text; set => lblPrice.Text = value; }
        //public Image imgItem { get => picBox.Image; set => picBox.Image = value; }
        public UC_ProductCard()
        {
            InitializeComponent();
           // BindClickEvent(this);
        }
        private double price;
        private string name;
        private int id;
      

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                lblPrice.Text = price.ToString() + " LYD";
            }
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                LoadItemImage();
            }
        }

        private void LoadItemImage()
        {
            try
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{id}.png");

                if (File.Exists(imagePath))
                {
                    // Method 1: Read as bytes first (most reliable)
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picBox.Image = new Bitmap(ms);
                    }
                }
                else
                {
                    // Set a default placeholder image
                    picBox.Image = null;
                }
            }
            catch (OutOfMemoryException)
            {
                // Image file is corrupted or invalid format
                picBox.Image = null;
                Console.WriteLine($"Invalid image file for item {id}");
            }
            catch (Exception ex)
            {
                picBox.Image = null;
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                lblName.Text = name;
            }
        }
        public Action clickCard;
    //    private void BindClickEvent(Control parent)
    //{
    //    foreach (Control c in parent.Controls)
    //    {
    //        if (c is PictureBox)
    //        {
    //            c.Click += (s, e) => this.OnClick(e);
    //        }
          
    //        else if (c.HasChildren)
    //        {
    //            BindClickEvent(c);
    //        }
    //        else
    //        {
    //            c.Click += (s, e) => this.OnClick(e);
    //        }
    //    }

       
    //}
       
        private void UC_ProductCard_Load(object sender, EventArgs e)
        {

        }

        private void rjPanel1_Click(object sender, EventArgs e)
        { if (clickCard != null)
                clickCard.Invoke();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            if (clickCard != null)
                clickCard.Invoke();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (clickCard != null)
                clickCard.Invoke();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            if (clickCard != null)
                clickCard.Invoke();
        }
    }


}
