namespace AzulBoardGame_PI
{
    partial class TelaMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gboMenu = new System.Windows.Forms.GroupBox();
            this.lblExit = new System.Windows.Forms.LinkLabel();
            this.lblCreditos = new System.Windows.Forms.LinkLabel();
            this.lblVersao = new System.Windows.Forms.LinkLabel();
            this.lblIniciar = new System.Windows.Forms.LinkLabel();
            this.lblVersaoJogo = new System.Windows.Forms.Label();
            this.gboMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitulo.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(59, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(522, 59);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AZUL BOARD GAME";
            // 
            // gboMenu
            // 
            this.gboMenu.BackColor = System.Drawing.Color.Black;
            this.gboMenu.Controls.Add(this.lblExit);
            this.gboMenu.Controls.Add(this.lblCreditos);
            this.gboMenu.Controls.Add(this.lblVersao);
            this.gboMenu.Controls.Add(this.lblIniciar);
            this.gboMenu.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboMenu.ForeColor = System.Drawing.Color.Red;
            this.gboMenu.Location = new System.Drawing.Point(107, 143);
            this.gboMenu.Name = "gboMenu";
            this.gboMenu.Size = new System.Drawing.Size(434, 468);
            this.gboMenu.TabIndex = 1;
            this.gboMenu.TabStop = false;
            this.gboMenu.Text = "MENU";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(176, 322);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(86, 35);
            this.lblExit.TabIndex = 4;
            this.lblExit.TabStop = true;
            this.lblExit.Text = "EXIT";
            this.lblExit.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblExit_LinkClicked);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditos.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(149, 257);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(140, 35);
            this.lblCreditos.TabIndex = 3;
            this.lblCreditos.TabStop = true;
            this.lblCreditos.Text = "CREDITS";
            this.lblCreditos.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCreditos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreditos_LinkClicked);
            this.lblCreditos.MouseLeave += new System.EventHandler(this.lblCreditos_MouseLeave);
            this.lblCreditos.MouseHover += new System.EventHandler(this.lblCreditos_MouseHover);
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(98, 193);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(239, 35);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.TabStop = true;
            this.lblVersao.Text = "GAME VERSION";
            this.lblVersao.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblVersao.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVersao_LinkClicked);
            this.lblVersao.MouseLeave += new System.EventHandler(this.lblVersao_MouseLeave);
            this.lblVersao.MouseHover += new System.EventHandler(this.lblVersao_MouseHover);
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciar.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.Location = new System.Drawing.Point(112, 128);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(212, 35);
            this.lblIniciar.TabIndex = 1;
            this.lblIniciar.TabStop = true;
            this.lblIniciar.Text = "START GAME";
            this.lblIniciar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblIniciar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblIniciar_LinkClicked);
            this.lblIniciar.MouseLeave += new System.EventHandler(this.lblIniciar_MouseLeave);
            this.lblIniciar.MouseHover += new System.EventHandler(this.lblIniciar_MouseHover);
            // 
            // lblVersaoJogo
            // 
            this.lblVersaoJogo.AutoSize = true;
            this.lblVersaoJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersaoJogo.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersaoJogo.ForeColor = System.Drawing.Color.White;
            this.lblVersaoJogo.Location = new System.Drawing.Point(12, 635);
            this.lblVersaoJogo.Name = "lblVersaoJogo";
            this.lblVersaoJogo.Size = new System.Drawing.Size(138, 30);
            this.lblVersaoJogo.TabIndex = 2;
            this.lblVersaoJogo.Text = "Versão: ";
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AzulBoardGame_PI.Properties.Resources.capa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.lblVersaoJogo);
            this.Controls.Add(this.gboMenu);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaMenu";
            this.Load += new System.EventHandler(this.TelaMenu_Load);
            this.gboMenu.ResumeLayout(false);
            this.gboMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gboMenu;
        private System.Windows.Forms.LinkLabel lblIniciar;
        private System.Windows.Forms.LinkLabel lblExit;
        private System.Windows.Forms.LinkLabel lblCreditos;
        private System.Windows.Forms.LinkLabel lblVersao;
        private System.Windows.Forms.Label lblVersaoJogo;
    }
}

