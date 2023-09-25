using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova__3__Bimestre.Classes
{
    internal class Medico:Funcionario
    {
        public string RegistroConselho { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico()
        {

        }
        public Medico(string registroConselho, double valorHoraExtra, string especialidade, string nome, string cPF, string matricula, DateTime dataNascimento, string sexo, double salario) : base( nome,cPF, matricula, dataNascimento,  sexo,  salario)
        {
            RegistroConselho = registroConselho;
            ValorHoraExtra = valorHoraExtra;
            Especialidade = especialidade;
        }

        public  void SalarioAcrecimo()
        {
            double ValorAuxílioPericulosidade = 0;

            double ValorAuxilar = (Salario * 20) / 100;

            Salario = Salario + ValorAuxílioPericulosidade + ValorAuxilar;
            Console.WriteLine($"{Salario}");

        }
    }
}
