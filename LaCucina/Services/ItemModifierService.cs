using LaCucina.DataLink;
using LaCucina.Models;

namespace LaCucina.Services
{
    public class ItemModifierService
    {
        private readonly ItemRepository repo;

        public ItemModifierService() : this(new ItemRepository()) { }

        public ItemModifierService(ItemRepository repo)
        {
            this.repo = repo;
        }

        public ItemDetails GetItemCustomizationDetails(int menuItemId)
        {
            return repo.GetItemDetailsWithIngredients(menuItemId);
        }
    }
}