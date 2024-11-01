using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND.DndEngine
{
    internal class Position
    {
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Position()
        {
            //~~~
        }

        public Position(int PosX, int PosY)
        {
            this.PosX = PosX;
            this.PosY = PosY;
        }


    }

    
}
