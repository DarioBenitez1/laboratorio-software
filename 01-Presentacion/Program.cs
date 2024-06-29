using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Aplicacion;
using _02_Aplicacion.DTO;
using _03_Dominio.Entidades;
using _04_PersistenciaDatos;

namespace _01_Presentacion
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ProductoDTO verdura = new ProductoDTO(Guid.NewGuid(), "zapallo", 12, 8, "pepe");
            ProductoDTO verdura2 = new ProductoDTO(Guid.NewGuid(), "zanahoria", 12, 8, "activo");
            ProductoDTO verdura3 = new ProductoDTO(Guid.NewGuid(), "cebolla", 10, 7, "activo");

            ProductoRepositorioMySQL repositorio = new ProductoRepositorioMySQL();

            CrearProducto casoDeUsoCrear = new CrearProducto(repositorio);
            casoDeUsoCrear.Ejecutar(verdura);
            casoDeUsoCrear.Ejecutar(verdura2);
            casoDeUsoCrear.Ejecutar(verdura3);
            ListarProducto casoDeUsoLista = new ListarProducto(repositorio);
            List<ProductoDTO> product = casoDeUsoLista.Ejecutar();
            Console.WriteLine("Productos disponibles:");
            foreach (ProductoDTO productos in product)
            {
                Console.WriteLine($"{productos.Nombre()}, {productos.Precio()}, {productos.Cantidad()}, {productos.Estado()} ");
            }
            Console.WriteLine("fin");

            BorrarProducto casoDeUsoBorrar = new BorrarProducto(repositorio);
            casoDeUsoBorrar.Ejecutar(verdura3);

            ActualizarProducto casoDeUsoActualizar = new ActualizarProducto(repositorio);
            ProductoDTO productoActualizadoDto = new ProductoDTO(verdura2.Id(), "zanahoria actualizado", 15, 10, "INACTIVO");

            casoDeUsoActualizar.Ejecutar(productoActualizadoDto);
            List<ProductoDTO> producto = casoDeUsoLista.Ejecutar();
            Console.WriteLine("Productos disponibles:");
            foreach (ProductoDTO productos in producto)
            {
                Console.WriteLine(productos.Nombre());
            }
            Console.WriteLine("fin");





            Console.ReadLine();
        }
    }
    
}
