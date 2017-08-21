using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SJ.SJDapperORM.Domain
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string NomeFornecedor { get; set; }
        public string NomeContato { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        
        //
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
