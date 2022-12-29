namespace NotePad_CS
{
    partial class NotePadCS
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditarDataHora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarQuebraDeLinhaAutomatica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExibirBarraDeStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
            this.menuEditar,
            this.menuFormatar,
            this.menuExibir,
            this.menuAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(784, 25);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivoNovo,
            this.menuArquivoNovaJanela,
            this.menuArquivoAbrir,
            this.toolStripSeparator1,
            this.menuArquivoSalvar,
            this.menuArquivoSalvarComo,
            this.toolStripSeparator2,
            this.menuArquivoSair});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(65, 21);
            this.menuArquivo.Text = "Arquivo";
            // 
            // menuArquivoNovo
            // 
            this.menuArquivoNovo.Name = "menuArquivoNovo";
            this.menuArquivoNovo.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoNovo.Text = "Novo";
            this.menuArquivoNovo.Click += new System.EventHandler(this.menuArquivoNovo_Click);
            // 
            // menuArquivoNovaJanela
            // 
            this.menuArquivoNovaJanela.Name = "menuArquivoNovaJanela";
            this.menuArquivoNovaJanela.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoNovaJanela.Text = "Nova Janela";
            this.menuArquivoNovaJanela.Click += new System.EventHandler(this.menuArquivoNovaJanela_Click);
            // 
            // menuArquivoAbrir
            // 
            this.menuArquivoAbrir.Name = "menuArquivoAbrir";
            this.menuArquivoAbrir.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoAbrir.Text = "Abrir";
            this.menuArquivoAbrir.Click += new System.EventHandler(this.menuArquivoAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuArquivoSalvar
            // 
            this.menuArquivoSalvar.Name = "menuArquivoSalvar";
            this.menuArquivoSalvar.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoSalvar.Text = "Salvar";
            this.menuArquivoSalvar.Click += new System.EventHandler(this.menuArquivoSalvar_Click);
            // 
            // menuArquivoSalvarComo
            // 
            this.menuArquivoSalvarComo.Name = "menuArquivoSalvarComo";
            this.menuArquivoSalvarComo.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoSalvarComo.Text = "Salvar Como";
            this.menuArquivoSalvarComo.Click += new System.EventHandler(this.menuArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // menuArquivoSair
            // 
            this.menuArquivoSair.Name = "menuArquivoSair";
            this.menuArquivoSair.Size = new System.Drawing.Size(180, 22);
            this.menuArquivoSair.Text = "Sair";
            this.menuArquivoSair.Click += new System.EventHandler(this.menuArquivoSair_Click);
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarDesfazer,
            this.menuEditarRefazer,
            this.toolStripSeparator3,
            this.menuEditarRecortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.menuEditarExcluir,
            this.toolStripSeparator4,
            this.menuEditarDataHora});
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(54, 21);
            this.menuEditar.Text = "Editar";
            // 
            // menuEditarDesfazer
            // 
            this.menuEditarDesfazer.Name = "menuEditarDesfazer";
            this.menuEditarDesfazer.Size = new System.Drawing.Size(147, 22);
            this.menuEditarDesfazer.Text = "Desfazer";
            // 
            // menuEditarRefazer
            // 
            this.menuEditarRefazer.Name = "menuEditarRefazer";
            this.menuEditarRefazer.Size = new System.Drawing.Size(147, 22);
            this.menuEditarRefazer.Text = "Refazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(144, 6);
            // 
            // menuEditarRecortar
            // 
            this.menuEditarRecortar.Name = "menuEditarRecortar";
            this.menuEditarRecortar.Size = new System.Drawing.Size(147, 22);
            this.menuEditarRecortar.Text = "Recortar";
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(147, 22);
            this.menuEditarCopiar.Text = "Copiar";
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(147, 22);
            this.menuEditarColar.Text = "Colar";
            // 
            // menuEditarExcluir
            // 
            this.menuEditarExcluir.Name = "menuEditarExcluir";
            this.menuEditarExcluir.Size = new System.Drawing.Size(147, 22);
            this.menuEditarExcluir.Text = "Excluir";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(144, 6);
            // 
            // menuEditarDataHora
            // 
            this.menuEditarDataHora.Name = "menuEditarDataHora";
            this.menuEditarDataHora.Size = new System.Drawing.Size(147, 22);
            this.menuEditarDataHora.Text = "Data e Hora";
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormatarQuebraDeLinhaAutomatica,
            this.menuFormatarFonte});
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(73, 21);
            this.menuFormatar.Text = "Formatar";
            // 
            // menuFormatarQuebraDeLinhaAutomatica
            // 
            this.menuFormatarQuebraDeLinhaAutomatica.Name = "menuFormatarQuebraDeLinhaAutomatica";
            this.menuFormatarQuebraDeLinhaAutomatica.Size = new System.Drawing.Size(238, 22);
            this.menuFormatarQuebraDeLinhaAutomatica.Text = "Quebra de linha automática";
            // 
            // menuFormatarFonte
            // 
            this.menuFormatarFonte.Name = "menuFormatarFonte";
            this.menuFormatarFonte.Size = new System.Drawing.Size(238, 22);
            this.menuFormatarFonte.Text = "Fonte";
            // 
            // menuExibir
            // 
            this.menuExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExibirZoom,
            this.menuExibirBarraDeStatus});
            this.menuExibir.Name = "menuExibir";
            this.menuExibir.Size = new System.Drawing.Size(52, 21);
            this.menuExibir.Text = "Exibir";
            // 
            // menuExibirZoom
            // 
            this.menuExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExibirZoomAmpliar,
            this.menuExibirZoomReduzir,
            this.menuExibirZoomRestaurar});
            this.menuExibirZoom.Name = "menuExibirZoom";
            this.menuExibirZoom.Size = new System.Drawing.Size(165, 22);
            this.menuExibirZoom.Text = "Zoom";
            // 
            // menuExibirZoomAmpliar
            // 
            this.menuExibirZoomAmpliar.Name = "menuExibirZoomAmpliar";
            this.menuExibirZoomAmpliar.Size = new System.Drawing.Size(132, 22);
            this.menuExibirZoomAmpliar.Text = "Ampliar";
            // 
            // menuExibirZoomReduzir
            // 
            this.menuExibirZoomReduzir.Name = "menuExibirZoomReduzir";
            this.menuExibirZoomReduzir.Size = new System.Drawing.Size(132, 22);
            this.menuExibirZoomReduzir.Text = "Reduzir";
            // 
            // menuExibirZoomRestaurar
            // 
            this.menuExibirZoomRestaurar.Name = "menuExibirZoomRestaurar";
            this.menuExibirZoomRestaurar.Size = new System.Drawing.Size(132, 22);
            this.menuExibirZoomRestaurar.Text = "Restaurar";
            // 
            // menuExibirBarraDeStatus
            // 
            this.menuExibirBarraDeStatus.Checked = true;
            this.menuExibirBarraDeStatus.CheckOnClick = true;
            this.menuExibirBarraDeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuExibirBarraDeStatus.Name = "menuExibirBarraDeStatus";
            this.menuExibirBarraDeStatus.Size = new System.Drawing.Size(165, 22);
            this.menuExibirBarraDeStatus.Text = "Barra de Status";
            // 
            // menuAjuda
            // 
            this.menuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjudaExibirAjuda,
            this.menuAjudaSobre});
            this.menuAjuda.Name = "menuAjuda";
            this.menuAjuda.Size = new System.Drawing.Size(53, 21);
            this.menuAjuda.Text = "Ajuda";
            // 
            // menuAjudaExibirAjuda
            // 
            this.menuAjudaExibirAjuda.Name = "menuAjudaExibirAjuda";
            this.menuAjudaExibirAjuda.Size = new System.Drawing.Size(198, 22);
            this.menuAjudaExibirAjuda.Text = "Exibir Ajuda";
            // 
            // menuAjudaSobre
            // 
            this.menuAjudaSobre.Name = "menuAjudaSobre";
            this.menuAjudaSobre.Size = new System.Drawing.Size(198, 22);
            this.menuAjudaSobre.Text = "Sobre o NotePad_CS";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(38, 17);
            this.statusBarLabel.Text = "100 %";
            this.statusBarLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 25);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(784, 514);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // NotePadCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "NotePadCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad_CS";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem menuExibir;
        private System.Windows.Forms.ToolStripMenuItem menuAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem menuEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem menuEditarRefazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuEditarDataHora;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarQuebraDeLinhaAutomatica;
        private System.Windows.Forms.ToolStripMenuItem menuFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem menuExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem menuExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem menuExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem menuExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem menuExibirBarraDeStatus;
        private System.Windows.Forms.ToolStripMenuItem menuAjudaExibirAjuda;
        private System.Windows.Forms.ToolStripMenuItem menuAjudaSobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.RichTextBox txtContent;
    }
}

