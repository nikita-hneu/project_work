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
    /// Interaction logic for RemoveUser.xaml
    /// </summary>
    public partial class RemoveUser : Page
    {
        InternetContext db = new InternetContext();
        public RemoveUser()
        {
            InitializeComponent();
            db.Users.Load();
            List<string> UserList = new List<string>();

            foreach (var item in db.Users.ToList())
            {
                UserList.Add(item.FirstName + " " + item.LastName);
            }

            UsersComboBox.ItemsSource = UserList;
        }
        private void Remove_User(object sender, RoutedEventArgs e)
        {
            string UserName = (string)UsersComboBox.SelectedItem;
            int UserId = -1;
            foreach (var i in db.Users)
            {
                if (i.FirstName + " " + i.LastName == UserName) UserId = i.Id;
            }
            if (UserId == -1)
            {
                MessageBox.Show("Будь-ласка, виберіть користувача!");
            }
            else
            {
                User user = db.Users.Find(UserId);
                db.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Користувач успішно видалений");
            }
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
