using System.Windows;
using System.Windows.Shapes;


namespace Mind_map_creator
{
    public class StrokeInitialize
    {
        internal static double strokeThinknes;

        public static void InitShape(Shape shape)
        {
            shape.StrokeThickness = strokeThinknes;
        }
    }
}
