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
using System.Windows.Forms;

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
            Console.WriteLine($"Project: {ProjectDir}");
            Console.WriteLine("game load succeeded");

            ImageAsset MainMenuBackground = new ImageAsset($@"{ProjectDir}\GameResources\BackGrounds\space_Background_2048.png", "MainMenuBackground", new ObjSize(1024, 1024));
            AddInterface(MainMenuBackground);

            LoadFont("DungeonFont", 20);

            ObjButton Test = new ObjButton("a",null,null);

            //TextLabel TestLabel = new TextLabel("Ori Hifi", "TEST", "DungeonFont");
            //TestLabel.UpdatePos(new Position(100 , 100));
            
         
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
