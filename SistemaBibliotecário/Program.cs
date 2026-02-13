using SistemaBibliotecário;
using System;

namespace SistemBibliotecário
{

    class Program
    {
        static void Main(string[] args)
        {
            CadastroLivro CadastrosLivros = new CadastroLivro();

            Console.WriteLine("Sistema bibliotecário: ");

            do
            {
                Console.WriteLine($"1 - Cadastrar livro\n" +
                    $"2 - Conferir status do livro\n" +
                    $"3 - Emprestar livro\n" +
                    $"4 - Sair");

                string escolhaUsuario = Console.ReadLine();
                Console.Clear();
                int decisaoUsuario = VerificacaoNumero(escolhaUsuario);

                switch (decisaoUsuario)
                {
                    case 1:
                        Console.Write("Nome do livro: ");
                        string nomeLivro = Console.ReadLine();
                        string nomeLivroFormatado = VerificacaoNome(nomeLivro);
                        if(NomeRepetido(nomeLivroFormatado, CadastrosLivros))
                        {
                            Console.WriteLine("Livro já existente!");
                            Thread.Sleep(1500);
                            Console.Clear();
                            break;
                        }

                        Console.Write("Id do livro: ");
                        escolhaUsuario = Console.ReadLine();
                        int IdLivro = VerificaNumber(escolhaUsuario);
                        
                            IdLivro = NumberRepetido(IdLivro, CadastrosLivros); 
                        

                        Console.Write("Nome do autor: ");
                        string nomeAutor = Console.ReadLine();
                        string nomeAutorFormatado = VerificacaoNome(nomeAutor);
                        Console.Clear();

                        
                        bool disponivel = true;

                        Livro livro = new Livro(nomeLivroFormatado, IdLivro, nomeAutorFormatado, disponivel);
                        CadastrosLivros.AdicionarLivro(livro);
                        break;

                    case 2:
                        Console.Write("Para conferir o status de um livro, digite o Id do livro ou o nome: ");
                        string conferirLivro = Console.ReadLine();
                       VerificaNomeOuId(conferirLivro, CadastrosLivros);
                            break;
                    //PRÓXIMO PASSO PROGRAMAR A OPÇÃO 3: EMPRESTAR LIVRO

                    case 3:
                        Console.Write("Digite o nome ou Id do livro para aluga-lo: ");
                        string emprestimoLivro = Console.ReadLine();
                        
                            for(int i = 0; i < CadastrosLivros.Livros.Count; i++)
                            {
                                if (string.Equals(emprestimoLivro, CadastrosLivros.Livros[i].NomeLivro, StringComparison.OrdinalIgnoreCase) && CadastrosLivros.Livros[i].Disponibilidade == true || int.TryParse(emprestimoLivro, out int n) && n == CadastrosLivros.Livros[i].IdLivro && CadastrosLivros.Livros[i].Disponibilidade == true)
                                {
                                    DateTime dataAlugado = DateTime.Now;
                                    DateTime dataEntrega = dataAlugado.AddDays(30);
                                    TimeSpan tempo = dataEntrega - dataAlugado;
                                    Console.WriteLine($"Você está alugando o livro {CadastrosLivros.Livros[i].NomeLivro}, você precisa devolvê-lo em " +
                                        $"{tempo.Days} dias, no dia {dataEntrega.ToShortDateString()}");
                                    CadastrosLivros.Livros[i].Disponibilidade = false;
                                    Thread.Sleep(5000);
                                    Console.Clear();
                                    break;
                                }
                            }
                        
                        
                        break;

                    case 4:
                        
                        break;

                }
              
                if(decisaoUsuario == 4)
                {
                    break;
                }
            } while (true);
        }

        static int VerificacaoNumero(string escolhaUsuario)
        {
            int numero;
            while (!int.TryParse(escolhaUsuario, out numero) || numero < 1 || numero > 4)
            {
                Console.WriteLine($"Número inválido! Por favor, digite uma opção corretamente: ");
                Console.WriteLine($"1 - Cadastrar livro\n" +
                    $"2 - Conferir status do livro\n" +
                    $"3 - Emprestar livro\n" +
                    $"4 - Sair");
                escolhaUsuario = Console.ReadLine();
                Console.Clear();

            }

            return numero;



        }
        static int VerificaNumber (string escolhaUsuario)
        {
            int numero;
            
                while (!int.TryParse(escolhaUsuario, out numero))
                {
                    Console.Write("Número de ID inválido! Digite corretamente: ");
                    escolhaUsuario = Console.ReadLine();
                }
               
            
                       return numero;
        }

        static int NumberRepetido(int numero, CadastroLivro cadas)
        {
           
                for (int i = 0; i < cadas.Livros.Count; i++)
                {


                    if (numero == cadas.Livros[i].IdLivro)
                    {
                        Console.Write($"ID digitada já está em uso! Digite uma ID diferente: ");
                        string escolhaUsuario = Console.ReadLine();
                        numero = VerificaNumber(escolhaUsuario);
                        i = -1;
                    Console.Clear();
                    }
                }

           
            return numero;
        }

        static string VerificacaoNome(string nomeLivro)
        {

            while (!nomeLivro.Any(char.IsLetter))
            {
                Console.Write($"Nome incorreto! Por favor digite o nome corretamente: ");
                nomeLivro = Console.ReadLine();
            }
            nomeLivro = nomeLivro.ToUpper();

           
         
                    
            return nomeLivro;
        }

        static void VerificaNomeOuId(string escolha, CadastroLivro cadas)
        {
            int num = 0;
            int i;
            for(i = 0; i < cadas.Livros.Count; i++)
            {
                if(string.Equals(escolha, cadas.Livros[i].NomeLivro, StringComparison.OrdinalIgnoreCase) || int.TryParse(escolha, out num) && num == cadas.Livros[i].IdLivro)
                {
                   
                    if (cadas.Livros[i].Disponibilidade == true)
                    {
                        Console.WriteLine($"{cadas.Livros[i].NomeLivro} está disponível para empréstimo!");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                        
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine($"{cadas.Livros[i].NomeLivro} não está disponível para empréstimo.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                        
                        
                    }

                }
             
                
                
                
            }
            if (i == cadas.Livros.Count)
            {
                Console.WriteLine("Livro não encontrado!");
                Thread.Sleep(3000);
                Console.Clear();
            }

        }

        static bool NomeRepetido(string nome, CadastroLivro cadas)
        {
            for(int i = 0; i < cadas.Livros.Count; i++)
            {
                if(string.Equals(nome, cadas.Livros[i].NomeLivro, StringComparison.OrdinalIgnoreCase))
                {
                    
                    return true;
                }
            }
            return false;
        }
        
    }
}