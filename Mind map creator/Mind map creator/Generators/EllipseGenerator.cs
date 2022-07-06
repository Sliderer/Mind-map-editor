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
    class EllipseGenerator
    {
        internal Ellipse ellipse;
        private double centerX;
        private double centerY;

        public EllipseGenerator()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = Brushes.Black;
            StrokeInitialize.InitShape(ellipse);
            ellipse.Width = 0;
            ellipse.Height = 0;


            centerX = 0;
            centerY = 0;
        }

        public void SetCenter(double x, double y)
        {
            ellipse.Margin = new Thickness(x, y, 0,0);
            centerX = x;
            centerY = y;
        }

        public void SetScale(double x, double y)
        {
            ellipse.Width = Math.Abs(centerX - x);
            ellipse.Height = Math.Abs(centerY - y);
        }
    }
}
