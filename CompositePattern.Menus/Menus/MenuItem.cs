using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Menus.Menus
{
    public class MenuItem: MenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override bool IsItemVegetarian()
        {
            return IsVegetarian;
        }

        public override void Print()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append(" " + GetName());

            if (IsItemVegetarian())
            {
                stringBuilder.Append("(v)");
            }

            stringBuilder.Append(", " + GetPrice());
            stringBuilder.Append("\n -- " + GetDescription());

            Console.WriteLine(stringBuilder.ToString());
            Console.WriteLine();
        }
    }
}
