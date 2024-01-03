namespace WindowsFormsAlura
{
    partial class Form_Questao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Questao));
            this.Label_Questao = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Pic_imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Questao
            // 
            this.Label_Questao.AutoSize = true;
            this.Label_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Questao.Location = new System.Drawing.Point(18, 9);
            this.Label_Questao.Name = "Label_Questao";
            this.Label_Questao.Size = new System.Drawing.Size(269, 25);
            this.Label_Questao.TabIndex = 0;
            this.Label_Questao.Text = "Você deseja validar o CPF";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.Location = new System.Drawing.Point(174, 60);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(115, 23);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "Sim, Continue";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(174, 89);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(115, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Não, Pare";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Pic_imagem
            // 
            this.Pic_imagem.Image = global::WindowsFormsAlura.Properties.Resources.Question1;
            this.Pic_imagem.Location = new System.Drawing.Point(12, 47);
            this.Pic_imagem.Name = "Pic_imagem";
            this.Pic_imagem.Size = new System.Drawing.Size(129, 80);
            this.Pic_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pic_imagem.TabIndex = 3;
            this.Pic_imagem.TabStop = false;
            // 
            // Form_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 143);
            this.Controls.Add(this.Pic_imagem);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Label_Questao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Questao;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.PictureBox Pic_imagem;
    }
}