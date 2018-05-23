using System;
using System.Collections.Generic;
using AppCocacolaNayMobiV2.Models.Inventarios;
using System.Text;
using System.Threading.Tasks;

namespace AppCocacolaNayMobiV2.Interfaces.Inventarios
{
    public interface IFicSrvConteoInventario
    {
        Task<IList<zt_inventarios>> FicMetGetListInventarios();
        Task FicMetInsertNewInventario(zt_inventarios FicPaZt_inventarios_Item);
        Task FicMetRemoveInventario(zt_inventarios FicPaZt_inventarios_Remove);

        //Task<List<zt_inventarios>> ficMetGetListInventarioActual(string ficPaIdCedi, DateTime ficPaFecha);

        //void ficFcnInsertCEDIS(zt_cat_cedis ficPaZtCatCEDIS);
        //Task<IList<TodoItem>> GetAll();
        //Task Insert(TodoItem item);
        //Task Remove(TodoItem item);

    }
}
