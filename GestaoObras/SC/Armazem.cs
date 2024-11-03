using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.SC
{
    public class Armazem
    {
        #region Properties
        public int IdArmazem { get; private set; }
        public string Localizacao { get; set; }
        public int Capacidade { get; private set; }

        public List<Item> Inventario { get; private set; }
        #endregion


        #region constructor
        public Armazem(int IdArmazem, string Localizao, int Capacidade) 
        { 
            this.IdArmazem = IdArmazem;
            this.Localizacao = Localizao;
            this.Capacidade = Capacidade;
            this.Inventario = new List<Item>();

        }
        #endregion

        #region Public methods
        public void AdicionarItem(Item item)
        {
            if (Inventario.Count < Capacidade)
            {
                Inventario.Add(item);
            }
            else
            {
                throw new InvalidOperationException("Capacidade do armazém foi atingida.");
            }
        }

        public void RemoverItem(Item item)
        {
            Inventario.Remove(item);
        }
        #endregion
    }
}
