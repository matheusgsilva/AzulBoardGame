using AzulBoardGame_PI.Models;
using AzulServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Consultas
{
    class Centro
    {
        public List<AzulejoCentro> LerCentro(int idJogador, string senhaJogador)
        {
            try
            {
                string centro = Jogo.LerCentro(idJogador, senhaJogador);
                centro = centro.Replace("\r", "");
                string[] linhas = centro.Split('\n');

                List<AzulejoCentro> list = new List<AzulejoCentro>();

                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    AzulejoCentro azulejoCentro = new AzulejoCentro();
                    azulejoCentro.id = Converter(itens[0]);
                    azulejoCentro.cor = itens[1];
                    azulejoCentro.quantidade = Converter(itens[2]);
                    azulejoCentro.penalidade = Converter(itens[3]);
                    list.Add(azulejoCentro);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public void MontarCentro(Form form, int idJogador, string senhaJogador)
        {
            try
            {
                int campo = 1, azulejoMenosUm = 1;
                string centro = Jogo.LerCentro(idJogador, senhaJogador);
                centro = centro.Replace("\r", "");
                string[] linhas = centro.Split('\n');
                new Elementos().OcultarCentro(form);
                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    AzulejoCentro azulejoCentro = new AzulejoCentro();
                    azulejoCentro.id = Converter(itens[0]);
                    azulejoCentro.cor = itens[1];
                    azulejoCentro.quantidade = Converter(itens[2]);
                    azulejoCentro.penalidade = Converter(itens[3]);
                    if (!azulejoCentro.quantidade.Equals(0))
                    {
                        for (int i = 0; i < azulejoCentro.quantidade; i++)
                        {
                            var found = form.Controls.Find("centro" + campo, true);
                            if (found.Count() > 0)
                            {
                                if (azulejoCentro.penalidade.Equals(1) && azulejoMenosUm.Equals(1))
                                {
                                    found[0].BackgroundImage = Properties.Resources.azulejo0;
                                    campo++;
                                    azulejoMenosUm--;
                                    i--;
                                    continue;
                                }
                                found[0].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("azulejo" + azulejoCentro.id);
                                campo++;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public int Converter(string numero)
        {
            return Convert.ToInt32(numero);
        }
    }
}
