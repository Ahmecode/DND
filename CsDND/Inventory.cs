using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND
{
    internal class Inventory
    {
        private string InvName;
        private Item[] Items;
        private int LastPos;
        private int MaxItems;

        public Inventory(int MaxItems , string InvName) { 
            this.MaxItems = MaxItems;
            this.Items = new Item[MaxItems];
            this.LastPos = 0;
            this.InvName = InvName;
        }

        public void AddItem(Item Item)
        {
            if (LastPos > MaxItems)
            {
                Console.WriteLine("INV: The inventory is full !");
                Console.WriteLine(" ");
                return;
            }
                
            if (Items[0] == null)
            {
                Items[0] = Item;
                LastPos++;
                return;
            }

            for (int i = 0; i <= LastPos; i++)
            {
                if (Items[i].GetName() == Item.GetName() && Items[i].GetId() == Item.GetId())
                {
                    if (Items[i].GetIsStackable() && Item.GetIsStackable() == true)
                    {
                        Items[i].SetQuantity(+Item.GetQuantity());
                        return;
                    }
                }
            }

            Items[LastPos] = Item;
            LastPos++;
        }

        public void RemoveItem(Item Item )
        {
            if (Items[0] == null)
            {
                Console.WriteLine("DEV: empty inventory");
                return;
            }

            for (int i =0; Items[i] != null; i++)
            {
                if (Items[i].GetName() == Item.GetName() && Items[i].GetId() == Item.GetId())
                {
                    Items[i] = Items[LastPos - 1];
                    LastPos--;
                    Console.WriteLine($"DEV: Item {Item.GetName()} {Item.GetId()} Removed from {InvName}");
                }
            }
           
        }


    }
}
