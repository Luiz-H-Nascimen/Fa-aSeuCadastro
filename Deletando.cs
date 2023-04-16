using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCadastro
{
    partial class Program
    {
        static void Deletar(List<Candidatos> listaDeCandidatos)

        {
        excluindo:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digitou |3|");
            Console.ResetColor();
            excluindo2:
            Console.WriteLine("Deletar Candidato;");
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
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite o - Id - do Candidato para Deletar.");
            Console.ResetColor();
            Console.WriteLine("Digite |Enter| para Retorna ");
            Console.WriteLine();


            int selecionado = int.Parse(Console.ReadLine());
            if(selecionado == 0)
            {
                goto menu;
            }
            var candidatoEscolhido = listaDeCandidatos.Where(c => c.Id == selecionado).FirstOrDefault();

            if (candidatoEscolhido == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("(Id) não CADASTRADO.Tente novamente um (Id) listado nos cadastros!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Digite |Enter| para retornar.");
                Console.ReadLine();
                Console.Clear();

                goto excluindo2;
            }

            Console.Clear() ;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Deseja EXCLUIR o candidato listado abaixo?");
            Console.ResetColor();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("    Nome: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(candidatoEscolhido.Nome);
            Console.ResetColor();
            Console.Write("    Id: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(candidatoEscolhido.Id);
            Console.ResetColor();
            var removendo = listaDeCandidatos.Where(c => c.Id == selecionado).FirstOrDefault();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite |Enter| para confirma:");
            Console.WriteLine("           Digite |0| para retornar:");
            
            

            try 
            {
                int retorno = int.Parse(Console.ReadLine());
                Console.Clear();
                if (retorno == 0)
                { 
                    goto excluindo2;
                }
                else
                {
                    goto removendo;
                }
            }
            catch
            {
                goto removendo;
            }

             removendo:
            listaDeCandidatos.Remove(candidatoEscolhido);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("      Candidato Deletado!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Tecle |Enter| para retornar ao menu inicial.");
            Console.ReadLine();
            Console.Clear();

        menu:;
        }


    }
}


