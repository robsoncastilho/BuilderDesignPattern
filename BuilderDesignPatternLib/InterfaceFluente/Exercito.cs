namespace BuilderDesignPatternLib.InterfaceFluente
{
    public class Exercito
    {
        public void ConstruirGuerreiro(CriadorDeGuerreiro criadorDeGuerreiro)
        {
            criadorDeGuerreiro.ComArco().ComArmadura().ComEspada();
        }
    }
}
