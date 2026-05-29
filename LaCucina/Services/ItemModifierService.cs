using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Services
{
    public class ItemModifierService
    {
        public ItemDetails GetItemCustomizationDetails(int menuItemId)
        {
            ItemRepository repo = new ItemRepository();
            ItemDetails details = repo.GetItemDetailsWithIngredients(menuItemId);

            return details;
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
            ItemRepository repo = new ItemRepository();

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
            ItemRepository repo = new ItemRepository();
            return repo.GetActiveOrderItemsByTable(tableId, out openOrderId, out currentTotal);
        }

        public bool CompleteOrderPayment(int orderId)
        {
            ItemRepository repo = new ItemRepository();
            return repo.PayAndCloseOrder(orderId);
        }

        public bool UpdateOrderDiscount(int orderId, double subTotal, double finalTotal, int? discountId, byte? discountType, double discountAmountValue)
        {
            ItemRepository repo = new ItemRepository();
            return repo.UpdateOrderDiscountDetails(orderId, subTotal, finalTotal, discountId, discountType, discountAmountValue);
        }

        public DataTable GetDiscountsForForm()
        {
            ItemRepository repo = new ItemRepository();
            return repo.GetActiveDiscountsForToday();
        }
    }
}