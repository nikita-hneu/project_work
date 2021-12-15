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
    /// Interaction logic for RemoveInternetResource.xaml
    /// </summary>
    public partial class RemoveInternetResource : Page
    {
        InternetContext db = new InternetContext();
        public RemoveInternetResource()
        {
            InitializeComponent();
            db.Resources.Load();
            List<string> ResourceList = new List<string>();

            foreach (var item in db.Resources.ToList())
            {
                ResourceList.Add(item.Name);
            }

            ResourcesComboBox.ItemsSource = ResourceList;
        }

        private void Remove_Internet_Resource(object sender, RoutedEventArgs e)
        {
            string ResourceName = (string)ResourcesComboBox.SelectedItem;
            int ResourceId = -1;
            foreach (var i in db.Resources)
            {
                if (i.Name == ResourceName) ResourceId = i.Id;
            }
            if(ResourceId == -1)
            {
                MessageBox.Show("Будь-ласка, виберіть користувача!");
            }
            else
            {
                InternetResource manufacture = db.Resources.Find(ResourceId);
                db.Remove(manufacture);
                db.SaveChanges();
                MessageBox.Show("Інтернет ресурс успішно видалений");
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
