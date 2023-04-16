using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Collections.Generic;

namespace SeuCadastro
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Candidatos> listaCandidatos = new List<Candidatos>();
        start:
            try
            {
                inicio:
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Olá,seja BEM VINDO");
                Console.WriteLine();
            inicio2:
                Console.WriteLine("Temos Vaga de EMPREGO para:");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("(Pedreiro, Carpinteiro ou Eletrecista)");
                Console.ResetColor();
                int Opicao = 0;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine();
                Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                Console.WriteLine("'   |1|. Cadrastar                '");
                Console.WriteLine("'   |2|. Informações do cadastro  '");
                Console.WriteLine("'   |3|. Alterar Cadastro         '");
                Console.WriteLine("'   |4|. Deletar Cadastro         '");
                Console.WriteLine("'   |5|. Sair                     '");
                Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                Console.WriteLine();
                Console.ResetColor();
                Opicao = int.Parse(Console.ReadLine());
                

                switch (Opicao)
                {
                    case 1:
                        listaCandidatos = new Cadastro().Cadastrar(listaCandidatos);
                        
                        goto inicio2;
                        //break;
                    case 2:
                        InformacaoDeCadastro(listaCandidatos);
                        goto inicio2;
                        //break;
                    case 3:
                        Alterar(listaCandidatos);
                        Console.Clear();
                        goto inicio2;
                        //break;
                    case 4:
                        Deletar(listaCandidatos);
                        Console.Clear();
                        goto inicio2;
                    //break;

                    case 5:
                        {
                            //Console.Clear();
                            //Console.WriteLine("Digitou |3| > Sair.");
                            //Console.WriteLine();
                            //Console.WriteLine("Deseja realmente sair?");
                            //Console.WriteLine("|1|Sim  ou  |0|Não");
                            //Console.Clear();
                            //Console.ReadLine();

                            return;
                        }



                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção invalida. Tente outras opções! |1|,|2|,|3|,|4| ou |5|.");
                        Console.ResetColor();
                        Console.WriteLine("Digite |Enter| para retornar.");
                        Console.ReadLine();
                        goto inicio2;
                        //break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                goto start;
            }
        finaliza:;
        }
    }
}