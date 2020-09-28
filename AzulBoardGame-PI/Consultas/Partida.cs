using AzulServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulBoardGame_PI.Consultas
{
    class Partida
    {
        public int id { get; set; }
        public string nome { get; set; }

        public string data { get; set; }

        public string status { get; set; }


        public List<Partida> ListarPartidas(string status)
        {
            try
            {
                string retorno = Jogo.ListarPartidas(status);
                retorno = retorno.Replace("\r", "");
                string[] linhas = retorno.Split('\n');
                List<Partida> list = new List<Partida>();

                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    Partida partida = new Partida();

                    partida.id = Converter(itens[0]);
                    partida.nome = itens[1];
                    partida.data = itens[2];
                    partida.status = itens[3];

                    list.Add(partida);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public int Converter(string number)
        {
            return Convert.ToInt32(number);
        }
    }
}
