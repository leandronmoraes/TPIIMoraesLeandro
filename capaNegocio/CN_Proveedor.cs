using capaDatos.Models;
using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor datos;

        public CN_Proveedor()
        {
            datos = new CD_Proveedor();
        }

        public List<proveedor> ObtenerTodosLosProveedores()
        {
            return datos.ObtenerTodosLosProveedores();
        }

        public void AgregarProveedor(proveedor nuevoProveedor)
        {
            // Aquí puedes realizar validaciones adicionales antes de agregar el proveedor.
            datos.AgregarProveedor(nuevoProveedor);
        }

        public void CambiarEstadoProveedor(int proveedorId)
        {
            datos.CambiarEstadoProveedor(proveedorId);
        }

        public List<proveedor> ObtenerProveedoresActivos()
        {
            return datos.ObtenerProveedoresPorEstado(1); // 1 para proveedores activos
        }

        public List<proveedor> ObtenerProveedoresInactivos()
        {
            return datos.ObtenerProveedoresInactivos();
        }

        public List<proveedor> BuscarProveedorPorCUIT(string cuit)
        {
            return datos.BuscarProveedorPorCUIT(cuit);
        }

    }
}
