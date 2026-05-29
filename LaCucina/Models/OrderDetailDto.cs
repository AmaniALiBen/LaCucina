using System;
using System.Collections.Generic;

namespace LaCucina.Models
{
    /// <summary>
    /// Full order detail used to render the receipt panel.
    /// </summary>
    public class OrderDetailDto
    {
        public int      OrderId         { get; set; }

        /// <summary>True = Takeaway, False = Dine-in.</summary>
        public bool     IsTakeaway      { get; set; }

        /// <summary>Table number; ignored when IsTakeaway is true.</summary>
        public string      TableNumber     { get; set; }

        public DateTime CreatedAt       { get; set; }
        public decimal  TotalAmount     { get; set; }

        /// <summary>Null when no discount was applied.</summary>
        public decimal? DiscountAmount  { get; set; }

        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }
}
