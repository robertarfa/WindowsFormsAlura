namespace WindowsFormsAlura
{
    partial class Form_Principal_Menu_UserControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal_Menu_UserControl));
            this.Menu_principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.válidaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byteBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Application = new System.Windows.Forms.TabControl();
            this.imageList_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.Menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.byteBankToolStripMenuItem,
            this.toolStripMenuItem1,
            this.windowsToolStripMenuItem});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Size = new System.Drawing.Size(800, 30);
            this.Menu_principal.TabIndex = 0;
            this.Menu_principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demonstraçãoKeyToolStripMenuItem,
            this.helloWorldToolStripMenuItem,
            this.máscaraToolStripMenuItem,
            this.validaCPFToolStripMenuItem,
            this.válidaCPF2ToolStripMenuItem,
            this.validaSenhaToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // demonstraçãoKeyToolStripMenuItem
            // 
            this.demonstraçãoKeyToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_DemonstracaoKey1;
            this.demonstraçãoKeyToolStripMenuItem.Name = "demonstraçãoKeyToolStripMenuItem";
            this.demonstraçãoKeyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.demonstraçãoKeyToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.demonstraçãoKeyToolStripMenuItem.Text = "Demonstração &Key";
            this.demonstraçãoKeyToolStripMenuItem.Click += new System.EventHandler(this.demonstraçãoKeyToolStripMenuItem_Click);
            // 
            // helloWorldToolStripMenuItem
            // 
            this.helloWorldToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_HelloWorld1;
            this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
            this.helloWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.helloWorldToolStripMenuItem.Text = "Hello &World";
            this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
            // 
            // máscaraToolStripMenuItem
            // 
            this.máscaraToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_Mascara;
            this.máscaraToolStripMenuItem.Name = "máscaraToolStripMenuItem";
            this.máscaraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.máscaraToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.máscaraToolStripMenuItem.Text = "&Máscara";
            this.máscaraToolStripMenuItem.Click += new System.EventHandler(this.máscaraToolStripMenuItem_Click);
            // 
            // validaCPFToolStripMenuItem
            // 
            this.validaCPFToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_ValidaCPF;
            this.validaCPFToolStripMenuItem.Name = "validaCPFToolStripMenuItem";
            this.validaCPFToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.validaCPFToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.validaCPFToolStripMenuItem.Text = "Valida &CPF";
            this.validaCPFToolStripMenuItem.Click += new System.EventHandler(this.validaCPFToolStripMenuItem_Click);
            // 
            // válidaCPF2ToolStripMenuItem
            // 
            this.válidaCPF2ToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_ValidaCPF2;
            this.válidaCPF2ToolStripMenuItem.Name = "válidaCPF2ToolStripMenuItem";
            this.válidaCPF2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.válidaCPF2ToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.válidaCPF2ToolStripMenuItem.Text = "Valida C&PF 2";
            this.válidaCPF2ToolStripMenuItem.Click += new System.EventHandler(this.válidaCPF2ToolStripMenuItem_Click);
            // 
            // validaSenhaToolStripMenuItem
            // 
            this.validaSenhaToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Frm_ValidaSenha1;
            this.validaSenhaToolStripMenuItem.Name = "validaSenhaToolStripMenuItem";
            this.validaSenhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.validaSenhaToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.validaSenhaToolStripMenuItem.Text = "Valida &Senha";
            this.validaSenhaToolStripMenuItem.Click += new System.EventHandler(this.validaSenhaToolStripMenuItem_Click);
            // 
            // apagarAbaToolStripMenuItem
            // 
            this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // byteBankToolStripMenuItem
            // 
            this.byteBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.byteBankToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.money;
            this.byteBankToolStripMenuItem.Name = "byteBankToolStripMenuItem";
            this.byteBankToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.byteBankToolStripMenuItem.Text = "ByteBank";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.Cadastros;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::WindowsFormsAlura.Properties.Resources.user;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 26);
            this.toolStripMenuItem1.Text = "Ações";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Application
            // 
            this.Tbc_Application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Application.ImageList = this.imageList_Imagens;
            this.Tbc_Application.Location = new System.Drawing.Point(0, 30);
            this.Tbc_Application.Name = "Tbc_Application";
            this.Tbc_Application.SelectedIndex = 0;
            this.Tbc_Application.Size = new System.Drawing.Size(800, 420);
            this.Tbc_Application.TabIndex = 1;
            this.Tbc_Application.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_Application_MouseDown);
            // 
            // imageList_Imagens
            // 
            this.imageList_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Imagens.ImageStream")));
            this.imageList_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Imagens.Images.SetKeyName(0, "Frm_DemonstracaoKey.png");
            this.imageList_Imagens.Images.SetKeyName(1, "Frm_HelloWorld.png");
            this.imageList_Imagens.Images.SetKeyName(2, "Frm_Mascara.png");
            this.imageList_Imagens.Images.SetKeyName(3, "Frm_ValidaCPF.png");
            this.imageList_Imagens.Images.SetKeyName(4, "Frm_ValidaCPF2.png");
            this.imageList_Imagens.Images.SetKeyName(5, "Frm_ValidaSenha.png");
            this.imageList_Imagens.Images.SetKeyName(6, "folder.png");
            this.imageList_Imagens.Images.SetKeyName(7, "user.png");
            // 
            // Form_Principal_Menu_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Application);
            this.Controls.Add(this.Menu_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_principal;
            this.Name = "Form_Principal_Menu_UserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_principal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonstraçãoKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máscaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaCPFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem válidaCPF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Application;
        private System.Windows.Forms.ImageList imageList_Imagens;
        private System.Windows.Forms.ToolStripMenuItem apagarAbaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byteBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}