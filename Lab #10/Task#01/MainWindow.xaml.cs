using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Task01
{
    public partial class BringBackPocoyo : Window
    {
        public BringBackPocoyo()
        {
            InitializeComponent();

            // Set image sources
            Image1.Source = new BitmapImage(new Uri("pack://application:,,,/image1.png"));
            Image2.Source = new BitmapImage(new Uri("pack://application:,,,/image2.png"));
            Image3.Source = new BitmapImage(new Uri("pack://application:,,,/image3.png"));
        }
    }
}