using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Terran
{
    public class RevestimentoBaseTerran : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Revestimento da base terran");
        }
    }
}