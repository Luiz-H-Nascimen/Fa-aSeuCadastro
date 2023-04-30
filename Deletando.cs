using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCadastro
{
    public class Deletando
    {
        private List<Candidatos> ListaDeCandidatos = new List<Candidatos>();

        public Deletando()
        {
            try
            {
                string caminho = "Candidatos.txt";
                string[] colaboradoresDb = File.ReadAllLines(caminho);

                foreach (var cadidatoDb in colaboradoresDb)
                {
                    var propArray = cadidatoDb.Split(',');
                    var cadidato = new Candidatos
                    {
                        Id = Convert.ToInt32(propArray[0]),
                        Nome = propArray[1],
                        Telefone = propArray[2],
                        Salario = Convert.ToDouble(propArray[3]),
                        Email = propArray[4],
                        Profissoes = propArray[5],
                        Idade = Convert.ToInt32(propArray[6])
                    };
                    ListaDeCandidatos.Add(cadidato);
                }

            }
            catch (Exception)
            {

                ListaDeCandidatos = new List<Candidatos>();
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digitou |4|");
            Console.ResetColor();

        }
        public void DeletarCandidato()
        {
            Console.WriteLine("Deletar Candidato;");
            Console.WriteLine();

        excluindo:

            foreach (var c in ListaDeCandidatos)
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

            if (ListaDeCandidatos.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(Id) não CADASTRADO.Tente novamente um (Id) listado nos cadastros!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("<|Enter| Retorna ");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Digite o - Id - do Candidato para Deletar.");
                Console.ResetColor();
                Console.WriteLine("<|Enter| Retorna ");
                Console.WriteLine();
            }


            try
            {
                string imput = Console.ReadLine();
                int opicao = string.IsNullOrWhiteSpace(imput) ? 0 : int.Parse(imput);
                Console.Clear();
                if (opicao == 0)
                    new Menus().MenuInicial();

                var candidatoEscohido = ListaDeCandidatos.Where(c => c.Id == opicao).FirstOrDefault();


                if (candidatoEscohido == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Id não estar CADASTRADO, tente novamente.");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("<|Enter| Retorna ");
                    Console.ReadLine();
                    Console.Clear();
                    DeletarCandidato();
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Deseja EXCLUIR o candidato listado abaixo?");
                Console.ResetColor();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.Write("    Nome: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(candidatoEscohido.Nome);
                Console.ResetColor();
                Console.Write("    Id: ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(candidatoEscohido.Id);
                Console.ResetColor();
                var removendo = ListaDeCandidatos.Where(c => c.Id == opicao).FirstOrDefault();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite |Enter| para confirma:");
                Console.WriteLine("           Digite |5| para retornar:");

                try
                {
                    int retorno = int.Parse(Console.ReadLine());

                    if (retorno == 5)
                    {
                        goto excluindo;
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

                ListaDeCandidatos.Remove(candidatoEscohido);

                File.Delete("Candidatos.txt");

                using (var fluxosaida = new FileStream("Candidatos.txt", FileMode.Append))
                using (var sr = new StreamWriter(fluxosaida))
                {
                    foreach (var item in ListaDeCandidatos)
                    {
                        sr.WriteLine(item.ToString());
                    }

                }


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
            }
            catch 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Opção invalida, Tente novamente digitando apenas NUMEROS");
                Console.ReadLine();
                Console.Clear();
                DeletarCandidato();
            }
            

        menu:;
        }


    }
}


