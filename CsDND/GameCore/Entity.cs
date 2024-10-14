using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND
{
    internal class Entity
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected double Health { get; set; }
        protected double Armor { get; set; }
        protected double Lucky { get; set; }
        protected Class Class { get; set; }  
        protected int Level { get; set; }
        protected double Xp { get; set; }

        public Entity(int Id, string Name, double Health, double Armor, double Lucky , Class Class , int Level , double Xp)
        {
            this.Id = Id;
            this.Name = Name;
            this.Health = Health;
            this.Armor = Armor;
            this.Lucky = Lucky;
            this.Class = Class;
            this.Xp = Xp;
        }






    }
}
