using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppCocacolaNayMobiV2.ViewModels.Inventarios;

namespace AppCocacolaNayMobiV2.Views.Inventarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FicViCpConteoInventarioItem : ContentPage
    {
        private object FicLoParameter { get; set; }

        public FicViCpConteoInventarioItem(object ficPaParameter)
        {
            InitializeComponent();

            FicLoParameter = ficPaParameter;

            BindingContext = App.FicMetLocator.FicVmConteoInventarioItem;

        }

        protected override void OnAppearing()
        {
            //FIC: Aqui se declara una variable de tipo ViewModel Item
            var FicViewModel = BindingContext as FicVmConteoInventarioItem;
            if (FicViewModel != null) FicViewModel.OnAppearing(FicLoParameter);
        }

        protected override void OnDisappearing()
        {
            var FicViewModel = BindingContext as FicVmConteoInventarioItem;
            if (FicViewModel != null) FicViewModel.OnDisappearing();
        }
    }
}