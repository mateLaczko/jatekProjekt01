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
        Map Palya = new Map(new TextBlock[12, 12], new OnePoint(0, 0), new OnePoint(11, 11), new OnePoint(1, 11), new OnePoint(11, 3), new OnePoint(9, 9));
        public int Count = 0;
        public int MovementCount = 0;

        public MainWindow()
        {
            
            InitializeComponent();
            Palya.Fieldek = CreateFields(12, 12);
        }
       
        public TextBlock[,] CreateFields(int x, int y)
        {
            TextBlock[,] textBlocks = new TextBlock[x, y];
            for (int i = 0; i < textBlocks.GetLength(0); i++)
            {
                for (int j = 0; j < textBlocks.GetLength(1); j++)
                {
                    textBlocks[i, j] = new TextBlock();
                    textBlocks[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    textBlocks[i, j].VerticalAlignment = VerticalAlignment.Top;
                    textBlocks[i, j].Height = 25;
                    textBlocks[i, j].Width = 25;
                    textBlocks[i, j].FontSize = 12;
                    textBlocks[i, j].Background = Brushes.LightGray;
                    grid_name.Children.Add(textBlocks[i, j]);
                    textBlocks[i, j].Margin = new Thickness { Left = (i + 1) * 27, Top = (j + 1) * 27 };
                    textBlocks[i, j].Name = $"box_{i}x{j}";
                }
            }
            return textBlocks;
        }

        private void Window_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (Palya.Win() == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }
            MovementCount++;

            if (e.Key == Key.Right)
                Palya.JobbraLeptet();
            if (e.Key == Key.Left)
                Palya.BalraLeptet();
            if (e.Key == Key.Up)
                Palya.FelLeptet();
            if (e.Key == Key.Down)
                Palya.LeLeptet();

            //Palya.Csapdak(Palya.Fieldek, MovementCount);
            Palya.CollectYellows();
            Palya.SetWinPoint();
            FeedBack.Text = $"{Palya.StarsCount[0]}, {Palya.StarsCount[1]}, {Palya.StarsCount[2]}";

            if (Palya.Win() == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Palya.Win() == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }
        }

        private void GameStartgeci_Click(object sender, RoutedEventArgs e)
        {
            Palya.MapBuilder();
            FeedBack.Text = "";
            MovementCount = 0;
        }
    }
}
