namespace Biblioteca.Models;

public class Livro
{
    public int Id {get; set; }
    public string? Titulo {get; set; }
    public string? Autor {get; set; }
    public int QtdPaginas {get; set; }
    public DateOnly DataPublicacao {get; set; }
    public string? Genero {get; set; }
}