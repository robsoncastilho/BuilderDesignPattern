namespace BuilderDesignPatternLib.InterfaceFluente
{
    public class CriadorDeGuerreiroMedieval : CriadorDeGuerreiro
    {
        public CriadorDeGuerreiroMedieval()
        {
            _guerreiro = new GuerreiroMedieval();
        }

        public override CriadorDeGuerreiro ComEspada()
        {
            _guerreiro.EscolherEspada("espada medieval");
            return this;
        }

        public override CriadorDeGuerreiro ComArmadura()
        {
            _guerreiro.ColocarArmadura("armadura medieval");
            return this;
        }

        public override CriadorDeGuerreiro ComArco()
        {
            _guerreiro.EscolherArco("arco medieval");
            return this;
        }
    }
}
