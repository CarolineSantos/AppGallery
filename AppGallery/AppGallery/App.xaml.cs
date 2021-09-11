using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var pagina = new NavigationPage(
            //    new XamarimForms.Paginas.PaginaDeNavegacao.Conteudo01()
            //    );
            //MainPage = pagina;

            /* Carrosel
                //Sempre vai trazer a 1° página selecionada
                var pagina = new CarouselPage();
                pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrosel.Conteudo01());
                pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrosel.Conteudo02());
                pagina.Children.Add(new XamarimForms.Paginas.PaginaDeCarrosel.Conteudo03());
            
                //Escolher qual indice deve estar selecionado
                //pagina.CurrentPage = pagina.Children[1];
                
                //MainPage = new XamarimForms.Paginas.PaginaDeCarrosel.Carrosel();

            */


            //MainPage = new XamarimForms.Paginas.PaginaDeCarrosel.Conteudo01();

            /* Menu Lateral 
                var pagina = new MasterDetailPage();
                //Menu
                pagina.Master = ;
                //Conteudo
                pagina.Detail = ;
            */

            /*  Pagina de Abas
                MainPage = new XamarimForms.Paginas.PaginaDeAbas.Abas();
            */

            MainPage = new XamarimForms.Paginas.PaginaDeMenuLateral.MenuLateral();
            MainPage = new XamarimForms.AppBase.Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
