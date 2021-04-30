﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula05.Entities
{
    public class Empresa
    {
         public Guid IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public List<Funcionario> funcionarios { get; set; } 
    }
}
