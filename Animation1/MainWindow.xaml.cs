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
using System.Windows.Media.Animation;

namespace Animation1
{
    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonHeight_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.From = 100;
            doubleAnimation.To = 250;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);

            Rect.BeginAnimation(Rectangle.HeightProperty, doubleAnimation);

        }

        private void ButtonWidth_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation doubleAnimation = new DoubleAnimation();

            doubleAnimation.By = 150;
            doubleAnimation.Duration = TimeSpan.FromSeconds(2);

            Rect.BeginAnimation(Rectangle.WidthProperty, doubleAnimation);

        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            Rect.BeginAnimation(Rectangle.WidthProperty, null);
            Rect.BeginAnimation(Rectangle.HeightProperty, null);
        }
    }
}
