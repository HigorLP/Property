using System;
using System.Collections.Generic;

namespace Property {
    internal class Menu {
        static void Main(string[] args) {
            List<Property> properties = new List<Property>();

            while (true) {
                Console.WriteLine("1. Cadastrar imóvel novo");
                Console.WriteLine("2. Cadastrar imóvel usado");
                Console.WriteLine("3. Visualizar imóveis");
                Console.WriteLine("4. Sair");

                int option = int.Parse(Console.ReadLine());

                if (option == 1) {
                    Console.WriteLine("Rua: ");
                    string street = Console.ReadLine();

                    Console.WriteLine("Número: ");
                    string number = Console.ReadLine();

                    Console.WriteLine("Bairro: ");
                    string neighborhood = Console.ReadLine();

                    Console.WriteLine("Cidade: ");
                    string city = Console.ReadLine();

                    Console.WriteLine("Preço: ");
                    double price = double.Parse(Console.ReadLine());
                    string address = street + ", " + number + " - " + neighborhood + " - " + city;

                    properties.Add(new NewProperty(address, price));

                    Console.WriteLine("Imóvel novo cadastrado com sucesso!");
                } else if (option == 2) {
                    Console.WriteLine("Rua: ");
                    string street = Console.ReadLine();

                    Console.WriteLine("Número: ");
                    string number = Console.ReadLine();

                    Console.WriteLine("Bairro: ");
                    string neighborhood = Console.ReadLine();

                    Console.WriteLine("Cidade: ");
                    string city = Console.ReadLine();
                    Console.WriteLine("Preço: ");
                    double price = double.Parse(Console.ReadLine());

                    string address = street + ", " + number + " - " + neighborhood + " - " + city;
                    properties.Add(new UsedProperty(address, price));

                    Console.WriteLine("Imóvel usado cadastrado com sucesso!");
                } else if (option == 3) {
                    if (properties.Count == 0) {
                        Console.WriteLine("Não há imóveis cadastrados.");
                    } else {
                        foreach (Property property in properties) {
                            property.PrintInfo();
                            Console.WriteLine();
                        }
                    }
                } else if (option == 4) {
                    break;
                } else {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }
    }
}
