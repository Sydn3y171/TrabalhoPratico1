using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GestaoObras.models
{
    public class Person
    {
        
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

        #endregion

        #region Construtor

        public Person(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;
        }

        public Person(int id, string nome)
        {
            this.id = id;
            Nome = nome;
        }
        #endregion

        #region Method

        public abstract string ObterIdentificacao();

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