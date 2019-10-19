using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UtecoApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string user = "admin";
        string pass = "123";
        
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {if (txtUsername.Text == user && txtPass.Text == pass)
                await Navigation.PushModalAsync(new PrincipalPagina());

            else
            {
                lblError.Text = "Usuario o clave incorrecto";
            }
        }

        private void btncancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}
