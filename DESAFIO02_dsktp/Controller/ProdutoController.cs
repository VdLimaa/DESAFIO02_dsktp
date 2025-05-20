using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http;
using DESAFIO02_dsktp.Model;

namespace DESAFIO02_dsktp.Controller
{
    public static class ProdutoController
    {
        private static readonly HttpClient client = new HttpClient(); 
        public static async Task<List<Produto>> BuscarProdutosAsync() 
        { 
            var resposta = await client.GetAsync("https://fakestoreapi.com/products"); 
            resposta.EnsureSuccessStatusCode(); 
            var conteudo = await resposta.Content.ReadAsStringAsync(); 
            return JsonSerializer.Deserialize<List<Produto>>(conteudo); 
        
        }
    }
}
