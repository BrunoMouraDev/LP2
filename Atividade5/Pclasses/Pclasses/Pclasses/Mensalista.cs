using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    class Mensalista : Empregado // Especialização --> Herança
    {
        public Double SalarioMensal { get; set; }

        //Sobreescrevendo o método

        public override double SalarioBruto()
        {
            return SalarioMensal;
        }

        public Mensalista()
        {
            // TODO: Complete member initialization
        }
    }
}
