using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJ.SJDapperORM.Domain
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public int IDFornecedor { get; set; }
        public int IDCategoria { get; set; }
        public TipoUnidade TipoUnidade { get; set; }
        public decimal PrecoUnidade { get; set; }
        
        // referencia
        public Fornecedor Fornecedor { get; set; }
        public Categoria Categoria { get; set; }
    }
}
