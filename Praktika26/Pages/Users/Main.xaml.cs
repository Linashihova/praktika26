using Praktika26.Classes;
using System.Windows;
using System.Windows.Controls;

namespace Praktika26.Pages.Users
{
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
            {
                parent.Children.Add(new Elements.Item(User, this));
            }
        }
        private void AddUser(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Users.Add(this));
        }
    }
}
