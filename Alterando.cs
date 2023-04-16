using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeuCadastro
{
    partial class Program
    {
        static void Alterar(List<Candidatos> listaDeCandidatos)

        {
            var nome = string.Empty;
            string telefone = string.Empty;
            string email = string.Empty;
            var idade = 0;
            string profissoes = string.Empty;
            Random idaleatorio = new Random();
            var id = idaleatorio.Next(1000);
            double salario = 1500;

            List<Candidatos> listaantiga = new List<Candidatos>();
            Candidatos antigocand = new Candidatos();
            
        alterando:
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Digitou |3|");
                Console.ResetColor();
            alterando2:
                Console.WriteLine("Alterar Cadastro do Candidato;");
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
                Console.WriteLine("Digite o - Id - do Candidato para alterar informações.");
                Console.ResetColor();
                Console.WriteLine("Digite |Enter| para Retorna ");
                Console.WriteLine();



                try
                {
                    int escolhido = int.Parse(Console.ReadLine());
                    Console.Clear();
                    var candidatoalterado = listaDeCandidatos.Where(c => c.Id == escolhido).FirstOrDefault();

                    if (candidatoalterado != null)
                    {
                    opçãoletra:    
                        Console.WriteLine("Digete para alterara a opção:");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|N|");
                        Console.ResetColor();
                        Console.Write(" Nome: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(candidatoalterado.Nome);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|I|");
                        Console.ResetColor();
                        Console.Write(" Idade: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(candidatoalterado.Idade);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|T|");
                        Console.ResetColor();
                        Console.Write(" Telefone: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(candidatoalterado.Telefone);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|E|");
                        Console.ResetColor();
                        Console.Write(" Email: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(candidatoalterado.Email);
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|P|");
                        Console.ResetColor();
                        Console.Write(" Profissão: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(candidatoalterado.Profissoes);
                        Console.ResetColor();
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        Console.WriteLine("<|Enter| Retorna ");

                        try
                        {
                            var letraOpiçao = Console.ReadLine();
                            if (letraOpiçao == "n" || letraOpiçao == "N")
                            {
                                Console.Clear();
                                Console.Write("Digite um novo NOME;");
                                Console.WriteLine("                                <|R| Retorna ao menu.");

                            nome:
                                try
                                {
                                    Regex regex = new Regex("[A-z]");
                                    nome = Console.ReadLine();

                                    while (!regex.IsMatch(nome))
                                    {

                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("Tente Novamente! Digite |Enter|");
                                        Console.ResetColor();

                                        goto nome;
                                    }
                                    if (nome == "r" || nome == "R")
                                    {
                                        Console.Clear();
                                        goto alterando2;
                                    }

                                    antigocand.Id = candidatoalterado.Id;
                                    antigocand.Nome = nome;
                                    antigocand.Idade = candidatoalterado.Idade;
                                    antigocand.Telefone = candidatoalterado.Telefone;
                                    antigocand.Email = candidatoalterado.Email;
                                    antigocand.Profissoes = candidatoalterado.Profissoes;
                                    antigocand.Salario = candidatoalterado.Salario;

                                    listaDeCandidatos.Remove(candidatoalterado);
                                    listaDeCandidatos.Add(antigocand);
                                }
                                catch { Console.Clear(); }

                                Console.Clear();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine();
                                Console.Write("O Nome ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(candidatoalterado.Nome);
                                Console.ResetColor();
                                Console.Write(" foi alterado para ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(nome + ".");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("      Alteração BEM SUCEDIDA !!!");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("Digite |Enter| para retornar ao menu inicial.");
                                Console.ReadLine();
                            }
                            if (letraOpiçao == "t" || letraOpiçao == "T")
                            {
                            telefone:
                                Console.Clear();
                                Console.Write("Digite um novo TELEFONE;");
                                Console.WriteLine("                                <|R| Retorna ao menu.");

                                try
                                {
                                    do
                                    {
                                        telefone = Console.ReadLine();

                                        if (telefone == "r" || telefone == "R")
                                        {
                                            Console.Clear();
                                            goto alterando2;
                                        }

                                        if (telefone.Length <= 9)
                                        {

                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("Tente Novamente! Digite |Enter|");
                                            Console.ResetColor();
                                            Console.ReadLine();
                                            Console.Clear();
                                            goto telefone;
                                        }

                                        if (telefone.Any(char.IsLetter))
                                        {
                                            goto telefone;
                                        }
                                    }
                                    while (telefone == string.Empty);

                                    antigocand.Id = candidatoalterado.Id;
                                    antigocand.Nome = candidatoalterado.Nome;
                                    antigocand.Idade = candidatoalterado.Idade;
                                    antigocand.Telefone = telefone;
                                    antigocand.Email = candidatoalterado.Email;
                                    antigocand.Profissoes = candidatoalterado.Profissoes;
                                    antigocand.Salario = candidatoalterado.Salario;

                                    listaDeCandidatos.Remove(candidatoalterado);
                                    listaDeCandidatos.Add(antigocand);

                                    Console.Clear();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine();
                                    Console.Write("O Telefone ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(candidatoalterado.Telefone);
                                    Console.ResetColor();
                                    Console.Write(" foi alterado para ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(telefone + ".");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("      Alteração BEM SUCEDIDA !!!");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("Digite |Enter| para retornar ao menu inicial.");
                                    Console.ReadLine();
                                }
                                catch
                                {
                                    goto telefone;
                                }
                            }
                            if (letraOpiçao == "e" || letraOpiçao == "E")
                            {
                            email:
                                Console.Clear();
                                Console.Write("Digite um novo E-MAIL;");
                                Console.WriteLine("                                <|R| Retorna ao menu.");

                                try
                                {
                                    Regex regex = new Regex("[A-z]");
                                    email = Console.ReadLine();

                                    while (!regex.IsMatch(email))
                                    {
                                        goto email;

                                    }
                                    if (email == "r" || email == "R")
                                    {
                                        Console.Clear();
                                        goto alterando2;
                                    }
                                }
                                catch
                                {
                                    Console.Clear();
                                    goto email;
                                }

                                antigocand.Id = candidatoalterado.Id;
                                antigocand.Nome = candidatoalterado.Nome;
                                antigocand.Idade = candidatoalterado.Idade;
                                antigocand.Telefone = candidatoalterado.Telefone;
                                antigocand.Email = email;
                                antigocand.Profissoes = candidatoalterado.Profissoes;
                                antigocand.Salario = candidatoalterado.Salario;

                                listaDeCandidatos.Remove(candidatoalterado);
                                listaDeCandidatos.Add(antigocand);

                                Console.Clear();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine();
                                Console.Write("O E-mail: ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(candidatoalterado.Email);
                                Console.ResetColor();
                                Console.Write(" foi alterado para ");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(email + ".");
                                Console.ResetColor();
                                Console.WriteLine();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("      Alteração BEM SUCEDIDA !!!");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine("Digite |Enter| para retornar ao menu inicial.");
                                Console.ReadLine();
                            }

                            if (letraOpiçao == "i" || letraOpiçao == "I")
                            {
                            idade:
                                Console.Clear();
                                Console.Write("Para alterar a IDADE;");
                                Console.WriteLine("                                <|R| Retorna ao menu.");

                                try
                                {
                                    int numpessoas = 1;
                                    int somaidades = 0;
                                    for (int e = 0; e < numpessoas; e++)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Digite o ano de nascimento:");
                                        int anonascimento = int.Parse(Console.ReadLine());
                                        int Idade = DateTime.Now.Year - anonascimento;
                                        somaidades += Idade;
                                    }

                                    idade = somaidades;

                                    if (idade >= 40)
                                    {
                                        salario += salario * 0.15;
                                    }
                                    if (letraOpiçao == "r" || letraOpiçao == "R")
                                    {
                                        Console.Clear();
                                        goto alterando2;
                                    }

                                    antigocand.Id = candidatoalterado.Id;
                                    antigocand.Nome = candidatoalterado.Nome;
                                    antigocand.Idade = idade;
                                    antigocand.Telefone = candidatoalterado.Telefone;
                                    antigocand.Email = candidatoalterado.Email;
                                    antigocand.Profissoes = candidatoalterado.Profissoes;
                                    antigocand.Salario = salario;

                                    listaDeCandidatos.Remove(candidatoalterado);
                                    listaDeCandidatos.Add(antigocand);

                                    Console.Clear();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine();
                                    Console.Write("A idade: ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(candidatoalterado.Idade);
                                    Console.ResetColor();
                                    Console.Write(" foi alterado para ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(idade + ".");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("      Alteração BEM SUCEDIDA !!!");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("Digite |Enter| para retornar ao menu inicial.");
                                    Console.ReadLine();
                                }
                                catch
                                {
                                    Console.Clear();
                                    goto alterando2;
                                }
                            }
                            if (letraOpiçao == "p" || letraOpiçao == "P")
                            {
                            profissão:
                                Console.Clear();
                                Console.WriteLine("Digite uma nova PROFISSÃO;");
                                Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                                Console.WriteLine("'   Digite:|1| - Pedreiro         '");
                                Console.WriteLine("'   Digite:|2| - Carpinteiro      '");
                                Console.WriteLine("'   Digite:|3| - Eletricista      '");
                                Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                                Console.WriteLine("              <|R| Retorna ao menu.");

                                try
                                {


                                    int opicao = int.Parse(Console.ReadLine());
                                    switch (opicao)
                                    {
                                        case 1:
                                            profissoes = "Pedreiro";
                                            break;
                                        case 2:
                                            profissoes = "Carpinteiro";
                                            break;
                                        case 3:
                                            profissoes = "Eletricista";
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                                            Console.WriteLine("Opção invalida. Tente outras opções! |1|,|2|ou|3|");
                                            Console.ResetColor();
                                            Console.WriteLine("Digite |Enter| para retornar.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            break;

                                    }

                                    antigocand.Id = candidatoalterado.Id;
                                    antigocand.Nome = candidatoalterado.Nome;
                                    antigocand.Idade = candidatoalterado.Idade;
                                    antigocand.Telefone = candidatoalterado.Telefone;
                                    antigocand.Email = candidatoalterado.Email;
                                    antigocand.Profissoes = profissoes;
                                    antigocand.Salario = candidatoalterado.Salario;

                                    listaDeCandidatos.Remove(candidatoalterado);
                                    listaDeCandidatos.Add(antigocand);


                                    Console.Clear();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine();
                                    Console.Write("A profissão: ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(candidatoalterado.Profissoes);
                                    Console.ResetColor();
                                    Console.Write(" foi alterado para ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(profissoes + ".");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("      Alteração BEM SUCEDIDA !!!");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine("Digite |Enter| para retornar ao menu inicial.");
                                    Console.ReadLine();

                                }
                                catch
                                {
                                    Console.Clear();
                                    goto alterando2;
                                }

                            }
                        }
                        catch { }



                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção invalida");
                        Console.ResetColor();
                        Console.WriteLine("Tente Novamente!!!");
                        Console.WriteLine("Digite |Enter| para retornar.");
                        Console.ReadLine();

                    }
                }
                catch 
                {

                }

            }
            catch { }
        menu:;

        }

    }

}
    
            
 // FALTA ID INVALIDO NO CASE 3 ALTERANDO





//Console.Clear();
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine("(Id) não CADASTRADO.Tente novamente um (Id) listado nos cadastros!");
//Console.ResetColor();
//Console.WriteLine();
//Console.WriteLine("Digite |Enter| para retornar.");
//Console.ReadLine();
//Console.Clear();

//Console.Clear();
//Console.WriteLine();
//Console.Write("Id: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Id);
//Console.ResetColor();

//Console.Write("Nome: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Nome);
//Console.ResetColor();

//Console.Write("Idade: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Idade);
//Console.ResetColor();

//Console.Write("Telefone: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Telefone);
//Console.ResetColor();

//Console.Write("E-mail: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Email);
//Console.ResetColor();

//Console.Write("Profissão: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Profissoes);
//Console.ResetColor();

//Console.Write("Salario: ");
//Console.ForegroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine(candidatoEscolhido.Salario);
//Console.ResetColor();

//goto alterando2;