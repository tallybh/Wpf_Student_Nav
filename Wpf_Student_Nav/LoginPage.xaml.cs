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
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            if(Username.Text.Length > 0 && Password.Text.Length >0)
            {
                //1.check if user exist
                UserDb db = new UserDb();
                User u = db.CheckByNameAndPass(Username.Text, Password.Text);

                if(u != null)
                {
                    //3.Update AppContext with logged user
                    AppContext.User = u;

                    //3. throw event for main widow to update menu
                    if (LoggedInEvent != null)
                    {
                        LoggedInEvent(this, e);
                    }

                    //navigate to homepage
                    NavigationService nav = NavigationService.GetNavigationService(this);
                    nav.Navigate(new HomePage());
                }

                else
                {
                    //הודעה למשתמש
                }   
            }
        }
    }
}
