using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValuesObjects
{
    public class Estado
    {
        private string valor;

        public Estado(string valor)
        {
            DebeContenerEstado(valor);
            this.valor = valor;
        }
        private void DebeContenerEstado(string valor)
        {
            if (valor == "")
            {
                throw new Exception("El Estado no debe ser vacio");
            }
        }

        public string Valor()
        {
            return valor;
        }
    }
}