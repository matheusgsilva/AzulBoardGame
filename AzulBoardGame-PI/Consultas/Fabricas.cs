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
    class Fabricas
    {
        public List<AzulejoFabrica> LerFabricas(int idJogador, string senhaJogador)
        {
            try
            {
                string fabricas = Jogo.LerFabricas(idJogador, senhaJogador);
                fabricas = fabricas.Replace("\r", "");
                string[] linhas = fabricas.Split('\n');

                List<AzulejoFabrica> list = new List<AzulejoFabrica>();

                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    AzulejoFabrica azulejoFabrica = new AzulejoFabrica();

                    azulejoFabrica.idFabrica = Converter(itens[0]);
                    azulejoFabrica.idAzulejo = Converter(itens[1]);
                    azulejoFabrica.cor = itens[2];
                    azulejoFabrica.quantidade = Converter(itens[3]);
                    list.Add(azulejoFabrica);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return null;
            }
        }

        public void MontarFabricas(Form form, int idJogador, string senhaJogador)
        {
            try
            {
                int contador = 0;
                string fabricas = Jogo.LerFabricas(idJogador, senhaJogador);
                fabricas = fabricas.Replace("\r", "");
                string[] linhas = fabricas.Split('\n');
                new Elementos().OcultarFabricas(form);
                foreach (string s in linhas)
                {
                    if (s.Equals(""))
                        break;
                    string[] itens = s.Split(',');
                    AzulejoFabrica azulejoFabrica = new AzulejoFabrica();

                    azulejoFabrica.idFabrica = Converter(itens[0]);
                    azulejoFabrica.idAzulejo = Converter(itens[1]);
                    azulejoFabrica.cor = itens[2];
                    azulejoFabrica.quantidade = Converter(itens[3]);

                    var found = form.Controls.Find("fabrica" + azulejoFabrica.idFabrica, true);
                    if (found.Count() > 0)
                    {
                       
                        if (found[0].Visible == false)
                            found[0].Visible = true;
                        for (int i = 0; i < azulejoFabrica.quantidade; i++)
                        {
                            contador++;
                            var control = form.Controls.Find("p" + contador, true);
                            if (control.Count() > 0)
                            {
                                control[0].BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("azulejo" + azulejoFabrica.idAzulejo);
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
