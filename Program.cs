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
		
	}
}
