using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//--
using AppCocacolaNayMobiV2.ViewModels.Inventarios;

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

        protected override void OnAppearing()
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