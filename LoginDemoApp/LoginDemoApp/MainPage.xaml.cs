using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using LoginDemoApp.Models;
using System.Net.Http;
using System.Net;

namespace LoginDemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
       
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Login log = new Login
            {
                Email = txtMail.Text,
                Pin = txtPin.Text
            };
            //Indicamos la URL de nuestra API
            Uri RequestUri = new Uri("");
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(log);
            var contentJson = new StringContent(json,Encoding.UTF8,"application/json");
            var response = await client.PostAsync(RequestUri, contentJson);

            //Validamos el status de la petición.
            if(response.StatusCode==HttpStatusCode.OK)
            {
                await Navigation.PushAsync(new Home());
            }
            else
            {
                await DisplayAlert("Mensaje", "Datos Invalidos", "Ok");
            }
        }
    }
}
