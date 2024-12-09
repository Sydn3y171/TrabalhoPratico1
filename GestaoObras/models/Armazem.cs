using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;

namespace GestaoObras.models
{
    public class Armazem
    {

        /// <summary>
        /// Public Properties
        /// </summary>
        #region Properties
        public int IdArmazem { get; private set; }
        public string NomeArmazem { get; set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; private set; }

        public ArmazemType ArmazemType { get; set; }
        
        #endregion


        /// <summary>
        /// Class Contructor
        /// </summary>
        /// <param name="IdArmazem"></param>
        /// <param name="Localizao"></param>
        /// <param name="Capacidade"></param>
        /// <param name="NomeArmazem"></param>
        /// <param name="ArmazemType"></param>

        #region constructor
        public Armazem(int IdArmazem, string Localizao, int Capacidade, string NomeArmazem, ArmazemType ArmazemType) 
        { 
            this.IdArmazem = IdArmazem;
            this.NomeArmazem = NomeArmazem;
            this.Localizacao = Localizao;
            this.Capacidade = Capacidade;
            this.ArmazemType = ArmazemType;
            

        }
        #endregion
        /// <summary>
        /// Class Methods
        /// </summary>

        #region Methods
        public void MostraDetalhes()
        {
            Console.WriteLine($"ID: {IdArmazem},Armazém: {NomeArmazem}, Localização: {Localizacao}, Tipo: {ArmazemType}");
        }
        #endregion
    }
}
