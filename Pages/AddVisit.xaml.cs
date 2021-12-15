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
    /// Interaction logic for AddVisit.xaml
    /// </summary>
    public partial class AddVisit : Page
    {
        InternetContext db = new InternetContext();
        public AddVisit()
        {
            InitializeComponent();
            db.Resources.Load();
            List<string> ResourceList = new List<string>();

            foreach (var item in db.Resources.ToList())
            {
                ResourceList.Add(item.Name);
            }

            ResourcesComboBox.ItemsSource = ResourceList;

            db.Users.Load();
            List<string> UserList = new List<string>();

            foreach (var item in db.Users.ToList())
            {
                UserList.Add(item.FirstName + " " + item.LastName);
            }

            UsersComboBox.ItemsSource = UserList;

        }

        private void Add_Visit(object sender, RoutedEventArgs e)
        {
            string ResourceName = (string)ResourcesComboBox.SelectedItem;
            string UserName = (string)UsersComboBox.SelectedItem;
            int ResourceId = -1;
            int UserId = -1;
            foreach (var i in db.Resources)
            {
                if (i.Name == ResourceName) ResourceId = i.Id;
            }
            foreach (var i in db.Users)
            {
                if (i.FirstName + " " + i.LastName == UserName) UserId = i.Id;
            }
            if (ResourceId == -1 || UserId == -1)
            {
                MessageBox.Show("Будь-ласка, виберіть інтернет ресурс та користувача!");
            }
            else
            {
                InternetResource resource = db.Resources.Find(ResourceId);
                User user = db.Users.Find(UserId);

                UserResource ur = new UserResource(user, resource);

                if (db.UsersResources.Any(o => o.ResourceData == ur.ResourceData))
                {
                    MessageBox.Show("Таке відвідування вже існує в базі даних!");
                }
                else
                {
                    db.UsersResources.Add(ur);

                    db.SaveChanges();
                    MessageBox.Show("Відвідування успішно додано");
                }
                ResourcesComboBox.Text = String.Empty;
                UsersComboBox.Text = String.Empty;
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
        private void AddUser(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUser());
        }

        private void RemoveInternetResource(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RemoveInternetResource());
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
