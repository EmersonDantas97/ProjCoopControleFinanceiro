﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCoopControleFinanceiro.Views.Usuario
{
    internal interface IUsuarioView
    {
        public string usuario { get; set; }
        public string senha { get; set; }
        public bool lembrarLogin { get; set; }
    }
}
