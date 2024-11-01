using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CsDND.DndEngine //38:35 / 2:43:33
{
    class Canvas: Form{
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    internal abstract class CsDndEngine
    {
        private Rectangle UserScreenSize;
        private string GameDir;
        private ObjSize ScreenSize; // Define the screensize with ObjSize class 
        private string GameTitle; // the name of the window
        private Canvas GameWindow; // the physical layer of the game 
        private Thread GameLoopThread = null;

        private List<Interface> AllInterfaces = new List<Interface>();
        public CsDndEngine() // the deafult (dont use it)
        {
            this.ScreenSize.X = UserScreenSize.Width;
            this.ScreenSize.Y = UserScreenSize.Height;
            this.GameTitle = string.Empty;

            GameWindow = new Canvas();
            GameWindow.Size = new Size(ScreenSize.X, ScreenSize.Y);

            Application.Run(GameWindow);
        }

        public CsDndEngine(string Title , string GameDir) // input based 
        {

            InitializeUserScreenSize();
            try
            {
                this.GameDir = GameDir;
                this.ScreenSize.X = UserScreenSize.Width;
                this.ScreenSize.Y = UserScreenSize.Height;
                this.GameTitle = Title;

                GameWindow = new Canvas();
                GameWindow.Size = new Size(ScreenSize.X, ScreenSize.Y);
                GameWindow.Text = Title;
                GameWindow.Paint += GameRender;

                GameLoopThread = new Thread(GameLoop);
                GameLoopThread.Start();

                Application.Run(GameWindow);
            }

            catch {
                Console.WriteLine("the game is loading");
            }
        }

        private void InitializeUserScreenSize()
        {   
            try
            {
                UserScreenSize = Screen.PrimaryScreen.Bounds;
                this.ScreenSize.X = UserScreenSize.Width;
                this.ScreenSize.Y = UserScreenSize.Height;
            }

            catch (Exception Ex)
            {
                Console.WriteLine($"InitializeUserScreenSize was failed Exception{Ex.Message}");
                Console.WriteLine($"");
                this.ScreenSize.X = 1920;
                this.ScreenSize.Y = 1080;
            }
        }


        private void GameLoop()
        {
            OnLoad();
            while (GameLoopThread.IsAlive == true)// this method called every (frame / second) while the game loop thread is active
            {
                OnDraw();
                GameWindow.BeginInvoke((MethodInvoker)delegate { GameWindow.Refresh(); }); // refresh the windwo every (frame / second)
                Thread.Sleep(1000);
                OnUpdate();
            }
        }

        private void GameRender(object Sender, PaintEventArgs Graphic)
        {
            Graphics G = Graphic.Graphics;
            try
            {
                Interface MainMenuBackground = AllInterfaces.Find(i => i.Name == "MainMenuBackground");
                Position CenterPos = MainMenuBackground.CenterImage(MainMenuBackground.GetInterfaceSize() , this.ScreenSize);
                G.DrawImage(MainMenuBackground.LoadBackround(ScreenSize), CenterPos.PosX, CenterPos.PosY);
            }
            catch { Console.WriteLine("error in loading main menu"); }
        }

        public void AddInterface(Interface Interface)
        {
            AllInterfaces.Add(Interface);
        }

        public void RemoveInterface(string InterfaceName)
        {
            AllInterfaces.RemoveAll(i => i.Name == InterfaceName);
        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();


        


    }
}
