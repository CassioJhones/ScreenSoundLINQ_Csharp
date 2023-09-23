using ScreenSoundLINT.Modelos;
using System.Text.Json;
using ScreenSoundLINT.Filtros;
using (HttpClient client = new HttpClient())
{
	try
	{
		string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
		//LinqFilter.FiltrarTodososGeneros(musicas);
		//LinqOrder.ExibirListaArtistasOrdenados(musicas);
		//LinqFilter.FiltrarMusicasArtista(musicas, "Michael Jackson");
		//LinqFilter.FiltrarArtistaGenero(musicas,"blues");
		//musicas[1998].MostrarMusica();
		//musicas[1995].MostrarMusica();
		//musicas[2].MostrarMusica();

		var musicaspreferidasCASSIO = new MusicasPreferidas("Cassio");
		musicaspreferidasCASSIO.AddMusicasFavoritas(musicas[16]);
        musicaspreferidasCASSIO.AddMusicasFavoritas(musicas[10]);
        musicaspreferidasCASSIO.AddMusicasFavoritas(musicas[98]);
        musicaspreferidasCASSIO.AddMusicasFavoritas(musicas[24]);
        musicaspreferidasCASSIO.AddMusicasFavoritas(musicas[25]);
		musicaspreferidasCASSIO.ExibirMusicasFavoritas();

		var musicaspreferidasLETICIA = new MusicasPreferidas("Leticia");
        musicaspreferidasLETICIA.AddMusicasFavoritas(musicas[12]);
        musicaspreferidasLETICIA.AddMusicasFavoritas(musicas[18]);
        musicaspreferidasLETICIA.AddMusicasFavoritas(musicas[968]);
        musicaspreferidasLETICIA.AddMusicasFavoritas(musicas[284]);
        musicaspreferidasLETICIA.AddMusicasFavoritas(musicas[425]);
        musicaspreferidasLETICIA.ExibirMusicasFavoritas();

    }

	catch (Exception ex)
	{
        Console.WriteLine($"Temos um problema:\n {ex.Message}");
	}
}

//Integração de sistemas: As APIs(Application Programming Interfaces) são utilizadas para permitir a comunicação entre diferentes sistemas e aplicativos. Ao saber trabalhar com APIs, você será capaz de integrar seus aplicativos com serviços externos, como redes sociais, sistemas de pagamento, serviços de armazenamento em nuvem, entre outros. Isso permite que você desenvolva soluções mais robustas e com maior funcionalidade.
//Reutilização de código: APIs bem projetadas seguem princípios de modularidade e encapsulamento, permitindo que você reutilize código e evite a duplicação de esforços.
//Acesso a dados e serviços externos: Muitas vezes, você precisará acessar dados ou serviços externos em seus aplicativos.
//Agora é a sua vez! Neste link, existe uma série de APIs públicas e seu desafio é realizar uma requisição e exibir os dados no console.
