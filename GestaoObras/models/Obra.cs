using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models
{
    public abstract class Obra
    {


        /// <summary>
        /// Added public and private properties
        /// </summary>
        #region Private Properties

        private double orcamento { get; set; }

        private DateOnly dataFim;
        private string nomeObra;
        private double orcamentoInicial;
        private string endereco;
        private string orgaoResponsavel;

        private string estado { get; set; }


        #endregion

        public string Nome { get; set; }

        public string Endereço { get; set; }

        public string Descricao { get; set; }

        #region Public Properties

        public int IdObra { get; private set; } //private set, the ID gets dif only one time 

        public DateOnly DataInicio { get; set; }

        #endregion

        /// <summary>
        /// created construtor
        /// </summary>
        /// <param name="idObra"></param>
        /// <param name="nomeObra"></param>
        /// <param name="descricao"></param>
        /// <param name="orcamentoInicial"></param>

        #region Construtor 
        public Obra(int idObra, string nomeObra, string descricao, double orcamentoInicial)
        {
            IdObra = idObra;
            Nome = nomeObra;
            orcamento = orcamentoInicial;
        }

        public string Estado
        {
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

        public DateOnly DataFim
        {
            get { return dataFim; }
            set
            {
                if (value >= DataInicio)
                {
                    dataFim = value;
                }
                else
                {
                    throw new ArgumentException("Data final deve ser posterior à data de inicio da obra!");
                }
            }
        }

        public double Orcamento
        {
            get { return orcamento; }
            private set { orcamento = value; }
         }
        #endregion


        /// <summary>
        /// Method to Calculate taxa obra publica
        /// </summary>
        /// <returns></returns>

        #region CalcularTaxaObra
        public abstract double Calculate();
        #endregion
    }



}

