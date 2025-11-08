public class Musica
{

    public Musica(Banda artista,String nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome {  get;  }
    public Banda Artista {  get; }
    public int Duracao {  get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => 
        $"A musica {Nome} é da banda {Artista}";

    public Genero Genero { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"NOME: {Nome}");
        Console.WriteLine($"ARTISTA: {Artista.Nome}");
        Console.WriteLine($"DURACAO: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"DISPONIVEL");
        }
        else 
        {
            Console.WriteLine("Musica no plano PLUS+");
        }
        
    }

    public void ExibirNomeEArtista()
    {
        Console.WriteLine($"NOME: {Nome}");
        Console.WriteLine($"ARTISTA: {Artista.Nome}");
    }
}
