using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsDND.DndEngine.Interface
{
    internal class InterfaceGroup
    {
        private string ScreenName;
        private ObjSize ScreenSize;

        private List<ImageAsset> ImageAssets = new List<ImageAsset>();
        private List<TextLabel> TextLabels = new List<TextLabel>();
        private List<ObjButton> Buttons = new List<ObjButton>();

        public InterfaceGroup() {
        }

        public void LoadInterfaceScreen()
        {
            //~~~
        }

        public void SetGroupSize(ObjSize InputSize)
        {
            ScreenSize.X = InputSize.X;
            ScreenSize.Y = InputSize.Y;
        }

        public void AddImage(ImageAsset Image)
        {
            this.ImageAssets.Add(Image);
        }

        public void RemoveImage(string Name)
        {
            ImageAsset ImageToRemove = ImageAssets.Find(x => x.Name == Name);
            if (ImageToRemove != null)
            {
                ImageAssets.Remove(ImageToRemove);
            }
        }

        public void AddTextLabel(TextLabel Label)
        {
            this.TextLabels.Add(Label);
        }

        public void RemoveTextLabel(string Name)
        {
            TextLabel LabelToRemove = TextLabels.Find(x => x.LabelName == Name);
            if (LabelToRemove != null)
            {
                TextLabels.Remove(LabelToRemove);
            }
        }

        public void AddButton(ObjButton Button)
        {
            this.Buttons.Add(Button);
        }

        public void RemoveButton(string Name)
        {
            ObjButton ButtonToRemove = Buttons.Find(x => x.Name == Name);
            if (ButtonToRemove != null)
            {
                Buttons.Remove(ButtonToRemove);
            }
        }


        public void LoadInterfaceCenter(ObjSize ScreenSize)
        {
            
        }
    }
}
