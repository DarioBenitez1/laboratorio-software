using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Dominio.Entidades;

namespace _03_Dominio.Repositorio
{
    public interface ProductoRepo
    {
        List<Producto> Listar();
        void Grabar(Producto producto);
        void Borrar(Guid id);
        void Actualizar(Producto producto);
    }
}
