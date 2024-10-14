using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsDND
{
    internal class Player : Entity
    {
        public Player(int Id, string Name, double Health, double Armor, double Lucky, Class Class , int Level , double Xp)
            : base(Id, Name, Health, Armor, Lucky, Class , Level , Xp) 
        {

        }

        public void PlayerStatsInterface()
        {
            Console.WriteLine($"Player: {this.Name} Stats");
            Console.WriteLine($"Health: [{this.Health}] Armor: [{this.Armor}] Luck: [{this.Lucky}] Class: [{this.Class.GetClassName()}]");
            Console.WriteLine(" ");
        }


    }
}
