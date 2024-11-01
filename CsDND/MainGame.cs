using CsDND.DndEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CsDND
{
    internal class MainGame : DndEngine.CsDndEngine
    {
        public MainGame()
            : base("DndGame", Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName) 
        {

        }

        public override void OnLoad()
        {
            string ProjectDir = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName;
            Console.WriteLine(ProjectDir);
            Console.WriteLine("game load succeeded");
            Interface MainMenuBackground = new Interface($@"{ProjectDir}\Graphics\BackGrounds\space_Background_1024.png","MainMenuBackground",new ObjSize(1024 , 1024));
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
