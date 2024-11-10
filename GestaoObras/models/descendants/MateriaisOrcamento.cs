using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoObras.models.descendants
{
    public class MateriaisOrcamento : Materiais
    {
        public Material Material { get; set; }
        
        public int IdMaterial => Material?.Id ?? 0; // se não tiver definido retorna a 0

        public string NomeMaterial => Material?.Nome ?? "N/A"; //retorna N/A se não tiver definido um nome

        public decimal PrecoUnitario => Material?.PrecoVenda ?? 0; // retorna a 0 se não tiver definido um preço
        public int Quantidade { get; set; }
        
        



        #region Methods
        /// <summary>
        /// Método para calcular o custo total dos materiais no orçamento.
        /// Multiplica a quantidade pelo preço unitário.
        /// </summary>
        /// <returns>O custo total do material.</returns>
        public decimal CalcularCustoTotal()
        {
            return Quantidade * PrecoUnitario;
        }
        #endregion

        #region Metedo Mostra Detalhes Artigo
        /// <summary>
        /// Método para mostrar os detalhes do material no orçamento
        /// </summary>
        public void MostrarDetalhes()
        {
            Console.WriteLine($"Referencia Artigo: {IdMaterial}, Nome Artigo: {NomeMaterial}, Quantidade: {Quantidade}, Preço Unitário: {PrecoUnitario:C}, Custo Total: {CalcularCustoTotal():C}");
        }
        #endregion

    }
}
