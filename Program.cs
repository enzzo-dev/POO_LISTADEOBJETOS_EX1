using System;
using System.Collections.Generic;
using POO_LISTADEOBJETOS_EX1.classes;

namespace POO_LISTADEOBJETOS_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar a lista
            List<Produto> produtos = new List<Produto>(); 


            //Adicionar produtos à lista

            // produtos.Add(new Produto(1,"Apple Watch" , 2547.4f));
            // produtos.Add(new Produto(2,"Xiaomi Redmi note 9s" , 1847.4f));
            // produtos.Add(new Produto(3,"Zenfone Asus" , 2247.6f));
            // produtos.Add(new Produto(4,"Iphone 11" , 4558.4f));
            // produtos.Add(new Produto(5,"Motorola G8" , 2737.8f));

            //Adicionar produtos de forma mais básica
            // Produto samsung = new Produto();
            // samsung.Codigo = 6;
            // samsung.Nome = "Sansung S10e";
            // samsung.Preco = 3250.5f;

            // produtos.Add(samsung);

            // ou 
            System.Console.WriteLine("Deseja adicionar quantos produtos?");
            int resposta = int.Parse(Console.ReadLine());

            int i = 0;
            do{
                Console.WriteLine("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o preço do produto: ");
                float preco = float.Parse(Console.ReadLine());
                System.Console.WriteLine("-----------------------------------------------------------");

                produtos.Add(new Produto(codigo , nome , preco));

                i++;

            }while(i < resposta);
            
            Console.Clear();

            //Mostrar produtos com foreach

            Console.WriteLine("Deseja ver os produtos cadastrados?");
            string resposta2 = Console.ReadLine();

            if(resposta2 == "sim" || resposta2 == "Sim" || resposta2 == "s")
            {
                foreach (Produto p in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
                Console.ResetColor();
            }
            } else {
                Console.Clear();
            }
            

            //Remover produtos da lista
            System.Console.WriteLine("-----------------------------------------------------");
            System.Console.WriteLine("Deseja excluir algum item? ");
            string resposta3 = Console.ReadLine();

            if(resposta3 == "sim" || resposta3 == "Sim" || resposta3 == "s"){

                System.Console.WriteLine("Desja excluir qual item? Digite o índice de array");
                int excluir = int.Parse(Console.ReadLine());
                produtos.RemoveAt(excluir); //Entre os parenteses é o indice do array]


                 Console.WriteLine("Lista alterada: ");

                 foreach(Produto p in produtos){
                    System.Console.WriteLine("-------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
                    Console.ResetColor();
                    System.Console.WriteLine("-------------------------------------------------");
                }

            }
           
            //Remover atráves de expressões
            //produtos.RemoveAll(x => x.Nome == "Zenfone Asus");

           


        }
    }
}
