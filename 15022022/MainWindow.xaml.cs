using _15022022.Negocio;
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

namespace _15022022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginService login = new LoginService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextbox.Password;

            if(login.check(username, password) )
            {
                //salidaLabel.Content = "Usuario logiado";
                MessageBox.Show("Exito!!","Usuario logeado");
            }
            else
            {
                MessageBox.Show("Eroro de login", "Usuario o password incorrectos");
                //salidaLabel.Content = "Usuario o password incorrectos";
            }
        }
    }
}
