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
        protected string ClassName { get; set; }
        protected int[] Mana { get; set; }
        protected double AttackMult { get; set; }
        protected double ManaMult { get; set; }
        protected double LuckMult { get; set; }
        protected double ArmorMult { get; set; }




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
