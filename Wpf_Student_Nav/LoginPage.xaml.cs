using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Student_Nav
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public event EventHandler LoggedInEvent;
        User _user;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //1.save user to DB
            //UserDb db = new userDb();
            //db.InsertUser(this._user);

            //3.Update AppContext with logged user
            AppContext.User = _user;

            //3. throw event for main widow to update menu
            if (LoggedInEvent != null)
            {
                LoggedInEvent(this, e);
            }

        }
    }
}
