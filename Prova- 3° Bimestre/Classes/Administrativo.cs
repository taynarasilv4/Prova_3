using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova__3__Bimestre.Classes
{
    internal class Administrativo:Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo()
        {
        
        }
        public Administrativo(string funcao, string nome, string cPF, string matricula, DateTime dataNascimento, string sexo, double salario) : base(nome, cPF, matricula, dataNascimento, sexo, salario)
        {
            Funcao = funcao;
        }

        public void SalarioAcrecimo()
        {
            double ValeTransponde = 150;

            double valeAlimentacao = (Salario * 15) / 100;

            Salario = Salario + ValeTransponde + valeAlimentacao;
            Console.WriteLine($"{Salario}");

        }
    }
}
