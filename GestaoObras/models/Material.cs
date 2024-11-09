using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;

namespace GestaoObras.models
{
    public class Materiais : Armazem
    {

        /// <summary>
        /// Added public and private properties to the subclass Materiais
        /// </summary>
        #region Properties
        public int IdMaterial { get; private set; }
        public string NomeMaterial { get; set; }
        public MaterialType TipoMaterial { get; set; }
        public double Preco { get; private set; }
        #endregion



        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="IdMaterial"></param>
        /// <param name="NomeMaterial"></param>
        /// <param name="TipoMaterial"></param>
        /// <param name="Preco"></param>
        /// <param name="IdArmazem"></param>
        /// <param name="Localizacao"></param>
        /// <param name="Capacidade"></param>
        /// <param name="NomeArmazem"></param>
        /// <param name="tipoArmazem"></param>
        #region constructor
        public Materiais(int IdMaterial, string NomeMaterial, MaterialType TipoMaterial, double Preco,
                  int IdArmazem, string Localizacao, int Capacidade, string NomeArmazem, ArmazemType tipoArmazem)
     : base(IdArmazem, Localizacao, Capacidade, NomeArmazem, tipoArmazem)  // Chamada ao construtor da base
        {
            this.IdMaterial = IdMaterial;
            this.NomeMaterial = NomeMaterial;
            this.TipoMaterial = TipoMaterial;
            this.Preco = Preco;
        }

        #endregion
        /// <summary>
        /// Methods
        /// </summary>
        #region Public methods

        public void MostraDetalhes()
        {
            base.MostraDetalhes();
            Console.WriteLine($"ID: {IdMaterial}, Material: {NomeMaterial},  Tipo: {TipoMaterial},Preço de Custo: {Preco}");
        }
        public void UpdatePreco(decimal novoPreco)
        {
            if (novoPreco >= 0)
            {
                Preco = Preco;
            }
            else
            {
                throw new ArgumentException("O preço não pode ser negativo!");
            }
        }
        #endregion
    }

}
