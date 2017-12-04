using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ujjatek
{
    public class EndPoint
    {
        public TextBlock Position { get; private set; }

        public EndPoint(TextBlock position)
        {
            Position = position;
        }

        public void SetColor()
        {
            Position.Background = Brushes.Blue;
        }
    }
}
