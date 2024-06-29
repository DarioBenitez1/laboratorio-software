using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Dominio.ValuesObjects;

namespace _03_Dominio.Entidades
{
    public class Producto
    {
        Identificador id;
        Nombre nombre;
        Precio precio;
        Cantidad cantidad;
        Estado estado;

        public Producto(Guid id, string nombre, int precio, int cantidad, string estado)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.precio = new Precio(precio);
            this.cantidad = new Cantidad(cantidad);
            this.estado = new Estado(estado);
        }

        public Guid Id()
        {
            return this.id.Valor();
        }
        public string Nombre()
        {
            return nombre.Valor();
        }
        public int Precio()
        {
            return precio.Valor();
        }
        public int Cantidad()
        {
            return cantidad.Valor();
        }
        public string Estado()
        {
            return estado.Valor();
        }

        public void Actualizar(Guid id, string nombre, int precio, int cantidad, string estado)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.precio = new Precio(precio);
            this.cantidad = new Cantidad(cantidad);
            this.estado = new Estado(estado);
        }

    }
}
