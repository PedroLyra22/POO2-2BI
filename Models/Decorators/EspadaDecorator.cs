public class EspadaDecorator : GuerreiroDecorator
{
    private int _incrementoAtaque = 10;

    public EspadaDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
        this.Ataque += _incrementoAtaque;
    }

    public override void Atacar(Guerreiro oponente)
    {
        base.Atacar(oponente);
    }
}
