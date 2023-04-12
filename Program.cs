using System;
using System.Collections.Generic;

namespace Biblioteca
{
	class Program
	{
		static void Main(string[] args)
		{
			Biblioteca biblioteca = new Biblioteca();

			while (true)
			{
				Console.Clear();
				Console.WriteLine("Bem-vindo à Biblioteca");
				Console.WriteLine("Selecione uma opção:");
				Console.WriteLine("1 - Cadastro");
				Console.WriteLine("2 - Consultas");
				Console.WriteLine("3 - Empréstimos");
				Console.WriteLine("4 - Devoluções");
				Console.WriteLine("0 - Sair");

				int.TryParse(Console.ReadLine(), out int opcao);

				switch (opcao)
				{
					case 1:
						// Aqui você pode chamar um método para lidar com cadastros
						// Cadastro(biblioteca);
						break;
					case 2:
						// Aqui você pode chamar um método para lidar com consultas
						// Consultas(biblioteca);
						break;
					case 3:
						// Aqui você pode chamar um método para lidar com empréstimos
						// Emprestimos(biblioteca);
						break;
					case 4:
						// Aqui você pode chamar um método para lidar com devoluções
						// Devolucoes(biblioteca);
						break;
					case 0:
						Console.WriteLine("Saindo...");
						Environment.Exit(0);
						break;
					default:
						Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
						Console.ReadKey();
						break;
				}
			}			
		}
		
		static void Cadastro(Biblioteca biblioteca)
		{
			Console.Clear();
			Console.WriteLine("Selecione uma opção de cadastro:");
			Console.WriteLine("1 - Cadastrar cliente");
			Console.WriteLine("2 - Cadastrar livro");
			Console.WriteLine("0 - Voltar");

			int.TryParse(Console.ReadLine(), out int opcao);

			switch (opcao)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Cadastro de Cliente:");
					Console.Write("Nome: ");
					string nomeCliente = Console.ReadLine();
					Console.Write("Data de nascimento (AAAA-MM-DD): ");
					DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);
					Console.Write("Telefone: ");
					string telefone = Console.ReadLine();

					Cliente novoCliente = new Cliente { Id = biblioteca.clientes.Count + 1, Nome = nomeCliente, DataNascimento = dataNascimento, Telefone = telefone };
					biblioteca.clientes.Add(novoCliente);

					Console.WriteLine("Cliente cadastrado com sucesso!");
					Console.ReadKey();
					break;

				case 2:
					Console.Clear();
					Console.WriteLine("Cadastro de Livro:");
					Console.Write("Título: ");
					string titulo = Console.ReadLine();
					Console.Write("Autor: ");
					string autor = Console.ReadLine();

					Livro novoLivro = new Livro { Id = biblioteca.livros.Count + 1, Titulo = titulo, Autor = autor, Disponivel = true };
					biblioteca.livros.Add(novoLivro);

					Console.WriteLine("Livro cadastrado com sucesso!");
					Console.ReadKey();
					break;

				case 0:
					// Retorna ao menu principal
					break;

				default:
					Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;
			}
		}
		
	}
}
