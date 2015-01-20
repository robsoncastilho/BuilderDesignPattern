namespace BuilderDesignPatternLib
{
    // Builder concreto - implementa uma forma de criar o personagem
    public class CriadorDeGuerreiroFuturista : CriadorDeGuerreiro
    {
        public CriadorDeGuerreiroFuturista()
        {
            _guerreiro = new GuerreiroFuturista();
        }

        public override void ComEspada()
        {
            _guerreiro.EscolherEspada("espada futurista");
        }

        public override void ComArmadura()
        {
            _guerreiro.ColocarArmadura("armadura futurista");
        }

        public override void ComArco()
        {
            _guerreiro.EscolherArco("arco futurista");
        }
    }
}