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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    enum Mode
    {
        Idle, Drawing, Wiping
    }


    public partial class MainWindow : Window 
    {

        private Mode currentMode;
        private Mode selectedMode;
        private IDrawer currentDrawer;
        private Shape lastShape;

        public MainWindow()
        {
            InitializeComponent();
            currentMode = Mode.Idle;
            selectedMode = Mode.Drawing;
            currentDrawer = new IdleDrawer();
        }

        private void ScaleValueChaned(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeScreenScale((sender as Slider).Value);
        }

        private void ChangeScreenScale(double value)
        {
            foreach(Shape i in Canvas.Children)
            {
                i.Width -= 1;
                i.Height -= 1;
            }
        }

        private void ToolsButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToolsBar.Visibility == Visibility.Visible)
            {
                ToolsBar.Visibility = Visibility.Hidden;
            }
            else
            {
                ToolsBar.Visibility = Visibility.Visible;
            }
        }

        private void Canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            currentMode = Mode.Idle;
            currentDrawer.ReInit();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {

            currentMode = selectedMode;
            if (currentMode != Mode.Drawing) return;

    
            var resultShapes = currentDrawer.MouseDown(sender, e);
            if (resultShapes == null) return;
            
            foreach (Shape shape in resultShapes)
            {
                shape.MouseDown += DeleteObject;
                Canvas.Children.Add(shape);
                lastShape = shape;
            }
        }

        public void DeleteObject(object sender, MouseEventArgs e)
        {
            if (currentMode == Mode.Wiping)
            {
                Canvas.Children.Remove((Shape)sender);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (currentMode == Mode.Drawing)
            {
                currentDrawer.MouseMove(sender, e);
            }
        }

        private void Drawpolyline_Click(object sender, RoutedEventArgs e)
        {
            selectedMode = Mode.Drawing;
            currentDrawer = new PolylineDrawer();
        }

        private void DrawRectangle_Click(object sender, RoutedEventArgs e)
        {
            selectedMode = Mode.Drawing;
            currentDrawer = new RectangleDrawer();
        }

        private void DrawElipse_Click(object sender, RoutedEventArgs e)
        {
            selectedMode = Mode.Drawing;
            currentDrawer = new EllipseDrawer();
        }

        private void DrawLine_Click(object sender, RoutedEventArgs e)
        {
            selectedMode = Mode.Drawing;
            currentDrawer = new LineDrawer();
        }

        private void StrokeThicknes_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            StrokeInitialize.strokeThinknes = (sender as Slider).Value;
        }

        private void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == (ModifierKeys.Control) && e.Key == Key.Z && lastShape != null)
            {
                Canvas.Children.Remove(lastShape);
            }
        }

        private void Rubber_Click(object sender, RoutedEventArgs e)
        {
            selectedMode = Mode.Wiping;
        }

        private void ColorPickerButton_Click(object sender, RoutedEventArgs e)
        {
            ColorPickerPanel.Visibility = Visibility.Visible;
        }
    }
}
