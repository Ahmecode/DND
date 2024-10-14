using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace CsDND
{
    internal class Class
    {
        private string ClassName { get; set; }
        private int[] Mana { get; set; }
        private double AttackMult { get; set; }
        private double ManaMult { get; set; }
        private double LuckMult { get; set; }
        private double ArmorMult { get; set; }




        public Class(string ClassName)
        {
            this.ClassName = ClassName;
            Mana = new int[4]; 

            
        }

        public string GetClassName()
        {
            return ClassName;
        }

       
    }
}
