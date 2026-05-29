using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;

namespace LaCucina.Services
{
    public class OrdersService
    {
        private readonly OrdersRepository _repo = new OrdersRepository();

        public List<string> GetWaiters() => _repo.GetWaiters();

        public List<string> GetTables() => _repo.GetTables();

        public List<OrderRowDto> GetOrders(
            DateTime from,
            DateTime to,
            string   waiter = null
            )
        {
            return _repo.GetOrders(from, to, waiter);
        }

        public OrderDetailDto GetOrderDetail(int orderId)
            => _repo.GetOrderDetail(orderId);
    }
}
