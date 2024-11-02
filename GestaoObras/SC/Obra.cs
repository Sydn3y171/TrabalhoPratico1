using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.SC
{
    public class Obra
    {

        #region Private Properties

        private double orcamento { get; set; }

        private DateOnly dataFim;

        private string estado { get; set; }


        #endregion

        #region Public Properties

        public int IdObra { get; private set; } //private set, the ID gets dif only one time 

        public string Nome { get; set; }

        public string Endereço { get; set; }

        public string Descricao { get; set; }

        public DateOnly DataInicio { get; set; }

        public string Estado { 
        get { return estado; }
            set
            {
                if (value == "em curso" || value == "concluído" || value == "em planeamento")
                {
                    estado = value;
                }
                else
                {
                    throw new ArgumentException("Estado inválido!");
                }
            }
        }

        #endregion

        #region Function 
        public Obra(int idObra, string nomeObra, double orcamentoInicial)
        {
            IdObra = idObra;
            Nome = nomeObra;
            orcamento = orcamentoInicial;
        }
    }

    #endregion


}
}
