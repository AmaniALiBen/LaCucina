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
    public partial class ManageSpacesForm : Form
    {
        USFloorplanEditor UC;
        public ManageSpacesForm(USFloorplanEditor UC)
        {
            this.UC = UC;
            InitializeComponent();
        }

       

        public void fillPnlRows() 
        {
            pnlRows.Controls.Clear();
                    
            foreach (var space in DataBase.spaces) 
            {
                UCSpaceRow row = new UCSpaceRow(space.Key,space.Value.name);
                pnlRows.Controls.Add(row);
                
            }
        }

        private void ManageSpacesForm_Load(object sender, EventArgs e)
        {
            fillPnlRows();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UCSpaceRow.lastSelectedRow.name=txtSpaceName.Texts;
            DataBase.spaces[UCSpaceRow.lastSelectedRow.id].name=txtSpaceName.Texts;
            fillPnlRows();
            btnSaveChanges.Visible = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            UC.fillSpacesPanel();

        }


        private void btnAddSpace_Click(object sender, EventArgs e)
        {
            if(txtSpaceName.Texts!=null)
            {
                Space s = new Space(++DataBase.SpaceCounter, txtSpaceName.Texts);
                DataBase.spaces.Add(DataBase.SpaceCounter, s);
                fillPnlRows();
                txtSpaceName.Texts = "";
            }
        }
    }
}
