using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ProdutoController : Controller
{   
    // Listar produtos
    public IActionResult ListaProdutos()
    {
        // Dados dos produtos
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto A", Preco = 30.5M },
            new Produto { Id = 2, Nome = "Produto B", Preco = 55.0M },
            new Produto { Id = 3, Nome = "Produto C", Preco = 40.0M },
        };

        return View(produtos);
    }

    // Exibi detalhes de um produto específico
    public IActionResult DetalhesProduto(int id)
    {
        // Dados dos produtos
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Produto A", Preco = 30.5M },
            new Produto { Id = 2, Nome = "Produto B", Preco = 55.0M },
            new Produto { Id = 3, Nome = "Produto C", Preco = 40.0M },
        };

        // Encontra o produto pelo ID
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

        Produto produto = produtos.Find(p => p.Id == id);
#pragma warning restore CS8600 

        return View(produto);
    }
}
