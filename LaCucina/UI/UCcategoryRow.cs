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
    public partial class UCcategoryRow : UserControl
    {
        public string category;
        public string name
        {
            get { return category; }
            set
            {
                category = value;
                lblcategory.Text = category;
            }
        }
        public UCcategoryRow()
        {
            InitializeComponent();
        }
        //نوصل الاكشن من برا 
        public Action Edit;
        public Action Delete;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //لما نكتب اكشن تتفعل
            Delete?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit?.Invoke();
        }
    }
}
