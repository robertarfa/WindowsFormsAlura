namespace WindowsFormsAlura
{
    partial class Form_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HelloWorld));
            this.label_Titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ModificaTexto = new System.Windows.Forms.Button();
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(30, 30);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(255, 24);
            this.label_Titulo.TabIndex = 0;
            this.label_Titulo.Text = "Visual Studio .Net Version";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(609, 405);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(179, 33);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Fechar a aplicação";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // btn_ModificaTexto
            // 
            this.btn_ModificaTexto.Location = new System.Drawing.Point(34, 73);
            this.btn_ModificaTexto.Name = "btn_ModificaTexto";
            this.btn_ModificaTexto.Size = new System.Drawing.Size(251, 23);
            this.btn_ModificaTexto.TabIndex = 2;
            this.btn_ModificaTexto.Text = "Modifica Texto do Label";
            this.btn_ModificaTexto.UseVisualStyleBackColor = true;
            this.btn_ModificaTexto.Click += new System.EventHandler(this.Btn_ModificaTexto_Click);
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(34, 124);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(385, 22);
            this.txt_ConteudoLabel.TabIndex = 3;
            // 
            // Form_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaTexto);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.label_Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_ModificaTexto;
        private System.Windows.Forms.TextBox txt_ConteudoLabel;
    }
}

