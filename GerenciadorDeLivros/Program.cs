// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

using GerenciadorLivros.models;


    class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gerenciador de Livros");
                Console.WriteLine("1. Cadastrar livro");
                Console.WriteLine("2. Mostrar livros");
                Console.WriteLine("3. Sair");
                Console.Write("Digite uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarLivro(livros);
                        break;
                    case "2":
                        MostrarLivros(livros);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione uma tecla para tentar novamente...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void CadastrarLivro(List<Livro> livros)
        {
            Console.Clear();
            Console.WriteLine("Cadastrar Livro");

            Livro livro = new Livro();

            Console.Write("Digite o nome do livro: ");
            livro.Nome = Console.ReadLine();

            Console.Write("Digite o autor do livro: ");
            livro.Autor = Console.ReadLine();

            Console.Write("Digite a quantidade de páginas: ");
            livro.QuantidadePaginas = int.Parse(Console.ReadLine());

            Console.Write("Você leu o livro? (s/n): ");
            string leu = Console.ReadLine().ToLower();
            livro.Leu = (leu == "s");

            livros.Add(livro);

            Console.WriteLine("Livro cadastrado com sucesso! Pressione uma tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void MostrarLivros(List<Livro> livros)
        {
            Console.Clear();
            Console.WriteLine("Livros Cadastrados");

            if (livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro cadastrado.");
            }
            else
            {
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro);
                }
            }

            Console.WriteLine("Pressione uma tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }


