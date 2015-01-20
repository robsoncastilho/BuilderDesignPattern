namespace BuilderDesignPatternLib
{
    // Produto abstrato - resultado do builder
    public abstract class Guerreiro
    {
        public string Espada { get; protected set; }
        public string Armadura { get; protected set; }
        public string Arco { get; protected set; }

        public abstract void EscolherEspada(string espada);
        public abstract void ColocarArmadura(string armadura);
        public abstract void EscolherArco(string arco);
    }
}