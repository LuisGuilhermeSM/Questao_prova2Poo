using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaQuestãoP2Poo
{
    internal class Caminhao : Veiculo
    {
        private int eixos;

        public Caminhao() { }

        public Caminhao(string placa, int ano, int eixos) : base(placa, ano)
        {
            this.eixos = eixos;
        }

        public int Eixos { get => eixos; set => eixos = value; }

        public override double Alugar()
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            //MessageBox.Show(Convert.ToString(data.Year));
            double diaria;
            diaria = (300 * this.eixos) - (data.Year - this.ano) * 50;
            return diaria;
        }
    }
}
