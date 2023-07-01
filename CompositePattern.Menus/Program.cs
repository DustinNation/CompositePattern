using System.Threading.Tasks.Dataflow;
using CompositePattern.Menus;
using CompositePattern.Menus.Menus;
using IteratorPattern.Menu;

// First, create all of the menu objects.
MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert, of course!");

// We also need a top-level menu that we'll call "ALL MENUS"
MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

// We're using the composite Add() method to add each menu to the top-level menu, "ALL MENUS"
allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

// Now we need to add all of the menu items.
AddBreakfastMenuItems();
AddDinerMenuItems();
AddCafeMenuItems();

dinerMenu.Add(dessertMenu);
AddDessertMenuItems();

// Once we've constructed our entire menu hierarchy, we hand the whole thing to the Waitress,
// and as you've seen, it's as easy as apple pie for her to print it out.
var waitress = new Waitress(allMenus);

waitress.PrintMenu();



// Made these just to collapse all of the text for the items.
void AddDinerMenuItems()
{
    dinerMenu.Add(new MenuItem(
        "Vegetarian BLT",
        "(Fakin') Bacon with lettuce & tomato on whole wheat",
        true,
        2.99)
    );

    dinerMenu.Add(new MenuItem(
        "Soup of the Day",
        "A bowl of the soup of the day, with a side of potato salad",
        false,
        3.29)
    );

    dinerMenu.Add(new MenuItem(
        "Hot Dog",
        "A hot dog, with sauerkraut, relish, onions, topped with cheese",
        false,
        3.05)
    );

    dinerMenu.Add(new MenuItem(
        "Steamed Veggies with Rice",
        "Steamed vegetables over brown rice",
        true,
        3.99)
    );

    dinerMenu.Add(new MenuItem(
        "Pasta",
        "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
        true,
        3.89)
    );
}

void AddBreakfastMenuItems()
{
    pancakeHouseMenu.Add(new MenuItem(
        "K&B's Pancake Breakfast",
        "Pancakes with scrambled eggs and toast",
        false,
        2.99)
    );

    pancakeHouseMenu.Add(new MenuItem(
        "Regular Pancake Breakfast",
        "Pancakes with fried eggs and sausage",
        false,
        2.99)
    );

    pancakeHouseMenu.Add(new MenuItem(
        "Blueberry Pancakes",
        "Pancakes made with fresh blueberries. Served with blueberry syrup.",
        true,
        3.59)
    );

    pancakeHouseMenu.Add(new MenuItem(
        "Waffles",
        "Waffles with your choice of blueberries or strawberries.",
        true,
        3.59)
    );
}

void AddDessertMenuItems()
{
    dessertMenu.Add(new MenuItem(
        "Apple Pie",
        "Apple pie with a flaky crust, topped with vanilla ice cream",
        true,
        1.59)
    );

    dessertMenu.Add(new MenuItem(
        "Cheesecake",
        "Creamy New York cheesecake, with a chocolate graham crust.",
        true,
        1.99)
    );

    dessertMenu.Add(new MenuItem(
        "Sorbet",
        "A scoop of raspberry and a scoop of lime.",
        true,
        1.89)
    );
}

void AddCafeMenuItems()
{
    cafeMenu.Add(new MenuItem(
        "Veggie Burger and Air Fries",
        "Veggie burger on a whole wheat bun. Served with lettuce, tomato, and fries.",
        true, 
        3.99)
    );

    cafeMenu.Add(new MenuItem(
        "Soup of the Day",
        "A cup of the soup of the day. Served with a side salad.",
        false,
        3.69)
    );

    cafeMenu.Add(new MenuItem(
        "Burrito",
        "A large burrito with whole pinto beans, salsa, and guacamole.",
        true,
        4.29)
    );
}