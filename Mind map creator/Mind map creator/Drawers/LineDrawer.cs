using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Shapes;

namespace Mind_map_creator
{
    class LineDrawer : IDrawer
    {
        private LineGenerator lineGenerator;

        public LineDrawer()
        {
            lineGenerator = new LineGenerator();
        }

        public IEnumerable<Shape> MouseDown(object sender, MouseButtonEventArgs e)
        {
            lineGenerator.SetPoint1(e.GetPosition(null).X, e.GetPosition(null).Y);
            yield return lineGenerator.line;
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            lineGenerator.SetPoint2(e.GetPosition(null).X, e.GetPosition(null).Y);
        }

        public void ReInit()
        {
            lineGenerator = new LineGenerator();
        }
    }
}
