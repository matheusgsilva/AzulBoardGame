using AzulServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Componentes
{
    class MontarTabuleiro
    {
        public void Montar(Form form, int idJogador, string senhaJogador)
        {
            string[] itens = { };
            try
            {
                string dados = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
                dados = dados.Replace("\r", "");

                string[] linhas = dados.Split('\n');
                new Elementos().OcultarPecas(form);
                for (int i = 0; i < linhas.Length - 1; i++)
                {
                    if (linhas[i].Equals("chão")) break;
                    if (linhas[i].Contains(","))
                    {
                        if (!linhas[i].Contains("A") && !linhas[i].Contains("V") && !linhas[i].Contains("P") && !linhas[i].Contains("B"))
                        {
                            itens = linhas[i].Split(',');
                            for (int w = Convert.ToInt32(itens[2]); w > 0; w--)
                            {
                                new Elementos().MontarPecas(form, ("l" + itens[0] + "a" + w).ToString(), "azulejo" + itens[1]);
                            }
                        }
                        else if (linhas[i].Contains("A") || linhas[i].Contains("V") || linhas[i].Contains("P") || linhas[i].Contains("B"))
                        {
                            itens = linhas[i].Split(',');
                            new Elementos().MontarPecas(form, ("p" + itens[0] + "a" + itens[2].Substring(0, 1)).ToString(), "azulejo" + itens[2].Substring(0, 1));
                        }
                    }

                }
                string[] linhasChao = dados.Split('ã');
                string[] data = linhasChao[1].Split('\n');
                new Elementos().OcultarChao(form);
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i].Equals("o")) continue;
                    if (data[i].Contains(","))
                    {
                        itens = data[i].Split(',');
                        new Elementos().MontarPecas(form, ("c" + itens[0]).ToString(), "azulejo" + itens[1]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
