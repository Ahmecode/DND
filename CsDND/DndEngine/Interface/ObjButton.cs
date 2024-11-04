using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsDND.DndEngine
{
    internal class ObjButton:Control
    {
        public string Name { get; set; }
        public TextLabel BtnText { get; set; }
        public ImageAsset BtnImage { get; set; }
        public ObjSize BtnSize;
        public Position BtnPos;
        public bool IsHover;
        public bool IsPressed;

        public ObjButton(string Name, TextLabel BtnText)
        {
            this.Name = Name;
        }
        public ObjButton(string Name, ImageAsset BtnImage)
        {
            this.Name = Name;
            this.BtnImage = BtnImage;
        }
        public ObjButton(string Name, TextLabel BtnText, ImageAsset BtnImage)
        {
            this.Name = Name;
            this.BtnText = BtnText;
            this.BtnImage = BtnImage;
        }

        public void SetDeafultControls()
        {
            this.BackColor = Color.Transparent;
            //this.MouseEnter += OnMouseEnter;
            //this.MouseLeave += OnMouseLeave;
            //this.Click += OnClick;
        }

        private void OnMouseEnter()
        {

        }

        private void OnMouseLeave()
        {

        }

        private void OnClicks()
        {

        }




    }
}
