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
        #region Properties
        public int IdArmazem { get; private set; }
        public string NomeArmazem { get; set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; private set; }

        public ArmazemType ArmazemType { get; set; };
        
        #endregion


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

        #region Public methods
        public void MostraDetalhes()
        {
            Console.WriteLine($"ID: {IdArmazem},Armazém: {NomeArmazem}, Localização: {Localizacao}, Tipo: {ArmazemType}");
        }
        #endregion
    }
}
