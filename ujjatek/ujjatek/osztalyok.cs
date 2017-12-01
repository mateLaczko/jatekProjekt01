using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

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
                    fieldek[i + 1].Text = fieldek[i].Text;
                    fieldek[i].Text = "";
                    db++;
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
                    fieldek[i - 1].Text = fieldek[i].Text;
                    fieldek[i].Text = "";
                    db++;
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
                    fieldek[i - 6].Text = fieldek[i].Text;
                    fieldek[i].Text = "";
                    db++;
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
                    fieldek[i + 6].Text = fieldek[i].Text;
                    fieldek[i].Text = "";
                    db++;
                }

            }
        }
    }
}
