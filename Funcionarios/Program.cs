using System;
using System.Collections.Generic;
using System.Globalization;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos Funcionários serão registrados ?");
            int n = int.Parse(Console.ReadLine());
            List<Funcionarios> list = new List<Funcionarios>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionarios: " + "#" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
            }
            Console.Write("Digite o Id do Funcionário que terá aumento de salário: ");
            int id1 = int.Parse(Console.ReadLine());

            Funcionarios fun = list.Find(x=> x.Id == id1);
            if (fun != null)
            {
                Console.Write("Digite a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                fun.AumentoDeSalario(porcentagem);
               
            }
            else
            {
                Console.WriteLine("Id não existe!");
            }

            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (var lista in list)
            {
                Console.WriteLine(lista);
            }
           

        }

    }
}
