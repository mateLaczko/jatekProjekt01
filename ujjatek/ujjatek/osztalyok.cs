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
        public void JobbraLeptet(List<TextBlock> fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.Count(); i++)
            {
                if (fieldek[i].Text != "" && db < 1 && i != 5 && i != 11 && i != 17 && i != 23 && i != 29 && i != 35)
                {
                    if(fieldek[i + 1].Background != Brushes.Black)
                    {
                        fieldek[i + 1].Text = fieldek[i].Text;
                        fieldek[i].Text = "";
                        db++;
                    }
                }
            }
        }

        public void BalraLeptet(List<TextBlock> fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.Count(); i++)
            {
                if (fieldek[i].Text != "" && db < 1 && i != 0 && i != 6 && i != 18 && i != 24 && i != 30)
                {
                    if (fieldek[i - 1].Background != Brushes.Black)
                    {
                        fieldek[i - 1].Text = fieldek[i].Text;
                        fieldek[i].Text = "";
                        db++;
                    }    
                }
            }
        }

        public void FelLeptet(List<TextBlock> fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.Count(); i++)
            {
                if (fieldek[i].Text != "" && db < 1 && i != 0 && i != 1 && i != 2 && i != 3 && i != 4 && i != 5)
                {
                    if (fieldek[i - 6].Background != Brushes.Black)
                    {
                        fieldek[i - 6].Text = fieldek[i].Text;
                        fieldek[i].Text = "";
                        db++;
                    }  
                }
            }
        }

        public void LeLeptet(List<TextBlock> fieldek)
        {
            int db = 0;
            for (int i = 0; i < fieldek.Count(); i++)
            {
                if (fieldek[i].Text != "" && db < 1 && i != 30 && i != 31 && i != 32 && i != 33 && i != 34 && i != 35)
                {
                    if (fieldek[i + 6].Background != Brushes.Black)
                    {
                        fieldek[i + 6].Text = fieldek[i].Text;
                        fieldek[i].Text = "";
                        db++;
                    }  
                }
            }
        }

        public void SetAkadalyok(List<TextBlock> fieldek)
        {
            fieldek[6].Background = Brushes.Black;
            fieldek[7].Background = Brushes.Black;
            fieldek[8].Background = Brushes.Black;
            fieldek[9].Background = Brushes.Black;
            fieldek[11].Background = Brushes.Black;
            fieldek[18].Background = Brushes.Black;
            fieldek[20].Background = Brushes.Black;
            fieldek[21].Background = Brushes.Black;
            fieldek[22].Background = Brushes.Black;
            fieldek[23].Background = Brushes.Black;
            fieldek[26].Background = Brushes.Black;
            fieldek[30].Background = Brushes.Black;
            fieldek[34].Background = Brushes.Black;
            fieldek[35].Background = Brushes.Blue;
            StartPoint(fieldek);
        }

        public void StartPoint(List<TextBlock> fieldek)
        {
            
            bool isPlayer = false;
            for (int i = 0; i < fieldek.Count; i++)
            {
                if(fieldek[i].Text == "֍")
                {
                    isPlayer = true;
                }
            }
            if(isPlayer == false)
                fieldek[0].Text = "֍";
        }

        public bool Win(List<TextBlock> fieldek)
        {
            if (fieldek[35].Text == "֍")
                return true;
            else
                return false;
                
        }
    }
}
