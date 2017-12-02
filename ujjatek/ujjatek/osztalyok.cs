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
    }
}
