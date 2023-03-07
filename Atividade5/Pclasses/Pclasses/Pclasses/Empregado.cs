using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract class Empregado
    {
        private int matricula; //Atributos
        private string nomeEmpregado; //Atributos
        private DateTime dataEntradaEmpresa; //Atributos
        private char homeOffice; //Atributos


        public int Matricula //Propriedades
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nomeempregado //Propriedades
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa //Propriedades
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice //Propriedades
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }




        //Método são ações/Comportamentos

        public String VerificaHome()//Método
        {
            if (homeOffice == 'S' || homeOffice == 's')
                return "Empregado trabalha em Home-office";
            else
                return "Empregado não trabalha em Home-office";
        }

        //virtual --> pode ser sobreescrito
        public virtual int TempoTrabalho()
        {
            //Representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        //Deve ser implementado
        //Derived classes must implement this

        public abstract double SalarioBruto(); // não precisa ser implementando

        public Empregado() //COnstrutor --> New
        {

        }
    }
}
