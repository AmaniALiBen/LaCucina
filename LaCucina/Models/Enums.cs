using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Models
{
    public enum Role
    {
        Admin = 0,
        Waiter = 1,
        Chef = 2
    }
    public enum TableFormat
    {
        circular,
        horizontal,
        vertical
    }

   
    public enum TableStatus
    {
        vacant,
        preparing,
        ready,
        completed

    }
    public enum BatchStatus
    {
        Pending = 0,
        Ready = 1,
        Served = 2
    }
    public enum OrderItemStatus
    {
        Pending = 0,
        Done = 1,
        Cancelled = 2
    }
}
