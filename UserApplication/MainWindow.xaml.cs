using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace UserApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();
            var appContext = new AppContext();
            db = appContext;
            var usersTable = db.Users.ToList();

        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            var login = TextBoxLogin.Text.Trim();
            var password = TextBoxPass.Password.Trim();
            var repPassword = TextBoxRepPass.Password.Trim();
            var email = TextBoxEmail.Text.ToLower().Trim();

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Incorrect login!";
                TextBoxLogin.Background = Brushes.IndianRed;
            }
            else if (password.Length < 5)
            {
                TextBoxPass.ToolTip = "Incorrect Password!";
                TextBoxPass.Background = Brushes.IndianRed;
            }
            else if (password != repPassword)
            {
                TextBoxRepPass.ToolTip = "Passwords dont match!";
                TextBoxRepPass.Background = Brushes.IndianRed;
            }
            else if (email.Length < 6 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Incorrect email!";
                TextBoxEmail.Background = Brushes.IndianRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPass.ToolTip = "";
                TextBoxPass.Background = Brushes.Transparent;
                TextBoxRepPass.ToolTip = "";
                TextBoxRepPass.Background = Brushes.Transparent;
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;
                User user = new User(login, email, password);

                MessageBox.Show("All right");
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
    }
}
