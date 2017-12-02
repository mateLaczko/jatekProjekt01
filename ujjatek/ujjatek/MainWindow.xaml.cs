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
        TextBlock[,] fieldek = new TextBlock[12, 12];
        
        public MainWindow()
        {
            
            InitializeComponent();
            fieldek = CreateFields(12, 12);

        }
       
        public TextBlock[,] CreateFields(int x, int y)

        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(180, 180, 180));
            TextBlock[,] textBlocks = new TextBlock[x, y];
            for (int i = 0; i < textBlocks.GetLength(0); i++)
            {
                for (int j = 0; j < textBlocks.GetLength(1); j++)
                {
                    textBlocks[i, j] = new TextBlock();
                    textBlocks[i, j].HorizontalAlignment = HorizontalAlignment.Left;
                    textBlocks[i, j].VerticalAlignment = VerticalAlignment.Top;
                    textBlocks[i, j].TextWrapping = TextWrapping.Wrap;
                    textBlocks[i, j].Height = 25;
                    textBlocks[i, j].Width = 25;
                    textBlocks[i, j].FontSize = 12;
                    textBlocks[i, j].Background = Brushes.LightGray;
                    textBlocks[i, j].TextAlignment = TextAlignment.Center;
                    grid_name.Children.Add(textBlocks[i, j]);
                    textBlocks[i, j].Margin = new Thickness { Left = (i + 1) * 27, Top = (j + 1) * 27 };
                    textBlocks[i, j].Name = $"box_{i}x{j}";
                }
            }
            return textBlocks;
        }
        private void Window_KeyUp_1(object sender, KeyEventArgs e)
        {
            Funkciok OP = new Funkciok();
            if (OP.Win(fieldek) == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }

            if (e.Key == Key.Right)
                OP.JobbraLeptet(fieldek);
            if (e.Key == Key.Left)
                OP.BalraLeptet(fieldek);
            if (e.Key == Key.Up)
                OP.FelLeptet(fieldek);
            if (e.Key == Key.Down)
                OP.LeLeptet(fieldek);

            if (OP.Win(fieldek) == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Funkciok OP = new Funkciok();
            if (OP.Win(fieldek) == true)
            {
                FeedBack.Text = "Vége, nyertél!";
                return;
            }
        }

        private void GameStartgeci_Click(object sender, RoutedEventArgs e)
        {
            Funkciok OP = new Funkciok();
            OP.SetAkadalyok(fieldek);
            FeedBack.Text = "";
        }
    }
}
