using System.Windows.Controls;
using Project_Work.Context;
using System.Windows;
using System.Windows.Navigation;
using System;
using Project_Work.Models;
using System.Linq;

namespace Project_Work.Pages
{
    /// <summary>
    /// Interaction logic for AddInternetResource.xaml
    /// </summary>
    public partial class AddInternetResource : Page
    {
        InternetContext db = new InternetContext();
        public AddInternetResource()
        {
            InitializeComponent();
        }

        private void Add_Manufacture(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string url = URL.Text;
            DateTime date = Date.DisplayDate;

            InternetResource resource = new InternetResource(name, url, date);

            if(name == "" || url == "")
            {
                MessageBox.Show("Усі поля маують бути заповненні!");
            }
            else if(date > DateTime.Now)
            {
                MessageBox.Show("Дата створення повина бути у минулому!");
            }
            else if (db.Resources.Any(o => o.Name + o.URL == resource.Name + resource.URL))
            {
                MessageBox.Show("Такий ресурс вже існує в базі даних!");
            }
            else
            {
                db.Resources.Add(resource);
                db.SaveChanges();
                MessageBox.Show("Інтернет ресурс успішно доданий");
            }

            Name.Text = String.Empty;
            URL.Text = String.Empty;
            Date.Text = String.Empty;
        }

        private void MainMenu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Main());
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
