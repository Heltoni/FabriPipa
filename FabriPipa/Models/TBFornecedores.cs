//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FabriPipa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBFornecedores
    {
        public int IdFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string NmFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public System.DateTime DtInclusao { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
    }
}