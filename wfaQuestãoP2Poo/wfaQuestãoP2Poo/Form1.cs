using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaQuestãoP2Poo
{
    public partial class Form1 : Form
    {
        //Nome: Luis Guilherme Silva Matos


        public void GerarListView()
        {
            lvLista.Columns.Add("Placa", 120).TextAlign = HorizontalAlignment.Center;
            lvLista.Columns.Add("Ano", 60).TextAlign = HorizontalAlignment.Center;
            lvLista.Columns.Add("Assentos", 120).TextAlign = HorizontalAlignment.Center;
            lvLista.Columns.Add("Eixos", 60).TextAlign = HorizontalAlignment.Center;
            lvLista.Columns.Add("Diaria", 120).TextAlign = HorizontalAlignment.Center;
            lvLista.View = View.Details;
        }
        
        public Form1()
        {
            InitializeComponent();
            lbqtdAssentosEixos.Visible = false;
            tbQtdAssentosEixos.Visible = false;
            mtbPlaca.Mask = "LLL-0000";
            pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
            GerarListView();
        }

        private void rbOnibus_CheckedChanged(object sender, EventArgs e)
        {
            lbqtdAssentosEixos.Visible = true;
            tbQtdAssentosEixos.Visible = true;
            lbqtdAssentosEixos.Text = "Qtd Assentos";
            pbImagens.Image = Properties.Resources.onibus;

        }

        private void rbCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            lbqtdAssentosEixos.Visible = true;
            tbQtdAssentosEixos.Visible = true;
            lbqtdAssentosEixos.Text = "Qtd Eixos";
            pbImagens.Image = Properties.Resources.caminhão;
        }

        public void GerarMensagem(string mensagem)
        {
            MessageBox.Show("Voce deve preencher o campo: " + mensagem + "!");
        }

        public bool checarCampos()
        {
            bool preenchidos = true;
            if(mtbPlaca.MaskCompleted == false)
            {
                preenchidos = false;
                GerarMensagem(laPlaca.Text);
            } else if(tbAno.Text.Trim() == string.Empty)
            {
                preenchidos = false;
                GerarMensagem(laAno.Text);
            } else if(tbQtdAssentosEixos.Text.Trim() == string.Empty)
            {
                preenchidos = false;
                GerarMensagem(lbqtdAssentosEixos.Text);
            }

            return preenchidos;
            
        }

        public void PopularListView(Veiculo veiculotemp)
        {
            string[] dados_veiculo = new string[5];

            dados_veiculo[0] = veiculotemp.Placa;
            dados_veiculo[1] = Convert.ToString(veiculotemp.Ano);
            dados_veiculo[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", veiculotemp.Alugar());

            if (rbOnibus.Checked)
            {
                dados_veiculo[2] = tbQtdAssentosEixos.Text;
                lvLista.Items.Add(new ListViewItem(dados_veiculo));
            }

            if (rbCaminhao.Checked)
            {
                dados_veiculo[3] = tbQtdAssentosEixos.Text;
                lvLista.Items.Add(new ListViewItem(dados_veiculo));
            }


        }

        public void mensagemValor(double valor)
        {
            MessageBox.Show("O valor do aluguel diário será: R$ " + valor);
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {

            bool camposPreenchidos = checarCampos();

            if(camposPreenchidos == true && rbOnibus.Checked == true) 
            {
                Veiculo veiculotemp = new Onibus(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(tbQtdAssentosEixos.Text));

                mensagemValor(veiculotemp.Alugar());

                PopularListView(veiculotemp);


            } else if(camposPreenchidos && rbCaminhao.Checked)
            {
                Veiculo veiculotemp = new Caminhao(mtbPlaca.Text, Convert.ToInt32(tbAno.Text), Convert.ToInt32(tbQtdAssentosEixos.Text));

                mensagemValor(veiculotemp.Alugar());
                PopularListView(veiculotemp);
            }
            
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbAno.Text = string.Empty;
            tbQtdAssentosEixos.Text = string.Empty;
            mtbPlaca.Text = string.Empty;
        }

        private void tbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
