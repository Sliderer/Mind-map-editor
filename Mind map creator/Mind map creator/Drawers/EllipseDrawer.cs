using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Mind_map_creator
{
    public class EllipseDrawer : IDrawer
    {
        private EllipseGenerator ellipseGenerator;

        public EllipseDrawer()
        {
            ellipseGenerator = new EllipseGenerator();
        }

        public IEnumerable<Shape> MouseDown(object sender, MouseButtonEventArgs e)
        {
            ellipseGenerator.SetCenter(e.GetPosition(null).X, e.GetPosition(null).Y);
            yield return ellipseGenerator.ellipse;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            ellipseGenerator.SetScale(e.GetPosition(null).X, e.GetPosition(null).Y);
        }

        public void ReInit()
        {
            ellipseGenerator = new EllipseGenerator();
        }
    }
}
