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
    public class PolylineDrawer : IDrawer
    {
        private PolylineGenerator currentPolyline;

        public void MouseMove(object sender, MouseEventArgs e)
        {
            currentPolyline.AddPoint(e);
        }

        public IEnumerable<Shape> MouseDown(object sender, MouseButtonEventArgs e)
        {
            currentPolyline = new PolylineGenerator();
            currentPolyline.AddPoint(e);
            yield return currentPolyline.polyline;
        }

        public void ReInit()
        {
            currentPolyline = new PolylineGenerator();
        }
    }
}
