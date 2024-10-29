using CsDND.DndEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CsDND
{
    internal class MainGame : DndEngine.CsDndEngine
    {
        public MainGame()
            : base(new ObjSize(1920 , 1080), "DndGame") 
        {

        }

        public override void OnLoad()
        {
            Console.WriteLine("game load succeeded");
            Interface MainMenuBackground = new Interface(@"C:/Users/MaximTurdaliev/source/repos/CsDND/CsDND/Graphics/BackGrounds/space_Background_2048.png","MainMenuBackground");
            AddInterface(MainMenuBackground);
        }
        int Count = 0;
        public override void OnUpdate()
        {
           
            Console.WriteLine(Count++);
        }

        public override void OnDraw()
        {
           
        }


    }
}
