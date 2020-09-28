using AzulServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzulBoardGame_PI.Componentes
{
    class VerificarVez
    {
        public string[] Verificar(int idJogador, string senha)
        {
            try
            {
                string result = Jogo.VerificarVez(idJogador, senha);
                if (!result.Contains("ERRO"))
                {
                    result = result.Replace("\r", "");
                    string[] linhas = result.Split('\n');

                    string[] itens = linhas[0].Split(',');

                    return itens;
                }
                else
                    return null;
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
