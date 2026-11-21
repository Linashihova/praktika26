using System.Windows;
using System.Windows.Controls;

namespace Praktika26.Pages.Clubs
{
    public partial class Add : Page
    {
        Main Main;
        Models.Clubs Club;
        public Add(Main Main, Models.Clubs Club = null)
        {
            InitializeComponent();
            this.Main = Main;
            if (Club != null)
            {
                this.Club = Club;
                this.tbName.Text = Club.Name;
                this.tbAddress.Text = Club.Address;
                this.tbWorkTime.Text = Club.WorkTime;
                btnAdd.Content = "Изменить";
            }
        }
        private void AddClub(object sender, RoutedEventArgs e)
        {
            if (this.Club == null)
            {
                Club = new Models.Clubs();
                Club.Name = this.tbName.Text;
                Club.Address = this.tbAddress.Text;
                Club.WorkTime = this.tbWorkTime.Text;
                this.Main.AllClub.Clubs.Add(this.Club);
            }
            else
            {
                Club.Name = this.tbName.Text;
                Club.Address = this.tbAddress.Text;
                Club.WorkTime = this.tbWorkTime.Text;
            }
            this.Main.AllClub.SaveChanges();
            MainWindow.init.OpenPages(new Pages.Clubs.Main());
        }
    }
}
