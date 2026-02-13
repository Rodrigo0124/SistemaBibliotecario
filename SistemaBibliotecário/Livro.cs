using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecário
{
    public class Livro
    {
        public string NomeLivro { get; set; }
        public int IdLivro { get; set; }
        public string NomeAutor { get; set; }
        public bool Disponibilidade { get; set; }

        public Livro(string nomeLivro, int idLivro, string nomeAutor, bool disponibilidade)
        {
            NomeLivro = nomeLivro;
            IdLivro = idLivro;
            NomeAutor = nomeAutor;
            Disponibilidade = disponibilidade;
        }
    }
}
