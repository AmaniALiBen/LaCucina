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
    public partial class UCSpaceRow : UserControl
    {
        public int id;
        public String name;
        public static UCSpaceRow lastSelectedRow=null;






        public UCSpaceRow()
        {
            InitializeComponent();
        }
        public UCSpaceRow(int id, String name) 
        {
            InitializeComponent();
            this.id = id;   
            this.name = name;
            lblName.Text = name;
            



        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataBase.spaces.Remove(this.id);
            List<int> spaseTablesIds =new List<int>();
           
            foreach (var table in DataBase.tables)
            {
                if (table.Value.spaceId == this.id)
                   spaseTablesIds.Add(table.Key);

            }
            foreach (var id in spaseTablesIds)
            {
                DataBase.tables.Remove(id);

            }
            ManageSpacesForm parent = this.FindForm() as ManageSpacesForm;

            parent.fillPnlRows();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ManageSpacesForm parent = this.FindForm() as ManageSpacesForm;
            parent.txtSpaceName.Texts = this.name;
            parent.btnSaveChanges.Visible = true;
            lastSelectedRow = this;
        }
    }
}
