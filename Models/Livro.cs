namespace LivroController.Models
{
    public class Livro
    {
      public int Id { get; set; }  // Chave primária
      public string Titulo { get; set; }
      public string Autor { get; set; }
      public int AnoPublicacao { get; set; }
      public string Genero { get; set; }

      public String Editora { get; set; }
    }
}
