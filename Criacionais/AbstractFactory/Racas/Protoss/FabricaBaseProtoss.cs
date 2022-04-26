using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Protoss
{
    public class FabricaBaseProtoss : IFabricaBases
    {
        public void CriarBase()
        {
            Console.WriteLine("Criando Base Protoss");
            var revestimento = new RevestimentoBaseProtoss();
            revestimento.Composicao();

            var energia = new EnergiaBaseProtoss();
            energia.Composicao();
        }
    }
}