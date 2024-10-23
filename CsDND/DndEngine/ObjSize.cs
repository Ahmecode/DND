using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND.DndEngine
{
    internal class ObjSize
    {
        public int X {  get; set; }
        public int Y {  get; set; }

        public ObjSize(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public ObjSize()
        {
            this.X = 0;
            this.Y = 0;
        }

        public void ReSize(int Value)
        {
            this.X *= Value;
            this.Y *= Value;
        }


    }
}
