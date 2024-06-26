using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValuesObjects
{
    public class Cantidad
    {
        public int valor;

        public Cantidad(int valor)
        {
            debeSerPositivo(valor);
            this.valor = valor;

        }
        private void debeSerPositivo(int valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("El stock no puede ser negativo.");
            }
        }
        public int Valor()
        {
            return valor;
        }

    }
}

