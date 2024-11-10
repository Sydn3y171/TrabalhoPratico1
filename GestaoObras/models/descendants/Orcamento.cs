using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class Orcamento : Documents
    {
        public Cliente Cliente { get; set; }
        public Obra Obra { get; set; }
        public MateriaisOrcamento MaterialOrcamento { get; set; }

        #region Metedo para Calcular valor total orcamento
        /// <summary>
        /// Calcula o valor total do orçamento com base no custo total do material incluído.
        /// </summary>
        /// <returns>O valor total do orçamento.</returns>
        public decimal CalcularValorTotal()
        {
            return MaterialOrcamento.CalcularCustoTotal();
        }
        #endregion

        #region Metedo Descriminar Orcamento
        /// <summary>
        /// Descrição do Orcamento
        /// </summary>
        /// <returns>Uma string com a descrição do orçamento.</returns>
        public override string ObterDescricao()
        {
            return $"Orçamento para Obra {Obra.IdObra} - Cliente: {Cliente.Nome} (NIF: {Cliente.NIF}), Valor Total: {CalcularValorTotal():C}";
        }
        #endregion
    }
}
