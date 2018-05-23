using System.Collections.ObjectModel;
using System.Windows.Input;
using AppCocacolaNayMobiV2.Models.Inventarios;
using AppCocacolaNayMobiV2.Interfaces.Navigation;
using AppCocacolaNayMobiV2.Interfaces.Inventarios;
using AppCocacolaNayMobiV2.ViewModels.Base;

namespace AppCocacolaNayMobiV2.ViewModels.Inventarios
{
    public class FicVmConteoInventarioList : FicViewModelBase
    {
        private ObservableCollection<zt_inventarios> FicOcZt_inventarios_Items;
        private zt_inventarios FicZt_inventarios_SelectedItem;

        private ICommand ficAddCommand;

        private IFicSrvNavigationInventario FicLoSrvNavigationInventario;
        private IFicSrvConteoInventario FicLoSrvConteoInventario;

        //FIC: Constructor
        public FicVmConteoInventarioList(
            IFicSrvNavigationInventario ficPaSrvNavigationInventario,
            IFicSrvConteoInventario ficPaSrvConteoInventario)
        {
            //FIC: se asigna el objeto que se recibe como parametro de tipo navigation services
            FicLoSrvNavigationInventario = ficPaSrvNavigationInventario;
            //FIC: se asigna el objeto que se recibe como parametro de tipo SqlServices 
            FicLoSrvConteoInventario = ficPaSrvConteoInventario;
        }

        //FIC: Metodo para obtener la lista de registros de inventarios
        public ObservableCollection<zt_inventarios> FicMetZt_inventarios_Items
        {
            get { return FicOcZt_inventarios_Items; }
            set
            {
                FicOcZt_inventarios_Items = value;
                RaisePropertyChanged();
            }
        }

        //FIC: Metodo para tomar solo un registro de la lista de registros de inventarios
        public zt_inventarios FicMetZt_inventarios_SelectedItem
        {
            get { return FicZt_inventarios_SelectedItem; }
            set
            {
                FicZt_inventarios_SelectedItem = value;
                FicLoSrvNavigationInventario.FicMetNavigateTo<FicVmConteoInventarioItem>(FicZt_inventarios_SelectedItem);
            }
        }

        //FIC: Metodo de tipo comando para agregar un registro 
        public ICommand ficMetAddCommand
        {
            get { return ficAddCommand = ficAddCommand ?? new FicVmDelegateCommand(AddCommandExecute); }
        }

        public override async void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            //FIC: Ejecuto uno de los metodos definidos en los servicios de Interfaz de inventarios
            var result = await FicLoSrvConteoInventario.FicMetGetListInventarios();

            FicMetZt_inventarios_Items = new ObservableCollection<zt_inventarios>();
            foreach (var ficPaItem in result)
            {
                FicMetZt_inventarios_Items.Add(ficPaItem);
            }
        }

        private void AddCommandExecute()
        {
            var ficZt_inventarios = new zt_inventarios();
            //FicLoSrvNavigationInventario.FicMetNavigateTo<zt_inventarios>(ficZt_inventarios_TodoItems);
            FicLoSrvNavigationInventario.FicMetNavigateTo<FicVmConteoInventarioItem>(ficZt_inventarios);
        }
    }
}
