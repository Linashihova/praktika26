using System.Windows;
using System.Windows.Controls;

namespace Praktika26.Pages.Clubs.Elements
{
    public partial class Item : UserControl
    {
        Main Main;
        Models.Clubs Club;
        public Item(Models.Clubs Club, Main Main)
        {
            InitializeComponent();
            this.tbName.Text = Club.Name;
            this.tbAddress.Text = Club.Address;
            this.tbWorkTime.Text = Club.WorkTime;
            this.Main = Main;
            this.Club = Club;
        }
        private void EditClub(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this.Main, this.Club));
        }

        private void DeleteClub(object sender, RoutedEventArgs e)
        {
            Classes.UserContext AllUsers = new Classes.UserContext();
            AllUsers.Users.RemoveRange(AllUsers.Users.Where(x => x.IdClub == Club.Id));
            AllUsers.SaveChanges();

            Main.AllClub.Clubs.Remove(Club);
            Main.AllClub.SaveChanges();
            Main.parent.Children.Remove(this);
        }
    }
}
