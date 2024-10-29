using System;
using System.Collections.Generic;

public class JogoService
    {
        private Base baseA;
        private Base baseB;
        private List<Guerreiro> guerreirosA;
        private List<Guerreiro> guerreirosB;
        private Random random;

        public JogoService()
        {
            baseA = new Base("Base A");
            baseB = new Base("Base B");
            guerreirosA = new List<Guerreiro>();
            guerreirosB = new List<Guerreiro>();
            random = new Random();
        }

        public void IniciarJogo()
        {
            while (baseA.Vida > 0 && baseB.Vida > 0)
            {
                Console.WriteLine("\n--- Novo turno ---");

                // Criação de guerreiros aleatórios a partir de cada base
                if (random.Next(0, 2) == 0)
                {
                    guerreirosA.Add(baseA.GerarGuerreiroAleatorio());
                }
                if (random.Next(0, 2) == 0)
                {
                    guerreirosB.Add(baseB.GerarGuerreiroAleatorio());
                }

                // Movimento dos guerreiros
                ProcessarTurno();
            }

            // Fim de jogo
            if (baseA.Vida <= 0)
            {
                Console.WriteLine("Base A foi destruída. Base B venceu!");
            }
            else
            {
                Console.WriteLine("Base B foi destruída. Base A venceu!");
            }
        }

        private void ProcessarTurno()
        {
            // Batalhas entre guerreiros
            for (int i = 0; i < Math.Min(guerreirosA.Count, guerreirosB.Count); i++)
            {
                Guerreiro guerreiroA = guerreirosA[i];
                Guerreiro guerreiroB = guerreirosB[i];

                guerreiroA.Atacar(guerreiroB);
                if (guerreiroB.Vida > 0)
                {
                    guerreiroB.Atacar(guerreiroA);
                }
                else
                {
                    guerreirosB.RemoveAt(i);
                }

                if (guerreiroA.Vida <= 0)
                {
                    guerreirosA.RemoveAt(i);
                }
            }

            // Se sobrar guerreiros, eles atacam a base inimiga
            if (guerreirosA.Count > guerreirosB.Count)
            {
                baseB.ReceberDano(guerreirosA[guerreirosB.Count].Ataque);
            }

            if (guerreirosB.Count > guerreirosA.Count)
            {
                baseA.ReceberDano(guerreirosB[guerreirosA.Count].Ataque);
            }
        }
    }

