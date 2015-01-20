namespace BuilderDesignPatternLib
{
    public class GuerreiroFuturista : Guerreiro
    {
        public override void EscolherEspada(string espada)
        {
            Espada = espada;
        }

        public override void ColocarArmadura(string armadura)
        {
            Armadura = armadura;
        }

        public override void EscolherArco(string arco)
        {
            Arco = arco;
        }
    }
}