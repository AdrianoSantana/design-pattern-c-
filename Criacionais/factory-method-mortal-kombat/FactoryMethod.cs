using factory_method_mortal_kombat.Personagens;

namespace factory_method_mortal_kombat
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
          switch(personagem)
          {
            case "Liu Kang": return new LiuKang();
            case "Sub Zero": return new SubZero();
            case "Scorpion": return new Scorpion();
            default: throw new Exception("Escolha um personagem!");
          }
        }
    }
}