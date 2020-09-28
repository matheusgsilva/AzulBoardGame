using AzulBoardGame_PI.Componentes;
using AzulBoardGame_PI.Forms;
using AzulServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulBoardGame_PI
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void lblIniciar_MouseHover(object sender, EventArgs e)
        {
            new EfeitosTela().FontHover(lblIniciar);
        }

        private void lblIniciar_MouseLeave(object sender, EventArgs e)
        {
            new EfeitosTela().FontLeave(lblIniciar);
        }

        private void lblVersao_MouseHover(object sender, EventArgs e)
        {
            new EfeitosTela().FontHover(lblVersao);
        }

        private void lblVersao_MouseLeave(object sender, EventArgs e)
        {
            new EfeitosTela().FontLeave(lblVersao);
        }

        private void lblCreditos_MouseHover(object sender, EventArgs e)
        {
            new EfeitosTela().FontHover(lblCreditos);
        }

        private void lblCreditos_MouseLeave(object sender, EventArgs e)
        {
            new EfeitosTela().FontLeave(lblCreditos);
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            new EfeitosTela().FontHover(lblExit);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            new EfeitosTela().FontLeave(lblExit);
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            lblVersaoJogo.Visible = false;
            Icon = Properties.Resources.icon;
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void lblVersao_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string version = Jogo.Versao;
            lblVersaoJogo.Text = " Versão do Jogo: " + version;
            lblVersaoJogo.Visible = true;
        }

        private void lblIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            TelaConfig f = new TelaConfig();
            f.Closed += (s, args) => Close();
            f.Show();
        }

        private void lblCreditos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCreditos f = new TelaCreditos();
            f.ShowDialog();
        }
    }
}
