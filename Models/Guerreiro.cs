public class Guerreiro
{
    public string Nome { get; set; }
    public int Ataque { get; set; }
    public int Defesa { get; set; }
    public int Vida { get; set; }

    public Guerreiro(string nome, int ataque, int defesa, int vida)
    {
        Nome = nome;
        Ataque = ataque;
        Defesa = defesa;
        Vida = vida;
    }

    public virtual void Atacar(Guerreiro oponente)
    {
        int dano = this.Ataque - oponente.Defesa;
        if (dano > 0)
        {
            oponente.ReceberDano(dano);
            Console.WriteLine($"{Nome} causou {dano} de dano a {oponente.Nome}");
        }
        else
        {
            Console.WriteLine($"{Nome} não conseguiu penetrar a defesa de {oponente.Nome}");
        }
    }

    public virtual void ReceberDano(int dano)
    {
        Vida -= dano;
        Console.WriteLine($"{Nome} recebeu {dano} de dano e tem {Vida} de vida restante.");
    }
}
