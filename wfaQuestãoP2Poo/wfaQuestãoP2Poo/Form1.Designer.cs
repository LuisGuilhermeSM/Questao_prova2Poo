namespace wfaQuestãoP2Poo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbOnibus = new System.Windows.Forms.RadioButton();
            this.rbCaminhao = new System.Windows.Forms.RadioButton();
            this.mtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.laPlaca = new System.Windows.Forms.Label();
            this.laAno = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.lbqtdAssentosEixos = new System.Windows.Forms.Label();
            this.tbQtdAssentosEixos = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lvLista = new System.Windows.Forms.ListView();
            this.pbImagens = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // rbOnibus
            // 
            this.rbOnibus.AutoSize = true;
            this.rbOnibus.Location = new System.Drawing.Point(146, 63);
            this.rbOnibus.Name = "rbOnibus";
            this.rbOnibus.Size = new System.Drawing.Size(70, 20);
            this.rbOnibus.TabIndex = 0;
            this.rbOnibus.Text = "Ônibus";
            this.rbOnibus.UseVisualStyleBackColor = true;
            this.rbOnibus.CheckedChanged += new System.EventHandler(this.rbOnibus_CheckedChanged);
            // 
            // rbCaminhao
            // 
            this.rbCaminhao.AutoSize = true;
            this.rbCaminhao.Location = new System.Drawing.Point(322, 63);
            this.rbCaminhao.Name = "rbCaminhao";
            this.rbCaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbCaminhao.TabIndex = 1;
            this.rbCaminhao.Text = "Caminhão";
            this.rbCaminhao.UseVisualStyleBackColor = true;
            this.rbCaminhao.CheckedChanged += new System.EventHandler(this.rbCaminhao_CheckedChanged);
            // 
            // mtbPlaca
            // 
            this.mtbPlaca.Location = new System.Drawing.Point(261, 151);
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mtbPlaca.TabIndex = 2;
            // 
            // laPlaca
            // 
            this.laPlaca.AutoSize = true;
            this.laPlaca.Location = new System.Drawing.Point(157, 151);
            this.laPlaca.Name = "laPlaca";
            this.laPlaca.Size = new System.Drawing.Size(42, 16);
            this.laPlaca.TabIndex = 3;
            this.laPlaca.Text = "Placa";
            // 
            // laAno
            // 
            this.laAno.AutoSize = true;
            this.laAno.Location = new System.Drawing.Point(157, 195);
            this.laAno.Name = "laAno";
            this.laAno.Size = new System.Drawing.Size(31, 16);
            this.laAno.TabIndex = 4;
            this.laAno.Text = "Ano";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(261, 195);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 5;
            this.tbAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAno_KeyPress);
            // 
            // lbqtdAssentosEixos
            // 
            this.lbqtdAssentosEixos.AutoSize = true;
            this.lbqtdAssentosEixos.Location = new System.Drawing.Point(157, 252);
            this.lbqtdAssentosEixos.Name = "lbqtdAssentosEixos";
            this.lbqtdAssentosEixos.Size = new System.Drawing.Size(87, 16);
            this.lbqtdAssentosEixos.TabIndex = 6;
            this.lbqtdAssentosEixos.Text = "Qtd Assentos";
            // 
            // tbQtdAssentosEixos
            // 
            this.tbQtdAssentosEixos.Location = new System.Drawing.Point(261, 249);
            this.tbQtdAssentosEixos.Name = "tbQtdAssentosEixos";
            this.tbQtdAssentosEixos.Size = new System.Drawing.Size(100, 22);
            this.tbQtdAssentosEixos.TabIndex = 7;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(146, 315);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(143, 59);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(361, 315);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(146, 59);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lvLista
            // 
            this.lvLista.HideSelection = false;
            this.lvLista.Location = new System.Drawing.Point(146, 444);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(773, 97);
            this.lvLista.TabIndex = 10;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            // 
            // pbImagens
            // 
            this.pbImagens.Location = new System.Drawing.Point(698, 63);
            this.pbImagens.Name = "pbImagens";
            this.pbImagens.Size = new System.Drawing.Size(351, 278);
            this.pbImagens.TabIndex = 11;
            this.pbImagens.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 624);
            this.Controls.Add(this.pbImagens);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbQtdAssentosEixos);
            this.Controls.Add(this.lbqtdAssentosEixos);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.laAno);
            this.Controls.Add(this.laPlaca);
            this.Controls.Add(this.mtbPlaca);
            this.Controls.Add(this.rbCaminhao);
            this.Controls.Add(this.rbOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOnibus;
        private System.Windows.Forms.RadioButton rbCaminhao;
        private System.Windows.Forms.MaskedTextBox mtbPlaca;
        private System.Windows.Forms.Label laPlaca;
        private System.Windows.Forms.Label laAno;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label lbqtdAssentosEixos;
        private System.Windows.Forms.TextBox tbQtdAssentosEixos;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ListView lvLista;
        private System.Windows.Forms.PictureBox pbImagens;
    }
}

