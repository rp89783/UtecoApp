using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UtecoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPagina : ContentPage
    {
        public PrincipalPagina()
        {
            InitializeComponent();
        }

        private void btnApps_Clicked(object sender, EventArgs e)
        {

        }
    }
}