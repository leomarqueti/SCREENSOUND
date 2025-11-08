using System.Net.Http.Headers;

public class Album
{
    private List<Musica> musicas = new List<Musica> ();

    public Album(String nome)
    {
        Nome = nome;
    }
    public string Nome {  get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }


    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Musicas no album {Nome}");
        foreach (var musica in musicas) {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"A duracao total do algum {DuracaoTotal}");

    }

}