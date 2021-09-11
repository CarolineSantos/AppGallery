using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.PaginaDeNavegacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo03 : ContentPage
    {
        public Conteudo03()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void VoltaParaAnterior_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void VoltaInicioPilha_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void InserirPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(
                new Conteudo01(),
                this    
            );
        }

        private void RemoverPagina_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage(Navigation.NavigationStack[0]);
        }

        private void PaginaInicial_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(
                new Conteudo01()
             );
        }
    }
}