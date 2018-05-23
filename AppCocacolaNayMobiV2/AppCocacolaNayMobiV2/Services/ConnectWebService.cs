using AppCocacolaNayMobiV2.Models.Inventarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppCocacolaNayMobiV2.Services
{
    public class ConnectWebService
    {
        private HttpClient _Client = new HttpClient();

        public async Task<ObservableCollection<zt_inventarios>> getWebServiceInv()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallinv";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_inventarios>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_inventarios>(post);
        }//GET WEB SERVICE zt_inventarios

        public async Task setWebServiceInv(List<zt_inventarios> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createinv";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }
        }//POST WEB SERVICE zt_inventarios

        public async Task<ObservableCollection<zt_cat_almacenes>> getWebServiceAlm()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallalm";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_cat_almacenes>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_cat_almacenes>(post);
        }//GET WEB SERVICE zt_cat_almacenes

        public async Task setWebServiceAlm(List<zt_cat_almacenes> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createalm";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_cat_almacenes

        public async Task<ObservableCollection<zt_cat_cedis>> getWebServiceCed()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallced";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_cat_cedis>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_cat_cedis>(post);
        }//GET WEB SERVICE zt_cat_cedis

        public async Task setWebServiceCed(List<zt_cat_cedis> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createced";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_cat_cedis

        public async Task<ObservableCollection<zt_cat_productos>> getWebServicePod()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallpod";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_cat_productos>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_cat_productos>(post);
        }//GET WEB SERVICE zt_cat_productos

        public async Task setWebServicePod(List<zt_cat_productos> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createpod";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_cat_productos

        public async Task<ObservableCollection<zt_cat_unidad_medidas>> getWebServiceUnm()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallunm";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_cat_unidad_medidas>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_cat_unidad_medidas>(post);
        }//GET WEB SERVICE zt_cat_unidad_medidas

        public async Task setWebServiceUnm(List<zt_cat_unidad_medidas> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createunm";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_cat_unidad_medidas

        public async Task<ObservableCollection<zt_inventarios_conteos>> getWebServiceInc()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallinc";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_inventarios_conteos>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_inventarios_conteos>(post);
        }//GET WEB SERVICE zt_inventarios_conteos

        public async Task setWebServiceInc(List<zt_inventarios_conteos> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createinc";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_inventarios_conteos

        public async Task<ObservableCollection<zt_inventarios_det>> getWebServiceInd()
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/findallind";

            /*PREGUNTA*/
            var content = await _Client.GetStringAsync(url);

            /*RESPUESTA, SE TRABAJA EL JSON DE RESPUESTA*/
            var post = JsonConvert.DeserializeObject<List<zt_inventarios_det>>(content);

            /*LO PASAMOS A UN FORMATO DE MANEJO*/
            return new ObservableCollection<zt_inventarios_det>(post);
        }//GET WEB SERVICE zt_inventarios_det

        public async Task setWebServiceInd(List<zt_inventarios_det> item, bool isNewItem = false)
        {
            /*URL A USAR*/
            const string url = "http://localhost:57821/ServiceInventarios.svc/createind";
            var uri = new Uri(string.Format(url, string.Empty));

            /*CREAMOS EN JSON*/
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            /*ENVIAMOS EL JSON*/
            HttpResponseMessage response = null;
            if (isNewItem)
            {
                response = await _Client.PostAsync(uri, content);
            }

            /*RECIBIMOS LA RESPUESTA*/
            if (response.IsSuccessStatusCode)
            {


            }

        }//POST WEB SERVICE zt_inventarios_det
    }
}
