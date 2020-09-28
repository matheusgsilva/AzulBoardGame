using AzulBoardGame_PI.Consultas;
using AzulServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Forms
{
    public partial class TelaConfig : Form
    {
        public int idPartida { get; set; }

        public string senhaPartida { get; set; }

        public int idJogador { get; set; }

        public string senhaJogador { get; set; }

        public TelaConfig()
        {
            InitializeComponent();  
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
            string[] itens = { "Todas", "Aberta", "Jogando", "Encerrada" };
            foreach (string modo in itens)
                cboSelecao.Items.Add(modo);
            cboSelecao.SelectedIndex = 0;

            pnlDireita.BackgroundImage = Properties.Resources.azul;
            txtNomeJogador.Visible = false;
            txtSenhaPartida.Visible = false;
            btnEntrar.Visible = false;
            lblEntrar.Visible = false;
            lblMensagem.Visible = false;
            btnIniciar.Visible = false;
            lblNomeJogador.Visible = false;
            lblSenhaPartida.Visible = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string result = Jogo.IniciarPartida(idJogador, senhaJogador);

            if (result.Contains("ERRO:Partida não está aberta"))
            {
                Hide();
                TelaTabuleiro f = new TelaTabuleiro(this);
                f.Closed += (s, args) => Close();
                f.Show();
            }
            else if(!result.Contains("ERRO"))
            {
                Hide();
                TelaTabuleiro f = new TelaTabuleiro(this);
                f.Closed += (s, args) => Close();
                f.Show();
            }
            else
            {
                MessageBox.Show(result);
            }

                     
        }

        DataTable table;
        private void btnListar_Click(object sender, EventArgs e)
        {
            string valorCombo = cboSelecao.SelectedItem.ToString();
            List<Partida> lista = new Partida().ListarPartidas(valorCombo.Substring(0, 1));

            table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Data", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dgvPartidas.DefaultCellStyle.ForeColor = Color.Black;

            foreach (Partida partida in lista)
            {
                table.Rows.Add(partida.id, partida.nome, partida.data, partida.status);
            }

            dgvPartidas.DataSource = table;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            TelaCriarPartida t = new TelaCriarPartida();
            t.ShowDialog();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "Nome LIKE '" + txtBusca.Text + "%'";
            dgvPartidas.DataSource = dv;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNomeJogador.TextLength.Equals(0) && !txtSenhaPartida.TextLength.Equals(0) && !idPartida.Equals(0))
                {
                    string result = Jogo.EntrarPartida(idPartida, txtNomeJogador.Text, txtSenhaPartida.Text);
                    if (result.Contains("ERRO"))
                        MessageBox.Show(result);
                    else
                    {
                        lblMensagem.Visible = true;
                        btnIniciar.Visible = true;
                        string[] infos = result.Split(',');
                        idJogador = Convert.ToInt32(infos[0]);
                        senhaJogador = infos[1];
                        senhaPartida = txtSenhaPartida.Text;
                    }
                }
                else
                    MessageBox.Show("Há campos em branco");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void dgvPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlDireita.BackgroundImage = null;
            lblEntrar.Visible = true;
            txtNomeJogador.Visible = true;
            txtSenhaPartida.Visible = true;
            btnEntrar.Visible = true;
            lblSenhaPartida.Visible = true;
            lblNomeJogador.Visible = true;

            try
            {
                if (dgvPartidas.SelectedRows.Count > 1)
                    MessageBox.Show("Selecione somente uma linha");
                else
                {
                    idPartida = Convert.ToInt32(dgvPartidas.SelectedRows[0].Cells[0].Value);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
