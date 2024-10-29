
    public class Cavaleiro : Guerreiro
    {
        public Cavaleiro(string nome) : base(nome, 5, 10, 15)
        {
        }

        public override void Atacar(Guerreiro oponente)
        {
            base.Atacar(oponente);
        }
    }

