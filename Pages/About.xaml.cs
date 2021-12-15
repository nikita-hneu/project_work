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

namespace Project_Work.Pages
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }


        private void MainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Main());
        }
        private void AddInternetResource(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddInternetResource());
        }

        private void RemoveInternetResource(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoveInternetResource());
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUser());
        }

        private void RemoveUser(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoveUser());
        }

        private void ShowInternetResourcesList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowInternetResourcesList());
        }

        private void ShowUsersList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowUsersList());
        }

        private void AddVisit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddVisit());
        }
        private void RemoveVisit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoveVisit());
        }
        private void ShowVisitList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShowVisitList());
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
