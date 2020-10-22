

namespace Funcionarios
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoDeSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return "Id: " + Id + "," + "Nome: " + Nome + " , " + "Salário R$: " + Salario;
        }

    }
}
