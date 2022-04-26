using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Zerg
{
    public class RevestimentoBaseZerg : IRevestimento
    {
        public void Composicao()
        {
            Console.WriteLine("Revestimento da base Zerg");
        }
    }
}