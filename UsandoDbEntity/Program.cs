using UsandoDbEntity.Data;
using UsandoDbEntity.Models;

try
{
    var context = new UsandoDbEntityContext();
    var artistaDAL = new DAL<Artista>(context);

    // Teste ARTISTAS

    // Inserir artista ----------------

    //var novoArtista = new Artista("novoartista", "novo");
    //artistaDAL.Inserir(novoArtista);

    // Atualizar artista ----------------

    //var novoArtista2 = new Artista("novoArtista2", "bio") { Id = 3 };
    //artistaDAL.Atualizar(novoArtista2);

    // Deletar artista ------------------

    //var novoArtista2 = new Artista("novoArtista2", "bio") { Id = 3 };
    //artistaDAL.Deletar(novoArtista2);

    // Buscar artistar -------------------

    //var listaArtistas = artistaDAL.SelecionarTudo();
    //foreach (var artista in listaArtistas)
    //{
    //    Console.WriteLine(artista.Nome);
    //}

    //Buscar por condição ----------------

    //var artistaBuscado = artistaDAL.BuscarPor(a => a.Nome.Equals("Teste"));
    //Console.WriteLine($"\nArtista buscado: {artistaBuscado?.Nome}");

    // Teste Musicas

    // Inserir música ------------------

    //var artistaBuscado = artistaDAL.BuscarPor(a => a.Nome.Equals("novoartista"));
    //Console.WriteLine(artistaBuscado.Nome);

    //var musicaArtistaBuscado = new Musica("musicaTeste")
    //{
    //    AnoLancamento = 2000
    //};

    //artistaBuscado.Musicas.Add(musicaArtistaBuscado);
    //artistaDAL.Atualizar(artistaBuscado);

    // Listar músicas -------------------

    //foreach (var musica in artistaBuscado.Musicas)
    //{
    //    Console.WriteLine(musica.Nome);
    //}

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}