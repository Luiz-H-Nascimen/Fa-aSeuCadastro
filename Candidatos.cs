using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeuCadastro
{

    public class Candidatos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public double Salario { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Profissoes { get; set; }
        public int Idade { get; set; }

        public Candidatos Creat(int id, string nome, string telefone, double salario, string email, string profissoes, int idade)
        {
            var candidatos = new Candidatos
            {
                Id = id,
                Nome = nome,
                Telefone = telefone,
                Salario = salario,
                Email = email,
                Profissoes = profissoes,
                Idade = idade,
            };
            return candidatos;
        }

        public override string ToString()
        {
            return $"{Id},{Nome},{Telefone},{Salario},{Email},{Profissoes},{Idade}";
        }


    }

}