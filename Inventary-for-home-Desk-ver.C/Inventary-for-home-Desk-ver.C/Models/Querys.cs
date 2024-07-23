﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Inventary_for_home_Desk_ver.C.Models
{
    public class Querys
    {
        //Funcines de crear
        /// <summary>
        /// Funcion de añadir articulo
        /// </summary>
        /// <param name="_NuevoArtículo">Cadena con el nombre</param>
        /// <param name="_numstock">Cantidad</param>
        /// <param name="_TypePN">Tipo de prioridad</param>
        /// <param name="_TypeSN">Tipo de empaque</param>
        /// <param name="_PDate">Fecha de compra</param>
        /// <param name="_EDate">Fecha de expiracion</param>
        /// <returns></returns>
         //Nuevo Articulo
        public static async Task<bool> CrearNArtAsync(string _NuevoArtículo, string _numstock, string _TypePN, string _TypeSN, DateTime _PDate, DateTime _EDate)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    
                    var result = await db.Database.ExecuteSqlAsync($"EXEC OptionMenu 1, {_NuevoArtículo}, {_numstock}, {_TypePN}, {_TypeSN}, {_PDate}, {_EDate}, 1, {null}");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> CrearNStockAsync(string _NuevoStock)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    

                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoStock 1, {null}, {_NuevoStock}, 1");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> CrearNPrioridadAsync(string _NuevaPrioridad, string _DescPrio)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    
                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoPrioridad 1, {null}, {_NuevaPrioridad}, {_DescPrio}, 1");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Funciones de visualisación
        public static async Task<List<StoredProcedure1>> ObtenerTablaItemAsync()
        {
            using (var db = new InventoryForHomeContext())
            {
                var StoredProcedure1 = await db.StoredProcedure1s.FromSql($"EXEC OptionMenu 2").ToListAsync();
                return StoredProcedure1;
            }
        }

        //VERSION NO ASINCRONA
        public static  List<StoredProcedure1> ObtenerTablaItem()
        {
            using (var db = new InventoryForHomeContext())
            {
                var StoredProcedure1 =  db.StoredProcedure1s.FromSql($"EXEC OptionMenu 2").ToList();
                return StoredProcedure1;
            }
        }

        public static async Task<List<StoredProcedure3>> ObtenerTablaStockAsync()
        {
            using (var db = new InventoryForHomeContext())
            {
                var StoredProcedure3 = await db.StoredProcedure3s.FromSql($"EXEC CatalogoStock 2").ToListAsync();
                return StoredProcedure3;
            }
        }

        public static async Task<List<StoredProcedure2>> ObtenerTablaPrioridadAsync()
        {
            using (var db = new InventoryForHomeContext())
            {
                var StoredProcedure2 = await db.StoredProcedure2s.FromSql($"EXEC CatalogoPrioridad 2").ToListAsync();
                return StoredProcedure2;
            }
        }

        //Funciones de actualizar
        public static async Task<bool> ActArtAsync(string _ActName, string _numstock, string _TypePN, string _TypeSN, string _PDate, string _EDate, string _Actualizar)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    
                    var result = await db.Database.ExecuteSqlAsync($"EXEC OptionMenu 3, {_ActName}, {_numstock}, {_TypePN}, {_TypeSN}, {_PDate}, {_EDate}, 1, {_Actualizar}");
                    //await db.Items.FromSql($"EXEC OptionMenu 3, {_ActName}, {_numstock}, {_TypePN}, {_TypeSN}, {_PDate}, {_EDate}, 1, {_Actualizar}").ToListAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> ActStockAsync(string _ActIDStock, string _ActSName)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoStock 3, {_ActIDStock}, {_ActSName}, 1");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> ActPrioridadAsync(string _ActIDPrioridad, string _ActPrioName, string _ActPrioDesc)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoPrioridad 3, {_ActIDPrioridad}, {_ActPrioName}, {_ActPrioDesc}");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Funciones de eliminar
        public static async Task<bool> ElimArtAsync(string _Eliminar)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    
                    var result = await db.Database.ExecuteSqlAsync($"EXEC OptionMenu 4, {null}, {null}, {null}, {null}, {null}, {null}, {null}, {_Eliminar}");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> ElimStockAsync(string _ElimStock)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    //@CS Int = 0,
                    //@Var_Identidad Int = 0,
                    //@Var_TSName Nvarchar(MAX) = Null,
                    //@Var_Activo Bit = 0
                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoStock 4, {_ElimStock}, {null}, {null}");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static async Task<bool> ElimPrioridadAsync(string _ElimPrioridad)
        {
            try
            {
                using (var db = new InventoryForHomeContext())
                {
                    var result = await db.Database.ExecuteSqlAsync($"EXEC CatalogoPrioridad 4, {_ElimPrioridad}, {null}, {null}");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    
        ///SECCION DE QUERYS CON LINQ
        ///

        public static async Task<StoredProcedure1> obtenerItemByIdAsync(int IdItem)
        {
            using (var db = new InventoryForHomeContext())
            {
                var QryResult = await (from a in db.Items
                                       join b in db.CatTypePrioritaries
                                       on a.IdTypePrioritary equals b.IdTypePrioritary
                                       join c in db.CatTypeStocks
                                       on a.IdTypeStock equals c.IdTypeStock
                                       where a.Active == true 
                                       && a.IdItem == IdItem

                                       select new StoredProcedure1
                                       {
                                           ItemName = a.ItemName,
                                           Stock = a.Stock,
                                           TypePrioritaryName = b.TypePrioritaryName,
                                           TypeStockName = c.TypeStockName,
                                           PurchesDate = a.PurchesDate,
                                           ExpirationDate = a.ExpirationDate,
                                       }

                                       ).ToListAsync();





                return QryResult[0];
            }
        }

        public static async Task<StoredProcedure3> obtenerStockByIdAsync(int IdStock)
        {
            using (var db = new InventoryForHomeContext())
            {
                var QryStock = await (from c in db.CatTypeStocks
                                      where c.IdTypeStock == IdStock

                                      select new StoredProcedure3
                                      {
                                          IdTypeStock = c.IdTypeStock,
                                          TypeStockName = c.TypeStockName,
                                      }

                                      ).ToListAsync();



                return QryStock[0];
            }
        }

        public static async Task<StoredProcedure2> obtenerPrioByIdAsync(int IdPrio)
        {
            using (var db = new InventoryForHomeContext())
            {
                var QryPrio = await (from d in db.CatTypePrioritaries
                                     where d.IdTypePrioritary == IdPrio

                                     select new StoredProcedure2
                                     {
                                         IdTypePrioritary = d.IdTypePrioritary,
                                         TypePrioritaryName = d.TypePrioritaryName,
                                         Description = d._Description,
                                     }

                                     ).ToListAsync();



                return QryPrio[0];
            }
        }
    }
}
