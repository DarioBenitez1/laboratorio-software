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
    public class BorrarProducto
    {
        private ProductoRepo repositorio;

        public BorrarProducto(ProductoRepo repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Ejecutar(ProductoDTO productoDTO)
        {
            repositorio.Borrar(productoDTO.Id());

        }
    }
}
