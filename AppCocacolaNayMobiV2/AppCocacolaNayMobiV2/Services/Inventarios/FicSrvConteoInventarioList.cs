﻿using AppCocacolaNayMobiV2.Helpers;
using AppCocacolaNayMobiV2.Interfaces.Inventarios;
using AppCocacolaNayMobiV2.Interfaces.SQLite;
using AppCocacolaNayMobiV2.Models.Inventarios;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCocacolaNayMobiV2.Services.Inventarios
{
    public class FicSrvConteoInventarioList : IFicSrvConteoInventario
    {
        private static readonly FicAsyncLock ficMutex = new FicAsyncLock();
        private SQLiteAsyncConnection ficSQLiteConnection;

        //FIC: Constructor
        public FicSrvConteoInventarioList()
        {
            var ficDataBasePath = DependencyService.Get<IFicConfigSQLiteNETStd>().FicGetDatabasePath();
            //var ficDataBasePath = "Data Source" = " + Server.MapPath(~/data/dbSQLite/";
            //SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + Server.MapPath("~/db/test_database2.db") + ";Version=3;New=True;Compress=True;");
            ficSQLiteConnection = new SQLiteAsyncConnection(ficDataBasePath);
            //FIC: Se manda llamar funcion local para verificar
            //si no existen las tablas crearlas de forma local en el dispositivo
            FicLoMetCreateDataBaseAsync();
        }

        //FIC: Metodo para crear las tablas si no existen localmente en el dispositivo
        public async void FicLoMetCreateDataBaseAsync()
        {
            //var config = DependencyService.Get<IConfigSqlite>();
            //ficSQLiteConnection = new SQLiteConnection(config.Plataforma, config.DirectorioDB);
            //ficSQLiteConnection.CreateTable<zt_cat_cedis>();
            //ficSQLiteConnection.CreateTable<zt_cat_almacenes>();
            //ficSQLiteConnection.CreateTable<zt_cat_unidad_medidas>();
            //ficSQLiteConnection.CreateTable<zt_cat_productos>();
            //ficSQLiteConnection.CreateTable<zt_inventarios>();
            //ficSQLiteConnection.CreateTable<zt_inventarios_det>();
            //ficSQLiteConnection.CreateTable<zt_inventarios_conteos>();

            using (await ficMutex.LockAsync().ConfigureAwait(false))
            {
                await ficSQLiteConnection.CreateTableAsync<zt_cat_cedis>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_cat_almacenes>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_cat_unidad_medidas>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_cat_productos>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_inventarios>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_inventarios_det>(CreateFlags.None).ConfigureAwait(false);
                await ficSQLiteConnection.CreateTableAsync<zt_inventarios_conteos>(CreateFlags.None).ConfigureAwait(false);
            }
        }

        #region zt_inventarios
        //FIC: esta funcion se agrega y se desarrolla aqui porque esta definida en interfaces
        public async Task<IList<zt_inventarios>> FicMetGetListInventarios()
        {
            //string ficStrFecha = ficPaFecha.Date.ToString("dd/MM/yyyy");
            //return ficSQLiteConexion.Table<zt_inventarios>().Where(x => x.IdCEDI == ficPaIdCedi && x.FechaReg == ficStrFecha).ToList();
            //return ficSQLiteConnection.Table<zt_inventarios>().ToListAsync();

            var items = new List<zt_inventarios>();
            using (await ficMutex.LockAsync().ConfigureAwait(false))
            {
                items = await ficSQLiteConnection.Table<zt_inventarios>().ToListAsync().ConfigureAwait(false);
            }

            return items;
        }


        //FIC: Insertar el Inventario en la tabla.
        public async Task FicMetInsertNewInventario(zt_inventarios FicPaZt_inventarios_Item)
        {
            //ficSQLiteConexion.Insert(ficPaZtInventarios);
            using (await ficMutex.LockAsync().ConfigureAwait(false))
            {
                var FicExistingInventarioItem = await ficSQLiteConnection.Table<zt_inventarios>()
                        .Where(x => x.Id == FicPaZt_inventarios_Item.Id)
                        .FirstOrDefaultAsync();

                if (FicExistingInventarioItem == null)
                {
                    await ficSQLiteConnection.InsertAsync(FicPaZt_inventarios_Item).ConfigureAwait(false);
                }
                else
                {
                    FicPaZt_inventarios_Item.Id = FicExistingInventarioItem.Id;
                    await ficSQLiteConnection.UpdateAsync(FicPaZt_inventarios_Item).ConfigureAwait(false);
                }
            }
        }


        public async Task FicMetRemoveInventario(zt_inventarios FicPaZt_inventarios_Item)
        {
            await ficSQLiteConnection.DeleteAsync(FicPaZt_inventarios_Item);
        }

        //FIC: Obtener por Link, el registro maximo del inventario.
        //public Task<List<zt_inventarios>> ficFcnGetListInventarioActual(string ficPaIdCedi, DateTime ficPaFecha)
        //{
        //    string ficStrFecha = ficPaFecha.Date.ToString("dd/MM/yyyy");

        //    //return ficSQLiteConexion.Table<zt_inventarios>().Where(x => x.IdCEDI == ficPaIdCedi && x.FechaReg == ficStrFecha).ToList();

        //    return ficSQLiteConnection.Table<zt_inventarios>().Where(x => x.IdCEDI == ficPaIdCedi).ToListAsync();
        //}

        #endregion

    }
}
