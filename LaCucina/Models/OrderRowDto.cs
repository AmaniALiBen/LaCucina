using System;

namespace LaCucina.Models
{
    /// <summary>
    /// Lightweight DTO used to populate a single row in the Orders list.
    /// </summary>
    public class OrderRowDto
    {
        public int      OrderId       { get; set; }

        /// <summary>True = Takeaway, False = Dine-in.</summary>
        public bool     IsTakeaway    { get; set; }

        /// <summary>Table number; ignored when IsTakeaway is true.</summary>
        public string      TableNumber   { get; set; }

        public string   WaiterName    { get; set; }
        public DateTime CreatedAt     { get; set; }
        public decimal  TotalAmount   { get; set; }

        /// <summary>Maps to <see cref="OrderStatus"/>.</summary>
        public int      OrderStatus   { get; set; }
    }
}
