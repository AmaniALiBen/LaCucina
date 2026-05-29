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
    public partial class UCMenuEditorItem : UserControl
    {
        private bool _isInitializing = false;

        public int ItemId { get; set; }
        public Action OnStatusChanged { get; set; }

        public UCMenuEditorItem()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public void SetCardData(int id, string name, bool isAvailable)
        {
            _isInitializing = true; 

            this.ItemId = id;
            this.ItemName = name;

            rjToggleButton1.Checked = isAvailable;
            lblStatus.Text = isAvailable ? "Available" : "Not Available";

            try
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                string imagePath = Path.Combine(imagesFolder, $"{id}.png");

                if (File.Exists(imagePath))
                {
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        picItem.Image = new Bitmap(ms);
                    }
                }
                else
                {
                    picItem.Image = null;
                }
            }
            catch (OutOfMemoryException)
            {
                picItem.Image = null;
                Console.WriteLine($"Invalid image file for item {id} in Chef Menu");
            }
            catch (Exception ex)
            {
                picItem.Image = null;
                Console.WriteLine($"Error loading image in Chef Menu: {ex.Message}");
            }

            _isInitializing = false;
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            if (rjToggleButton1.Checked)
            {
                lblStatus.Text = "Available";
                ItemRepository repo = new ItemRepository();
                repo.EnableItemManually(this.ItemId);
            }
            else
            {
                lblStatus.Text = "Not Available";
                ItemRepository repo = new ItemRepository();
                repo.DisableItemForToday(this.ItemId);
            }

            OnStatusChanged?.Invoke();
        }
    }
}