using Avalonia.Interactivity;
using Avalonia.Input;
using Avalonia.Controls;
using BenisStatsAvalonia.ViewModels;

namespace BenisStatsAvalonia.Views
{
    public partial class LoginView : UserControl
    {
        private string Username = "";
        private string Password = "";
        private string CaptchaSolution = "";
        private string CaptchaToken = "";

        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewViewModel();
        }
        private void KeyHandler(object sender, RoutedEventArgs e)
        {
            var source = e.Source as Control;
            switch (source.Name)
            {
                case "captchaInput":
                {
                    var key = (KeyEventArgs) e;
                    if (key.Key == Key.Enter) {

                        this.StartLogin();

                    }
                    break;
                }
                case "loginButton":
                {
                    this.StartLogin();
                    break;
                }
                default:
                    break;
            }
            e.Handled = true;
        }

        private void StartLogin()
        {
            /*

            if (this.usernameInput.Text != "" && this.passwordInput.Password != "" && this.captchaInput.Text != "")
            {
                this.username = this.usernameInput.Text;
                this.password = this.passwordInput.Password;
                this.captchaSolution = this.captchaInput.Text;

                this.PerformLogin();

                //BenisWindow display = new BenisWindow(this.username, this.password, this.captchaSolution, this.captchaToken);
                //display.Show();
            }
            else
            {

                //string errorTitle = "Incomplete input";
                //string errorMessage = "Please fill out all respective fields!";
                //MessageBoxButton okButton = MessageBoxButton.OK;
                //MessageBoxImage mark = MessageBoxImage.Exclamation;
                //MessageBox.Show(errorMessage, errorTitle, okButton, mark);

            }

            */

        }
    }
}