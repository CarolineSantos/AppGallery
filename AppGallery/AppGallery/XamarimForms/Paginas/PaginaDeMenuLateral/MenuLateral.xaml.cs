using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.PaginaDeMenuLateral
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void Pagina1_Clicked(object sender, EventArgs e)
        {
            //NavigationPage - trás a  faixa de cima que mostra o icone com 3 riscos
            Detail = new NavigationPage(new Conteudo01());

            //Desabilitar menu aspos clique
            IsPresented = false;
        }

        private void Pagina2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo02());
            IsPresented = false;
        }

        private void Pagina3_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Conteudo03());
            IsPresented = false;
        }
    }
}