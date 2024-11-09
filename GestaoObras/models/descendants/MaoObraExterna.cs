using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class MaoObraExterna : MaodeObra
    {
        public string Empresa { get; set; }

        // Construtor que chama o construtor da classe base com os parâmetros necessários
        public MaoObraExterna(int idMaoObra, string nome, double custoHora, DateOnly dataInicio, string empresa)
            : base(idMaoObra, nome, custoHora, dataInicio) // Passando os parâmetros para a classe base
        {
            this.Empresa = empresa;
        }

        public override string Descricao()
        {
            return $"Mão de Obra Externa fornecida pela empresa: {Empresa}";
        }

    }
}
