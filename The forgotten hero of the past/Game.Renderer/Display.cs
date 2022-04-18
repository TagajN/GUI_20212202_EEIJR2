using Game.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Game.Renderer
{
    public class Display : FrameworkElement
    {
        Size area;
        IGameModel model;
        public void SetupSizes(Size area)
        {
            this.area = area;
            this.InvalidateVisual();
        }

        public void SetupModel(IGameModel model)
        {
            this.model = model;
            this.model.Changed += (sender, eventargs) => this.InvalidateVisual();
        }
        public Brush BackgroundBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("images","map.png"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush CharacterBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("images", "mage.gif"), UriKind.RelativeOrAbsolute)));
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (area.Width > 0 && area.Height>0 && model != null)
            {
                drawingContext.DrawRectangle(BackgroundBrush, null, new Rect(0, 0, area.Width, area.Height));

                drawingContext.PushTransform(new TranslateTransform(model.xCordinate,model.yCordinate));
                drawingContext.DrawRectangle(CharacterBrush, null, new Rect(area.Width/2, area.Height/2, 200,200));
                drawingContext.Pop();

                drawingContext.DrawRectangle(Brushes.Transparent, null, new Rect(1,1010,1936,86));
            }
            
        }

    }
}
