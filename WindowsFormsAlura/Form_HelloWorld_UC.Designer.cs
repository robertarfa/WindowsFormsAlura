namespace WindowsFormsAlura
{
    partial class Form_HelloWorld_UC
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
            this.txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.btn_ModificaTexto = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ConteudoLabel
            // 
            this.txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ConteudoLabel.Location = new System.Drawing.Point(7, 113);
            this.txt_ConteudoLabel.Name = "txt_ConteudoLabel";
            this.txt_ConteudoLabel.Size = new System.Drawing.Size(648, 22);
            this.txt_ConteudoLabel.TabIndex = 6;
            // 
            // btn_ModificaTexto
            // 
            this.btn_ModificaTexto.Location = new System.Drawing.Point(7, 62);
            this.btn_ModificaTexto.Name = "btn_ModificaTexto";
            this.btn_ModificaTexto.Size = new System.Drawing.Size(251, 23);
            this.btn_ModificaTexto.TabIndex = 5;
            this.btn_ModificaTexto.Text = "Modifica Texto do Label";
            this.btn_ModificaTexto.UseVisualStyleBackColor = true;
            this.btn_ModificaTexto.Click += new System.EventHandler(this.btn_ModificaTexto_Click);
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(3, 19);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(255, 24);
            this.label_Titulo.TabIndex = 4;
            this.label_Titulo.Text = "Visual Studio .Net Version";
            // 
            // Form_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_ConteudoLabel);
            this.Controls.Add(this.btn_ModificaTexto);
            this.Controls.Add(this.label_Titulo);
            this.Name = "Form_HelloWorld_UC";
            this.Size = new System.Drawing.Size(670, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ConteudoLabel;
        private System.Windows.Forms.Button btn_ModificaTexto;
        private System.Windows.Forms.Label label_Titulo;
    }
}
