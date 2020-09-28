namespace AzulBoardGame_PI.Forms
{
    partial class TelaConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConfig));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblEntrar = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.pnlPartida = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.cboSelecao = new System.Windows.Forms.ComboBox();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblEncontrar = new System.Windows.Forms.Label();
            this.pnlDireita.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(431, 78);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(522, 59);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "AZUL BOARD GAME";
            // 
            // pnlDireita
            // 
            this.pnlDireita.BackColor = System.Drawing.Color.Transparent;
            this.pnlDireita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDireita.Controls.Add(this.lblMensagem);
            this.pnlDireita.Controls.Add(this.lblEntrar);
            this.pnlDireita.Controls.Add(this.btnIniciar);
            this.pnlDireita.Controls.Add(this.btnEntrar);
            this.pnlDireita.Controls.Add(this.txtSenhaPartida);
            this.pnlDireita.Controls.Add(this.lblSenhaPartida);
            this.pnlDireita.Controls.Add(this.txtNomeJogador);
            this.pnlDireita.Controls.Add(this.lblNomeJogador);
            this.pnlDireita.Location = new System.Drawing.Point(723, 161);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(604, 653);
            this.pnlDireita.TabIndex = 7;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMensagem.Location = new System.Drawing.Point(14, 459);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(577, 41);
            this.lblMensagem.TabIndex = 14;
            this.lblMensagem.Text = "Boa Sorte! Inicie a Partida!";
            // 
            // lblEntrar
            // 
            this.lblEntrar.AutoSize = true;
            this.lblEntrar.BackColor = System.Drawing.Color.Blue;
            this.lblEntrar.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrar.ForeColor = System.Drawing.Color.Black;
            this.lblEntrar.Location = new System.Drawing.Point(119, 9);
            this.lblEntrar.Name = "lblEntrar";
            this.lblEntrar.Size = new System.Drawing.Size(360, 36);
            this.lblEntrar.TabIndex = 13;
            this.lblEntrar.Text = "Entrar na Partida";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIniciar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnIniciar.Location = new System.Drawing.Point(171, 564);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(276, 39);
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEntrar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.Location = new System.Drawing.Point(171, 325);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(276, 39);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.txtSenhaPartida.Location = new System.Drawing.Point(139, 244);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(332, 39);
            this.txtSenhaPartida.TabIndex = 9;
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSenhaPartida.Location = new System.Drawing.Point(181, 215);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(254, 26);
            this.lblSenhaPartida.TabIndex = 8;
            this.lblSenhaPartida.Text = "Senha da Partida:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.txtNomeJogador.Location = new System.Drawing.Point(139, 105);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(332, 39);
            this.txtNomeJogador.TabIndex = 7;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNomeJogador.Location = new System.Drawing.Point(181, 76);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(242, 26);
            this.lblNomeJogador.TabIndex = 6;
            this.lblNomeJogador.Text = "Nome do Jogador:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.pnlPartida);
            this.panel1.Controls.Add(this.cboSelecao);
            this.panel1.Controls.Add(this.lblSelecione);
            this.panel1.Controls.Add(this.lblEncontrar);
            this.panel1.Location = new System.Drawing.Point(58, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 653);
            this.panel1.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnListar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(443, 149);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(211, 39);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "LISTAR PARTIDAS";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pnlPartida
            // 
            this.pnlPartida.BackColor = System.Drawing.Color.Navy;
            this.pnlPartida.Controls.Add(this.btnCriar);
            this.pnlPartida.Controls.Add(this.lblBuscar);
            this.pnlPartida.Controls.Add(this.txtBusca);
            this.pnlPartida.Controls.Add(this.dgvPartidas);
            this.pnlPartida.ForeColor = System.Drawing.Color.White;
            this.pnlPartida.Location = new System.Drawing.Point(5, 194);
            this.pnlPartida.Name = "pnlPartida";
            this.pnlPartida.Size = new System.Drawing.Size(649, 453);
            this.pnlPartida.TabIndex = 9;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCriar.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(3, 9);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(211, 39);
            this.btnCriar.TabIndex = 11;
            this.btnCriar.Text = "NOVA PARTIDA";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(280, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(116, 26);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.txtBusca.Location = new System.Drawing.Point(399, 8);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(247, 39);
            this.txtBusca.TabIndex = 1;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // dgvPartidas
            // 
            this.dgvPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartidas.GridColor = System.Drawing.Color.Black;
            this.dgvPartidas.Location = new System.Drawing.Point(3, 59);
            this.dgvPartidas.Name = "dgvPartidas";
            this.dgvPartidas.Size = new System.Drawing.Size(643, 391);
            this.dgvPartidas.TabIndex = 0;
            this.dgvPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPartidas_CellClick);
            // 
            // cboSelecao
            // 
            this.cboSelecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelecao.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold);
            this.cboSelecao.FormattingEnabled = true;
            this.cboSelecao.Location = new System.Drawing.Point(155, 88);
            this.cboSelecao.Name = "cboSelecao";
            this.cboSelecao.Size = new System.Drawing.Size(243, 34);
            this.cboSelecao.TabIndex = 8;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecione.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSelecione.Location = new System.Drawing.Point(3, 91);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(156, 26);
            this.lblSelecione.TabIndex = 7;
            this.lblSelecione.Text = "Selecione: ";
            // 
            // lblEncontrar
            // 
            this.lblEncontrar.AutoSize = true;
            this.lblEncontrar.BackColor = System.Drawing.Color.Blue;
            this.lblEncontrar.Font = new System.Drawing.Font("Algerian", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrar.ForeColor = System.Drawing.Color.Black;
            this.lblEncontrar.Location = new System.Drawing.Point(149, 9);
            this.lblEncontrar.Name = "lblEncontrar";
            this.lblEncontrar.Size = new System.Drawing.Size(367, 36);
            this.lblEncontrar.TabIndex = 4;
            this.lblEncontrar.Text = "Encontrar Partida";
            // 
            // TelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1384, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "TelaConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConfig";
            this.Load += new System.EventHandler(this.TelaConfig_Load);
            this.pnlDireita.ResumeLayout(false);
            this.pnlDireita.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPartida.ResumeLayout(false);
            this.pnlPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEncontrar;
        private System.Windows.Forms.ComboBox cboSelecao;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Panel pnlPartida;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblEntrar;
    }
}