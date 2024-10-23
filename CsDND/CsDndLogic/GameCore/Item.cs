using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND
{
    internal class Item
    {
        protected int Id;
        protected string Name {  get; set; }
        protected double Durability {  get; set; }
        protected int Quantity { get; set; }
        protected double Rarity { get; set; }
        protected int Value { get; set; }
        protected bool IsStackable { get; set; }

        public int GetId()
        {
            return this.Id;
        }

        public void SetId(int Id)
        {
            this.Id = Id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // Public getter and setter for Durability
        public double GetDurability()
        {
            return Durability;
        }

        public void SetDurability(double durability)
        {
            Durability = durability;
        }

        // Public getter and setter for Quantity
        public int GetQuantity()
        {
            return Quantity;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

        // Public getter and setter for Rarity
        public double GetRarity()
        {
            return Rarity;
        }

        public void SetRarity(double rarity)
        {
            Rarity = rarity;
        }

        // Public getter and setter for Value
        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            Value = value;
        }

        // Public getter and setter for IsStackable
        public bool GetIsStackable()
        {
            return IsStackable;
        }

        public void SetIsStackable(bool isStackable)
        {
            IsStackable = isStackable;
        }
    }
}
