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
            ItemRepository repo = new ItemRepository();
            return repo.GetByCategory(categoryId);
        }

        // ================= DELETE ITEM =================

        public bool DeleteItem(int itemId)
        {
            ItemRepository repo = new ItemRepository();
            Item item = repo.GetById(itemId);

            if (item == null)
                return false;

            repo.Delete(itemId);

            menuItemIngredientsRepository.DeleteAllByMenuItem(itemId);

            return true;
        }


        public List<Item> GetInStockItemsByCategory(int categoryId) 
        {
            ItemRepository repo = new ItemRepository();
            return repo.GetActiveItemsByCategory(categoryId);
        }
    }
}