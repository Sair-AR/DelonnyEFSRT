using Dominio.Entidad.Negocio.Abstraccion;
using Dominio.Entidad.Negocio.Entidad;
using Dominio.Entidad.Negocio.Entidad.Lista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SQL.Negocios
{
    public class proveedorDAO : IProveedor
    {
        public string Add(Proveedor registro)
        {
            throw new NotImplementedException();
        }
        public string Update(Proveedor registro)
        {
            throw new NotImplementedException();
        }

        public string Delete(Proveedor registro)
        {
            throw new NotImplementedException();
        }

        public Proveedor Find(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProveedorLista> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProveedorLista> GetByName(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
