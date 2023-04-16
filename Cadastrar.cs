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
        
        public List<Candidatos> Cadastrar(List<Candidatos> candidatos)
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
                    Console.Clear();


                    List<Candidatos> listaDeCandidatos = new List<Candidatos>();


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

                            goto inicio;
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



            candidatos.Add(new Candidatos().Creat(id, nome, telefone, salario, email, profissoes, idade));
           retorno:
            return candidatos;

        }
    
    }
}

/*using (var fluxosaida = new FileStream("Funcionarios.txt", FileMode.Append))
using (var sr = new StreamWriter(fluxosaida))
{
    foreach (var item in listaDeCandidatos)
    {
        sr.WriteLine(item.ToString());
    }
}
}
if (quantidade == 0)
{


goto inicio2;
}
if (quantidade < 0)
{
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Opição invalida. Só números apartir '0' são permitidos!");
Console.WriteLine("Tecle enter...");
Console.ReadLine();
Console.ResetColor();
goto inicio2;
}

}
catch (IOException e)
{

Console.WriteLine(e.Message);
}

}
catch (Exception)
{
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Opição invalida. Só números apartir '0' são permitidos!");
Console.ResetColor();
Console.WriteLine("Tecle enter...");
Console.ReadLine();

goto inicio2;
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Cadastro finalizado!");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("Tecle enter e retornar ao menu.");
Console.ReadLine();

inicio2:;



//IDADE

//Console.WriteLine("Quantas pessoas serão incluídas no cálculo?");
//int numPessoas = int.Parse(Console.ReadLine());
//int somaIdades = 0;
//for (int i = 0; i < numPessoas; i++)
//{
//    Console.WriteLine("Digite o ano de nascimento da pessoa " + (i + 1) + ":");
//    int anoNascimento = int.Parse(Console.ReadLine());
//    int idade = DateTime.Now.Year - anoNascimento;
//    somaIdades += idade;
//}
//Console.WriteLine("A soma das idades é: " + somaIdades);




//Console.WriteLine("Digite seu nome:");
//string nome = Console.ReadLine();
//Console.WriteLine("Olá " + nome + " Digete a data de nascimento:");
//string dataDeNascimento = Console.ReadLine();
//Console.WriteLine("Telefone :");
//string telefone = Console.ReadLine();
//Console.WriteLine("E-mail:");
//string email = Console.ReadLine();
//Console.WriteLine("Escolha a Profissão");
//Console.WriteLine("Reajustes referente ao salario de R$ 1.500,00");*/





