using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class Funcionario : Person
    {

        #region Properties
        private decimal Salario { get; set; }
        public string Cargo { get; set; }
        public DateOnly DataContratacao { get; set; }

        #endregion

        #region Construtor
        public Funcionario(int id, string nome, decimal salario, string cargo, DateTime dataContratacao)
            : base(id, nome) // Passa o telefone para a superclasse
        {
            Salario = salario;
            Cargo = cargo;
            DataContratacao = dataContratacao;
        }
        #endregion

        // Método para obter informações completas do funcionário
        public override string ObterIdentificacao()
        {
            return $"Funcionário: {Nome}, Cargo: {Cargo}, NIF: {nif}, Salário: {Salario:C}";
        }

        // Método para calcular o tempo de serviço do funcionário
        public int CalcularTempoDeServiço()
        {
            return (DateTime.Now.Year - DataContratacao.Year);
        }

        // Método para mostrar informacoes do funcionário
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Funcionário: {Nome}, ID: {Id}, Salário: {Salario:C}, Cargo: {Cargo}, Data de Contratação: {DataContratacao.ToShortDateString()}");
        }

        // Método para obter o salário
        public decimal ObterSalario()
        {
            return Salario;
        }

        // Método público para definir o salário
        public void DefinirSalario(decimal novoSalario)
        {
            if (novoSalario < 0)
            {
                throw new ArgumentException("O salário não pode ser negativo.");
            }
            Salario = novoSalario;
        }


    }
}
