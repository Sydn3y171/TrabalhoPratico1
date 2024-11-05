using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.SC
{
    public class Documents
    {

        public enum TipoDocumento
        {
            Orcamento,
            Compra,
            DocumentosDeObra,

        }

        #region Public Properties
        public int IdDocumento { get; private set; }
        public TipoDocumento TipodoDocumento { get; set; }
        public DateOnly DataDocumento { get; private set; }
        public Person Vendedor { get; set; }
        #endregion

        #region Constructor
        public Documents(int IdDocumento, string TipoDocumento, DateOnly DataDocumento, Person Vendedor)
        {
            this.IdDocumento = IdDocumento;
            this.TipodoDocumento = TipodoDocumento;
            this.DataDocumento = DataDocumento;
            this.Vendedor = Vendedor;
        }
        #endregion

    }
}