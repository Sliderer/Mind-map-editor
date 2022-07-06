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
    class PolylineGenerator
    {
        internal Polyline polyline;

        public PolylineGenerator()
        {
            polyline = new Polyline();
            polyline.Stroke = Brushes.Black;
            StrokeInitialize.InitShape(polyline);
        }

        public void AddPoint(MouseButtonEventArgs mouse)
        {
            Point point = new Point(mouse.GetPosition(null).X, mouse.GetPosition(null).Y);
            if (polyline.Points.Count > 0  && point != polyline.Points[polyline.Points.Count - 1])
            {
                polyline.Points.Add(point);
            }
        }

        public void AddPoint(MouseEventArgs mouse)
        {
            polyline.Points.Add(new Point(mouse.GetPosition(null).X, mouse.GetPosition(null).Y));
        }
    }
}
