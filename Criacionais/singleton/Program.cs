// See https://aka.ms/new-console-template for more information
using Criacionais.singleton;

Bola jogador_1 = Bola.GetInstancia;
jogador_1.Mensagem("Jogador 1: A bola está comigo no meio do campo");

Bola jogador_2_pede_bola = Bola.GetInstancia;
jogador_2_pede_bola.Mensagem("Jogador 2: Recebeu a bola na lateral");

Bola jogador_3_pede_bola = Bola.GetInstancia;
jogador_3_pede_bola.Mensagem("Jogador 3: Recebeu a bola no pequena área");

Console.WriteLine("---------Logs----------");
jogador_1.getToquesNaBola();


