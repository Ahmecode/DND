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
    internal class TextLabel : Control
    {

        public string LabelName {  get; set; } 
        public Control TextControl = new Control();
        public string Content { get; set; }
        public Font TextFont { get; set; }
        public Color TextColor { get; set; }
        public Position LabelPos = new Position();
        
        
        public TextLabel(string Content,string LabelName,string FontName) // deafult for your game
        {
            this.Content = Content; 
            this.TextColor = Color.White;
            this.LabelName = LabelName;
            this.TextFont = MainGame.GetFont(FontName);

            this.Location = new Point(0,0);
            SetControl(); // sets the parameters into control class so it can be rendered 
        }

        public TextLabel(string Content,string Name, Font Font, Color TextColor) // specific text label  
        {
            this.Content = Content;
            this.TextFont = Font;
            this.TextColor = TextColor;
            this.LabelName = Name;

            this.Location = new Point(0, 0);
            SetControl(); // sets the parameters into control class so it can be rendered 
        }

        public void SetControl()
        {
            this.AutoSize = true; 
            this.ForeColor = this.TextColor;
            this.Font = this.TextFont;
            this.Text = this.Content;
        }

        public void UpdatePos(Position Pos)
        {
            this.Location = new Point(Pos.PosX, Pos.PosY);
        }



        //public void DrawLabel(Graphics G)
        //{
           
        //}




        
    }
}
