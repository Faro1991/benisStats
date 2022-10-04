using ReactiveUI;
using BenisStatsAvalonia.Models;
using Avalonia.Media.Imaging;
using RestSharp;
using System;
using System.IO;
using System.Text.Json;

namespace BenisStatsAvalonia.ViewModels
{
    class LoginViewViewModel : ViewModelBase
    {
        Bitmap captchaContent;
        string CaptchaToken = "";

        public Bitmap CaptchaContent
        {
            get => captchaContent;
            private set => this.RaiseAndSetIfChanged(ref captchaContent, value);
        }

        public void GetCaptcha()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            RestClient Client = new RestClient("https://pr0gramm.com/api/user/captcha");
            Client.UseJson();
            RestRequest Request = new RestRequest(Method.GET);
            Request.AddCookie("__cfduid", "df96023e9103362cce3a653b6934983ed1587455977");
            Request.RequestFormat = RestSharp.DataFormat.Json;
            IRestResponse Response = Client.Execute(Request);

            string ResponseString = Response.Content;

            Pr0Captcha ApiResponse = JsonSerializer.Deserialize<Pr0Captcha>(ResponseString, options);

            this.CaptchaToken = ApiResponse.Token;

            string CaptchaBase64 = ApiResponse.Captcha.Split(",")[1];
            byte[] Base64 = Convert.FromBase64String(CaptchaBase64);
            
            MemoryStream Base64Stream = new MemoryStream(Base64);

            Bitmap CaptchaImage = new Bitmap(Base64Stream);

            captchaContent = CaptchaImage;
            
        }

        public LoginViewViewModel()
        {
            GetCaptcha();
        }
    }
}