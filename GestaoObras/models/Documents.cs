using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;

namespace GestaoObras.models
{
    public class Documents
    {
        /// <summary>
        /// Public Properties
        /// </summary>

        #region Public Properties
        public int IdDocumento { get; private set; }
        public DocumentType TipodoDocumento { get; set; }
        public DateOnly DataDocumento { get; private set; }
        public Person Vendedor { get; set; }
        #endregion


        /// <summary>
        /// Class Contrutor
        /// </summary>
        /// <param name="IdDocumento"></param>
        /// <param name="TipoDocumento"></param>
        /// <param name="DataDocumento"></param>
        /// <param name="Vendedor"></param>
        /// 

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