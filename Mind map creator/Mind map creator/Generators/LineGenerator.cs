using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Mind_map_creator
{
    class LineGenerator
    {
        internal Line line;

        public LineGenerator()
        {
            line = new Line();
            line.Stroke = Brushes.Black;
            StrokeInitialize.InitShape(line);
        }
        
        public void SetPoint1(double x, double y)
        {
            line.X1 = x;
            line.Y1 = y;
        }

        public void SetPoint2(double x, double y)
        {
            line.X2 = x;
            line.Y2 = y;
        }

    }
}
