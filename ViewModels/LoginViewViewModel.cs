using ReactiveUI;
using OpenPr0gramm;
using Avalonia.Media.Imaging;
using RestSharp;
using System.Text.Json;

namespace BenisStatsAvalonia.ViewModels
{
    class LoginViewViewModel : ViewModelBase
    {
        Bitmap captchaContent;

        public Bitmap CaptchaContent
        {
            get => captchaContent;
            private set => this.RaiseAndSetIfChanged(ref captchaContent, value);
        }

        public void PerformLogin(string Username, string Password, string CaptchaSolution, string CaptchaToken)
        {
            var Client = new Pr0grammClient();
            var LoginRes = Client.User.LogIn(Username, Password);
            
        }

        public LoginViewViewModel()
        {
            
        }
    }
}