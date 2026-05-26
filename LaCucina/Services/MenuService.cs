using LaCucina.DataLink;
using System.Collections.Generic;
using System.Linq;

namespace LaCucina.Services
{
    public class MenuService
    {
        // ================= CATEGORIES =================

        public List<Categories> GetCategories()
        {
            return CategoryRepository.GetAll();
        }

        // ================= ITEMS =================

        public List<Item> GetItemsByCategory(int categoryId)
        {
            return ItemRepository.GetByCategory(categoryId);
        }

        // ================= DELETE ITEM =================

        public bool DeleteItem(int itemId)
        {
            Item item = ItemRepository.GetById(itemId);

            if (item == null)
                return false;

            ItemRepository.Delete(itemId);

            menuItemIngredientsRepository.DeleteAllByMenuItem(itemId);

            return true;
        }


        public List<Item> GetInStockItemsByCategory(int categoryId) 
        {
            return ItemRepository.GetActiveItemsByCategory(categoryId);
        }
    }
}