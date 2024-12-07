﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoObras.enums;
using GestaoObras.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoObras.models.descendants
{
    public abstract class Cliente : Person, ICliente
    {


        private DateTime dataNascimento { get; set; }
        public ClientType TipoCliente { get; set; }
        public DateTime DataRegisto { get; private set; }
        public bool Ativo { get; set; }
    


    #region Constructor
    

    public Cliente(int ID, string Nome, int NIF, string morada, string codigoPostal, string Email, DateTime dataNascimento, ClientType TipoCliente)
           : base(Nome, Email, ID, NIF)
        {
            this.dataNascimento = dataNascimento;
            this.TipoCliente = TipoCliente;
        }

        #endregion

        #region Method

        public override string ObterIdentificacao(string Nome, int NIF, string Email, ClientType TipoCliente, bool Ativo)
        {
            return $"Cliente: {Nome}, NIF: {NIF}, Email: {Email}, Tipo: {TipoCliente}, Ativo: {Ativo}";
        }
        public override void MostrarDetalhesCliente(string Nome, int ID, int NIF, string Email, DateTime DataNascimento, ClientType TipoCliente, bool Ativo, DateTime DataRegisto)
        {
            Console.WriteLine($"Cliente: {Nome}, ID: {ID}, NIF: {NIF}, Email: {Email}, Data Nascimento: {DataNascimento.ToShortDateString()}, Tipo: {TipoCliente}, Ativo: {Ativo}, Data de Registo: {DataRegisto.ToShortDateString()}");
        }

        public string GerarRelatorio()
        {
            return $"ID: {ID}, Nome: {Nome}, NIF: {NIF}, Tipo de Cliente: {TipoCliente}";
        }



        #endregion

    }
}
