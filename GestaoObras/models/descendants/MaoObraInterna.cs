using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class MaoObraInterna : MaodeObra
    {
        public string Departamento { get; set; }

        public MaoObraInterna(int idMaoObra, string nome, double custoHora, DateOnly dataInicio, string departamento)
            : base(idMaoObra, nome, custoHora, dataInicio)  // Passa os parâmetros necessários para a classe base
        {
            Departamento = departamento;
        }

        public override string Descricao()
        {
            return $"Mão de Obra Interna: {IdMaoObra}, Departamento: {Departamento}, Custo por Hora: {CustoHora}";
        }

    }
}
