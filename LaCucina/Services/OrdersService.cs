using LaCucina.DataLink;
using LaCucina.Models;
using System;
using System.Collections.Generic;

public class OrdersService
{
    private readonly OrdersRepository _repo;

    public OrdersService() : this(new OrdersRepository()) { }

    public OrdersService(OrdersRepository repo)
    {
        _repo = repo;
    }

    public List<string> GetWaiters() => _repo.GetWaiters();
    public List<string> GetTables() => _repo.GetTables();
    public List<OrderRowDto> GetOrders(DateTime from, DateTime to, string waiter = null)
        => _repo.GetOrders(from, to, waiter);
    public OrderDetailDto GetOrderDetail(int orderId) => _repo.GetOrderDetail(orderId);
}