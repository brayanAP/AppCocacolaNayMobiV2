using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTInventarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceInventarios" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceInventarios.svc o ServiceInventarios.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceInventarios : IServiceInventarios
    {
        #region CREATE TABLAS
        
        public bool createAlm(List<ZT_CAT_ALMACENES> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                bool existsAlm = false;
                var lista = findAllAlm();

                for (int i = 0; i < inventario.Count; i++)
                {
                    
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].IdAlmacen == inventario[i].IdAlmacen)
                        {
                            existsAlm = true;
                        }
                    }

                    if (!(existsAlm))
                    {
                        try
                        {
                            ZT_CAT_ALMACENES inv = new ZT_CAT_ALMACENES
                            {
                                Id = inventario[i].Id,
                                IdCEDI = inventario[i].IdCEDI,
                                IdAlmacen = inventario[i].IdAlmacen,
                                Almacen = inventario[i].Almacen,
                                FechaReg = inventario[i].FechaReg,
                                UsuarioReg = inventario[i].UsuarioReg,
                                FechaUltMod = inventario[i].FechaUltMod,
                                UsuarioMod = inventario[i].UsuarioMod,
                                Activo = inventario[i].Activo,
                                Borrado = inventario[i].Borrado
                            };
                            dbe.ZT_CAT_ALMACENES.Add(inv);
                            dbe.SaveChanges();
                            
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        existsAlm = false;
                    }
                }
                return true;

            };
        }//GUARDAR ALMACEN

        public bool createCed(List<ZT_CAT_CEDIS> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                bool existsCed = false;
                var lista = findAllCed();

                for (int i = 0; i < inventario.Count; i++)
                {
                        for (int dx = 0; dx < lista.Count; dx++)
                        {
                            if (lista[dx].IdCEDI == inventario[i].IdCEDI)
                            {
                                existsCed = true;
                            }
                        }

                        if (!(existsCed))
                        {
                            try
                            {
                                ZT_CAT_CEDIS inv = new ZT_CAT_CEDIS
                                {
                                    Id = inventario[i].Id,
                                    IdCEDI = inventario[i].IdCEDI,
                                    CEDI = inventario[i].CEDI,
                                    FechaReg = inventario[i].FechaReg,
                                    UsuarioReg = inventario[i].UsuarioReg,
                                    FechaUltMod = inventario[i].FechaUltMod,
                                    UsuarioMod = inventario[i].UsuarioMod,
                                    Activo = inventario[i].Activo,
                                    Borrado = inventario[i].Borrado
                                };
                                dbe.ZT_CAT_CEDIS.Add(inv);
                                dbe.SaveChanges();
                               

                            }
                            catch
                            {

                            }
                    }
                    else
                    {
                        existsCed = false;
                    }
                }
                return true;
            };
        }//GUARDAR CEDIS

        public bool createInC(List<ZT_INVENTARIOS_CONTEOS> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                bool existsInC = false;
                var lista = findAllInC();

                for (int i = 0; i < inventario.Count; i++)
                {
                    
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].IdConteo == inventario[i].IdConteo)
                        {
                            existsInC = true;
                        }
                    }

                    if (!(existsInC))
                    {
                        try
                        {
                            ZT_INVENTARIOS_CONTEOS inv = new ZT_INVENTARIOS_CONTEOS
                            {
                                Id = inventario[i].Id,
                                IdInventario = inventario[i].IdInventario,
                                SKU = inventario[i].SKU,
                                IdConteo = inventario[i].IdConteo,
                                IdUbicacion = inventario[i].IdUbicacion,
                                IdCEDI = inventario[i].IdCEDI,
                                IdAlmacen = inventario[i].IdAlmacen,
                                Almacen = inventario[i].Almacen,
                                Lote = inventario[i].Lote,
                                CodBarras = inventario[i].CodBarras,
                                Material = inventario[i].Material,
                                CantFisica = inventario[i].CantFisica,
                                IdUMedida = inventario[i].IdUMedida,
                                CantidadPZA = inventario[i].CantidadPZA,
                                FechaReg = inventario[i].FechaReg,
                                HoraReg = inventario[i].HoraReg,
                                FechaUltMod = inventario[i].FechaUltMod,
                                HoraUltMod = inventario[i].HoraUltMod,
                                UsuarioReg = inventario[i].UsuarioReg
                            };
                            dbe.ZT_INVENTARIOS_CONTEOS.Add(inv);
                            dbe.SaveChanges();


                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        existsInC = false;
                    }
                }
                return true;
            };
        }//GUARDAR CONTEOS

        public bool createInD(List<ZT_INVENTARIOS_DET> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var lista = findAllInD();
                bool existsInD = false;

                for (int i = 0; i < inventario.Count; i++)
                {
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].SKU == inventario[i].SKU)
                        {
                            return true;
                        }
                    }

                    if (!(existsInD))
                    {

                        try
                        {
                            ZT_INVENTARIOS_DET inv = new ZT_INVENTARIOS_DET
                            {
                                Id = inventario[i].Id,
                                IdInventario = inventario[i].IdInventario,
                                SKU = inventario[i].SKU,
                                Material = inventario[i].Material,
                                CantTeorica = inventario[i].CantTeorica,
                                CantFisica = inventario[i].CantFisica,
                                Diferencia = inventario[i].Diferencia,
                                UMedida = inventario[i].UMedida,
                                FechaReg = inventario[i].FechaReg,
                                UsuarioReg = inventario[i].UsuarioReg,
                                FechaUltMod = inventario[i].FechaUltMod,
                                UsuarioMod = inventario[i].UsuarioMod,
                                Activo = inventario[i].Activo,
                                Borrado = inventario[i].Borrado
                            };
                            dbe.ZT_INVENTARIOS_DET.Add(inv);
                            dbe.SaveChanges();
                            

                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        existsInD = false;
                    }
                }
                return true;
            };
        }//GUARDAR DETALLES DE INVENTARIOS

        public bool createInv(List<ZT_INVENTARIOS> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var lista = findAllInv();
                bool existsInv = false;

                for (int i = 0; i < inventario.Count; i++)
                {
                    
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].IdInventario == inventario[i].IdInventario)
                        {
                            existsInv = true;
                        }
                    }

                    if (!(existsInv))
                    {
                        try
                        {
                            ZT_INVENTARIOS inv = new ZT_INVENTARIOS
                            {
                                Id = inventario[i].Id,
                                IdInventario = inventario[i].IdInventario,
                                IdCEDI = inventario[i].IdCEDI,
                                FechaReg = inventario[i].FechaReg,
                                Hora = inventario[i].Hora,
                                UsuarioReg = inventario[i].UsuarioReg,
                                FechaUltMod = inventario[i].FechaUltMod,
                                UsuarioMod = inventario[i].UsuarioMod,
                                Activo = inventario[i].Activo,
                                Borrado = inventario[i].Borrado
                            };
                            dbe.ZT_INVENTARIOS.Add(inv);
                            dbe.SaveChanges();
                            

                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        existsInv = false;
                    }
                   
                }
                return true;

            };
        }//CREAR UN NUEVO INVENTARIO

        public bool createPod(List<ZT_CAT_PRODUCTOS> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var lista = findAllPod();
                bool existsPod = false;

                for (int i = 0; i < inventario.Count; i++)
                {
                    
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].SKU == inventario[i].SKU)
                        {
                            existsPod = true;
                        }
                    }

                    if (!(existsPod))
                    {
                        try
                        {
                            ZT_CAT_PRODUCTOS inv = new ZT_CAT_PRODUCTOS
                            {
                                Id = inventario[i].Id,
                                SKU = inventario[i].SKU,
                                CodigoBarras = inventario[i].CodigoBarras,
                                Material = inventario[i].Material,
                                FechaReg = inventario[i].FechaReg,
                                UsuarioReg = inventario[i].UsuarioReg,
                                FechaUltMod = inventario[i].FechaUltMod,
                                UsuarioMod = inventario[i].UsuarioMod,
                                Activo = inventario[i].Activo,
                                Borrado = inventario[i].Borrado
                            };
                            dbe.ZT_CAT_PRODUCTOS.Add(inv);
                            dbe.SaveChanges();
                           
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        existsPod = false;
                    }
                }
                return true;
            };
        }//GUARDAR PRODUCTOS

        public bool createUnm(List<ZT_CAT_UNIDAD_MEDIDAS> inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var lista = findAllUnm();
                bool existsUnm = false;

                for (int i = 0; i < inventario.Count; i++)
                { 
                    for (int dx = 0; dx < lista.Count; dx++)
                    {
                        if (lista[dx].IdUMedida == inventario[i].IdUMedida)
                        {
                            existsUnm = true;
                        }
                    }

                    if (!(existsUnm))
                    {
                        try
                        {
                            ZT_CAT_UNIDAD_MEDIDAS inv = new ZT_CAT_UNIDAD_MEDIDAS();
                            inv.Id = inventario[i].Id;
                            inv.IdUMedida = inventario[i].IdUMedida;
                            inv.UMedida = inventario[i].UMedida;
                            inv.CantidadPZA = inventario[i].CantidadPZA;
                            inv.FechaReg = inventario[i].FechaReg;
                            inv.UsuarioReg = inventario[i].UsuarioReg;
                            inv.FechaUltMod = inventario[i].FechaUltMod;
                            inv.UsuarioMod = inventario[i].UsuarioMod;
                            inv.Activo = inventario[i].Activo;
                            inv.Borrado = inventario[i].Borrado;
                            dbe.ZT_CAT_UNIDAD_MEDIDAS.Add(inv);
                            dbe.SaveChanges();
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        existsUnm = false;
                    }
                }
                return true;
            };
        }//GUARDAR UNIDADES DE MEDIDA
        #endregion

        #region DELETE TABLAS
        public bool deleteAlm(ZT_CAT_ALMACENES inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_ALMACENES inv = dbe.ZT_CAT_ALMACENES.Single(i => i.IdAlmacen == inventario.IdAlmacen);
                    dbe.ZT_CAT_ALMACENES.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR ALMACEN

        public bool deleteCed(ZT_CAT_CEDIS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_CEDIS inv = dbe.ZT_CAT_CEDIS.Single(i => i.IdCEDI == inventario.IdCEDI);
                    dbe.ZT_CAT_CEDIS.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR CEDIS

        public bool deleteInC(ZT_INVENTARIOS_CONTEOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS_CONTEOS inv = dbe.ZT_INVENTARIOS_CONTEOS.Single(i => i.IdConteo == inventario.IdConteo);
                    dbe.ZT_INVENTARIOS_CONTEOS.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR CONTEOS

        public bool deleteInD(ZT_INVENTARIOS_DET inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS_DET inv = dbe.ZT_INVENTARIOS_DET.Single(i => i.Id == inventario.Id);
                    dbe.ZT_INVENTARIOS_DET.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR DETALLES

        public bool deleteInv(ZT_INVENTARIOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS inv = dbe.ZT_INVENTARIOS.Single(i => i.IdInventario == inventario.IdInventario);
                    dbe.ZT_INVENTARIOS.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR UN INVENTARIO

        public bool deletePod(ZT_CAT_PRODUCTOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_PRODUCTOS inv = dbe.ZT_CAT_PRODUCTOS.Single(i => i.Id == inventario.Id);
                    dbe.ZT_CAT_PRODUCTOS.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR PRODUCTOS

        public bool deleteUnm(ZT_CAT_UNIDAD_MEDIDAS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_UNIDAD_MEDIDAS inv = dbe.ZT_CAT_UNIDAD_MEDIDAS.Single(i => i.IdUMedida == inventario.IdUMedida);
                    dbe.ZT_CAT_UNIDAD_MEDIDAS.Remove(inv);
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//ELIMINAR UNIDADES DE MEDIDA
        #endregion

        #region UPDATE TABLAS
        public bool editAlm(ZT_CAT_ALMACENES inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_ALMACENES inv = dbe.ZT_CAT_ALMACENES.Single(i => i.IdAlmacen == inventario.IdAlmacen);
                    inv.Id = inventario.Id;
                    inv.IdCEDI = inventario.IdCEDI;
                    inv.IdAlmacen = inventario.IdAlmacen;
                    inv.Almacen = inventario.Almacen;
                    inv.FechaReg = inventario.FechaReg;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR ALMACEN

        public bool editCed(ZT_CAT_CEDIS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_CEDIS inv = dbe.ZT_CAT_CEDIS.Single(i => i.IdCEDI == inventario.IdCEDI);
                    inv.Id = inventario.Id;
                    inv.IdCEDI = inventario.IdCEDI;
                    inv.CEDI = inventario.CEDI;
                    inv.FechaReg = inventario.FechaReg;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR CEDIS

        public bool editInC(ZT_INVENTARIOS_CONTEOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS_CONTEOS inv = dbe.ZT_INVENTARIOS_CONTEOS.Single(i => i.IdConteo == inventario.IdConteo);
                    inv.Id = inventario.Id;
                    inv.IdInventario = inventario.IdInventario;
                    inv.SKU = inventario.SKU;
                    inv.IdConteo = inventario.IdConteo;
                    inv.IdUbicacion = inventario.IdUbicacion;
                    inv.IdCEDI = inventario.IdCEDI;
                    inv.IdAlmacen = inventario.IdAlmacen;
                    inv.Almacen = inventario.Almacen;
                    inv.Lote = inventario.Lote;
                    inv.CodBarras = inventario.CodBarras;
                    inv.Material = inventario.Material;
                    inv.CantFisica = inventario.CantFisica;
                    inv.IdUMedida = inventario.IdUMedida;
                    inv.CantidadPZA = inventario.CantidadPZA;
                    inv.FechaReg = inventario.FechaReg;
                    inv.HoraReg = inventario.HoraReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.HoraUltMod = inventario.HoraUltMod;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR CONTEOS

        public bool editInD(ZT_INVENTARIOS_DET inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS_DET inv = dbe.ZT_INVENTARIOS_DET.Single(i => i.Id == inventario.Id);
                    inv.Id = inventario.Id;
                    inv.IdInventario = inventario.IdInventario;
                    inv.SKU = inventario.SKU;
                    inv.Material = inventario.Material;
                    inv.CantTeorica = inventario.CantTeorica;
                    inv.CantFisica = inventario.CantFisica;
                    inv.Diferencia = inventario.Diferencia;
                    inv.UMedida = inventario.UMedida;
                    inv.FechaReg = inventario.FechaReg;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR DETALLES

        public bool editInv(ZT_INVENTARIOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_INVENTARIOS inv = dbe.ZT_INVENTARIOS.Single(i => i.IdInventario == inventario.IdInventario);
                    inv.Id = inventario.Id;
                    inv.IdInventario = inventario.IdInventario;
                    inv.IdCEDI = inventario.IdCEDI;
                    inv.FechaReg = inventario.FechaReg;
                    inv.Hora = inventario.Hora;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR UN INVENTARIO

        public bool editPod(ZT_CAT_PRODUCTOS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_PRODUCTOS inv = dbe.ZT_CAT_PRODUCTOS.Single(i => i.Id == inventario.Id);
                    inv.Id = inventario.Id;
                    inv.SKU = inventario.SKU;
                    inv.CodigoBarras = inventario.CodigoBarras;
                    inv.Material = inventario.Material;
                    inv.FechaReg = inventario.FechaReg;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }//EDITAR PRODUCTOS

        public bool editUnm(ZT_CAT_UNIDAD_MEDIDAS inventario)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                try
                {
                    ZT_CAT_UNIDAD_MEDIDAS inv = dbe.ZT_CAT_UNIDAD_MEDIDAS.Single(i => i.IdUMedida == inventario.IdUMedida);
                    inv.Id = inventario.Id;
                    inv.IdUMedida = inventario.IdUMedida;
                    inv.UMedida = inventario.UMedida;
                    inv.CantidadPZA = inventario.CantidadPZA;
                    inv.FechaReg = inventario.FechaReg;
                    inv.UsuarioReg = inventario.UsuarioReg;
                    inv.FechaUltMod = inventario.FechaUltMod;
                    inv.UsuarioMod = inventario.UsuarioMod;
                    inv.Activo = inventario.Activo;
                    inv.Borrado = inventario.Borrado;
                    dbe.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            };
        }
        #endregion

        #region SELECT LISTA TABLAS
        public List<ZT_CAT_ALMACENES> findAllAlm()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_CAT_ALMACENES>().ToList();

            }
        }//TRAER LISTA ALMACENES

        public List<ZT_CAT_CEDIS> findAllCed()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                ZT_CAT_CEDIS CEDI = new ZT_CAT_CEDIS();
                CEDI.Id = 1;
                CEDI.IdCEDI = "1";
                CEDI.CEDI = "TEPIC";
                this.deleteCed(CEDI);
                return dbe.Set<ZT_CAT_CEDIS>().ToList();

            }
        }//TRAER LISTA CEDIS

        public List<ZT_INVENTARIOS_CONTEOS> findAllInC()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_INVENTARIOS_CONTEOS>().ToList();

            }
        }//TRAER LISTA CONTEOS

        public List<ZT_INVENTARIOS_DET> findAllInD()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_INVENTARIOS_DET>().ToList();

            }
        }//TRAER LISTA DETALLES

        public List<ZT_INVENTARIOS> findAllInv()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_INVENTARIOS>().ToList();
            }
        }//TRAER LISTA INVENTARIOS

        public List<ZT_CAT_PRODUCTOS> findAllPod()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_CAT_PRODUCTOS>().ToList();

            }
        }//TRAER LISTA PRODUCTOS

        public List<ZT_CAT_UNIDAD_MEDIDAS> findAllUnm()
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                return dbe.Set<ZT_CAT_UNIDAD_MEDIDAS>().ToList();

            }
        }//TRAER LISTA UNIDADES MEDIDA
        #endregion

        #region SELECT ID TABLAS
        public ZT_CAT_ALMACENES findAlm(string id)
        {
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                int iid = Int32.Parse(id);
                var query = (from p in dbe.ZT_CAT_ALMACENES
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER ALMACEN UNICO

        public ZT_CAT_CEDIS findCed(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_CAT_CEDIS
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER CEDI UNICO

        public ZT_INVENTARIOS_CONTEOS findInC(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_INVENTARIOS_CONTEOS
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER CONTEO UNICO

        public ZT_INVENTARIOS_DET findInD(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_INVENTARIOS_DET
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER DETALLE UNICO

        public ZT_INVENTARIOS findInv(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_INVENTARIOS
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER INVENTARIO UNICO

        public ZT_CAT_PRODUCTOS findPod(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_CAT_PRODUCTOS
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER PRODUCTO UNICO

        public ZT_CAT_UNIDAD_MEDIDAS findUnm(string id)
        {
            int iid = Int32.Parse(id);
            using (DBINVENTARIOSEntitiess dbe = new DBINVENTARIOSEntitiess())
            {
                var query = (from p in dbe.ZT_CAT_UNIDAD_MEDIDAS
                             where p.Id == iid
                             select p);
                var inventario = query.First();
                return inventario;
            }
        }//TRAER UNIDAD MEDIDA UNICA
        #endregion
    }
}
