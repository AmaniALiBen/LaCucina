using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCucina
{
    internal class Space : RJButton
    {
        public int id;
        public String name;
        public static Space lastSelectedSpace = null;



        public Space(int id, String name)
        {
            this.id = id;
            this.name = name;
            this.BackColor = Color.FromArgb(30, 31, 32);
            this.ForeColor = Color.FromArgb(255, 255, 255);

            this.BorderSize = 0;
            this.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            this.BorderRadius = 10;
            this.Text = name;
            this.Size = new System.Drawing.Size(100, 28);
            this.Click += Space_Click;


        }
        public void Space_Click(object sender, EventArgs e)
        {
            if (lastSelectedSpace != null && lastSelectedSpace != this)
            {
                lastSelectedSpace.BackColor = Color.FromArgb(30, 31, 32);

                lastSelectedSpace.ForeColor = Color.FromArgb(255, 255, 255);
            }

            lastSelectedSpace = this;
            this.BackColor = Color.FromArgb(230, 126, 34);
            this.ForeColor = Color.FromArgb(0, 0, 0);
            FindAndRefreshEditor();


        }
        private void FindAndRefreshEditor()
        {
            // Method 1: Search up the parent tree
            Control current = this.Parent;
            while (current != null)
            {
                if (current is USFloorplanEditor editor)
                {
                    editor.fillTablePanel(true);
                    return;
                }
                current = current.Parent;
            }

        }
    }
}
