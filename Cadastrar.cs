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
                        Console.Write("Digitou |1|                  ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar menu inicial. ");
                        Console.WriteLine();
                        Console.WriteLine("Digite o nome:");
                        Console.WriteLine();
                        

                        Regex regex = new Regex("[A-z]");
                        nome = Console.ReadLine();

                        while (!regex.IsMatch(nome))
                        {
                            
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Tente Novamente! Digite |Enter|");
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
                            Console.Write("                                 ");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("|T|");
                            Console.ResetColor();
                            Console.WriteLine("<Tela anterior(Nome).");
                            Console.Write("Digite o telefone:               ");
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("|R|");
                            Console.ResetColor();
                            Console.WriteLine("<Para retornar menu inicial. ");
                           
                            telefone = Console.ReadLine();

                            if (telefone == "r" || telefone == "R")
                            {
                                Console.Clear();
                                goto retorno;
                            }
                            if(telefone == "t" || telefone == "T")
                            {
                                goto nome;
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
                        Console.Write("Opção não é obrigatoria.>Proximo:");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("|Enter|");
                        Console.ResetColor();
                        Console.Write("                                           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|T|");
                        Console.ResetColor();
                        Console.WriteLine("<Tela anterior(Telefone).");
                        Console.Write("Digite o E-mail:                           ");
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("|R|");
                        Console.ResetColor();
                        Console.WriteLine("<Para retornar menu inicial. ");
                        Console.ResetColor();
                        

                        Regex regex = new Regex("[A-z]");
                        email = Console.ReadLine();

                        while (!regex.IsMatch(email))
                        {
                            goto email;

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
                        goto email;
                    }

                salario:
                    
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("Escolha um cargo:");
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine();
                        Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                        Console.WriteLine("'   Digite:|1| - Pedreiro         '");
                        Console.WriteLine("'   Digite:|2| - Carpinteiro      '");
                        Console.WriteLine("'   Digite:|3| - Eletricista      '");
                        Console.WriteLine("'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'");
                        Console.WriteLine();
                        Console.ResetColor();
                        Console.Write("¨Salario inicial de ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("R$ 1500,00¨");
                        Console.ResetColor();
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("¨Reajuste de +15%");
                        Console.ResetColor();
                        Console.Write(" para funcionarios acima de ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("[40 anos]¨");
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
                                goto salario;
                                //break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.Clear();
                    }

                idade:

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
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("Salario de R$ ");
                        Console.WriteLine(salario + ",00");
                        Console.ResetColor();
                        Console.Write("com reajuste.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Salario de R$ " + salario + ",00");
                        Console.ResetColor();
                        Console.WriteLine("sem reajuste.");
                        Console.ReadLine();
                    }

                    string caminho = "C:\\Users\\Rafael\\Desktop\\FacaSeuCadastro-LuizH\\Projeto Thitex\\ArquivoTXT.Candidatos.txt";
                    StreamWriter sw = new StreamWriter(caminho);
                    sw.WriteLine(new Candidatos().Creat(id, nome, telefone, salario, email, profissoes, idade));
                    sw.Close();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine("Candidato Cadastro com SUCESSO!!!");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("Tecle |Enter| para retornar ao menu inicial.");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch { }

            }
            catch { }
          
          
        retorno:;
        }
    
    }
}