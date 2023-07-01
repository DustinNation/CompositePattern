using System.Text;

namespace CompositePattern.Menus;

public class Menu : MenuComponent
{
    private List<MenuComponent> menuComponents = new List<MenuComponent>();

    private string _name;
    string _description;

    public Menu(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public override void Add(MenuComponent menuComponent)
    {
        menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent)
    {
        menuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int i)
    {
        return menuComponents[i];
    }

    public override string GetName()
    {
        return _name;
    }

    public override string GetDescription()
    {
        return _description;
    }

    public override void Print()
    {
        Console.WriteLine("\n" + GetName() + ", " + GetDescription());
        Console.WriteLine("-------------------");

        foreach (var menuComponent in menuComponents)
        {
            menuComponent.Print();
        }
    }
}