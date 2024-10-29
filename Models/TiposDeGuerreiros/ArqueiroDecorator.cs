
    public class Arqueiro : Guerreiro
    {
        public Arqueiro(string nome) : base(nome, 20, 5, 5)
        {
        }

        public override void Atacar(Guerreiro oponente)
        {
            base.Atacar(oponente);
        }
    }

