namespace SOLID._02_OCP.Bad;

public enum EProductType
{
    Eletronics = 1,
    Health = 2,
    Beauty = 3,
    Clothing = 4
}


/*

Mau exemplo de código, 
pois a classe Discount viola o princípio OCP, 
pois toda vez que um novo tipo de produto for adicionado, será necessário alterar a classe Discount.

*/

public class Discount
{
    public double Calculate(EProductType productType, double price)
    {
        switch (productType)
        {
            case EProductType.Eletronics:
                return price * 0.2;
            case EProductType.Health:
                return price * 0.3;
            case EProductType.Beauty:
                return price * 0.4;
            case EProductType.Clothing:
                return price * 0.5;
            default:
                return price;
        }        
    }
}
