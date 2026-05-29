using LaCucina.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaCucina.Services
{
    public class ItemModifierService
    {
        public ItemDetails GetItemCustomizationDetails(int menuItemId)
        {
            ItemRepository repo = new ItemRepository();
            ItemDetails details = repo.GetItemDetailsWithIngredients(menuItemId);

            return details;
        }

     
    }
}