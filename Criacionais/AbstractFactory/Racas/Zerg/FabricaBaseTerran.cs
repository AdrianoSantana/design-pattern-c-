using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Zerg
{
    public class FabricaBaseZerg : IFabricaBases
    {
        public void CriarBase()
        {
            Console.WriteLine("Criando Base Terran");
            var revestimento = new RevestimentoBaseZerg();
            revestimento.Composicao();

            var energia = new EnergiaBaseZerg();
            energia.Composicao();
        }
    }
}