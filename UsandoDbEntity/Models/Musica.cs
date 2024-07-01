using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoDbEntity.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public virtual Artista Artista { get; set; }

        public Musica(string nome)
        {
            Nome = nome;
        }

    }
}
