using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;

namespace GestaoObras.models
{
    public class Estaleiro
    {

        #region Private Properties

        private int idVeiculo { get; set; }

        #endregion

        #region Public Properties

        public int IdVeiculo
        {
            get { return idVeiculo; }

            set { idVeiculo = value; }
        }

        public VeiculosType TipoVeiculo { get; set; }

        public string Modelo { get; set; }

        public double HorasDeUso { get; set; }

        public bool EmUso { get; set; }
        #endregion


        #region Constructor

        public Estaleiro(int IdVeiculo, VeiculosType Tipoveiculos, string Modelo, double HorasDeUso, bool EmUso)
        {
            this.IdVeiculo = IdVeiculo;
            this.TipoVeiculo= Tipoveiculos;
            this.Modelo = Modelo;
            this.HorasDeUso = HorasDeUso;
            this.EmUso = EmUso;
        }



        #endregion
    }
}
