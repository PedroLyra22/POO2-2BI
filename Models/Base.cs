using System;
using System.Collections.Generic;


    public class Base
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        private Random random = new Random();

        public Base(string nome)
        {
            Nome = nome;
            Vida = 1000; // Vida inicial da base
        }

        // Método para criar guerreiros aleatoriamente
        public Guerreiro GerarGuerreiroAleatorio()
        {
            int tipo = random.Next(0, 3); // 0: Espadachim, 1: Arqueiro, 2: Cavaleiro
            switch (tipo)
            {
                case 0:
                    return new Espadachim($"Espadachim do {Nome}");
                case 1:
                    return new Arqueiro($"Arqueiro do {Nome}");
                case 2:
                    return new Cavaleiro($"Cavaleiro do {Nome}");
                default:
                    return new Espadachim($"Espadachim do {Nome}");
            }
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;
            Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida restante da base: {Vida}");
        }
    }

