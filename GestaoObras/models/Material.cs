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
        #region Properties
        public int IdMaterial { get; private set; }
        public string NomeMaterial { get; set; }
        public MaterialType TipoMaterial { get; set; }
        public double Preco { get; private set; }
        #endregion
        #region constructor
        public Materiais(int IdMaterial, string NomeMaterial, MaterialType TipoMaterial, double Preco)
        {
            this.IdMaterial = IdMaterial;
            this.NomeMaterial = NomeMaterial;
            this.TipoMaterial = TipoMaterial;
            this.Preco = Preco;
        }

        #endregion

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
