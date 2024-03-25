using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestãoP2Poo
{
    public abstract class Veiculo
    {

        protected string placa;
        protected int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
        }

        public abstract double Alugar();


    }
}
