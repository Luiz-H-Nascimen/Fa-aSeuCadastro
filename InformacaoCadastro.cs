using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Threading.Channels;
using System.Text.RegularExpressions;

namespace SeuCadastro
{
    partial class Program
    {

        static void InformacaoDeCadastro(List<Candidatos> listaDeCandidatos)
        
        {
        inicioinfo:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digitou |2|");
            Console.ResetColor();
        inicioinfo2:
            Console.WriteLine("Candidatos Cadastrados;");
            Console.WriteLine();

        

            foreach (var c in listaDeCandidatos)
            {
                Console.Write("    Id: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(c.Id);
                Console.ResetColor();
                Console.Write("    Nome: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(c.Nome);
                Console.ResetColor();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite o - Id - do Candidato pra mais detalhes.");
            Console.ResetColor();
            Console.WriteLine("<|Enter| Retorna ");
            Console.WriteLine();

            try
            {

                string imput = Console.ReadLine();
                int opicao = string.IsNullOrWhiteSpace(imput) ? 0 : int.Parse(imput);
                Console.Clear();
                if (opicao == 0)
                    goto retorno;

                
                var dadoscompleto = listaDeCandidatos.Where(c => c.Id == opicao).FirstOrDefault();

                

                if (dadoscompleto == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Id não estar CADASTRADO, tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("<|Enter| Retorna ");
                    Console.ReadLine();
                    Console.Clear();
                    goto inicioinfo2;
                }



                Console.Clear();
                Console.WriteLine();
                Console.Write("Id: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Id);
                Console.ResetColor();

                Console.Write("Nome: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Nome);
                Console.ResetColor();

                Console.Write("Idade: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Idade);
                Console.ResetColor();

                Console.Write("Telefone: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Telefone);
                Console.ResetColor();

                Console.Write("E-mail: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Email);
                Console.ResetColor();

                Console.Write("Profissão: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Profissoes);
                Console.ResetColor();

                Console.Write("Salario: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(dadoscompleto.Salario);
                Console.ResetColor();

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("<|Enter| Retorna ");
                Console.ReadLine();
                Console.Clear();

                goto inicioinfo2;
            }
            catch 
            {
                Console.Clear();
                Console.WriteLine(  "Opição invalida, Digite apenas numeros");
                Console.ReadLine();
                Console.Clear();
                goto inicioinfo2;
            }
        retorno:;
        }
    }
}
