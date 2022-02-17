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

namespace Goblin_Slayer
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int vs = Convert.ToInt32(textBox.Text);
            for (int i = 0; i < vs; i++)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(@"C:\Users\iai\Desktop\Goblin Slayer\goblin.png"));
                image.Width = 100;
                myWrapPanel.Children.Add(image);
            }
        }
    }
}
