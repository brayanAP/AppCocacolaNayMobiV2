using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//--
using AppCocacolaNayMobiV2.ViewModels.Inventarios;
using AppCocacolaNayMobiV2.Services;
using AppCocacolaNayMobiV2.Models.Inventarios;
using System.Collections.Generic;
using AppCocacolaNayMobiV2.Services.Inventarios;

namespace AppCocacolaNayMobiV2.Views.Inventarios
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FicViCpConteoInventarioList : ContentPage
    {
        private object FicParameter { get; set; }

        public FicViCpConteoInventarioList(object ficPaParameter)
        {
            InitializeComponent();

            FicParameter = ficPaParameter;
            //FIC: se manda llamar el metodo FicVmConteoinventario del Locator
            BindingContext = App.FicMetLocator.FicVmConteoInventarioList;
        }

        

        protected override async void OnAppearing()
        {
           var viewModel = BindingContext as FicVmConteoInventarioList;
            if (viewModel != null) viewModel.OnAppearing(FicParameter);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as FicVmConteoInventarioList;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}