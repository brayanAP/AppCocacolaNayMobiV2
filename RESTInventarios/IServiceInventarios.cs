using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTInventarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceInventarios" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceInventarios
    {

        #region CRUD TABLA: ZT_INVENTARIOS
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallinv", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_INVENTARIOS> findAllInv();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findinv/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_INVENTARIOS findInv(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createinv",  ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createInv(List<ZT_INVENTARIOS> inventario);

        

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editinv", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editInv(ZT_INVENTARIOS inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteinv", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteInv(ZT_INVENTARIOS inventario);
        #endregion  

        #region CRUD TABLA: ZT_CAT_ALMACENES
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallalm", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_CAT_ALMACENES> findAllAlm();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findalm/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_CAT_ALMACENES findAlm(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createalm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createAlm(List<ZT_CAT_ALMACENES> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editalm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editAlm(ZT_CAT_ALMACENES inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deletealm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteAlm(ZT_CAT_ALMACENES inventario);
        #endregion  

        #region CRUD TABLA: ZT_CAT_CEDIS
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallced", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_CAT_CEDIS> findAllCed();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findced/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_CAT_CEDIS findCed(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createced", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createCed(List<ZT_CAT_CEDIS> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editced", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editCed(ZT_CAT_CEDIS inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteced", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteCed(ZT_CAT_CEDIS inventario);
        #endregion  

        #region CRUD TABLA: ZT_CAT_PRODUCTOS
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallpod", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_CAT_PRODUCTOS> findAllPod();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findpod/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_CAT_PRODUCTOS findPod(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createpod", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createPod(List<ZT_CAT_PRODUCTOS> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editpod", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editPod(ZT_CAT_PRODUCTOS inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deletepod", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deletePod(ZT_CAT_PRODUCTOS inventario);
        #endregion  

        #region CRUD TABLA: ZT_CAT_UNIDAD_MEDIDAS
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallunm", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_CAT_UNIDAD_MEDIDAS> findAllUnm();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findunm/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_CAT_UNIDAD_MEDIDAS findUnm(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createunm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createUnm(List<ZT_CAT_UNIDAD_MEDIDAS> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editunm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editUnm(ZT_CAT_UNIDAD_MEDIDAS inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteunm", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteUnm(ZT_CAT_UNIDAD_MEDIDAS inventario);
        #endregion  

        #region CRUD TABLA: ZT_INVENTARIOS_CONTEOS
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallinc", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_INVENTARIOS_CONTEOS> findAllInC();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findinc/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_INVENTARIOS_CONTEOS findInC(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createinc", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createInC(List<ZT_INVENTARIOS_CONTEOS> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editinc", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editInC(ZT_INVENTARIOS_CONTEOS inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteinc", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteInC(ZT_INVENTARIOS_CONTEOS inventario);
        #endregion  

        #region CRUD TABLA: ZT_INVENTARIOS_DET
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findallind", ResponseFormat = WebMessageFormat.Json)]
        List<ZT_INVENTARIOS_DET> findAllInD();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findind/{id}", ResponseFormat = WebMessageFormat.Json)]
        ZT_INVENTARIOS_DET findInD(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "createind", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool createInD(List<ZT_INVENTARIOS_DET> inventario);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "editind", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool editInD(ZT_INVENTARIOS_DET inventario);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteind", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool deleteInD(ZT_INVENTARIOS_DET inventario);
        #endregion  

    }//IServiceInventarios
}//RESTWSINVENTARIOS
