using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Terran
{
    public class EnergiaBaseTerran : IEnergia
    {
        public void Composicao()
        {
            Console.WriteLine("Energia de sustentação da base terran");
        }
    }
}