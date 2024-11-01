using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection;


namespace CsDND.DndEngine
{
    internal class TextLabel
    {

        private string Name {  get; set; } 
        public Control TextControl = new Control();
        public string Content { get; set; }
        public Font TextFont { get; set; }
        public Color TextColor { get; set; }

        
        
        public TextLabel(string Content,string Name) // deafult for my game
        {
            this.Content = Content; 
            this.TextColor = Color.White;
            
        }

        public TextLabel(string Content,string Name, Font Font, Color TextColor) //  
        {
            this.Content = Content;
            this.TextFont = Font;
            this.TextColor = TextColor;
            this.Name = Name;
        }




        
    }
}
