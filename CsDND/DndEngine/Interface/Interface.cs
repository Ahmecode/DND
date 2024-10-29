using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CsDND.DndEngine
{
    internal class Interface
    {
        private Image Content;
        private string Path;
        private ObjSize InterfaceSize ;
        public string Name {  get; set; }

        public Interface(string FilePath, string InterfaceName , ObjSize InterfaceSize)
        {
            this.Path = FilePath;
            if (File.Exists(Path)){

                try
                {
                    this.Content = Image.FromFile(Path);

                }

                catch (Exception Error)
                {
                    Console.WriteLine($"Failed to load interface {Error.Message} ");
                }

                this.InterfaceSize = InterfaceSize;
                this.Name = InterfaceName;
            }
            else { Console.WriteLine("FileNotFound");}
        }

        public ObjSize GetInterfaceSize()
        {
            return this.InterfaceSize;
        }

        public Image LoadImageFile()
        {
            return Content;   
        }

        public Image LoadBackround(ObjSize ScreenSize)
        {
            Image Resizebackground = new Bitmap(ScreenSize.X, ScreenSize.Y);
            Graphics Helper = Graphics.FromImage(Resizebackground);
            try
            {
                Helper.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                Helper.DrawImage(this.Content, 0, 0, ScreenSize.X, ScreenSize.Y);
            }

            catch(Exception Ex)
            {
                Console.WriteLine($"coudlnt resize the image: Name{this.Name} , Path:{this.Path}");
                Console.WriteLine($"Exeption: {Ex.Message}");
            }
            finally {
                Helper.Dispose();
            }

            return Resizebackground;
        }
        public Position CenterImage(ObjSize ImageSize , ObjSize ScreenSize)
        {
            Position CenterPos = new Position();
            CenterPos.PosX = (ScreenSize.X / 2) - (ImageSize.X / 2);
            CenterPos.PosY = (ScreenSize.Y / 2) - (ImageSize.Y / 2);

            return CenterPos;

        }
    }
}
