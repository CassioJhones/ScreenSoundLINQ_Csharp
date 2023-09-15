namespace ScreenSoundLINT.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas { get; }

    public MusicasPreferidas(string nome) {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musica>();     
    }


    public void AddMusicasFavoritas(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }


    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"\nMusicas Favoritas de {Nome}");
        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($" - {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine("\n");
    }
}
