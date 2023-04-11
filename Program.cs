using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // adicionando clientes
            biblioteca.clientes.Add(new Cliente { Id = 1, Nome = "João", DataNascimento = new DateTime(1980, 01, 01), Telefone = "123456789" });
            biblioteca.clientes.Add(new Cliente { Id = 2, Nome = "Maria", DataNascimento = new DateTime(1990, 02, 02), Telefone = "987654321" });

            // adicionando livros
            biblioteca.livros.Add(new Livro { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis", Disponivel = true });
            biblioteca.livros.Add(new Livro { Id = 2, Titulo = "O Cortiço", Autor = "Aluísio Azevedo", Disponivel = true });

            // emprestando um livro
            biblioteca.EmprestarLivro(1, 1);

            //devolvendo o livro emprestado
            biblioteca.DevolverLivro(1, 1);

            // chamada do método para iniciar o sistema
            IniciarBiblioteca(biblioteca);
        }

        static void IniciarBiblioteca(Biblioteca biblioteca)
        {
            // aqui o sistema pode ser iniciado com outras chamadas de métodos da classe Biblioteca
            biblioteca.EmprestarLivro(1, 1);
        }
    }
}
