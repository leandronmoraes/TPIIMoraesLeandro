using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace capaDatos
{
    public class CD_Producto
    {
        private ProyectoTPII_MoraesLeandroEntities dbContext;

        public CD_Producto()
        {
            dbContext = new ProyectoTPII_MoraesLeandroEntities();
        }

        public List<producto> ObtenerProductos()
        {
            var productos = dbContext.producto
                .Where(p => p.estado == 1)
                .ToList();

            return productos;
        }

        //public List<producto> ObtenerProductos()
        //{
        //    using (ProyectoTPII_MoraesLeandroEntities dbContext = new ProyectoTPII_MoraesLeandroEntities())
        //    {
        //        var productos = dbContext.producto
        //            .Include(p => p.categoria)
        //            .Include(p => p.proveedor)
        //            .ToList();

        //        // Forzar la carga de propiedades de navegación antes de cerrar el contexto
        //        foreach (var producto in productos)
        //        {
        //            // Acceder a las propiedades de navegación para forzar la carga
        //            var categoria = producto.categoria;
        //            var proveedor = producto.proveedor;
        //        }

        //        return productos;
        //    }
        //}





        public void AgregarProducto(producto nuevoProducto)
        {
            // Verificar si ya existe un producto con el mismo nombre
            var productoExistente = dbContext.producto.FirstOrDefault(p => p.nombre_producto == nuevoProducto.nombre_producto && p.estado == 1);

            if (productoExistente == null)
            {
                // El producto no existe, se puede agregar
                dbContext.producto.Add(nuevoProducto);
                dbContext.SaveChanges();
            }
            else
            {
                // El producto ya existe, maneja el caso en consecuencia (puedes lanzar una excepción, retornar un mensaje, etc.)
                throw new Exception("Ya existe un producto con el mismo nombre.");
            }
        }

        public void ModificarProducto(producto productoModificado)
        {
            try
            {
                using (var newContext = new ProyectoTPII_MoraesLeandroEntities())
                {
                    var existingProduct = newContext.producto.FirstOrDefault(p => p.id_producto == productoModificado.id_producto);
                    if (existingProduct != null)
                    {
                        productoModificado.estado = 1; // Asegúrate de asignar un valor a la propiedad estado
                        newContext.Entry(existingProduct).State = EntityState.Detached; // Desconectar la entidad existente
                        newContext.Entry(productoModificado).State = EntityState.Modified;
                        newContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                throw new Exception("Error al modificar el producto: " + ex.Message, ex);
            }
        }

      
        //Método para dar de baja al producto.
        public void DarDeBajaProducto(int productoId)
        {
            var productoADarDeBaja = dbContext.producto.FirstOrDefault(p => p.id_producto == productoId);
            if (productoADarDeBaja != null)
            {
                productoADarDeBaja.estado = 0; // Cambia el estado del producto a inactivo
                dbContext.SaveChanges();
            }
        }

        //public List<producto> ObtenerProductosInactivos()
        //{
        //    var productosInactivos = dbContext.producto
        //        .Where(p => p.estado == 0 || p.stock_producto == 0)
        //        .ToList();

        //    return productosInactivos;

        //}

        //VER
        public List<producto> ObtenerProductosInactivos()
        {
            var productosInactivos = dbContext.producto
                .Where(p => p.estado == 0)
                .ToList();

            foreach (var producto in productosInactivos)
            {
                if (producto.stock_producto == 0)
                {
                    producto.estado = 0;
                    // Puedes guardar los cambios en la base de datos si es necesario
                    dbContext.SaveChanges();
                }
            }

            return productosInactivos;
        }





        public void CambiarEstadoProducto(int productoId, int nuevoEstado)
        {
            var producto = dbContext.producto.FirstOrDefault(p => p.id_producto == productoId);

            if (producto != null)
            {
                producto.estado = nuevoEstado;
                dbContext.SaveChanges();
            }
        }

    }
}

