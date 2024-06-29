using System;
using Xunit;
using _03_Dominio.ValuesObjects;

namespace pruebas_unitarias
{
    public class Nombre_test
    {
        [Theory]
        [InlineData("mandarina","mandarina")]
        public void DebeContenerNombre_test_positivo(string nombre,string expectativa)
        {
            // Arrange
            Nombre nombre_prueba = new Nombre(nombre);

            // Act & Assert
            Assert.Equal(expectativa, nombre_prueba.DebeContenerNombre(nombre_prueba.Valor()));
        }
    }
}