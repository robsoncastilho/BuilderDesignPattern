namespace BuilderDesignPatternLib
{
    // Builder abstrato - fornece uma interface para criação de um guerreiro
    public abstract class CriadorDeGuerreiro
    {
        protected Guerreiro _guerreiro;
        public Guerreiro ObterGuerreiro()
        {
            return _guerreiro;
        }

        public abstract void ComEspada();
        public abstract void ComArmadura();
        public abstract void ComArco();
    }
}
