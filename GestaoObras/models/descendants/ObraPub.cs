using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class ObraPub : Obra
    {
        // Propriedade específica para Obra Pública
        public string EntidadeResponsavel { get; set; }

        #region Constructors
        public ObraPub(int idObra, string nomeObra, string descricao, DateOnly dataInicio,
                       DateOnly dataPrevistaTermino, double orcamentoInicial, string endereco,
                       string estado, string orgaoResponsavel)
            : base(idObra, nomeObra, descricao,orcamentoInicial, dataInicio, dataPrevistaTermino, endereco, estado, orgaoResponsavel)
        {
            this.EntidadeResponsavel = EntidadeResponsavel;
        }
        #endregion

        public override double Calculate()
        {
            
            double custoTotal = Orcamento;
          
            double taxaPublica = 0.05;
            custoTotal += Orcamento * taxaPublica;

            return custoTotal;
        }

        #region Metodos
        public void AtualizarOrgaoResponsavel(string novoOrgao)
        {
            EntidadeResponsavel = novoOrgao;
            Console.WriteLine($"Entidade responsável atualizado para: {EntidadeResponsavel}");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nEntidade Responsável: {EntidadeResponsavel}";
        }
        #endregion

    }
}
