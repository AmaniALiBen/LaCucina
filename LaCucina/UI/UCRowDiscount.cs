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
    public partial class UCRowDiscount : UserControl
    {
        private string _name;
        private string _type;
        private bool _isActive;
        private string _value;
        private string _startDate;
        private string _endDate;

        public string name
        {
            get { return _name; }
           set {
               _name = value;
                lblName.Text = _name; }
        }

        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                lblType.Text = _type;
            }
        }

        public String value
        {
            get 
            {
               return  _value; 
            }
            set
            {
                  _value = value;
                lblValue.Text = _value.ToString();
            }
        }
        public bool isActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;

                if (_isActive)
                    lblStatus.Text = "Active";
                else lblStatus.Text = "inActive";
            }
        }

        public string startDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                lblStartDate.Text = _startDate;
            }
        }
        public string endtDate
        {
            get { return _endDate; }
            set
            {
                _endDate = value;
                lblEndDate.Text = _endDate;
            }
        }
        public UCRowDiscount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
