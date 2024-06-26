using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorio;

namespace _04_PersistenciaDatos
{
    public class ProductoEnMemoria : ProductoRepo
    {
        private List<Producto> productos = new List<Producto>();

        public List<Producto> Listar()
        {
            return productos;
        }
        public void Grabar(Producto producto)
        {
            productos.Add(producto);
        }
        public void Borrar(Guid id)
        {
            var product = productos.FirstOrDefault(p => p.Id() == id);
            if (product != null)
            {
                productos.Remove(product);
            }
        }
        public void Actualizar(Producto producto)
        {
            var product = productos.FirstOrDefault(p => p.Id() == producto.Id());
            if (product != null)
            {
                product.Actualizar(product.Id(),producto.Nombre(), producto.Precio(), producto.Cantidad());

            }
        }
    }
}
