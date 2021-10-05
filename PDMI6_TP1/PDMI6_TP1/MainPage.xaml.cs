using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDMI6_TP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OkClick(object sender, EventArgs e)
        {
            string idValue = id.Text;
            string passValue = pass.Text;
            if (idValue == "admin" && passValue == "senha@dmin")
            {
                await DisplayAlert("Login", "Logado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Login", "Login não autorizado", "OK");
            }
        }

        private void LimparClick(object sender, EventArgs e)
        {
            id.Text = "";
            pass.Text = "";

            id.Focus();
        }

        private async void CreditosClick(object sender, EventArgs args)
        {
            await DisplayAlert("Autores", "Alexia Ribeiro Marques CB3002314\nCaio Costa Cordeiro CB3001474", "OK");
        }
    }
}
