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
    public enum OrderStatus
    {
        Open = 0,
        Sent = 1,
        Ready = 2,
        Closed = 3
    }
    public enum TableFormat
    {
        circular,
        horizontal,
        vertical
    }


    public enum TableStatus
    {
        vacant = 0,
        occupied = 1,
        served = 2
    }
    public enum ItemStatus : byte
    {
        Preparing = 0,
        Done = 1,
        Delivered = 2
    }

    public enum BatchStatus : byte
    {
        Active = 0,
        Ready = 1,
        Delivered = 2
    }
}
