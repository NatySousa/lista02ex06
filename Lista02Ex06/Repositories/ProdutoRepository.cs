using Lista02Ex06.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lista02Ex06.Repositories
{
    public class ProdutoRepository
    {
        public void ExportarDados(Produto produto )
        {
            var path = $"c:\\temp\\produto_{produto.IdProduto}.json";
            var json = JsonConvert.SerializeObject(produto, Formatting.Indented);

            using (var streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }
        }
    }
}

