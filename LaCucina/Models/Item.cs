using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public class Item
    {
        private int id;
        private string name;
        private int categoryId;
        private double price;
        private bool isActive;
        private string imagePath;
        private DateTime? disabledUntil; // 🔹 إضافة الحقل الخاص بالتاريخ ويقبل قيمة فارغة Nullable

        public int Id
        {
            get { return id; }
           
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string ImagePath
        {
            get { return imagePath; } // ✔️ تم الإصلاح لتقرأ من الحقل المكتوم لمنع التكرار اللانهائي
            set { imagePath = value; } // ✔️ تم الإصلاح
        }

        // 🔹 الخاصية البرمجية (Property) للعمود الجديد ليتعامل معها الريبوزتوري والواجهات بأمان
        public DateTime? DisabledUntil
        {
            get { return disabledUntil; }
            set { disabledUntil = value; }
        }

        // 🔹 تحديث الـ Constructor لاستقبال المعطيات الافتراضية
        public Item(int id, string name, int categoryId, double price, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
            this.price = price;
            this.isActive = isActive;
            this.imagePath = ""; // قيمة افتراضية فارغة لمنع الـ NullReferenceException
            this.disabledUntil = null; // افتراضياً الوجبة متاحة وغير موقوفة عند الإنشاء
        }
    }
}