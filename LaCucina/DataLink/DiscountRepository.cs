using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina
{
    public  class DiscountRepository
    {
        // 🔹 1. جلب كل الخصومات الحية (غير المحذوفة) كـ List
        public virtual List<Discounts> GetAll()
        {
            string query = @"
                SELECT discount_id, discount_name, discount_type, discount_amount, start_date, end_date, is_active 
                FROM discounts 
                WHERE is_deleted = 0";

            return MapToList(query);
        }

        // 🔹 2. إضافة خصم جديد باستقبال كلاس Discounts مباشرة
        public virtual void Add(Discounts discount)
        {
            // تحويل الـ Enum إلى TinyInt (0 لـ Percentage و 1 لـ Fixed بناءً على الـ Check Constraint)
            int typeValue = (discount.type == Discounts.Type.Percentage) ? 0 : 1;

            // تنسيق التواريخ بشكل قياسي لتجنب مشاكل الـ SQL Server
            string formattedStart = DateTime.Parse(discount.start_date).ToString("yyyy-MM-dd HH:mm:ss");
            string formattedEnd = DateTime.Parse(discount.end_date).ToString("yyyy-MM-dd HH:mm:ss");

            string query = $@"
                INSERT INTO discounts (discount_name, discount_type, discount_amount, start_date, end_date, is_active, is_deleted) 
                VALUES ('{discount.name.Replace("'", "''")}', {typeValue}, {discount.value}, '{formattedStart}', '{formattedEnd}', {(discount.isActive ? 1 : 0)}, 0)";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 3. تحديث بيانات الخصم باستخدام الـ ID والكلاس
        public virtual void Update(int discountId, Discounts discount)
        {
            int typeValue = (discount.type == Discounts.Type.Percentage) ? 0 : 1;
            string formattedStart = DateTime.Parse(discount.start_date).ToString("yyyy-MM-dd HH:mm:ss");
            string formattedEnd = DateTime.Parse(discount.end_date).ToString("yyyy-MM-dd HH:mm:ss");

            string query = $@"
                UPDATE discounts 
                SET 
                    discount_name = '{discount.name.Replace("'", "''")}', 
                    discount_type = {typeValue}, 
                    discount_amount = {discount.value}, 
                    start_date = '{formattedStart}', 
                    end_date = '{formattedEnd}', 
                    is_active = {(discount.isActive ? 1 : 0)} 
                WHERE discount_id = {discountId}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔹 4. حذف منطقي للخصم (Soft Delete)
        public virtual void Delete(int discountId)
        {
            string query = $@"
                UPDATE discounts 
                SET is_deleted = 1 
                WHERE discount_id = {discountId}";

            DatabaseHelper.ExecuteNonQuery(query);
        }

        // 🔥 Helper: تحويل الـ DataTable إلى قائمة List<Discounts> متطابقة 100% مع نمط الـ ItemRepository
        private  List<Discounts> MapToList(string query)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            List<Discounts> list = new List<Discounts>();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["discount_name"].ToString();

                // قراءة الـ TinyInt وتحويله إلى الـ Enum الخاص بكِ (0 -> Percentage, 1 -> Fixed)
                int typeVal = Convert.ToInt32(row["discount_type"]);
                Discounts.Type type = (typeVal == 0) ? Discounts.Type.Percentage : Discounts.Type.Fixed;

                double value = Convert.ToDouble(row["discount_amount"]);

                // جلب التواريخ وتنسيقها كنصوص للـ UI (مع فحص أمان في حال كانت القيمة نل في البداية)
                string startDate = row["start_date"] != DBNull.Value ? Convert.ToDateTime(row["start_date"]).ToString("yyyy-MM-dd") : DateTime.Today.ToString("yyyy-MM-dd");
                string endDate = row["end_date"] != DBNull.Value ? Convert.ToDateTime(row["end_date"]).ToString("yyyy-MM-dd") : DateTime.Today.AddDays(7).ToString("yyyy-MM-dd");

                bool isActive = Convert.ToBoolean(row["is_active"]);

                Discounts discount = new Discounts(name, type, value, startDate, endDate, isActive, false);
                list.Add(discount);
            }

            return list;
        }

        // 🔹 5. دالة إضافية مساعدة لجلب جدول البيانات كاملاً لو احتجتِ الـ IDs مباشرة في الواجهة
        public virtual DataTable GetAllDiscountsTable()
        {
            string query = @"
                SELECT discount_id, discount_name, discount_type, discount_amount, start_date, end_date, is_active 
                FROM discounts 
                WHERE is_deleted = 0";

            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}