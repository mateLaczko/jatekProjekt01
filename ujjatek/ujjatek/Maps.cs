using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ujjatek
{
    public class Maps
    {
        public TextBlock[,] Fieldek { get; set; }
        public Player Player { get; private set; }
        public Stars Stars { get; set; }
        public TextBlock End { get; set; }

        public Maps(TextBlock[,] fieldek, Player player, Stars stars, TextBlock end)
        {
            Fieldek = fieldek;
            Player = player;
            Stars = stars;
            End = end;
        }

        public void SetAkadalyok()
        {
            for (int i = 2; i < Fieldek.GetLength(0); i += 3)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j += 4)
                {
                    //Fieldek[i, j].Background = Brushes.Black;
                    Fieldek[Fieldek.GetLength(0) - 12, Fieldek.GetLength(1) - 1].Background = Brushes.Yellow;
                    Fieldek[Fieldek.GetLength(0) - 6, Fieldek.GetLength(1) - 8].Background = Brushes.Yellow;
                    Fieldek[Fieldek.GetLength(0) - 1, Fieldek.GetLength(1) - 1].Background = Brushes.Blue;
                }
            }
            StartPoint();
        }

        public void StartPoint()
        {

            bool isPlayer = false;
            for (int i = 0; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i, j].Background == Brushes.Green)
                    {
                        isPlayer = true;
                    }
                }
            }
            if (isPlayer == false)
                Fieldek[0, 0].Background = Brushes.Green;
        }

        public bool Win()
        {
            if (Fieldek[Fieldek.GetLength(0) - 1, Fieldek.GetLength(1) - 1].Background == Brushes.Green)
                return true;
            else
                return false;

        }

        public int CollectYellows( ref int countelso, ref int countmasodik)
        {
            if (Fieldek[Fieldek.GetLength(0) - 12, Fieldek.GetLength(1) - 1].Background == Brushes.Green && countelso < 1)
            {
                countelso++;
                return 1;
            }
            else if (Fieldek[Fieldek.GetLength(0) - 6, Fieldek.GetLength(1) - 8].Background == Brushes.Green && countmasodik < 1)
            {
                countmasodik++;
                return 1;
            }
            else
                return 0;
        }
    }
}
