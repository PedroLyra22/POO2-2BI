public abstract class GuerreiroDecorator : Guerreiro
{
    protected Guerreiro _guerreiro;

    public GuerreiroDecorator(Guerreiro guerreiro) : base(guerreiro.Nome, guerreiro.Ataque, guerreiro.Defesa, guerreiro.Vida)
    {
        _guerreiro = guerreiro;
    }

    public override void Atacar(Guerreiro oponente)
    {
        _guerreiro.Atacar(oponente);
    }

    public override void ReceberDano(int dano)
    {
        _guerreiro.ReceberDano(dano);
    }
}
