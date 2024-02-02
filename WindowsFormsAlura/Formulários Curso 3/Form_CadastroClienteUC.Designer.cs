namespace WindowsFormsAlura
{
    partial class Form_CadastroClienteUC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Txt_CEP = new System.Windows.Forms.TextBox();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_Telefone = new System.Windows.Forms.TextBox();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Lbl_RendaFamiliar = new System.Windows.Forms.Label();
            this.Txt_RendaFamiliar = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.Grp_codigo = new System.Windows.Forms.GroupBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Grp_Genero = new System.Windows.Forms.GroupBox();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Grp_TemPai = new System.Windows.Forms.GroupBox();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Grp_endereco = new System.Windows.Forms.GroupBox();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Grp_outros = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.Grp_codigo.SuspendLayout();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Genero.SuspendLayout();
            this.Grp_TemPai.SuspendLayout();
            this.Grp_endereco.SuspendLayout();
            this.Grp_outros.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(549, 22);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(33, 16);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CPF.Location = new System.Drawing.Point(546, 41);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(217, 22);
            this.Txt_CPF.TabIndex = 3;
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(3, 25);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(88, 16);
            this.Lbl_NomeCliente.TabIndex = 2;
            this.Lbl_NomeCliente.Text = "Nome Cliente";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeCliente.Location = new System.Drawing.Point(3, 41);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(537, 22);
            this.Txt_NomeCliente.TabIndex = 2;
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(3, 111);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(67, 16);
            this.Lbl_NomePai.TabIndex = 4;
            this.Lbl_NomePai.Text = "Nome Pai";
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomePai.Location = new System.Drawing.Point(3, 127);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(537, 22);
            this.Txt_NomePai.TabIndex = 5;
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(3, 70);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(74, 16);
            this.Lbl_NomeMae.TabIndex = 6;
            this.Lbl_NomeMae.Text = "Nome Mãe";
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NomeMae.Location = new System.Drawing.Point(3, 86);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(537, 22);
            this.Txt_NomeMae.TabIndex = 4;
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(6, 30);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(34, 16);
            this.Lbl_CEP.TabIndex = 10;
            this.Lbl_CEP.Text = "CEP";
            // 
            // Txt_CEP
            // 
            this.Txt_CEP.Location = new System.Drawing.Point(6, 46);
            this.Txt_CEP.Name = "Txt_CEP";
            this.Txt_CEP.Size = new System.Drawing.Size(162, 22);
            this.Txt_CEP.TabIndex = 10;
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(174, 30);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(77, 16);
            this.Lbl_Logradouro.TabIndex = 12;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Logradouro.Location = new System.Drawing.Point(174, 46);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.Size = new System.Drawing.Size(588, 22);
            this.Txt_Logradouro.TabIndex = 11;
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(5, 77);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(91, 16);
            this.Lbl_Complemento.TabIndex = 14;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(5, 93);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(310, 22);
            this.Txt_Complemento.TabIndex = 12;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(320, 74);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(43, 16);
            this.Lbl_Bairro.TabIndex = 16;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(321, 93);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(265, 22);
            this.Txt_Bairro.TabIndex = 13;
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(318, 123);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(50, 16);
            this.Lbl_Estado.TabIndex = 18;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(6, 29);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(61, 16);
            this.Lbl_Telefone.TabIndex = 20;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Txt_Telefone
            // 
            this.Txt_Telefone.Location = new System.Drawing.Point(6, 45);
            this.Txt_Telefone.Name = "Txt_Telefone";
            this.Txt_Telefone.Size = new System.Drawing.Size(328, 22);
            this.Txt_Telefone.TabIndex = 16;
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(339, 29);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(64, 16);
            this.Lbl_Profissao.TabIndex = 22;
            this.Lbl_Profissao.Text = "Profissão";
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Profissao.Location = new System.Drawing.Point(341, 45);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(418, 22);
            this.Txt_Profissao.TabIndex = 17;
            // 
            // Lbl_RendaFamiliar
            // 
            this.Lbl_RendaFamiliar.AutoSize = true;
            this.Lbl_RendaFamiliar.Location = new System.Drawing.Point(6, 69);
            this.Lbl_RendaFamiliar.Name = "Lbl_RendaFamiliar";
            this.Lbl_RendaFamiliar.Size = new System.Drawing.Size(99, 16);
            this.Lbl_RendaFamiliar.TabIndex = 24;
            this.Lbl_RendaFamiliar.Text = "Renda Familiar";
            // 
            // Txt_RendaFamiliar
            // 
            this.Txt_RendaFamiliar.Location = new System.Drawing.Point(6, 85);
            this.Txt_RendaFamiliar.Name = "Txt_RendaFamiliar";
            this.Txt_RendaFamiliar.Size = new System.Drawing.Size(328, 22);
            this.Txt_RendaFamiliar.TabIndex = 18;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(6, 21);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(271, 22);
            this.Txt_codigo.TabIndex = 1;
            // 
            // Grp_codigo
            // 
            this.Grp_codigo.Controls.Add(this.Txt_codigo);
            this.Grp_codigo.Location = new System.Drawing.Point(3, 3);
            this.Grp_codigo.Name = "Grp_codigo";
            this.Grp_codigo.Size = new System.Drawing.Size(284, 56);
            this.Grp_codigo.TabIndex = 28;
            this.Grp_codigo.TabStop = false;
            this.Grp_codigo.Text = "groupBox1";
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Grp_Genero);
            this.Grp_DadosPessoais.Controls.Add(this.Grp_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeCliente);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeCliente);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(9, 65);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(769, 214);
            this.Grp_DadosPessoais.TabIndex = 29;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "groupBox1";
            // 
            // Grp_Genero
            // 
            this.Grp_Genero.Controls.Add(this.Rdb_Indefinido);
            this.Grp_Genero.Controls.Add(this.Rdb_Feminino);
            this.Grp_Genero.Controls.Add(this.Rdb_Masculino);
            this.Grp_Genero.Location = new System.Drawing.Point(13, 159);
            this.Grp_Genero.Name = "Grp_Genero";
            this.Grp_Genero.Size = new System.Drawing.Size(527, 49);
            this.Grp_Genero.TabIndex = 10;
            this.Grp_Genero.TabStop = false;
            this.Grp_Genero.Text = "Gênero";
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(349, 18);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(103, 20);
            this.Rdb_Indefinido.TabIndex = 9;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton3";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(188, 18);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(103, 20);
            this.Rdb_Feminino.TabIndex = 8;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton2";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(26, 18);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(103, 20);
            this.Rdb_Masculino.TabIndex = 7;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton1";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Grp_TemPai
            // 
            this.Grp_TemPai.Controls.Add(this.Chk_TemPai);
            this.Grp_TemPai.Location = new System.Drawing.Point(552, 93);
            this.Grp_TemPai.Name = "Grp_TemPai";
            this.Grp_TemPai.Size = new System.Drawing.Size(199, 56);
            this.Grp_TemPai.TabIndex = 9;
            this.Grp_TemPai.TabStop = false;
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(23, 24);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(95, 20);
            this.Chk_TemPai.TabIndex = 6;
            this.Chk_TemPai.Text = "checkBox1";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Grp_endereco
            // 
            this.Grp_endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_endereco.Controls.Add(this.Txt_CEP);
            this.Grp_endereco.Controls.Add(this.Lbl_Logradouro);
            this.Grp_endereco.Controls.Add(this.Txt_Logradouro);
            this.Grp_endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_endereco.Location = new System.Drawing.Point(10, 296);
            this.Grp_endereco.Name = "Grp_endereco";
            this.Grp_endereco.Size = new System.Drawing.Size(769, 167);
            this.Grp_endereco.TabIndex = 30;
            this.Grp_endereco.TabStop = false;
            this.Grp_endereco.Text = "groupBox1";
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(318, 139);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(146, 24);
            this.Cmb_Estados.TabIndex = 21;
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(5, 120);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(51, 16);
            this.Lbl_Cidade.TabIndex = 20;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(6, 139);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(306, 22);
            this.Txt_Cidade.TabIndex = 14;
            // 
            // Grp_outros
            // 
            this.Grp_outros.Controls.Add(this.Lbl_Telefone);
            this.Grp_outros.Controls.Add(this.Txt_Telefone);
            this.Grp_outros.Controls.Add(this.Lbl_Profissao);
            this.Grp_outros.Controls.Add(this.Txt_RendaFamiliar);
            this.Grp_outros.Controls.Add(this.Txt_Profissao);
            this.Grp_outros.Controls.Add(this.Lbl_RendaFamiliar);
            this.Grp_outros.Location = new System.Drawing.Point(12, 462);
            this.Grp_outros.Name = "Grp_outros";
            this.Grp_outros.Size = new System.Drawing.Size(766, 124);
            this.Grp_outros.TabIndex = 20;
            this.Grp_outros.TabStop = false;
            this.Grp_outros.Text = "groupBox1";
            // 
            // Form_CadastroClienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grp_outros);
            this.Controls.Add(this.Grp_endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.Controls.Add(this.Grp_codigo);
            this.Name = "Form_CadastroClienteUC";
            this.Size = new System.Drawing.Size(792, 589);
            this.Grp_codigo.ResumeLayout(false);
            this.Grp_codigo.PerformLayout();
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Genero.ResumeLayout(false);
            this.Grp_Genero.PerformLayout();
            this.Grp_TemPai.ResumeLayout(false);
            this.Grp_TemPai.PerformLayout();
            this.Grp_endereco.ResumeLayout(false);
            this.Grp_endereco.PerformLayout();
            this.Grp_outros.ResumeLayout(false);
            this.Grp_outros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.TextBox Txt_CEP;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.TextBox Txt_Logradouro;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.TextBox Txt_Bairro;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.TextBox Txt_Telefone;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.Label Lbl_RendaFamiliar;
        private System.Windows.Forms.TextBox Txt_RendaFamiliar;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.GroupBox Grp_codigo;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Grp_endereco;
        private System.Windows.Forms.GroupBox Grp_outros;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.GroupBox Grp_TemPai;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox Grp_Genero;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.ComboBox Cmb_Estados;
    }
}
