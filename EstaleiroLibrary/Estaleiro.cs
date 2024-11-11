using EstaleiroLibrary;

using GestaoObras.enums;

namespace EstaleiroLibrary
{
    public class Estaleiro
    {
        /// <summary>
        /// Public and Private properties
        /// </summary>

        #region Private Properties

        private int idVeiculo { get; set; }

        #endregion

        #region Public Properties

        public int IdVeiculo
        {
            get { return idVeiculo; }

            set { idVeiculo = value; }
        }

        //public VeiculosType TipoVeiculo { get; set; }


        public List<VeiculosType> TipoVeiculo
        {
            get => TipoVeiculo;
            set => TipoVeiculo = value;   
        
        }

        public string Modelo { get; set; }

        public double HorasDeUso { get; set; }

        public bool EmUso { get; set; }
        #endregion


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="IdVeiculo"></param>
        /// <param name="Tipoveiculos"></param>
        /// <param name="Modelo"></param>
        /// <param name="HorasDeUso"></param>
        /// <param name="EmUso"></param>
        #region Constructor

        public Estaleiro(int IdVeiculo, List<VeiculosType> TipoVeiculo, string Modelo, double HorasDeUso, bool EmUso)
        {
            this.IdVeiculo = IdVeiculo;
            this.TipoVeiculo = TipoVeiculo;
            this.Modelo = Modelo;
            this.HorasDeUso = HorasDeUso;
            this.EmUso = EmUso;
        }
        #endregion
    }
}
