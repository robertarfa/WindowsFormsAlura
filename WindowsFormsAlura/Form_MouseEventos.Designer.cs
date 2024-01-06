namespace WindowsFormsAlura
{
    partial class Form_MouseEventos
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
            this.btn_MouseEventos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_MouseEventos
            // 
            this.btn_MouseEventos.Location = new System.Drawing.Point(154, 82);
            this.btn_MouseEventos.Name = "btn_MouseEventos";
            this.btn_MouseEventos.Size = new System.Drawing.Size(293, 142);
            this.btn_MouseEventos.TabIndex = 0;
            this.btn_MouseEventos.UseVisualStyleBackColor = true;
            this.btn_MouseEventos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseEventos_MouseDown);
            this.btn_MouseEventos.MouseEnter += new System.EventHandler(this.btn_MouseEventos_MouseEnter);
            this.btn_MouseEventos.MouseLeave += new System.EventHandler(this.btn_MouseEventos_MouseLeave);
            this.btn_MouseEventos.MouseHover += new System.EventHandler(this.btn_MouseEventos_MouseHover);
            this.btn_MouseEventos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseEventos_MouseUp);
            // 
            // Form_EventosDoMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 322);
            this.Controls.Add(this.btn_MouseEventos);
            this.Name = "Form_EventosDoMouse";
            this.Text = "Form_EventosDoMouse";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MouseEventos;
    }
}