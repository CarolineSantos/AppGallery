﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarimForms.Paginas.PaginaDeCarrosel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carrosel : CarouselPage
    {
        public Carrosel()
        {
            InitializeComponent();

            //Deixa selecionada na página 02
            CurrentPage = Children[1];
        }
    }
}