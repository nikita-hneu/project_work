using System.Windows.Controls;
using Project_Work.Context;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Project_Work.Models;

namespace Project_Work.Pages
{
    /// <summary>
    /// Interaction logic for ShowUsersList.xaml
    /// </summary>
    public partial class ShowUsersList : Page
    {
        InternetContext db = new InternetContext();
        public ShowUsersList()
        {
            InitializeComponent();
            db.Users.Load();
            UsersGrid.ItemsSource = db.Users.Local.ToBindingList();
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
        private void About(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new About());
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
