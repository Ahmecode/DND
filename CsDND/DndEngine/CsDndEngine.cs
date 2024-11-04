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
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using CsDND.GameResources.Fonts;


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
        private ObjSize ScreenSize = new ObjSize(); // Define the screensize with ObjSize class 
        private string GameTitle; // the name of the window
        private Canvas GameWindow; // the physical layer of the game 
        private Thread GameLoopThread = null;

        public List<ImageAsset> AllInterfaces = new List<ImageAsset>();
        public static List<Font> AllFonts = new List<Font>();

        public CsDndEngine() // the deafult (dont use it)
        {
            this.ScreenSize.X = UserScreenSize.Width;
            this.ScreenSize.Y = UserScreenSize.Height;
            this.GameTitle = string.Empty;

            GameWindow = new Canvas();
            GameWindow.Size = new Size(ScreenSize.X, ScreenSize.Y);

            Application.Run(GameWindow);
        }

        public CsDndEngine(string Title , string GameDir) // input based game creation 
        {

            InitializeUserScreenSize();
            try
            {
                this.GameDir = GameDir;
                this.GameTitle = Title;

                GameWindow = new Canvas();
                GameWindow.Size = new Size(ScreenSize.X, ScreenSize.Y);
                GameWindow.Text = Title;
                GameLoopThread = new Thread(GameLoop);
                GameWindow.Paint += GameRender;

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
                ImageAsset MainMenuBackground = AllInterfaces.Find(i => i.Name == "MainMenuBackground");
                G.DrawImage(MainMenuBackground.LoadBackround(ScreenSize), 0, 0);

                TextLabel TestLabel = new TextLabel("Test Hello", "TEST","DungeonFont");
                TestLabel.UpdatePos(new Position(100,300));

                G.DrawString(TestLabel.Content, TestLabel.Font,new SolidBrush(TestLabel.TextColor),TestLabel.Location);

            }
            catch(Exception Ex) { Console.WriteLine($"error in loading main menu {Ex.Message}"); }
        }

        public void AddInterface(ImageAsset Interface)
        {
            AllInterfaces.Add(Interface);
        }

        public void RemoveInterface(string InterfaceName)
        {
            AllInterfaces.RemoveAll(i => i.Name == InterfaceName);
        }

        public static void LoadFont(string FontResourceName, float FontSize)
        {
            PrivateFontCollection privateFontCollection = new PrivateFontCollection();
            // Access the font data from the specific resources file
            byte[] FontData = ResourcesFont.ResourceManager.GetObject(FontResourceName) as byte[];

            if (FontData == null)
            {
                throw new FileNotFoundException("Font resource not found: " + FontResourceName);
            }

            IntPtr FontPointer = Marshal.AllocCoTaskMem(FontData.Length);
            Marshal.Copy(FontData, 0, FontPointer, FontData.Length);
            privateFontCollection.AddMemoryFont(FontPointer, FontData.Length);
            Marshal.FreeCoTaskMem(FontPointer);

            AllFonts.Add(new Font(privateFontCollection.Families[0], FontSize));
        }

        public static Font GetFont(string Name)
        {

            Font ReturnFont = AllFonts.Find(i => i.Name == Name);
            if (ReturnFont == null)
                Console.WriteLine($"[ENGINE] invalid font name GetFont({Name})  , returned null ");

            return ReturnFont;

        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();


        


    }
}
