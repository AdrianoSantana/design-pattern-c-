using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Protoss
{
    public class RevestimentoBaseProtoss : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Revestimento da base protoss");
        }
    }
}