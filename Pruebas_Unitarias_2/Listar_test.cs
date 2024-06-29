using System;
using Xunit;
using _03_Dominio.Repositorio;
using _02_Aplicacion.DTO;
using _02_Aplicacion;
using _04_PersistenciaDatos;
using _04_PersistenciaDatos.MySQLConnector;

namespace pruebas_unitarias
{
    public class Listar_test
    {
        [Fact]
        public void listar_tipoDeDatoCorrecto()
        {
            // Arrange
            ProductoRepositorioMySQL repositorio = new ProductoRepositorioMySQL();
            ListarProducto casoDeUsoLista = new ListarProducto(repositorio);
            List<ProductoDTO> product = casoDeUsoLista.Ejecutar();

            // Assert
            Assert.IsType<List<ProductoDTO>>(product);
        }
    }
}