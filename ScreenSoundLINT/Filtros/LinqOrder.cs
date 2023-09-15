

using ScreenSoundLINT.Modelos;

namespace ScreenSoundLINT.Filtros;

internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas =>
        musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("\nLISTA DE ARTISTAS ORDENADOS");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
