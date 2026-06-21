using LaCucina.DataLink;
using System.Collections.Generic;
using System.Linq;
namespace LaCucina.Services
{
    public class MenuService
    {
        private readonly CategoryRepository categoryRepository;
        private readonly ItemRepository itemRepository;
        private readonly menuItemIngredientsRepository MenuItemIngredientsRepository;

        public MenuService() : this(new CategoryRepository(), new ItemRepository(), new menuItemIngredientsRepository()) { }

        public MenuService(CategoryRepository categoryRepository, ItemRepository itemRepository, menuItemIngredientsRepository menuItemIngredientsRepository)
        {
            this.categoryRepository = categoryRepository;
            this.itemRepository = itemRepository;
            this.MenuItemIngredientsRepository = menuItemIngredientsRepository;
        }

        // ================= CATEGORIES =================
        public List<Categories> GetCategories()
        {
            return categoryRepository.GetAll();
        }
        // ================= ITEMS =================
        public List<Item> GetItemsByCategory(int categoryId)
        {
            return itemRepository.GetByCategory(categoryId);
        }
        // ================= DELETE ITEM =================
        public bool DeleteItem(int itemId)
        {
            Item item = itemRepository.GetById(itemId);
            if (item == null)
                return false;
            itemRepository.Delete(itemId);
            MenuItemIngredientsRepository.DeleteAllByMenuItem(itemId);
            return true;
        }
        public List<Item> GetInStockItemsByCategory(int categoryId)
        {
            return itemRepository.GetActiveItemsByCategory(categoryId);
        }
    }
}