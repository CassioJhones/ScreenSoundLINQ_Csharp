using ScreenSoundLINT.Modelos;

namespace ScreenSoundLINT.Filtros;

internal class LinqFilter
{
        public static void FiltrarTodososGeneros(List<Musica> musicas )
        {
        var todosGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        Console.WriteLine("\n--GENEROS FILTRADOS");
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($" - {genero}");
        }
      }

    public static void FiltrarArtistaGenero(List<Musica> musicas, string genero)
    {
        var artistarPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por genero musical >>> {genero}");
        foreach (var artista in artistarPorGeneroMusical)
        {
            Console.WriteLine($" - {artista}");
        }
    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(Musica => Musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($" - {musica.Nome} - {musica.Artista}");
        }
    }
}
