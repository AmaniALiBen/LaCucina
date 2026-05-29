using System.Collections.Generic;

namespace LaCucina.Models
{
    /// <summary>
    /// Represents a single line item inside an order receipt.
    /// </summary>
    public class OrderItemDto
    {
        public int    Quantity        { get; set; }
        public string MenuItemName   { get; set; }
        public decimal TotalPrice    { get; set; }

        /// <summary>
        /// Ingredients the customer asked to remove from this item.
        /// Displayed as modifier tags beneath the item name.
        /// </summary>
        public List<string> RemovedIngredients { get; set; } = new List<string>();

        /// <summary>
        /// Free-text note attached to this item (e.g. "extra crispy").
        /// Null or empty means no note badge is shown.
        /// </summary>
        public string NoteText { get; set; }
    }
}
