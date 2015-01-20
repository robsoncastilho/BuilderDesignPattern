namespace BuilderDesignPatternLib
{
    public class Exercito
    {
        public void ConstruirGuerreiro(CriadorDeGuerreiro criadorDeGuerreiro)
        {
            criadorDeGuerreiro.ComArco();
            criadorDeGuerreiro.ComArmadura();
            criadorDeGuerreiro.ComEspada();
        }
    }
}
