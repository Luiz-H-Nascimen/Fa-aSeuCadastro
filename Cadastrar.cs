using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static SeuCadastro.Candidatos;
using static System.Net.Mime.MediaTypeNames;

namespace SeuCadastro
{

    public class Cadastro
    {
        public Cadastro() { }

        public void Cadastrar()
        {
        inicio:
            var nome = string.Empty;
            string telefone = string.Empty;
            string email = string.Empty;
            int idade = 0;
            string profissoes = string.Empty;
            Random idaleatorio = new Random();
            var id = idaleatorio.Next(1000);
            double salario = 1500;

            try
            {
                try
                {
                nome:
                    try
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Digitou |1|");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("                              ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar |Menu Inicial| ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.ResetColor();
                        Console.WriteLine("Digite o nome:");

                        Regex regex = new Regex("[A-z]");
                        nome = Console.ReadLine();

                        while (!regex.IsMatch(nome))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Tente Novamente! Digite apenas letra. |Enter|");
                            Console.ResetColor();
                            Console.ReadLine();
                            Cadastrar();
                        }
                        if (nome == "r" || nome == "R")
                        {
                            Console.Clear();
                            goto retorno;
                        }
                    }
                    catch
                    {
                        goto nome;
                    }

                telefone:
                    try
                    {
                        do
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.Write("                                 ");
                            Console.ResetColor();
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("|T|");
                            Console.ResetColor();
                            Console.WriteLine("<Tela anterior|Nome|");
                            Console.Write("Digite o telefone:               ");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("|R|");
                            Console.ResetColor();
                            Console.WriteLine("<Para retornar|Menu Inicial| ");

                            telefone = Console.ReadLine();

                            if (telefone == "r" || telefone == "R")
                            {
                                Console.Clear();
                                goto retorno;
                            }
                            if (telefone == "t" || telefone == "T")
                            {
                                goto nome;
                            }
                            if (telefone.Length <= 9)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Tente Novamente! Digite apenas numeros. |Enter|");
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
                        {

                        }
                    }
                    catch
                    {
                        goto telefone;
                    }

                email:
                    try
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Não é obrigatorio informa o E-MAIL.        ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|Enter|");
                        Console.ResetColor();
                        Console.WriteLine("<Proxima.");
                        Console.Write("                                           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|T|");
                        Console.ResetColor();
                        Console.WriteLine("<Tela anterior|Telefone|");
                        Console.Write("Digite o E-mail:                           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar|Menu Inicial| ");
                        Console.ResetColor();

                        Regex regex = new Regex("[A-z]");
                        email = Console.ReadLine();

                        while (!regex.IsMatch(email))
                        {
                            Console.Clear();
                            goto cargo;
                        }
                        if (email == "r" || email == "R")
                        {
                            Console.Clear();
                            goto retorno;
                        }
                        if (email == "t" || email == "T")
                        {
                            Console.Clear();
                            goto telefone;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        goto cargo;
                    }

                cargo:

                    try
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Escolha um cargo:                    ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|T|");
                        Console.ResetColor();
                        Console.WriteLine("<Tela anterior|E-mail|");
                        Console.Write("                                     ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar|Menu Inicial| ");
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                        Console.WriteLine("'   Digite:|1| - Pedreiro         '");
                        Console.WriteLine("'   Digite:|2| - Carpinteiro      '");
                        Console.WriteLine("'   Digite:|3| - Eletricista      '");
                        Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                        Console.WriteLine();
                        Console.ResetColor();

                        int opicao = int.Parse(Console.ReadLine());
                        switch (opicao)
                        {
                            case 1:
                                profissoes = "Pedreiro";
                                goto idade;
                            //break;
                            case 2:
                                profissoes = "Carpinteiro";
                                goto idade;
                            //break;
                            case 3:
                                profissoes = "Eletricista";
                                goto idade;
                            //break
                            default:
                                Console.Clear();
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Opção invalida. Tente outras opções! |1|,|2|ou|3|");
                                Console.ResetColor();
                                Console.WriteLine("Digite |Enter| para retornar.");
                                Console.ReadLine();
                                Console.Clear();
                                goto cargo;
                                //break;


                        }

                    }
                    catch (Exception)
                    {
                        email = Console.ReadLine();
                        if (email == "t" || email == "T")
                        {
                            Console.Clear();
                            goto email;
                        }
                        if (email == "r" || email == "R")
                        {
                            Console.Clear();
                            goto retorno;
                        }
                    }

                idade:
                    try
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("Cargo:                                        ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|T|");
                        Console.ResetColor();
                        Console.WriteLine("<Tela anterior|Cargo|");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(profissoes);
                        Console.Write("                                           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar|Menu Inicial| ");
                        Console.Write("Salario inicial de ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("R$ 1500,00");
                        Console.ResetColor();
                        Console.Write("Tera um reajuste de");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(" +15%");
                        Console.ResetColor();
                        Console.Write("para funcionarios maiores de ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("40 anos.");
                        Console.ResetColor();

                        int numpessoas = 1;
                        int somaidades = 0;
                        for (int e = 0; e < numpessoas; e++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("__________________________________________");
                            Console.ResetColor();
                            Console.WriteLine("Digite o ANO DE NASCIMENTO:");
                            int anonascimento = int.Parse(Console.ReadLine());
                            int Idade = DateTime.Now.Year - anonascimento;
                            somaidades += Idade;
                            idade = somaidades;

                            if (anonascimento <= 1953 || anonascimento >= 2005)
                            {
                                Console.WriteLine("Idade: " + Idade + " anos");
                                Console.WriteLine("Não é permitido o cadastro de candidatos (-18 anos ou +70 anos).");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Tente Novamente! Voltando ao inicio do cadastro.");
                                Console.WriteLine("OBRIGADO por participar.");
                                Console.ResetColor();
                                Console.ReadLine();
                                goto nome;
                            }
                            if (idade >= 40)
                            {
                                salario += salario * 0.15;
                                Console.WriteLine("Idade: " + Idade + " anos");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("O salario sera de R$ " + salario + ",00");
                                Console.ResetColor();
                                Console.WriteLine(" (COM REAJUSTE)");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Idade: " + Idade + " anos");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("O salario sera de R$ " + salario + ",00");
                                Console.ResetColor();
                                Console.WriteLine(" (SEM REAJUSTE)");
                                Console.ReadLine();
                            }

                        }
                    }
                    catch
                    {
                        email = Console.ReadLine();
                        if (email == "t" || email == "T")
                        {
                            Console.Clear();
                            goto cargo;
                        }
                        if (email == "r" || email == "R")
                        {
                            Console.Clear();
                            goto retorno;
                        }
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção invalida, Digite apenas numeros");
                        Console.ResetColor();

                        goto idade;
                    }

                    string caminho = "Candidatos.txt";
                    using (StreamWriter writer = new StreamWriter(caminho, true))
                    {
                        writer.WriteLine(new Candidatos().Creat(id, nome, telefone, salario, email, profissoes, idade));
                    }

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Candidato Cadastro com SUCESSO!!!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Tecle |Enter| para retornar ao |Menu inicial|.");
                    Console.ReadLine();
                    Console.Clear();
                    new Menus().MenuInicial();
                }
                catch { }

            }
            catch { }
        retorno:;
        }
    }

}
