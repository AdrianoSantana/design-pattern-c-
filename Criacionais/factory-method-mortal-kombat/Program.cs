using factory_method_mortal_kombat;

FactoryMethod fm = new FactoryMethod();

Console.WriteLine("Escolha um personagem Liu Kang | Sub Zero | Scorpion ");
Console.WriteLine();

string personagemEscolhido = Console.ReadLine();

IPersonagem personagem = fm.EscolherPersonagem(personagemEscolhido!);
Console.WriteLine();
personagem.Escolhido();

Console.ReadKey();