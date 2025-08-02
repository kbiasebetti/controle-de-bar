using ControleDeBar.Dominio.ModuloProduto;
using System.ComponentModel.DataAnnotations;

namespace ControleDeBar.WebApp.Models;

public class CadastrarProdutoViewModel
{
    [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo \"Nome\" deve ter entre 2 e 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo \"Valor\" é obrigatório.")]
    [Range(0.01, 10000.00, ErrorMessage = "O campo \"Valor\" deve ser maior que R$ 0,00.")]
    public decimal Valor { get; set; }

    public CadastrarProdutoViewModel()
    {
    }
}

public class EditarProdutoViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo \"Nome\" é obrigatório.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo \"Nome\" deve ter entre 2 e 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O campo \"Valor\" é obrigatório.")]
    [Range(0.01, 10000.00, ErrorMessage = "O campo \"Valor\" deve ser maior que R$ 0,00.")]
    public decimal Valor { get; set; }

    public EditarProdutoViewModel() { }

    public EditarProdutoViewModel(int id, string nome, decimal valor)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
}

public class ExcluirProdutoViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public ExcluirProdutoViewModel() { }

    public ExcluirProdutoViewModel(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}

public class VisualizarProdutosViewModel
{
    public List<DetalhesProdutoViewModel> Registros { get; set; } = new List<DetalhesProdutoViewModel>();

    public VisualizarProdutosViewModel(List<Produto> produtos)
    {
        foreach (Produto p in produtos)
        {
            DetalhesProdutoViewModel detalhesVm = new DetalhesProdutoViewModel(
                p.Id,
                p.Nome,
                p.Valor
            );

            Registros.Add(detalhesVm);
        }
    }
}

public class DetalhesProdutoViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public decimal Valor { get; set; }

    public DetalhesProdutoViewModel(int id, string nome, decimal valor)
    {
        Id = id;
        Nome = nome;
        Valor = valor;
    }
}