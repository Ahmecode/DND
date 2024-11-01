using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDND.DndEngine.Interface
{
    internal class InterfaceScreen
    {
        private string ScreenName;

        private List<ImageAsset> ImageAssets = new List<ImageAsset>();
        private List<TextLabel> TextLabels = new List<TextLabel>();
        private List<Button> Buttons = new List<Button>();

        public InterfaceScreen() {
        }

        public void LoadInterfaceScreen()
        {

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

        public void AddButton(Button Button)
        {
            this.Buttons.Add(Button);
        }

        public void RemoveButton(string Name)
        {
            Button ButtonToRemove = Buttons.Find(x => x.Name == Name);
            if (ButtonToRemove != null)
            {
                Buttons.Remove(ButtonToRemove);
            }
        }


        public void LoadInterfaceScreen(int X)
        {

        }
    }
}
