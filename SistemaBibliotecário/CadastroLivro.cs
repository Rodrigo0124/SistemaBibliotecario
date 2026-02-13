using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecário
{
    public class CadastroLivro
    {
        public List<Livro> Livros { get; set; }

        public CadastroLivro()
        {
            Livros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }
    }
}
