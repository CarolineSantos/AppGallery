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
    public partial class Conteudo02 : ContentPage
    {
        public Conteudo02()
        {
            InitializeComponent();
        }

        private void PopAsynsc_Clicked(object sender, EventArgs e)//Volta para página anterior
        {
            Navigation.PopAsync();
        }

        private void PushAsync_Clicked(object sender, EventArgs e)
        {
            //abrir pagina 03
            Navigation.PushAsync(new Conteudo03());
        }
    }
}