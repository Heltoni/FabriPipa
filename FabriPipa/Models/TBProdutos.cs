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
    
    public partial class TBProdutos
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string UnidadeMedida { get; set; }
        public int Quantidade { get; set; }
        public string VlUnitario { get; set; }
        public string Validade { get; set; }
        public string IdFornecedor { get; set; }
        public string Observacao { get; set; }
        public System.DateTime DtInclusao { get; set; }
    }
}