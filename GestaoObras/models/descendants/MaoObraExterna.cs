using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class MaoObraExterna : MaodeObra
    {
        public override string TipoMaoObra => "Externa";
        public string EmpresaContratada { get; set; }

    }
}
