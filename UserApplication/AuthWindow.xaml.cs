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
using System.Windows.Shapes;

namespace UserApplication
{
    /// <summary>
    /// Interaction logic for AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            var login = TextBoxLogin.Text.Trim();
            var password = TextBoxPass.Password.Trim();

            if (login != "admin")
            {
                TextBoxLogin.ToolTip = "Incorrect login!";
            }
            else if (password != "admin")
            {
                TextBoxPass.ToolTip = "Incorrect Password!";
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPass.ToolTip = "";
                TextBoxPass.Background = Brushes.Transparent;
                

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.FirstOrDefault(b => b.Login == login && b.Pass == password);
                }

                MessageBox.Show(authUser != null ? "All right" : "Something Wrong");
            }
        }
    }
}
