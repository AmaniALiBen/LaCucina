using LaCucina.Models;
using System.Collections.Generic;
using System.Data;

namespace LaCucina.DataLink
{
    public class POSService
    {
        private readonly POSRepository _repo;

        public POSService() : this(new POSRepository()) { }

        public POSService(POSRepository repo)
        {
            _repo = repo;
        }

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
            return _repo.SaveFullOrderTransaction(
                tableId, userId, items,
                subTotalAmount, finalTotalAmount,
                discountId, discountType, discountValue,
                isTakeAway, out orderId);
        }

        public List<MemoryOrderItem> LoadOpenOrder(int tableId, out int openOrderId, out double currentTotal)
        {
            return _repo.GetActiveOrderItemsByTable(tableId, out openOrderId, out currentTotal);
        }

        public bool CompleteOrderPayment(int orderId)
        {
            return _repo.PayAndCloseOrder(orderId);
        }

        public bool UpdateOrderDiscount(int orderId, double subTotal, double finalTotal,
            int? discountId, byte? discountType, double discountAmountValue)
        {
            return _repo.UpdateOrderDiscountDetails(orderId, subTotal, finalTotal,
                discountId, discountType, discountAmountValue);
        }

        public DataTable GetDiscountsForForm()
        {
            return _repo.GetActiveDiscountsForToday();
        }
    }
}