using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models
{
    public class MaodeObra
    {
        /// <summary>
        /// Properties
        /// </summary>
        #region Properties

        public int IdMaoObra {  get; private set; }

        public string TipoMaoObra {  get; set; }

        public double CustoHora { get; private set; }

        public double HorasTrabalhadas {  get; set; }

        public string Especialidade {  get; set; }

        public DateOnly DataInicio { get; private set; }

        public DateOnly DataFim { get; set; }


        #endregion

        /// <summary>
        /// Added Construtor
        /// </summary>
        /// <param name="idMaoObra"></param>
        /// <param name="tipoMaoObra"></param>
        /// <param name="custoHora"></param>
        /// <param name="dataInicio"></param>

        #region Constructor

        public MaodeObra(int idMaoObra, string tipoMaoObra, double custoHora, DateOnly dataInicio)
        {
            this.IdMaoObra = idMaoObra;
            this.TipoMaoObra = tipoMaoObra;
            this.CustoHora = custoHora;
            this.DataInicio = dataInicio;

        }
        #endregion


        /// <summary>
        /// Methods
        /// </summary>
        /// <param name="novoCusto"></param>
        /// <exception cref="ArgumentException"></exception>
        #region Methods
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

        public virtual double CalcularCustoTotal()
        {
            return CustoHora * HorasTrabalhadas;
        }
        
        public virtual string Descricao()
        {
            return $"Mão de Obra: {IdMaoObra}, Custo por Hora: {CustoHora}";
        }

        #endregion

    }
}
