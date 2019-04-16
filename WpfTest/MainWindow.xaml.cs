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

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ellipse el = new Ellipse();
        Random rng = new Random();
        Point pos;

        public MainWindow()
        {
            InitializeComponent();

            // Create a SolidColorBrush with a red color to fill the 
            // Ellipse with.
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();

            // Describes the brush's color using RGB values. 
            // Each value has a range of 0-255.
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            el.Fill = mySolidColorBrush;
            el.StrokeThickness = 2;
            el.Stroke = Brushes.Black;

            // Set the width and height of the Ellipse.
            el.Width = 20;
            el.Height = 20;
            pos = new Point(0, 0);
            //el.MouseEnter += El_MouseEnter;
           
            // Add the Ellipse to the StackPanel.
            game.Children.Add(el);


        }

        private void El_MouseEnter(object sender, MouseEventArgs e)
        {
            game.Children.Remove(el);

            //Control.MousePosition;

            //el.Margin = new Thickness(rng.Next(Convert.ToInt32(game.Width)), rng.Next(Convert.ToInt32(game.Height)), 0, 0);

            game.Children.Add(el);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Hidden;
            game.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            game.Visibility = Visibility.Hidden;
            start.Visibility = Visibility.Visible;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
           

            b2.Margin = new Thickness(rng.Next(Convert.ToInt32(game.Width)), rng.Next(Convert.ToInt32(game.Height)), 0, 0);
        }
    }
}
