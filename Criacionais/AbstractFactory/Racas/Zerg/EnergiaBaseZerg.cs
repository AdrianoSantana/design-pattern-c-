using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Zerg
{
    public class EnergiaBaseZerg : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base zerg");
        }
    }
}