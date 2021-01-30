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

namespace StaffApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            var login = TextBoxLogin.Text.Trim();
            var password = TextBoxPass.Password.Trim();

            if (login == "admin" && password == "admin")
            {
                var tableWindow = new TableWindow();
                tableWindow.Show();
                base.Close();
               
            }
            else
            {
                TextBoxLogin.BorderBrush = Brushes.Red;
                TextBoxPass.BorderBrush = Brushes.Red;
                MessageBox.Show("Invalid login or password!");
            }

            
        }
    }
}
