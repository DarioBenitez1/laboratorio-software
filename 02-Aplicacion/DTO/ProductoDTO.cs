using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion.DTO
{
    public class ProductoDTO
    {
        private Guid id;
        private  string nombre; 
        private int precio;
        private int cantidad;


        public ProductoDTO(Guid id, string nombre, int precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public Guid Id()
        {
            return id;
        }

        public string Nombre()
        {
            return nombre;
        }
        public int Precio()
        {
            return precio;
        }
        public int Cantidad()
        {
            return cantidad;
        }
    }
}
