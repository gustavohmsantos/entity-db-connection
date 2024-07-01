namespace UsandoDbEntity.Models
{
    public class Artista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string FotoPerfil { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<Musica> Musicas { get; set; }

        public Artista(string nome, string bio)
        {
            Nome = nome;
            Bio = bio;
            FotoPerfil = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
        }
    }
}
