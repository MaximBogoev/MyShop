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
        item1.Description = " for Jenny qt :3";

        var item2 = new Item
        {
            ItemId = 2,
            Name = "Fried Chicken",
            Price = 19,
            Description = "for kne-Chris :)"
        };

        items.Add(item1);
        items.Add(item2);

        ViewBag.CurrentViewName = "List of Shop Items";
        return View(items);
    }
}