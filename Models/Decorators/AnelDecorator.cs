public class AnelDecorator : GuerreiroDecorator
{
    private double _poderReflexivo = 0.1; // 10% de reflexo
    private int _esferasDePoder = 0;

    public AnelDecorator(Guerreiro guerreiro) : base(guerreiro)
    {
    }

    public void ColetarEsfera()
    {
        if (_esferasDePoder < 9) // máximo de 100% (10 esferas)
        {
            _esferasDePoder++;
            _poderReflexivo += 0.1;
            Console.WriteLine($"{Nome} coletou uma esfera de poder. Poder reflexivo agora é {_poderReflexivo * 100}%.");
        }
        else
        {
            Console.WriteLine($"{Nome} já alcançou o máximo de poder reflexivo.");
        }
    }

    public override void ReceberDano(int dano)
    {
        base.ReceberDano(dano);
        int danoRefletido = (int)(dano * _poderReflexivo);
        Console.WriteLine($"{Nome} refletiu {danoRefletido} de dano.");
    }
}
