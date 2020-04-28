using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EuladoxTSApp.View;
using EuladoxTSApp.Model;
using System.Net;
using Newtonsoft.Json;

namespace EuladoxTSApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
            LoginModel LoginResponseObject = new LoginModel();

            LoginModel LoginRequestObject = new LoginModel()
            {
                user_name = EntUserName.Text,
                user_password = EntPassword.Text,
                client_host_name = "Sujata",
                client_serial_number = "SK12345678",
                caller_type = "MOBAPPAPI",
                login_by = "Agent"
            };
            string LoginJson = Newtonsoft.Json.JsonConvert.SerializeObject(LoginRequestObject);
            try
            {       
                var result = client.fnValidateLoginCredential(LoginJson);
                LoginResponseObject = JsonConvert.DeserializeObject<LoginModel>(result);
            //    bool test = false;
            }
            catch (Exception ex)
            {
               // bool test1 = false;
            }
            // var json = JsonConvert.SerializeObject(Login);


        }
    }
}