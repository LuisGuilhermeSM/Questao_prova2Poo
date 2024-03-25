using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaQuestãoP2Poo
{
    internal class Onibus : Veiculo 
    {

        private int assentos;

        public Onibus()
        {

        }

        public Onibus(string placa, int ano, int assentos):base(placa, ano)
        {
            this.assentos = assentos;
        }

        public int Assentos { get => assentos; set => assentos = value; }

        public override double Alugar()
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            double diaria;
            diaria = (30 * this.Assentos) - (data.Year - this.Ano) * 70;
            return diaria;
        }
    }
}
