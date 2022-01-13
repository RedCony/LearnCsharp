using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Inventory
    {
        List<Item> items;


        public Inventory()
        {
            this.items = new List<Item>();
        }

        public void Create(Item item)
        {
            this.items.Add(item);
        }
    }
}
