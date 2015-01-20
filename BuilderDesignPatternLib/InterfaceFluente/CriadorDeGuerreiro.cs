namespace BuilderDesignPatternLib.InterfaceFluente
{
    public abstract class CriadorDeGuerreiro
    {
        protected Guerreiro _guerreiro;
        public Guerreiro ObterGuerreiro()
        {
            return _guerreiro;
        }

        // retorno alterado de 'void' para 'CriadorDeGuerreiro'
        public abstract CriadorDeGuerreiro ComEspada();
        public abstract CriadorDeGuerreiro ComArmadura();
        public abstract CriadorDeGuerreiro ComArco();
    }
}