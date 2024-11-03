using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.SC
{
    public class Materiais
    {
        #region Properties
        public int IdMaterial { get; private set; }
        public string NomeMaterial { get; set; }
        public string TipoMaterial { get; set; }
        public string UnidadeMedida { get; set; }
        public double Preco { get; private set; }
        #endregion
        #region constructor
        public Materiais(int IdMaterial, string NomeMaterial, string TipoMaterial, string UnidadeMedida, double Preco)
        {
            this.IdMaterial = IdMaterial;
            this.NomeMaterial = NomeMaterial;
            this.TipoMaterial = TipoMaterial;
            this.UnidadeMedida = UnidadeMedida;
            this.Preco = Preco;
        }

        #endregion

        #region Public methods
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
