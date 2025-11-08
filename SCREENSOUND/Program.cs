Banda luanSantana = new Banda();

luanSantana.Nome = "Luan Santana";

Album album1 = new Album("Luz azul");



Musica musica1 = new Musica(luanSantana, "Predio")
{
    Duracao = 234,
    Disponivel = true,
};

Musica musica2 = new Musica(luanSantana, "Ilha")
{
    Duracao = 234,
    Disponivel = true,
};

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);


luanSantana.AdicionarAlbum(album1);

luanSantana.ExibirDiscografia();
musica1.ExibirFichaTecnica();
musica1.ExibirNomeEArtista();

