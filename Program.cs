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
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Olá,seja BEM VINDO");
            Console.WriteLine();
            new Menus().MenuInicial();
        }
    }
}