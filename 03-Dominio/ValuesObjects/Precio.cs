using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValuesObjects
{
    public class Precio
    {
        public int valor;

        public Precio(int valor)
        {
            debeSerPositivo(valor);
            this.valor = valor;

        }

        private void debeSerPositivo(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }

        }
        public int Valor()
        {
            return valor;
        }
    }
}

