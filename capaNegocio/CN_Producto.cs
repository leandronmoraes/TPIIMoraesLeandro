using capaDatos.Models;
using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace capaNegocio
{
    public class CN_Producto
    {
        private CD_Producto cdProducto;

        public CN_Producto()
        {
            cdProducto = new CD_Producto();
        }

        public List<producto> ObtenerProductos()
        {
            return cdProducto.ObtenerProductos();
        }

        public void AgregarProducto(producto nuevoProducto, string categoria, string proveedor)
        {
            // Realiza validaciones y lógica de negocio antes de agregar el producto
            if (!string.IsNullOrEmpty(nuevoProducto.nombre_producto) && !string.IsNullOrEmpty(categoria) &&
            nuevoProducto.stock_producto > 0 && nuevoProducto.precio_producto > 0)
            {
                // Establece el estado en 1
                nuevoProducto.estado = 1;

                // Obtén el ID de la categoría
                int idCategoria = ObtenerIdCategoriaPorNombre(categoria);
                if (idCategoria != -1)
                {
                    nuevoProducto.id_categoria = idCategoria;

                    // Obtén el ID del proveedor
                    int idProveedor = ObtenerIdProveedorPorNombre(proveedor);
                    if (idProveedor != -1)
                    {
                        nuevoProducto.id_proveedor = idProveedor;

                        // Realiza la operación de agregar el producto
                        cdProducto.AgregarProducto(nuevoProducto);
                    }
                    else
                    {
                        // Maneja el caso en que no se encuentre el proveedor
                        throw new Exception("Proveedor no encontrado.");
                    }
                }
                else
                {
                    // Maneja el caso en que no se encuentre la categoría
                    throw new Exception("Categoría no encontrada.");
                }
            }
            else
            {
                // Si el precio o el stock son 0, genera un error
                throw new Exception("El precio y el stock deben ser mayores que 0.");
            }
        }



        public void ModificarProducto(producto productoModificado, string categoria, string proveedor)
        {
            // Realiza validaciones y lógica de negocio antes de modificar el producto
            if (productoModificado != null && !string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(proveedor) &&
                productoModificado.stock_producto > 0 && productoModificado.precio_producto > 0)
            {
                // Obtén el ID de la categoría
                int idCategoria = ObtenerIdCategoriaPorNombre(categoria);
                if (idCategoria != -1)
                {
                    productoModificado.id_categoria = idCategoria;

                    // Obtén el ID del proveedor
                    int idProveedor = ObtenerIdProveedorPorNombre(proveedor);
                    if (idProveedor != -1)
                    {
                        productoModificado.id_proveedor = idProveedor;

                        productoModificado.estado = 1;
                        // Realiza la operación de modificar el producto
                        cdProducto.ModificarProducto(productoModificado);

                        //Refrescamos el datagrid para mostrar los cambios
                        
                    }
                    else
                    {
                        // Maneja el caso en que no se encuentre el proveedor
                        throw new Exception("Proveedor no encontrado.");
                    }
                }
                else
                {
                    // Maneja el caso en que no se encuentre la categoría
                    throw new Exception("Categoría no encontrada.");
                }
            }
            else
            {
                // Maneja el caso en que los datos no sean válidos
                throw new Exception("Datos de producto inválidos.");
            }
        }


        public void DarDeBajaProducto(int productoId)
        {
            if (productoId > 0)
            {
                cdProducto.DarDeBajaProducto(productoId);
            }
            else
            {
                throw new Exception("ID de producto inválido");
            }
        }

        private int ObtenerIdCategoriaPorNombre(string nombreCategoria)
        {
            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                var categoria = dbContext.categoria.FirstOrDefault(c => c.descripcion_categoria.Equals(nombreCategoria));
                if (categoria != null)
                {
                    return categoria.id_categoria;
                }
            }
            return -1; // Retorna -1 si la categoría no se encuentra
        }

        private int ObtenerIdProveedorPorNombre(string nombreProveedor)
        {
            using (var dbContext = new ProyectoTPII_MoraesLeandroEntities())
            {
                var proveedor = dbContext.proveedor.FirstOrDefault(p => p.nombre_proveedor.Equals(nombreProveedor));
                if (proveedor != null)
                {
                    return proveedor.id_proveedor;
                }
            }
            return -1; // Retorna -1 si el proveedor no se encuentra
        }

        public List<producto> ObtenerProductosInactivos()
        {
            return cdProducto.ObtenerProductosInactivos();
        }


        public void CambiarEstadoProducto(int productoId, int nuevoEstado)
        {
            if (productoId > 0)
            {
                cdProducto.CambiarEstadoProducto(productoId, nuevoEstado);
            }
            else
            {
                throw new Exception("ID de producto inválido");
            }
        }

    }
}
