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
        private PictureBox PictureBox = new PictureBox();
        public string Name {  get; set; }

        public Interface(string FilePath, string InterfaceName)
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

                this.Name = InterfaceName;
            }
            else { Console.WriteLine("FileNotFound");}
        }

        public Image LoadImageFile()
        {
            return Content;   
        }

        public Image LoadBackround(ObjSize ScreenSize)
        {
            PictureBox.Image = Content;
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.Dock = DockStyle.None;

            PictureBox.Width = ScreenSize.X;
            PictureBox.Height = ScreenSize.Y;

            return PictureBox.Image;
        }
    }
}
