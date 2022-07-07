using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Mind_map_creator
{
    class AnimationsHolder
    {

        public static DoubleAnimation activateToolsBar = new DoubleAnimation()
        {
            From = 0, To = 105, Duration = TimeSpan.FromSeconds(0.5f)
        };

        public static DoubleAnimation disactivateToolsBar = new DoubleAnimation()
        {
            From = 105,
            To = 0,
            Duration = TimeSpan.FromSeconds(0.5f)
        };

    }
}
