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
    public class Map
    {
        public TextBlock[,] Fieldek { get; set; }
        public OnePoint StartPoint { get; set; }
        public OnePoint WinPoint { get; set; }
        public List<OnePoint> Stars { get; set; }
        public int[] StarsCount { get; set; }

        //Konstruktor
        public Map(TextBlock[,] fieldek, OnePoint startpoint, OnePoint winpoint, OnePoint firstStar, OnePoint secondStar, OnePoint thirdStar)
        {
            Fieldek = fieldek;
            StartPoint = startpoint;
            WinPoint = winpoint;
            StarsCount = new int[3] {0, 0, 0};
            Stars = new List<OnePoint>();
            Stars.Add(firstStar);
            Stars.Add(secondStar);
            Stars.Add(thirdStar);
        }

        //Léptetések
        public void JobbraLeptet()
        {
            int db = 0;
            for (int i = 0; i < Fieldek.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i,j].Background == Brushes.Green && db < 1)
                    {

                        if (Fieldek[i + 1,j].Background != Brushes.Black)
                        {
                            Fieldek[i + 1,j].Background = Brushes.Green;
                            Fieldek[i,j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }
        public void BalraLeptet()
        {
            int db = 0;
            for (int i = 1; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (Fieldek[i - 1, j].Background != Brushes.Black)
                        {
                            Fieldek[i - 1, j].Background = Brushes.Green;
                            Fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }
        public void FelLeptet()
        {
            int db = 0;
            for (int i = 0; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 1; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (Fieldek[i, j-1].Background != Brushes.Black)
                        {
                            Fieldek[i, j-1].Background = Brushes.Green;
                            Fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }
        public void LeLeptet()
        {
            int db = 0;
            for (int i = 0; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1)-1; j++)
                {
                    if (Fieldek[i, j].Background == Brushes.Green && db < 1)
                    {

                        if (Fieldek[i, j + 1].Background != Brushes.Black)
                        {
                            Fieldek[i, j + 1].Background = Brushes.Green;
                            Fieldek[i, j].Background = Brushes.LightGray;
                            db++;
                        }
                    }
                }
            }
        }

        //Pályaelemek elhelyezése
        public void MapBuilder()
        {
            SetBlackBlocks();
            SetStars();
            SetWinPoint();
            SetPlayer();
        }
        public void SetBlackBlocks()
        {
            //Fieldek[0, 2].Background = Brushes.Black;
            //Fieldek[0, 4].Background = Brushes.Black;
            //Fieldek[0, 6].Background = Brushes.Black;
            //Fieldek[0, 8].Background = Brushes.Black;
            //Fieldek[0, 9].Background = Brushes.Black;
            //Fieldek[0, 10].Background = Brushes.Black;
            //Fieldek[0, 11].Background = Brushes.Black;
            //Fieldek[1, 2].Background = Brushes.Black;
            //Fieldek[1, 6].Background = Brushes.Black;
            //Fieldek[2, 1].Background = Brushes.Black;
            //Fieldek[2, 2].Background = Brushes.Black;
            //Fieldek[2, 4].Background = Brushes.Black;
            //Fieldek[2, 6].Background = Brushes.Black;
            //Fieldek[2, 8].Background = Brushes.Black;
            //Fieldek[2, 9].Background = Brushes.Black;
            //Fieldek[2, 10].Background = Brushes.Black;
            //Fieldek[3, 4].Background = Brushes.Black;
            //Fieldek[3, 10].Background = Brushes.Black;
            //Fieldek[4, 0].Background = Brushes.Black;
            //Fieldek[4, 1].Background = Brushes.Black;
            //Fieldek[4, 2].Background = Brushes.Black;
            //Fieldek[4, 3].Background = Brushes.Black;
            //Fieldek[4, 4].Background = Brushes.Black;
            //Fieldek[4, 6].Background = Brushes.Black;
            //Fieldek[4, 8].Background = Brushes.Black;
            //Fieldek[4, 9].Background = Brushes.Black;
            //Fieldek[4, 10].Background = Brushes.Black;
            //Fieldek[4, 11].Background = Brushes.Black;
            //Fieldek[5, 6].Background = Brushes.Black;
            //Fieldek[6, 0].Background = Brushes.Black;
            //Fieldek[6, 1].Background = Brushes.Black;
            //Fieldek[6, 2].Background = Brushes.Black;
            //Fieldek[6, 4].Background = Brushes.Black;
            //Fieldek[6, 5].Background = Brushes.Black;
            //Fieldek[6, 6].Background = Brushes.Black;
            //Fieldek[6, 8].Background = Brushes.Black;
            //Fieldek[6, 10].Background = Brushes.Black;
            //Fieldek[6, 11].Background = Brushes.Black;
            //Fieldek[7, 8].Background = Brushes.Black;
            //Fieldek[8, 0].Background = Brushes.Black;
            //Fieldek[8, 1].Background = Brushes.Black;
            //Fieldek[8, 2].Background = Brushes.Black;
            //Fieldek[8, 3].Background = Brushes.Black;
            //Fieldek[8, 4].Background = Brushes.Black;
            //Fieldek[8, 6].Background = Brushes.Black;
            //Fieldek[8, 8].Background = Brushes.Black;
            //Fieldek[8, 9].Background = Brushes.Black;
            //Fieldek[8, 10].Background = Brushes.Black;
            //Fieldek[9, 2].Background = Brushes.Black;
            //Fieldek[9, 6].Background = Brushes.Black;
            //Fieldek[9, 10].Background = Brushes.Black;
            //Fieldek[10, 0].Background = Brushes.Black;
            //Fieldek[10, 2].Background = Brushes.Black;
            //Fieldek[10, 3].Background = Brushes.Black;
            //Fieldek[10, 4].Background = Brushes.Black;
            //Fieldek[10, 6].Background = Brushes.Black;
            //Fieldek[10, 7].Background = Brushes.Black;
            //Fieldek[10, 8].Background = Brushes.Black;
            //Fieldek[10, 10].Background = Brushes.Black;
            //Fieldek[11, 0].Background = Brushes.Black;
            //Fieldek[11, 10].Background = Brushes.Black;
        }
        public void SetStars()
        {
            for (int i = 0; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i, j].Background == Brushes.Green)
                    {
                        return;
                    }
                }
            }

            foreach (var star in Stars)
            {
                Fieldek[star.X, star.Y].Background = Brushes.Yellow;
            }
        }
        public void SetWinPoint()
        {
            if (Fieldek[WinPoint.X, WinPoint.Y].Background != Brushes.Blue && Fieldek[WinPoint.X, WinPoint.Y].Background != Brushes.Green)
            {
                Fieldek[WinPoint.X, WinPoint.Y].Background = Brushes.Blue;
            }
        }
        public void SetPlayer()
        {
            bool isPlayer = false;
            for (int i = 0; i < Fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < Fieldek.GetLength(1); j++)
                {
                    if (Fieldek[i,j].Background == Brushes.Green)
                    {
                        isPlayer = true;
                    }
                } 
            }
            if(isPlayer == false)
                Fieldek[StartPoint.X, StartPoint.Y].Background = Brushes.Green;
        }

        //Események
        public bool Win()
        {
            for (int i = 0; i < StarsCount.Length; i++)
            {
                if(StarsCount[i] < 1)
                {
                    return false;
                }
            }

            if (Fieldek[WinPoint.X, WinPoint.Y].Background == Brushes.Green)
                return true;
            else
                return false;
                
        }
        public void CollectYellows()
        {
            for (int i = 0; i < Stars.Count; i++)
            {
                if(Fieldek[Stars[i].X, Stars[i].Y].Background == Brushes.Green && StarsCount[i] < 1)
                {
                    StarsCount[i] = 1;
                }
            }

            //if (Fieldek[Fieldek.GetLength(0) - 12, Fieldek.GetLength(1) - 1].Background == Brushes.Green && coountelso < 1)
            //{
            //    coountelso++;
            //    return 1;
            //}
            //else if (Fieldek[Fieldek.GetLength(0) - 6, Fieldek.GetLength(1) - 8].Background == Brushes.Green && countmasodik < 1)
            //{
            //    countmasodik++;
            //    return 1;
            //}
            //else
            //    return 0;
        }

        //public void Csapdak(TextBlock[,] fieldek, int movementcount)
        //{
        //    if(movementcount%3 == 0)
        //    {
        //        fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background = Brushes.Red;
        //        fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background = Brushes.Red;
        //    }
        //    else
        //    {
        //        if(fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background != Brushes.Green && fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background != Brushes.Green)
        //        {
        //            fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background = Brushes.LightGray;
        //            fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background = Brushes.LightGray;
        //        }
        //    }
        //}
    }
}
