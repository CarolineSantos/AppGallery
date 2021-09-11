using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.Modal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Conteudo01 : ContentPage
    {
        public Conteudo01()
        {
            InitializeComponent();
        }

        private void PushModalAsync_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PaginaDeModal());
        }
    }
}