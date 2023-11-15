using capaDatos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_Proveedor
    {
        private ProyectoTPII_MoraesLeandroEntities contexto;

        public CD_Proveedor()
        {
            contexto = new ProyectoTPII_MoraesLeandroEntities();
        }

        public List<proveedor> ObtenerTodosLosProveedores()
        {
            var proveedores = contexto.proveedor
                .Where(p => p.estado == 1)
                .ToList();
            return proveedores;
        }

        public void AgregarProveedor(proveedor nuevoProveedor)
        {
            nuevoProveedor.estado = 1; //establecemos el estado como activo por defecto
            contexto.proveedor.Add(nuevoProveedor);
            contexto.SaveChanges();
        }

        public void CambiarEstadoProveedor(int proveedorId)
        {
            var proveedor = contexto.proveedor.Find(proveedorId);
            if (proveedor != null)
            {
                proveedor.estado = 0; // Cambiar el estado a inactivo
                contexto.SaveChanges();
            }
        }

        public List<proveedor> ObtenerProveedoresPorEstado(int estado)
        {
            return contexto.proveedor.Where(p => p.estado == estado).ToList();
        }

        public List<proveedor> ObtenerProveedoresInactivos()
        {
            return contexto.proveedor.Where(p => p.estado == 0).ToList();
        }

        public List<proveedor> BuscarProveedorPorCUIT(string cuit)
        {
            return contexto.proveedor
                .Where(p => p.estado == 1 && p.cuit_proveedor.Contains(cuit))
                .ToList();
        }

    }
}


