using CustomControls.RJControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LaCucina
{
    public partial class UC_InvoiceItem : UserControl
    {
        private double total; // يمثل سعر الوحدة
        private int qty;

        public event EventHandler DataChanged;
        public event EventHandler ItemRemoved;

        // 🔹 الفحص الجوهري لمعرفة حالة الصنف (هل أُرسل للمطبخ وحُفظ أم لا)
        public bool IsSavedInDatabase { get; private set; } = false;

        public string ItemName
        {
            get => lblItemName.Text;
            set => lblItemName.Text = value;
        }

        public int Quantity
        {
            get => qty;
            set
            {
                qty = value;
                lblQty.Text = qty.ToString();
                UpdateSubtotal();
            }
        }

        public double Price
        {
            get => total;
            set
            {
                total = value;
                // 🔄 إرجاع عرض سعر الوحدة في الـ UI كما كان تماماً
                if (lblUnitPrice != null)
                {
                    lblUnitPrice.Text = total.ToString("N2");
                }
                UpdateSubtotal();
            }
        }

        public UC_InvoiceItem(string name, int qty, double price)
        {
            InitializeComponent();
            this.ItemName = name;
            this.total = price;
            this.Quantity = qty;
            this.Price = total;
        }

        public double Subtotal => qty * total;

        private void UpdateSubtotal()
        {
            lblTotal.Text = (qty * total).ToString("N2");
        }

        /// <summary>
        /// استدعاء هذه الدالة يعني أن الصنف تم طباعته أو حفظه مسبقاً في قاعدة البيانات
        /// </summary>
        public void MarkAsSavedInDatabase()
        {
            // 1. تحويل حالة الصنف إلى "محفوظ" لمنع الـ POSForm من دمج الكميات الجديدة عليه
            IsSavedInDatabase = true;

            // 2. تعطيل أزرار التحكم لمنع الكاشير من التلاعب بالطلب المرسل للمطبخ مباشرة
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;

            if (btnDelete != null) btnDelete.Enabled = false;

            // 3. تغيير التصميم البصري ليوحي بأنه صنف مثبت مسبقاً
            lblItemName.ForeColor = Color.Gray;
            lblItemName.Font = new Font(lblItemName.Font, lblItemName.Font.Style | FontStyle.Strikeout);
        }

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            if (IsSavedInDatabase) return;

            if (Quantity > 1)
            {
                Quantity--;
                DataChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                ItemRemoved?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            if (IsSavedInDatabase) return;

            Quantity++;
            DataChanged?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsSavedInDatabase) return;

            ItemRemoved?.Invoke(this, EventArgs.Empty);
        }

        private void lblQty_Click(object sender, EventArgs e) { }
        private void UC_InvoiceItem_Load(object sender, EventArgs e) { }
    }
}