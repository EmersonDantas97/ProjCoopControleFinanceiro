using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCoopControleFinanceiro.Model
{
    internal class Conta
    {
        public int id { get; set; }
        public DateTime data_registro { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public string tipo { get; set; }
        public DateTime data_emissao { get; set; }
        public DateTime data_pagar { get; set; }
        public string obs { get; set; }
        public string duracao { get; set; }
        public string forma_pagamento { get; set; }
        public char pago { get; set; }
        public char incerto { get; set; }
        public int parcela_atual { get; set; }
        public int qtd_parcela { get; set; }
        public string cartao { get; set; }
    }
}
