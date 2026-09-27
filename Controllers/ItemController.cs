using Microsoft.AspNetCore.Mvc;
using MyShop.Models; //calls out for namespace MyShop.Models

namespace MyShop.Controllers;

public class ItemController : Controller
{
    public IActionResult Table()
    {
        var items = new List<Item>();
        
        var item1 = new Item();
        item1.ItemId = 1;
        item1.Name = "Pizza";
        item1.Price = 67;
        item1.Description = " for Jenny the yellow mellow";

        var item2 = new Item
        {
            ItemId = 2,
            Name = "Fried Chicken",
            Price = 19,
            Description = "for kne-Chris :)"
        };
        var item3 = new Item
        {
            ItemId = 3,
            Name = "Egg.",
            Price = 8,
            Description = "Kimen vil ha egg..."
        };
        var item4 = new Item
        {
            ItemId = 4,
            Name = "Lefsegodt",
            Price = 22,
            Description = "For WebApplikasjoner teamet!"
        };

        items.Add(item1);
        items.Add(item2);
        items.Add(item3);
        items.Add(item4);

        ViewBag.CurrentViewName = "List of Shop Items";
        return View(items);
    }
}