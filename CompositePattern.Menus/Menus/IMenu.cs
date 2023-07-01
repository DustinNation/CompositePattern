using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Menus.Menus
{
    public interface IMenu
    {
        public List<MenuItem> CreateMenuItems();
    }
}
