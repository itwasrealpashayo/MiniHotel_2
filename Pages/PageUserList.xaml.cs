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
    /// Логика взаимодействия для PageUserList.xaml
    /// </summary>
    public partial class PageUserList : Page
    {
        public PageUserList()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Utility.Manager.MainFrame.Navigate(new PageUserAdd());
        }
    }
}
