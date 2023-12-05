﻿namespace WindowsFormsAlura
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
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonstraçãoKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máscaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.válidaCPF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Application = new System.Windows.Forms.TabControl();
            this.imageList_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.apagarAbaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_principal
            // 
            this.Menu_principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.windowsToolStripMenuItem});
            this.Menu_principal.Location = new System.Drawing.Point(0, 0);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Size = new System.Drawing.Size(800, 28);
            this.Menu_principal.TabIndex = 0;
            this.Menu_principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.apagarAbaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
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
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.windowsToolStripMenuItem.Text = "Windows";
            // 
            // Tbc_Application
            // 
            this.Tbc_Application.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Application.ImageList = this.imageList_Imagens;
            this.Tbc_Application.Location = new System.Drawing.Point(0, 28);
            this.Tbc_Application.Name = "Tbc_Application";
            this.Tbc_Application.SelectedIndex = 0;
            this.Tbc_Application.Size = new System.Drawing.Size(800, 422);
            this.Tbc_Application.TabIndex = 1;
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
            // 
            // apagarAbaToolStripMenuItem
            // 
            this.apagarAbaToolStripMenuItem.Name = "apagarAbaToolStripMenuItem";
            this.apagarAbaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.apagarAbaToolStripMenuItem.Text = "Apagar Aba";
            this.apagarAbaToolStripMenuItem.Click += new System.EventHandler(this.apagarAbaToolStripMenuItem_Click);
            // 
            // Form_Principal_Menu_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tbc_Application);
            this.Controls.Add(this.Menu_principal);
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
    }
}