using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Aplicacion.DTO;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorio;

namespace _02_Aplicacion
{
    public class ListarProducto
    {
        private ProductoRepo repositorio;

        public ListarProducto(ProductoRepo repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<ProductoDTO> Ejecutar()
        {
            List<ProductoDTO> productoDTO = new List<ProductoDTO>();
            List<Producto> producto = repositorio.Listar();
            foreach (Producto productos in producto)
            {
                ProductoDTO productosDTO = new ProductoDTO(
                    productos.Id(),
                    productos.Nombre(),
                    productos.Precio(),
                    productos.Cantidad()

                );
                productoDTO.Add(productosDTO);
            }
            return productoDTO;
        }
    }
}
