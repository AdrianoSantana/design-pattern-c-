using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Protoss
{
    public class EnergiaBaseProtoss : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base protoss");
        }
    }
}