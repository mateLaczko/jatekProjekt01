using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ujjatek
{
    public class Player
    {
        public TextBlock Position { get; set; }

        public Player(TextBlock position)
        {
            Position = position;
        }

        public void SetColor()
        {
            Position.Background = Brushes.Green;
        }

        public void JobbraLeptet(TextBlock[,] fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < fieldek.GetLength(1); j++)
                {
                    if (fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (fieldek[i + 1, j].Background != Brushes.Black)
                        {
                            fieldek[i + 1, j].Background = Brushes.Green;
                            fieldek[i, j].Background = Brushes.LightGray;
                            Position = fieldek[i, j];
                            db++;
                        }
                    }
                }
            }
        }

        public void BalraLeptet(TextBlock[,] fieldek)
        {
            int db = 0;
            for (int i = 1; i < fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < fieldek.GetLength(1); j++)
                {
                    if (fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (fieldek[i - 1, j].Background != Brushes.Black)
                        {
                            fieldek[i - 1, j].Background = Brushes.Green;
                            fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }

        public void FelLeptet(TextBlock[,] fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.GetLength(0); i++)
            {
                for (int j = 1; j < fieldek.GetLength(1); j++)
                {
                    if (fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (fieldek[i, j - 1].Background != Brushes.Black)
                        {
                            fieldek[i, j - 1].Background = Brushes.Green;
                            fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }

        public void LeLeptet(TextBlock[,] fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < fieldek.GetLength(1) - 1; j++)
                {
                    if (fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (fieldek[i, j + 1].Background != Brushes.Black)
                        {
                            fieldek[i, j + 1].Background = Brushes.Green;
                            fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }
    }
}
