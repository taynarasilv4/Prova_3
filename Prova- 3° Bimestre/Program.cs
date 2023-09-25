using Prova__3__Bimestre.Classes;

public class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> listfuncionario = new List<Funcionario>();
        List<Medico> listMedico = new List<Medico>();
        List<Administrativo> listAdministrativo = new List<Administrativo>();

        while (true) 
        {
            

            Console.WriteLine("Escolha uma opcao:");
            Console.WriteLine("1-Funcionario");
            Console.WriteLine("2-Medico");
            Console.WriteLine("3-Administrativo");
            Console.WriteLine("4-Sair");

            int opcao = Convert.ToInt32(Console.ReadLine());


            if (opcao == 1)
            {
                Funcionario f = new Funcionario();
                Console.WriteLine("Digite o nome do funcionario:");
                f.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf do funcionario:");
                f.CPF = Console.ReadLine();

                Console.WriteLine("Digite a matricula do funcionario:");
                f.Matricula = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do funcionario:");
                f.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o sexo do funcionario:");
                f.Sexo = Console.ReadLine();

                Console.WriteLine("Digite o salario do funcionario:");
                f.Salario = Convert.ToDouble(Console.ReadLine());

                listfuncionario.Add(f);
                
            }
            else if(opcao == 2) 
            {
                Medico m = new Medico();
                Console.WriteLine("Digite o nome do medico:");
                m.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf do medico:");
                m.CPF = Console.ReadLine();

                Console.WriteLine("Digite a matricula do medico:");
                m.Matricula = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do medico:");
                m.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o sexo do medico:");
                m.Sexo = Console.ReadLine();

                Console.WriteLine("Digite o salario do medico:");
                m.Salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o CRM do medico:");
                m.RegistroConselho = Console.ReadLine();

                Console.WriteLine("Digite o Valor da Hora Extra do medico:");
                m.ValorHoraExtra = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Especialidade do medico:");
                m.Especialidade = Console.ReadLine();

                listMedico.Add(m);

            }
            else if(opcao == 3) 
            {
                Administrativo a = new Administrativo();
                Console.WriteLine("Digite o nome do administrativo:");
                a.Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf do administrativo:");
                a.CPF = Console.ReadLine();

                Console.WriteLine("Digite a matricula do administrativo:");
                a.Matricula = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do administrativo:");
                a.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Digite o sexo do administrativo:");
                a.Sexo = Console.ReadLine();

                Console.WriteLine("Digite o salario do administrativo:");
                a.Salario = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite qual é a Funcao do administrativo:");
                a.Funcao = Console.ReadLine();
                listAdministrativo.Add(a);
            }
            else if (opcao == 4) 
            {
                break;
            }

            foreach (Funcionario f in listfuncionario) 
            {

                Console.WriteLine(f);
            }

            foreach (Medico m in listMedico)
            {
                Console.WriteLine(m);

            }

            foreach (Administrativo a in listAdministrativo)
            {
                Console.WriteLine(a);
            }



        }
    }
}