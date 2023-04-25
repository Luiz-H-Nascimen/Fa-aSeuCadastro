using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeuCadastro
{
    public class Menus
    {
        public void MenuInicial()
        {
            try
            {
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
                        new Cadastro().Cadastrar();
                        MenuInicial();
                        break;
                    case 2:
                        new Informacoes().InformacaoDeCadastro();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 3:
                        new Alterando().AlterarCandidato();
                        Console.Clear();
                        MenuInicial();
                        break;
                    case 4:
                        new Deletando().DeletarCandidato();
                        Console.Clear();
                        MenuInicial();
                        break;

                    case 5:
                        VerificarOpcaoDeSair();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Opção invalida. Tente outras opções! |1|,|2|,|3|,|4| ou |5|.");
                        Console.ResetColor();
                        Console.WriteLine("Digite |Enter| para retornar.");
                        Console.ReadLine();
                        MenuInicial();
                        break;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                MenuInicial();
            }
        }

        private void VerificarOpcaoDeSair()
        {
            Console.Clear();
            Console.WriteLine("Digitou |3| > Sair.");
            Console.WriteLine();
            Console.WriteLine("Deseja realmente sair?");
            Console.WriteLine("|1|Sim  ou  |0|Não");
            var opcao = Console.ReadLine();
            Console.Clear();
            if (Regex.IsMatch(opcao, @"^[0-1]{1,}$"))
            {
                if (opcao == "1")
                    return;
                else
                    Console.Clear();
                MenuInicial();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção invalida!         Tecle [Enter]");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
                VerificarOpcaoDeSair();
            }
        }
    }
}
