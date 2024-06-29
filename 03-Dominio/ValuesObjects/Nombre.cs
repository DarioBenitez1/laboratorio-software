using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValuesObjects
{
    public class Nombre
    {
        private string valor;

        public Nombre(string valor)
        {
            DebeContenerNombre(valor);
            this.valor = valor;
        }
        public string DebeContenerNombre(string valor)
        {
            if (valor == "")
            {
                throw new Exception("El nombre no debe ser vacio");
            }
            return this.valor;
        }

        public string Valor()
        {
            return valor;
        }
    }
}
