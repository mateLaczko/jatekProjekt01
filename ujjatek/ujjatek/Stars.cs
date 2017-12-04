using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ujjatek
{
    public class Stars
    {
        public List<TextBlock> Starlist { get; set; }

        public Stars(List<TextBlock> starlist)
        {
            Starlist = starlist;
        }

        public void SetColor()
        {
            foreach (var star in Starlist)
            {
                star.Background = Brushes.Yellow;
            }
        }
    }
}
