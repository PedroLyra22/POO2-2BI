public class ArmaduraDecorator : GuerreiroDecorator
{
    private int _incrementoDefesa = 10;

    public ArmaduraDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
        this.Defesa += _incrementoDefesa;
    }

    public override void ReceberDano(int dano)
    {
        base.ReceberDano(dano);
    }
}
