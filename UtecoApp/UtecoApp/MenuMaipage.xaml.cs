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
    public partial class MenuMaipage : MasterDetailPage
    {
        public MenuMaipage()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new PrincipalPagina());
        }
    }
}