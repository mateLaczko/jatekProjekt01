using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ujjatek
{
    public class Funkciok
    {
        public void JobbraLeptet(TextBlock[,] fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.GetLength(0)-1; i++)
            {
                for (int j = 0; j < fieldek.GetLength(1); j++)
                {
                    if (fieldek[i,j].Background == Brushes.Green && db < 1)
                    {

                        if (fieldek[i + 1,j].Background != Brushes.Black)
                        {
                            fieldek[i + 1,j].Background = Brushes.Green;
                            fieldek[i,j].Background = Brushes.LightGray;
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

                        if (fieldek[i, j-1].Background != Brushes.Black)
                        {
                            fieldek[i, j-1].Background = Brushes.Green;
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
                for (int j = 0; j < fieldek.GetLength(1)-1; j++)
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

        public void SetAkadalyok(TextBlock[,] fieldek)
        {
            for (int i = 2; i < fieldek.GetLength(0); i+=3)
            {
                for (int j = 0; j < fieldek.GetLength(1); j+=4)
                {
                    fieldek[i,j].Background = Brushes.Black;
                    fieldek[fieldek.GetLength(0) - 12, fieldek.GetLength(1) - 1].Background = Brushes.Yellow;
                    fieldek[fieldek.GetLength(0) - 6, fieldek.GetLength(1) - 8].Background = Brushes.Yellow;
                    fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 1].Background = Brushes.Blue;
                }
            }
            StartPoint(fieldek);
        }

        public void StartPoint(TextBlock[,] fieldek)
        {
            
            bool isPlayer = false;
            for (int i = 0; i < fieldek.GetLength(0); i++)
            {
                for (int j = 0; j < fieldek.GetLength(1); j++)
                {
                    if (fieldek[i,j].Background == Brushes.Green)
                    {
                        isPlayer = true;
                    }
                } 
            }
            if(isPlayer == false)
                fieldek[0, 0].Background = Brushes.Green;
        }

        public bool Win(TextBlock[,] fieldek)
        {
            if (fieldek[fieldek.GetLength(0)-1, fieldek.GetLength(1)-1].Background == Brushes.Green)
                return true;
            else
                return false;
                
        }

        public int CollectYellows(TextBlock[,] fieldek)
        {
            if ((fieldek[fieldek.GetLength(0) - 12, fieldek.GetLength(1) - 1].Background == Brushes.LightGray && fieldek[fieldek.GetLength(0) - 6, fieldek.GetLength(1) - 8].Background == Brushes.LightGray))
                return 0;

            if (fieldek[fieldek.GetLength(0) - 12, fieldek.GetLength(1) - 1].Background == Brushes.Green)
            {
                return 1;
            }
            else if (fieldek[fieldek.GetLength(0) - 6, fieldek.GetLength(1) - 8].Background == Brushes.Green)
            {
                return 1;
            }
            else
                return 0;
        }

        public void Csapdak(TextBlock[,] fieldek, int movementcount)
        {
            if(movementcount%3 == 0)
            {
                fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background = Brushes.Red;
                fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background = Brushes.Red;
            }
            else
            {
                if(fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background != Brushes.Green && fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background != Brushes.Green)
                {
                    fieldek[fieldek.GetLength(0) - 2, fieldek.GetLength(1) - 1].Background = Brushes.LightGray;
                    fieldek[fieldek.GetLength(0) - 1, fieldek.GetLength(1) - 2].Background = Brushes.LightGray;
                }
            }
        }
    }
}
