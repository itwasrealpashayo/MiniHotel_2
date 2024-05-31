using MiniHotel_2.Database;
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

namespace MiniHotel_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageManager.xaml
    /// </summary>
    public partial class PageManager : Page
    {
        public PageManager()
        {
            InitializeComponent();
        }

        private void BtnShift_Click(object sender, RoutedEventArgs e)
        {
            FrameSecond.Navigate(new PageShift());
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            FrameSecond.Navigate(new PageOrder());
        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            FrameSecond.Navigate(new PageUserList());
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Utility.Manager.MainFrame.Navigate(new PageAuth());
        }
    }   
}
