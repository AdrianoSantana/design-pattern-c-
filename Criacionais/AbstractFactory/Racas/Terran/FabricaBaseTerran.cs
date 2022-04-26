using AbstractFactory.Interfaces;

namespace AbstractFactory.Racas.Terran
{
    public class FabricaBaseTerran : IFabricaBases
    {
        public void CriarBase()
        {
            Console.WriteLine("Criando Base Terran");
            var revestimento = new RevestimentoBaseTerran();
            revestimento.Composicao();

            var energia = new EnergiaBaseTerran();
            energia.Composicao();
        }
    }
}