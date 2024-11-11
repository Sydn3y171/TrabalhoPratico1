using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoObras.models.descendants
{
    public abstract class Cliente : Person
    {

        
        private DateTime DataNascimento { get; set; }
        public ClientType TipoCliente { get; set; }
        public DateTime DataRegisto { get; private set; }
        public bool Ativo { get; set; }
    }

    #region Constructor
    

    public Cliente(int ID, string Nome, string NIF, string morada, string codigoPostal, string Email, DateTime dataNascimento, ClientType TipoCliente,)
           : base(Nome, Email, ID, NIF)
    {
        dataNascimento = dataNascimento;
        TipoCliente = TipoCliente;
    }

    #endregion

    #region Method

    public override string ObterIdentificacao(string Nome, int NIF,string Email,ClientType TipoCliente,bool Ativo)
    {
        return $"Cliente: {Nome}, NIF: {NIF}, Email: {Email}, Tipo: {TipoCliente}, Ativo: {Ativo}";
    }
    public abstract void MostrarDetalhesCliente(string Nome, int ID, int NIF,string Email, DateTime DataNascimento, ClientType TipoCliente,bool Ativo,DateTime DataRegisto)
    {
        Console.WriteLine($"Cliente: {Nome}, ID: {ID}, NIF: {NIF}, Email: {Email}, Data Nascimento: {DataNascimento.ToShortDateString()}, Tipo: {TipoCliente}, Ativo: {Ativo}, Data de Registo: {DataRegisto.ToShortDateString()}");
    }



    #endregion

}
