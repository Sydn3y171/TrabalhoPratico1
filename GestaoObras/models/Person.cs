using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models
{
    public abstract class Person
    {
        /// <summary>
        /// Added public and private properties
        /// </summary>
        #region Private Properties
        private int nif { get; set; }
        private int id { get; set; }
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

        public int NIF
        {
            get 
            {
                return NIF;
            }
            set
            {
                NIF = value;
            }

        }

        public int ID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }

        #endregion



        /// <summary>
        /// Construtor com parametros
        /// </summary>
        /// <param name="Nome"></param>
        /// <param name="Email"></param>
        #region Construtor

        public Person(string Nome, string Email, int ID, int NIF)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.id = ID;
            this.nif = NIF;
        }
        #endregion


        /// <summary>
        /// Methods ObterIdentificacao and ValidarTelefone
        /// </summary>
        /// <returns></returns>
        #region Method

        public abstract string ObterIdentificacao();
        public abstract void MostrarDetalhesCliente();

        // Método privado para validar o NIF 
        private bool ValidarNIF(string nif)
        {
            // Validar o NIF 
            return nif.Length == 9 && long.TryParse(nif, out _);
        }

        // Método privado para validar o Telefone
        private bool ValidarTelefone(string telefone)
        {
            // Validar o telefone
            return telefone.Length >= 9 && telefone.Length <= 15;
        }


        #endregion
    }
}