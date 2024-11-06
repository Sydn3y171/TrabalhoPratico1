using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models
{
    public class MaodeObra
    {

        #region Properties

        public int IdMaoObra {  get; private set; }

        public string TipoMaoObra {  get; set; }

        public double CustoHora { get; private set; }

        public double HorasTrabalhadas {  get; set; }

        public string Especialidade {  get; set; }

        public DateOnly DataInicio { get; private set; }

        public DateOnly DataFim { get; set; }

        #endregion



        #region Constructor

        public MaoDeObra(int idMaoObra, string tipoMaoObra, double custoHora, DateOnly dataInicio)
        {
            this.IdMaoObra = idMaoObra;
            this.TipoMaoObra = tipoMaoObra;
            this.CustoHora = custoHora;
            this.DataInicio = dataInicio;
        }

        public void UpdateCustoHora(double novoCusto)
        {
            if (novoCusto >= 0)
            {
                CustoHora = novoCusto;
            }
            else
            {
                throw new ArgumentException("O custo por hora não pode ser negativo!");
            }
        }

        public void DefinirDataInicio(DateOnly dataInicio)
        {
            if (dataInicio <= DateOnly.FromDateTime(DateTime.Now))
            {
                DataInicio = dataInicio;
            }
            else
            {
                throw new ArgumentException("A data de início não pode ser futura!");
            }
        }


        #endregion

    }
}
