using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.DataLink
{
    public class POSService
    {

        public bool ProcessAndSendOrder(
         int tableId,
         int userId,
         List<MemoryOrderItem> items,
         double subTotalAmount,
         double finalTotalAmount,
         int? discountId,
         byte? discountType,
         double discountValue,
         bool isTakeAway,
         out int orderId)
        {
             POSRepository repo = new POSRepository();
            return repo.SaveFullOrderTransaction(
                tableId,
                userId,
                items,
                subTotalAmount,
                finalTotalAmount,
                discountId,
                discountType,
                discountValue,
                isTakeAway,
                out orderId
            );
        }

        public List<MemoryOrderItem> LoadOpenOrder(int tableId, out int openOrderId, out double currentTotal)
        {
            POSRepository repo = new POSRepository();
            return repo.GetActiveOrderItemsByTable(tableId, out openOrderId, out currentTotal);
        }

        public bool CompleteOrderPayment(int orderId)
        {
            POSRepository repo = new POSRepository();
            return repo.PayAndCloseOrder(orderId);
        }

        public bool UpdateOrderDiscount(int orderId, double subTotal, double finalTotal, int? discountId, byte? discountType, double discountAmountValue)
        {
            POSRepository repo = new POSRepository();
            return repo.UpdateOrderDiscountDetails(orderId, subTotal, finalTotal, discountId, discountType, discountAmountValue);
        }

        public DataTable GetDiscountsForForm()
        {
            POSRepository repo = new POSRepository();
            return repo.GetActiveDiscountsForToday();
        }
    }
}
