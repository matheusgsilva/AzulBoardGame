using AzulBoardGame_PI.Componentes;
using AzulBoardGame_PI.Consultas;
using AzulBoardGame_PI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Forms
{
    public partial class TelaTabuleiro : Form
    {
        public int idJogador { get; set; }

        public string senhaJogador { get; set; }

        public int idPartida { get; set; }

        public bool pause { get; set; }

        public bool play { get; set; }

        public bool verPontuacao { get; set; }

        public int pontuacao { get; set; }

        public TelaTabuleiro(TelaConfig telaConfig)
        {
            idJogador = telaConfig.idJogador;
            senhaJogador = telaConfig.senhaJogador;
            idPartida = telaConfig.idPartida;

            InitializeComponent();
            pause = false;
        }
        private void TelaTabuleiro_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            fabrica1.Visible = false;
            fabrica2.Visible = false;
            fabrica3.Visible = false;
            fabrica4.Visible = false;
            fabrica5.Visible = false;
            fabrica6.Visible = false;
            fabrica7.Visible = false;
            fabrica8.Visible = false;
            fabrica9.Visible = false;

            new Fabricas().MontarFabricas(this, idJogador, senhaJogador);
            play = true;
            verPontuacao = true;

            bgw.RunWorkerAsync();
            bgwPontuacao.RunWorkerAsync();
            timer.Start();
        }

        private void lblPause_Click(object sender, EventArgs e)
        {

            if (pause == false)
            {
                pause = true;
                lblPause.Text = "➤";
            }
            else if (pause == true)
            {
                pause = false;
                lblPause.Text = "II";
                bgw.RunWorkerAsync();
                bgwPontuacao.RunWorkerAsync();
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            
            RealizarJogadas realizarJogadas = new RealizarJogadas();
            MontarTabuleiro montarTabuleiro = new MontarTabuleiro();
            Centro centro = new Centro();
            Fabricas fabricas = new Fabricas();

            if (pause == false)
            {
                string[] dados = new VerificarVez().Verificar(idJogador, senhaJogador);
                if (dados != null)
                {
                    if (Convert.ToInt32(dados[1]).Equals(idJogador))
                    {
                        realizarJogadas.PreparaJogadas(idJogador, senhaJogador);
                        montarTabuleiro.Montar(this, idJogador, senhaJogador);
                        centro.MontarCentro(this, idJogador, senhaJogador);
                        fabricas.MontarFabricas(this, idJogador, senhaJogador);
                    }
                    else
                        Thread.Sleep(1000);
                }
            }
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(pause == false)
                bgw.RunWorkerAsync();
        }

        private void bgwPontuacao_DoWork(object sender, DoWorkEventArgs e)
        {
            if (pause == false)
            {
                Thread.Sleep(5000);

                pontuacao = new Jogador().Pontuacao(idPartida, idJogador);

            }
        }

        private void bgwPontuacao_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (pause == false)
                bgwPontuacao.RunWorkerAsync();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(pause == false)
                lblPontuacao.Text = "PONTUACÃO: " + (pontuacao.Equals(-1) ? 0 : pontuacao);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            TelaMenu f = new TelaMenu();
            f.Closed += (s, args) => Close();
            f.Show();
        }
    }
}
