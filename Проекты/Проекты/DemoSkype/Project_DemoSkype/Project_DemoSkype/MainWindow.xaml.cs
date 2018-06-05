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

namespace Project_DemoSkype
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int countPannel = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButCutDownWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtONOFFSplitter_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void ButtONOFFSplitter_Click(object sender, RoutedEventArgs e)
        {
            countPannel++;
            if(countPannel%2==0)
            {
                ListPannel.Width = new GridLength(2, GridUnitType.Star);
            }
            else
            {
                ListPannel.Width = new GridLength(0, GridUnitType.Star);
            }
            
        }
    }
}
