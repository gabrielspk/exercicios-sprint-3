using System;
using MateODragao.models;

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

                        Guerreiro guerreiro = CriarGuerreiro ();

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragulino";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.inteligencia = 3;
                        dragao.vida = 300;

                        /*INICIO - Primeiro Diálogo */
                        CriarDialogo(guerreiro.Nome, $"{dragao.Nome}, seu louco! Vim-lhe derrotar-lhe");
                        CriarDialogo(dragao.Nome, "Humano tolinho. Quem pensas que és ?");

                        FinalizarDialogo ();

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

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
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
                                    int GuerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (GuerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto IMUNDOOOO! BIRLLLLLLLLLLLLLLL");
                                        dragao.vida -= dragao.vida - poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Você errou corno!");

                                    }

                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora Fuiii Familia VLW FLW KKJ");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }

                        }

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        while (guerreiro.Vida > 0 && dragao.vida > 0 && jogadorNaoCorreu) {
                            Console.Clear ();
                            System.Console.WriteLine ("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random ();
                            int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                            int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                            int GuerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                            int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                            if (GuerreiroDestrezaTotal < dragaoDestrezaTotal) {
                                System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Fritou o forévis kkkjj");
                                dragao.vida -= dragao.Forca;
                                System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                            } else {
                                System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou DESGRAÇADO!");
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
                                    geradorNumeroAleatorio = new Random ();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);
                                    GuerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (GuerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto IMUNDOOOO! BIRLLLLLLLLLLLLLLL");
                                        dragao.vida -= dragao.vida - poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ($"HP Dragão: {dragao.vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Você errou corno!");

                                    }

                                    break;
                                case "2":
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Simbora Fuiii Familia VLW FLW KKJ");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        if (guerreiro.Vida <= 0) {
                            System.Console.WriteLine ("Você Perdeu!");
                        }
                        if (dragao.vida <= 0) {
                            System.Console.WriteLine ("Você Venceu!");
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

        public static void CriarDialogo (string nome, string frase) {

            System.Console.WriteLine ($"{nome.ToUpper()}:{frase}");

        }

        // *Como abrir um método ! */

        public static void FinalizarDialogo () {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear ();
        }

        public static Guerreiro CriarGuerreiro () {
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Carti";
            guerreiro.Sobrenome = "Fontenelas";
            guerreiro.CidadeNatal = "Konoha";
            guerreiro.DatadeNascimento = DateTime.Parse ("16/04/1201");
            guerreiro.FerramentaAtaque = "Espada";
            guerreiro.FerramentaProtecao = "Escudão";
            guerreiro.Forca = 2;
            guerreiro.Inteligencia = 4;
            guerreiro.Destreza = 2;
            guerreiro.Vida = 20;

            return guerreiro;
        }

    }
}

