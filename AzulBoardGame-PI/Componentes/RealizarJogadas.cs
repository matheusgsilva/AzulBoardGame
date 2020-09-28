using AzulBoardGame_PI.Consultas;
using AzulBoardGame_PI.Forms;
using AzulBoardGame_PI.Models;
using AzulServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AzulBoardGame_PI.Componentes
{
    class RealizarJogadas
    {
        public bool pula { get; set; }

        public ArrayList linhas { get; set; }

        public int contador { get; set; }

        public int verificaEmboscada { get; set; }

        public void PreparaJogadas(int idJogador, string senhaJogador)
        {
            List<AzulejoFabrica> azulejoFabricas = new Fabricas().LerFabricas(idJogador, senhaJogador);
            List<AzulejoCentro> azulejoCentros = new Centro().LerCentro(idJogador, senhaJogador);
            List<Modelo> listaModeloIncompletos = Azulejos(idJogador, senhaJogador);
            pula = false;
            contador = 0;
            Jogar(listaModeloIncompletos, azulejoFabricas, azulejoCentros, idJogador, senhaJogador);
        }

        public void Jogar(List<Modelo> listaModeloIncompletos, List<AzulejoFabrica> azulejoFabricas, List<AzulejoCentro> azulejoCentros, int idJogador, string senhaJogador)
        {
            try
            {
                if (!listaModeloIncompletos.Count.Equals(0) && pula == false)
                {
                    if (!azulejoFabricas.Count.Equals(0))
                    {
                        string jogar = "jogar";
                        for (int i = 0; i < listaModeloIncompletos.Count; i++)
                        {
                            List<AzulejoFabrica> azulejosF = azulejoFabricas.Select(s => s).Where(s => s.idAzulejo.Equals(Convert.ToInt32(listaModeloIncompletos[i].idAzulejo)) && s.quantidade <= Convert.ToInt32(listaModeloIncompletos[i].quantidade)).OrderByDescending(s => s.quantidade).ToList();
                            if (!azulejosF.Count.Equals(0))
                            {
                                jogar = Jogo.Jogar(idJogador, senhaJogador, "F", azulejosF.First().idFabrica, azulejosF.First().idAzulejo, listaModeloIncompletos[i].linha);
                                if (jogar.Contains("ERRO")) continue;
                                else return;
                            }
                            else
                                continue;
                        }
                        if (jogar.Contains("jogar") || jogar.Contains("ERRO"))
                        {
                            pula = true;
                            Jogar(listaModeloIncompletos, azulejoFabricas, azulejoCentros, idJogador, senhaJogador);
                        }
                        else return;
                    }
                    else if (azulejoFabricas.Count.Equals(0) && !azulejoCentros.Count.Equals(0))
                    {
                        string jogar = "jogar";
                        for (int i = 0; i < listaModeloIncompletos.Count; i++)
                        {
                            List<AzulejoCentro> azulejosC = azulejoCentros.Select(s => s).Where(s => s.id.Equals(Convert.ToInt32(listaModeloIncompletos[i].idAzulejo)) && !s.quantidade.Equals(0) && s.quantidade <= Convert.ToInt32(listaModeloIncompletos[i].quantidade)).OrderByDescending(s => s.quantidade).ToList();
                            if (!azulejosC.Count.Equals(0))
                            {
                                jogar = Jogo.Jogar(idJogador, senhaJogador, "C", 0, azulejosC.First().id, listaModeloIncompletos[i].linha);
                                if (jogar.Contains("ERRO")) continue;
                                else return;
                            }
                            else
                                continue;

                        }
                        if (jogar.Contains("jogar") || jogar.Contains("ERRO"))
                        {
                            pula = true;
                            Jogar(listaModeloIncompletos, azulejoFabricas, azulejoCentros, idJogador, senhaJogador);
                        }
                        else return;
                    }
                }
                else
                {
                    if (!azulejoFabricas.Count.Equals(0))
                    {
                        string jogar = "jogar";

                        for (int linha = 0; linha < linhas.Count; linha++)
                        {
                            List<AzulejoFabrica> listaf = azulejoFabricas.Select(s => s).Where(s => s.quantidade <= (Convert.ToInt32(linhas[linha]) + contador)).OrderByDescending(s => s.quantidade).ToList();
                            if (listaf.Count.Equals(0)) continue;
                            else
                            {
                                foreach (AzulejoFabrica azulejoFabrica in listaf)
                                {
                                    jogar = Jogo.Jogar(idJogador, senhaJogador, "F", azulejoFabrica.idFabrica, azulejoFabrica.idAzulejo, Convert.ToInt32(linhas[linha]));
                                    if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                    {
                                        verificaEmboscada = 0;
                                        contador = 0;
                                        break;
                                    }
                                    verificaEmboscada++;
                                }
                                if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                {
                                    verificaEmboscada = 0;
                                    contador = 0;
                                    break;
                                }
                                else if (verificaEmboscada > (linhas.Count * listaf.Count))
                                {
                                    jogar = Jogo.Jogar(idJogador, senhaJogador, "F", listaf.First().idFabrica, listaf.First().idAzulejo, 0);
                                    if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                    {
                                        verificaEmboscada = 0;
                                        contador = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        if (jogar.Contains("jogar") || jogar.Contains("ERRO"))
                        {
                            contador++;
                            Jogar(listaModeloIncompletos, azulejoFabricas, azulejoCentros, idJogador, senhaJogador);
                        }
                        pula = false;
                    }
                    else if (azulejoFabricas.Count.Equals(0) && !azulejoCentros.Count.Equals(0))
                    {
                        string jogar = "jogar";

                        for (int linha = 0; linha < linhas.Count; linha++)
                        {
                            List<AzulejoCentro> listaC = azulejoCentros.Select(s => s).Where(s => s.quantidade <= (Convert.ToInt32(linhas[linha]) + contador) && !s.quantidade.Equals(0)).OrderByDescending(s => s.quantidade).ToList();
                            if (listaC.Count.Equals(0)) continue;
                            else
                            {
                                foreach (AzulejoCentro azulejoCentro in listaC)
                                {
                                    jogar = Jogo.Jogar(idJogador, senhaJogador, "C", 0, azulejoCentro.id, Convert.ToInt32(linhas[linha]));
                                    if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                    {
                                        verificaEmboscada = 0;
                                        contador = 0;
                                        break;
                                    }
                                    verificaEmboscada++;
                                }
                                if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                {
                                    verificaEmboscada = 0;
                                    contador = 0;
                                    break;
                                }
                                else if (verificaEmboscada > (linhas.Count * listaC.Count))
                                {
                                    jogar = Jogo.Jogar(idJogador, senhaJogador, "C", 0, listaC.First().id, 0);
                                    if (!jogar.Contains("jogar") && !jogar.Contains("ERRO"))
                                    {
                                        verificaEmboscada = 0;
                                        contador = 0;
                                        break;
                                    }
                                }
                            }
                        }
                        if (jogar.Contains("jogar") || jogar.Contains("ERRO"))
                        {
                            contador++;
                            Jogar(listaModeloIncompletos, azulejoFabricas, azulejoCentros, idJogador, senhaJogador);
                        }
                        pula = false;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public List<Modelo> Azulejos(int idJogador, string senhaJogador)
        {
            try
            {
                linhas = new ArrayList
                {
                    1,
                    2,
                    3,
                    4,
                    5
                };
                string dados = Jogo.LerTabuleiro(idJogador, senhaJogador, idJogador);
                dados = dados.Replace("\r", "");
                string[] modelo = dados.Split('p');
                string[] linhasModelo = modelo[0].Split('\n');
                List<Modelo> listaModeloIncompletos = new List<Modelo>();
                for (int i = 0; i < linhasModelo.Length - 1; i++)
                {
                    if (linhasModelo[i].Contains("modelo")) continue;
                    string[] itens = linhasModelo[i].Split(',');

                    if (itens[0].Equals(itens[2]))
                    {

                        for (int j = 0; j < linhas.Count; j++)
                        {
                            if (Convert.ToInt32(linhas[j]).Equals(Convert.ToInt32(itens[0])))
                                linhas.RemoveAt(j);
                        }

                    }  
                    else if (!itens[0].Equals(itens[2]))
                    {
                        Modelo m = new Modelo
                        {
                            linha = Convert.ToInt32(itens[0]),
                            idAzulejo = Convert.ToInt32(itens[1]),
                            quantidade = Convert.ToInt32(itens[0]) - Convert.ToInt32(itens[2])
                        };
                        listaModeloIncompletos.Add(m);
                    }
                }
                return listaModeloIncompletos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }
        }
    }
}
