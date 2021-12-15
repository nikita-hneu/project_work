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
    public partial class AddUser : Page
    {
        InternetContext db = new InternetContext();
        public AddUser()
        {
            InitializeComponent();
        }

        private void Add_User(object sender, RoutedEventArgs e)
        {
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string country = Country.Text;
            string city = City.Text;
            string street = Street.Text;
            string house_number = House_Number.Text;

            User user = new User(firstname, lastname, country, city, street, house_number);

            if (firstname =="" || lastname =="" || country == "" || city == "" || street == "")
            {
                MessageBox.Show("Усі поля маують бути заповненні!");
            }
            else if (db.Users.Any(o => o.AddressString == user.AddressString))
            {
                MessageBox.Show("Такий користувач вже існує в базі даних!");
            }
            else
            {
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Користувач успішно доданий");
            }
            
            FirstName.Text = String.Empty;
            LastName.Text = String.Empty;
            Country.Text = String.Empty;
            City.Text = String.Empty;
            Street.Text = String.Empty;
            House_Number.Text = String.Empty;
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
