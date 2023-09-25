using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova__3__Bimestre.Classes
{
    internal class Funcionario
    {
        public string Nome { get;set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }

        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario() 
        {
        
        }
        public Funcionario(string nome, string cPF, string matricula, DateTime dataNascimento, string sexo, double salario)
        {
            Nome = nome;
            CPF = cPF;
            Matricula = matricula;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Salario = salario;
        }

        
    }
}
