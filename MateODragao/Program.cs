using System;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                Console.Clear ();
                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("       Mate o Dragão!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar Jogo ");
                System.Console.WriteLine (" 0 - Sair do Jogo ");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro Guerreiro = new Guerreiro ();
                        Guerreiro.Nome = "Carti";
                        Guerreiro.Sobrenome = "Fontenelas";
                        Guerreiro.CidadeNatal = "Konoha";
                        Guerreiro.DatadeNascimento = DateTime.Parse ("16/04/1201");
                        Guerreiro.FerramentaAtaque = "Espada";
                        Guerreiro.FerramentaProtecao = "Escudão";
                        Guerreiro.Forca = 2;
                        Guerreiro.Inteligencia = 4;
                        Guerreiro.Destreza = 2;
                        Guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragulino";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /*INICIO - Primeiro Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");
                        System.Console.WriteLine ($"{dragaoo.Nome.ToUpper()}: Humano tolinho. Quem pensas que és ??");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /*FIM - Primeiro Diálogo */

                        /*INICIO - Segundo Diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostrar meu valor!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: QUEM ? DE ONDE ? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine ("BAMBAM: Tá na hora do Show!");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        /*FIM - Segundo Diálogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = Guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = Guerreiro.Forca > Guerreiro.Inteligencia ? Guerreiro.Forca + Guerreiro.Destreza : Guerreiro.Inteligencia + Guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro) {
                            System.Console.WriteLine ("**** Turno do Jogador ****");
                            System.Console.WriteLine ("Escolha uma ação: ");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int GuerreiroDestrezaTotal = Guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (GuerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto IMUNDOOOO! BIRLLLLLLLLLLLLLLL");
                                        dragao.vida -= dragao.vida - poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.nome.ToUpper()}: Você errou corno!");

                                    }

                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora Fuiii Familia VLW FLW KKJ");
                                    System.Console.WriteLine ($"{dragao.Nome.Toupper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        while (Guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu) {
                            Console.Clear ();
                            System.Console.WriteLine ("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int GuerreiroDestrezaTotal = Guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (GuerreiroDestrezaTotal < dragaoDestrezaTotal) {
                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Fritou o forévis kkkjj");
                                dragao.vida -= dragao.Forca;
                                System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                            } else {
                                System.Console.WriteLine ($"{dragao.nome.ToUpper()}: Errou DESGRAÇADO!");
                            }

                            System.Console.WriteLine ();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            Console.Clear ();

                            System.Console.WriteLine ("**** Turno do Jogador ****");
                            System.Console.WriteLine ("Escolha uma ação: ");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    int GuerreiroDestrezaTotal = Guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (GuerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto IMUNDOOOO! BIRLLLLLLLLLLLLLLL");
                                        dragao.vida -= dragao.vida - poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.nome.ToUpper()}: Você errou corno!");

                                    }

                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora Fuiii Familia VLW FLW KKJ");
                                    System.Console.WriteLine ($"{dragao.Nome.Toupper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        break;

                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine ("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine ("Comando Inválido!");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    }
}