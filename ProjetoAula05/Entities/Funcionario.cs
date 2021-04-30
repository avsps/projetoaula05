using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAula05.Entities
{
    public class Funcionario
    {
        public Guid IdFuncionario { get; set; }
        public String Nome { get; set; }
        public String Cpf{ get; set; }
        public String Matricula{ get; set; }
        public DateTime DataAdmissao{ get; set; }
        public Guid IdFEmpresa { get; set; }

        public Empresa Empresa { get; set; }

    }
}
