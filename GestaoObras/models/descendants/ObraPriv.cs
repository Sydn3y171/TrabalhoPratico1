using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models.descendants
{
    public class ObraPriv : Obra
    {
        public ObraPriv(int idObra, string nomeObra, double orcamentos) 
            :base(idObra, nomeObra, orcamentos)
        {

        }

        public override double Calculate() // não é necessário implementar
        {
            throw new NotImplementedException();
        }

    }
}
