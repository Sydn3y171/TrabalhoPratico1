using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras
{
    public class Person
    {
        #region Privete Properties
        private int nif { get; set; }
        private string endereco { get; set; }
        private int telefone { get; set; }
        #endregion

        #region Public Properties
        public string Nome
        {
            get
            {
                return this.Nome;
            }
            set
            {
                if (value.Length > 0)
                {
                    this.Nome = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return this.Email;
            }
            set
            {
                this.Email = value;
            }
        }

        #endregion

        #region Construtor

        public Person(string Name, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;
        }
        #endregion
    }
}