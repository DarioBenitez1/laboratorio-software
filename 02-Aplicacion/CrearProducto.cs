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
    public class CrearProducto
    {
        public ProductoRepo repositorio;

        public CrearProducto(ProductoRepo repositorio)
        {
            this.repositorio = repositorio;
        }
        public void Ejecutar(ProductoDTO productoDTO)
        {
            repositorio.Grabar(new Producto(
                productoDTO.Id(),
                productoDTO.Nombre(),
                productoDTO.Precio(),
                productoDTO.Cantidad(),
                productoDTO.Estado())
                );

        }
    }
}
