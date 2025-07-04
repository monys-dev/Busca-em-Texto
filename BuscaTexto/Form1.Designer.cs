﻿using System.Windows.Forms;

namespace BuscaTexto {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubstituir = new System.Windows.Forms.ToolStripMenuItem();
            this.btMtdPesquisa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoyerMoore = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForcaBruta = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKMP = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRabinKarp = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaseSensitive = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCoringa = new System.Windows.Forms.ToolStripMenuItem();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.OPFile = new System.Windows.Forms.OpenFileDialog();
            this.SVFile = new System.Windows.Forms.SaveFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAjuda,
            this.btnArquivo,
            this.btnPesquisar,
            this.btnSubstituir,
            this.btMtdPesquisa,
            this.configuraçõesToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(756, 30);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // btnAjuda
            // 
            this.btnAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSobre});
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(62, 26);
            this.btnAjuda.Text = "A&juda";
            // 
            // btnSobre
            // 
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.btnSobre.Size = new System.Drawing.Size(186, 26);
            this.btnSobre.Text = "S&obre...";
            this.btnSobre.Click += new System.EventHandler(this.clickSobre);
            // 
            // btnArquivo
            // 
            this.btnArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnAbrir,
            this.btnSalvar,
            this.btnSalvarComo,
            this.toolStripMenuItem1,
            this.btnSair});
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(75, 26);
            this.btnArquivo.Text = "&Arquivo";
            // 
            // btnNovo
            // 
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnNovo.Size = new System.Drawing.Size(264, 26);
            this.btnNovo.Text = "&Novo";
            this.btnNovo.Click += new System.EventHandler(this.clickNovo);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnAbrir.Size = new System.Drawing.Size(264, 26);
            this.btnAbrir.Text = "A&brir";
            this.btnAbrir.Click += new System.EventHandler(this.clickAbrir);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSalvar.Size = new System.Drawing.Size(264, 26);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.clickSalvar);
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.btnSalvarComo.Size = new System.Drawing.Size(264, 26);
            this.btnSalvarComo.Text = "Salvar como";
            this.btnSalvarComo.Click += new System.EventHandler(this.clickSalvarComo);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(261, 6);
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnSair.Size = new System.Drawing.Size(264, 26);
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.clickSair);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.btnPesquisar.Size = new System.Drawing.Size(84, 26);
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.clickPesquisar);
            // 
            // btnSubstituir
            // 
            this.btnSubstituir.Name = "btnSubstituir";
            this.btnSubstituir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.btnSubstituir.Size = new System.Drawing.Size(85, 26);
            this.btnSubstituir.Text = "Substituir";
            this.btnSubstituir.Click += new System.EventHandler(this.clickSubstituir);
            // 
            // btMtdPesquisa
            // 
            this.btMtdPesquisa.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBoyerMoore,
            this.btnForcaBruta,
            this.btnKMP,
            this.btnRabinKarp});
            this.btMtdPesquisa.Name = "btMtdPesquisa";
            this.btMtdPesquisa.Size = new System.Drawing.Size(157, 26);
            this.btMtdPesquisa.Text = "&Método de Pesquisa";
            // 
            // btnBoyerMoore
            // 
            this.btnBoyerMoore.Checked = true;
            this.btnBoyerMoore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnBoyerMoore.Name = "btnBoyerMoore";
            this.btnBoyerMoore.Size = new System.Drawing.Size(178, 26);
            this.btnBoyerMoore.Text = "Boyer Moore";
            this.btnBoyerMoore.Click += new System.EventHandler(this.clickBoyerMoore);
            // 
            // btnForcaBruta
            // 
            this.btnForcaBruta.Name = "btnForcaBruta";
            this.btnForcaBruta.Size = new System.Drawing.Size(178, 26);
            this.btnForcaBruta.Text = "Força Bruta";
            this.btnForcaBruta.Click += new System.EventHandler(this.clickForcaBruta);
            // 
            // btnKMP
            // 
            this.btnKMP.Name = "btnKMP";
            this.btnKMP.Size = new System.Drawing.Size(178, 26);
            this.btnKMP.Text = "KMP";
            this.btnKMP.Click += new System.EventHandler(this.clickKMP);
            // 
            // btnRabinKarp
            // 
            this.btnRabinKarp.Name = "btnRabinKarp";
            this.btnRabinKarp.Size = new System.Drawing.Size(178, 26);
            this.btnRabinKarp.Text = "Rabin Karp";
            this.btnRabinKarp.Click += new System.EventHandler(this.clickRabinKarp);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCaseSensitive,
            this.btnCoringa});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // btnCaseSensitive
            // 
            this.btnCaseSensitive.Name = "btnCaseSensitive";
            this.btnCaseSensitive.Size = new System.Drawing.Size(201, 26);
            this.btnCaseSensitive.Text = "Case sensitive";
            this.btnCaseSensitive.Click += new System.EventHandler(this.clickCaseSensitive);
            // 
            // btnCoringa
            // 
            this.btnCoringa.Name = "btnCoringa";
            this.btnCoringa.Size = new System.Drawing.Size(201, 26);
            this.btnCoringa.Text = "Caracter coringa";
            this.btnCoringa.Click += new System.EventHandler(this.clickCoringa);
            // 
            // texto
            // 
            this.texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(0, 30);
            this.texto.Margin = new System.Windows.Forms.Padding(4);
            this.texto.Name = "texto";
            this.texto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.texto.Size = new System.Drawing.Size(756, 529);
            this.texto.TabIndex = 1;
            this.texto.Text = "";
            // 
            // OPFile
            // 
            this.OPFile.DefaultExt = "txt | rtf";
            this.OPFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            this.OPFile.Title = "Selecione o Arquivo de texto";
            // 
            // SVFile
            // 
            this.SVFile.DefaultExt = "txt | rtf";
            this.SVFile.Filter = "Text Files (*.txt)|*.txt|Rich Text Files (*.rtf)|*.rtf";
            this.SVFile.Title = "Defina local para salvar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 559);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalho Prático - Busca em Texto 2025.1";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btnArquivo;
        private System.Windows.Forms.ToolStripMenuItem btnNovo;
        private System.Windows.Forms.ToolStripMenuItem btnAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisar;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.ToolStripMenuItem btnAjuda;
        private System.Windows.Forms.ToolStripMenuItem btnSobre;
        private System.Windows.Forms.ToolStripMenuItem btMtdPesquisa;
        private System.Windows.Forms.ToolStripMenuItem btnBoyerMoore;
        private System.Windows.Forms.ToolStripMenuItem btnForcaBruta;
        private System.Windows.Forms.ToolStripMenuItem btnKMP;
        private System.Windows.Forms.ToolStripMenuItem btnRabinKarp;
        private System.Windows.Forms.OpenFileDialog OPFile;
        private SaveFileDialog SVFile;
        private ToolStripMenuItem btnSalvar;
        private ToolStripMenuItem btnSalvarComo;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem btnCaseSensitive;
        private ToolStripMenuItem btnCoringa;
        private ToolStripMenuItem btnSubstituir;
    }
}

