using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.SC
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
                return Nome;
            }
            set
            {
                if (value.Length > 0)
                {
                    Nome = value;
                }
            }
        }
        public string Email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        #endregion

        #region Construtor

        public Person(string Name, string Email)
        {
            Nome = Nome;
            this.Email = Email;
        }
        #endregion
    }
}