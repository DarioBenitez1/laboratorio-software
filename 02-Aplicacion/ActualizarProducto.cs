using _02_Aplicacion.DTO;
using _03_Dominio.Entidades;
using _03_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion
{
    public class ActualizarProducto
    {
        public ProductoRepo repositorio;

        public ActualizarProducto(ProductoRepo repositorio)
        {
            this.repositorio = repositorio;
        }
        public void Ejecutar(ProductoDTO productoDTO)
        {
            repositorio.Actualizar(new Producto(
                productoDTO.Id(),
                productoDTO.Nombre(),
                productoDTO.Precio(),
                productoDTO.Cantidad())
                );

        }
    }
}
