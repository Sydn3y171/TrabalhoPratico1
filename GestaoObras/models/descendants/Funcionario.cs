using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public abstract class Funcionario : Person
    {
        /// <summary>
        /// Properties publicas e privadas da subclasse Funcionario
        /// </summary>

        #region Properties
        private decimal Salario { get; set; }
        public string Cargo { get; set; }
        public DateOnly DataContratacao { get; set; }

        #endregion

        /// <summary>
        /// Construtor da subclasse funcionario
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Nome"></param>
        /// <param name="salario"></param>
        /// <param name="cargo"></param>
        /// <param name="DataContratacao"></param>
        /// <param name="Email"></param>

        #region Construtor
        public Funcionario(int ID, string Nome, decimal salario, string cargo, DateTime DataContratacao, string Email)
            : base(Nome, Email, ID)
        {
            Salario = salario;
            Cargo = cargo;
            DataContratacao = DataContratacao;
        }
        #endregion

        /// <summary>
        /// Public Method to ObterIndentificacao do funcionario
        /// CalcularTempoDeServiço de um funcionario
        /// Mostrar os detalhes do funcionario
        /// Perceber qual é o seu salario bem como defenilo
        /// </summary>
        /// <returns></returns>
        public override string ObterIdentificacao()
        {
            return $"Funcionário: {Nome}, Cargo: {Cargo}, NIF: {NIF}, Salário: {Salario:C}";
        }

       
        public int CalcularTempoServico()
        {
            return (DateTime.Now.Year - DataContratacao.Year);
        }

        
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Funcionário: {Nome}, ID: {ID}, Salário: {Salario:C}, Cargo: {Cargo}, Data de Contratação: {DataContratacao.ToShortDateString()}");
        }

        
        public decimal ObterSalario()
        {
            return Salario;
        }

        public void DefSalario(decimal novoSalario)
        {
            if (novoSalario < 0)
            {
                throw new ArgumentException("O salário não pode ser negativo.");
            }
            Salario = novoSalario;
        }


    }
}
