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
    public partial class TelaCriarPartida : Form
    {
        public int id { get; set; }
        public string senha { get; set; }
        public TelaCriarPartida()
        {
            InitializeComponent();
        }

        private void TelaCriarPartida_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.icon;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (txtNomePartida.TextLength == 0 && txtSenhaPartida.TextLength == 0)
                MessageBox.Show("Há Campos em Baranco!");
            else
            {
                string result = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
                if (result.Contains("ERRO"))
                    MessageBox.Show(result);
                else
                {
                    id = Convert.ToInt32(result);
                    senha = txtSenhaPartida.Text;
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
