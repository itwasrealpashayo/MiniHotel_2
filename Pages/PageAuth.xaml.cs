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
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            user objUser = DatabaseEntities.GetContext().user.FirstOrDefault(x => x.login == TxbLogin.Text && x.password == PsbPassword.Password);

            if (objUser != null)
            {

                switch (objUser.userroleid)
                {
                    case 2:
                        MessageBox.Show($"Здраствуйте {objUser.firstname} {objUser.middlename}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utility.Manager.MainFrame.Navigate(new PageManager());
                        break;
                    case 3:
                        MessageBox.Show($"Здраствуйте {objUser.firstname} {objUser.middlename}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utility.Manager.MainFrame.Navigate(new PageUser1());
                        break;
                    case 1:
                        MessageBox.Show($"Здраствуйте {objUser.firstname} {objUser.middlename}!",
                                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        Utility.Manager.MainFrame.Navigate(new PageUser2());
                        break;

                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    
    }
}
