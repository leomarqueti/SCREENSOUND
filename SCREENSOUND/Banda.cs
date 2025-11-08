public class Banda
{
    private string _nome;
    List<Album> albums = new List<Album>();
        
    public string Nome
    {
        get { return _nome; } set { _nome = value; }    
    }


    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}