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
    /// Interaction logic for RemoveVisit.xaml
    /// </summary>
    public partial class RemoveVisit : Page
    {
        InternetContext db = new InternetContext();
        public RemoveVisit()
        {
            InitializeComponent();
            db.UsersResources.Load();
            List<string> VisitList = new List<string>();

            foreach (var item in db.UsersResources.ToList())
            {
                VisitList.Add(item.UserData + " - " + item.ResourceData);
            }

            VisitComboBox.ItemsSource = VisitList;
        }

        private void Remove_Visit(object sender, RoutedEventArgs e)
        {
            string UserName = (string)VisitComboBox.SelectedItem;
            int UserId = -1;
            int ResourceId = -1;
            foreach (var item in db.UsersResources)
            {
                if (item.UserData + " - " + item.ResourceData == UserName)
                {
                    UserId = item.UserId;
                    ResourceId = item.ResourceId;
                }
            }
            if (UserId == -1 || ResourceId == -1)
            {
                MessageBox.Show("Будь-ласка, виберіть відвідування!");
            }
            else
            {
                UserResource visit = db.UsersResources.Find(UserId, ResourceId);
                db.Remove(visit);
                db.SaveChanges();
                MessageBox.Show("Відвідування успішно видалений");
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
        private void RemoveUser(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoveUser());
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
