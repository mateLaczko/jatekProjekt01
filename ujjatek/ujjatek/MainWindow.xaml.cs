using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ujjatek
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
             
        }

        public List<TextBlock> GetFuckingFields()
        {
            List<TextBlock> fieldek = new List<TextBlock>();
            fieldek.Add(field1);
            fieldek.Add(field2);
            fieldek.Add(field3);
            fieldek.Add(field4);
            fieldek.Add(field5);
            fieldek.Add(field6);
            fieldek.Add(field7);
            fieldek.Add(field8);
            fieldek.Add(field9);
            fieldek.Add(field10);
            fieldek.Add(field11);
            fieldek.Add(field12);
            fieldek.Add(field13);
            fieldek.Add(field14);
            fieldek.Add(field15);
            fieldek.Add(field16);
            fieldek.Add(field17);
            fieldek.Add(field18);
            fieldek.Add(field19);
            fieldek.Add(field20);
            fieldek.Add(field21);
            fieldek.Add(field22);
            fieldek.Add(field23);
            fieldek.Add(field24);
            fieldek.Add(field25);
            fieldek.Add(field26);
            fieldek.Add(field27);
            fieldek.Add(field28);
            fieldek.Add(field29);
            fieldek.Add(field30);
            fieldek.Add(field31);
            fieldek.Add(field32);
            fieldek.Add(field33);
            fieldek.Add(field34);
            fieldek.Add(field35);
            fieldek.Add(field36);
            return fieldek;
        }

        private void Window_KeyUp_1(object sender, KeyEventArgs e)
        {
            Funkciok OP = new Funkciok();
            if (OP.Win(GetFuckingFields()) == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }
                
            if (e.Key == Key.Right)           
                OP.JobbraLeptet(GetFuckingFields());          
            if (e.Key == Key.Left)
                OP.BalraLeptet(GetFuckingFields());
            if (e.Key == Key.Up)
                OP.FelLeptet(GetFuckingFields());
            if (e.Key == Key.Down)
                OP.LeLeptet(GetFuckingFields());

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Funkciok OP = new Funkciok();
            if (OP.Win(GetFuckingFields()) == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }

            if (button.Name == "Up")
                OP.FelLeptet(GetFuckingFields());
            if(button.Name == "Right")
                OP.JobbraLeptet(GetFuckingFields());
            if (button.Name == "Down")
                OP.LeLeptet(GetFuckingFields());
            if (button.Name == "Left")
                OP.BalraLeptet(GetFuckingFields());
        }

        private void GameStartgeci_Click(object sender, RoutedEventArgs e)
        {
            Funkciok OP = new Funkciok();
            OP.SetAkadalyok(GetFuckingFields());
            FeedBack.Text = "";
        }
    }
}
