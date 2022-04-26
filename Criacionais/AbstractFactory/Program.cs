// See https://aka.ms/new-console-template for more information
using AbstractFactory.Interfaces;
using AbstractFactory.Racas.Protoss;
using AbstractFactory.Racas.Terran;
using AbstractFactory.Racas.Zerg;

IFabricaBases fabricaBases;

Console.WriteLine("Escolha um dos personagens: 1 - Protoss | 2 - Zergs | 3 - Terranos");
var escolha = Console.ReadLine();

switch(escolha)
{
    case "1":
        fabricaBases = new FabricaBaseProtoss();
        fabricaBases.CriarBase();
        break;

    case "2":
        fabricaBases = new FabricaBaseZerg();
        fabricaBases.CriarBase();
        break;

    case "3":
        fabricaBases = new FabricaBaseTerran();
        fabricaBases.CriarBase();
        break;

    default:
        throw new Exception("Não existe um personagem com esse código!");
}
