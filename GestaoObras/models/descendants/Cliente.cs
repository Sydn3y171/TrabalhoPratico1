using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoObras.models.descendants
{
    public class Cliente : Person
    {
        public string Email { get; set; }
        private DateTime DataNascimento { get; set; }
        public ClientType TipoCliente { get; set; }
        public DateTime DataRegisto { get; private set; }
        public bool Ativo { get; set; }
    }

    #region Constructor


    public Cliente(int id, string nome, string email, DateTime dataNascimento, ClientType tipoCliente)
            : base(id, nome)
    {
        email = email;
        dataNascimento = dataNascimento;
        ClientType = tipoCliente;
        Ativo = true;


    }

    #endregion

    #region Method

    public override string ObterIdentificacao()
    {
        return $"Cliente: {Nome}, NIF: {NIF}, Email: {Email}, Tipo: {TipoCliente}, Ativo: {Ativo}";
    }
    public void MostrarDetalhes()
    {
        Console.WriteLine($"Cliente: {Nome}, ID: {Id}, NIF: {NIF}, Email: {Email}, Data Nascimento: {DataNascimento.ToShortDateString()}, Tipo: {TipoCliente}, Ativo: {Ativo}, Data de Registo: {DataRegisto.ToShortDateString()}");
    }



    #endregion

}
