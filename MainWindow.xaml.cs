using System.Windows;
using Project_Work.Pages;
using System.Windows.Controls;

namespace Project_Work
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Main();

        }
    }
}
