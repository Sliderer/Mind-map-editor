using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Mind_map_creator
{
    public class RectangleDrawer : IDrawer
    {

        private RectangleGenerator ractangleGenerator;

        public RectangleDrawer()
        {
            ractangleGenerator = new RectangleGenerator();
        }

        public IEnumerable<Shape>MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            ractangleGenerator.SetCenter(e.GetPosition(null).X, e.GetPosition(null).Y);
            yield return ractangleGenerator.rectangle;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            ractangleGenerator.SetScale(e.GetPosition(null).X, e.GetPosition(null).Y);
        }

        public void ReInit()
        {
            ractangleGenerator = new RectangleGenerator();
        }
    }
}
