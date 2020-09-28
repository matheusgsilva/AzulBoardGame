using AzulServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulBoardGame_PI.Consultas
{
    class Jogador
    {
        public int id { get; set; }

        public string nome { get; set; }

        public int pontucao { get; set; }

        public string senhaJogador { get; set; }

        public List<Jogador> ListarJogadores(int idPartida)
        {
            try
            {
                string retorno = Jogo.ListarJogadores(idPartida);
                retorno = retorno.Replace("\r", "");
                string[] linhas = retorno.Split('\n');
                List<Jogador> list = new List<Jogador>();

                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    Jogador jogador = new Jogador();

                    jogador.id = Converter(itens[0]);
                    jogador.nome = itens[1];
                    jogador.pontucao = Converter(itens[2]);

                    list.Add(jogador);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public Jogador DetalhesJogador(string result)
        {
            try
            {
                Jogador jogador = new Jogador();
                result = result.Replace("\r\n", "");
                string[] itens = result.Split(',');
                jogador.id = Converter(itens[0]);
                jogador.senhaJogador = itens[1];
                return jogador;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public int Pontuacao(int idPartida, int idJogador)
        {
            try {

                int pontuacao = 0;
                string retorno = Jogo.ListarJogadores(idPartida);
                retorno = retorno.Replace("\r", "");
                string[] linhas = retorno.Split('\n');

                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    if (idJogador.Equals(Converter(itens[0])))
                    {
                        pontuacao = Converter(itens[2]);
                        return pontuacao;
                    }
                }
                return -1;               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return -1;
            }
}

public int Converter(string number)
        {
            return Convert.ToInt32(number);
        }


    }
}