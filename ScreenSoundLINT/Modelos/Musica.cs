
using System.Text.Json.Serialization;

namespace ScreenSoundLINT.Modelos;

internal class Musica
{    //pega o song do JSON e coloca em NOME
    [JsonPropertyName("song")]
    public string? Nome  { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public double? Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    public void MostrarMusica()
    {///Mostra as informaçoes solicitadas
        Console.WriteLine($"\nArtista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Duração: {Duracao/ 60000} min");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine("***************************************");
    }

}
