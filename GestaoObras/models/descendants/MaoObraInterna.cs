using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class MaoObraInterna : MaodeObra
    {
        public override string Tipo => "Interna";
        public string Departamento { get; set; }

        public override string ObterDetalhes()
        {
            return $"Mão de Obra Interna: {Nome}, Departamento: {Departamento}, Custo Total: {CalcularCustoTotal():C}";
        }

    }
}
