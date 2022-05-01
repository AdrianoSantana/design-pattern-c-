namespace Criacionais.singleton 
{
  public sealed class Bola
  {
    private static Bola? instancia = null;
    private List<string> toquesNaBola = new List<string>();
    public static Bola GetInstancia
    {
      get
      {
        if (instancia == null)
        {
          instancia = new Bola();
          Console.WriteLine("Bola em jogo");
        }
        return instancia;
      }
    }

    public void Mensagem(string msg)
    {
      Console.WriteLine(msg);
      toquesNaBola!.Add(msg);
    }

    public void getToquesNaBola()
    {
      foreach (var log in toquesNaBola)
      {
        Console.WriteLine(log);
      }
      
    }
  }
}