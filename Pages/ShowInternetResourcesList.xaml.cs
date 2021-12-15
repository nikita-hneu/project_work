using System.Windows.Controls;
using Project_Work.Context;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Project_Work.Models;
using System;

namespace Project_Work.Pages
{
    /// <summary>
    /// Interaction logic for ShowInternetResourcesList.xaml
    /// </summary>
    public partial class ShowInternetResourcesList : Page
    {
        InternetContext db = new InternetContext();
        public ShowInternetResourcesList()
        {
            InitializeComponent();
            db.Resources.Load();
            ResourcesGrid.ItemsSource = db.Resources.Local.ToBindingList();
            
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
