using System.Windows.Input;
using AppCocacolaNayMobiV2.Models.Inventarios;
using AppCocacolaNayMobiV2.Interfaces.Navigation;
using AppCocacolaNayMobiV2.Interfaces.Inventarios;
using AppCocacolaNayMobiV2.ViewModels.Base;

namespace AppCocacolaNayMobiV2.ViewModels.Inventarios
{
    public class FicVmConteoInventarioItem : FicViewModelBase
    {
        //FIC: se declara el metodo para la clase modelo
        private zt_inventarios Fic_Zt_inventarios_Item;

        //FIC: se declara las variables para los e botones del frontend
        private ICommand FicSaveCommand;
        private ICommand FicDeleteCommand;
        private ICommand FicCancelCommand;

        private IFicSrvNavigationInventario FicLoSrvNavigationInventario;
        //FIC: Se declara metodo de interfaz donde se encuentran
        //todos los metodos definidos para la clase de zt_inventarios
        private IFicSrvConteoInventario FicLoSrvConteoInventario;

        //FIC: Se declara el constructor
        public FicVmConteoInventarioItem(
            IFicSrvNavigationInventario FicPaSrvNavigationInventario,
            IFicSrvConteoInventario FicPaSrvConteoInventario)
        {
            //FIC: se asigna el objeto que se recibe como parametro de tipo navigation services
            FicLoSrvNavigationInventario = FicPaSrvNavigationInventario;
            //FIC: se asigna el objeto que se recibe como parametro de tipo SqlServices 
            FicLoSrvConteoInventario = FicPaSrvConteoInventario;
        }

        //FIC: se desarrolla el metodo declarado de la clase modelo
        public zt_inventarios Item
        {
            get { return Fic_Zt_inventarios_Item; }
            set
            {
                Fic_Zt_inventarios_Item = value;
                RaisePropertyChanged();
            }
        }

        public ICommand FicMetSaveCommand
        {
            get { return FicSaveCommand = FicSaveCommand ?? new FicVmDelegateCommand(SaveCommandExecute); }
        }

        public ICommand FicMetDeleteCommand
        {
            get { return FicDeleteCommand = FicDeleteCommand ?? new FicVmDelegateCommand(DeleteCommandExecute); }
        }

        public ICommand FicMetCancelCommand
        {
            get { return FicCancelCommand = FicCancelCommand ?? new FicVmDelegateCommand(CancelCommandExecute); }
        }

        public override void OnAppearing(object FicPaNavigationContext)
        {
            var FicLoZt_inventarios = FicPaNavigationContext as zt_inventarios;

            if (FicLoZt_inventarios != null)
            {
                Item = FicLoZt_inventarios;
            }

            base.OnAppearing(FicPaNavigationContext);
        }


        private async void SaveCommandExecute()
        {
            await FicLoSrvConteoInventario.FicMetInsertNewInventario(Item);
            FicLoSrvNavigationInventario.FicMetNavigateBack();
        }

        private async void DeleteCommandExecute()
        {
            await FicLoSrvConteoInventario.FicMetRemoveInventario(Item);
            FicLoSrvNavigationInventario.FicMetNavigateBack();
        }

        private void CancelCommandExecute()
        {
            FicLoSrvNavigationInventario.FicMetNavigateBack();
        }


    }
}
