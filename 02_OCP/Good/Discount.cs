namespace SOLID._02_OCP.Good;

public enum EProductType
{
    Eletronics = 1,
    Health = 2,
    Beauty = 3,
    Clothing = 4
}

/*
Bom exemplo de código,
pois a classe Discount segue o princípio OCP,
pois toda vez que um novo tipo de produto for adicionado, será necessário criar uma nova classe que herda de Discount.

- Usando o polimorfismo, para estender o comportamento da classe Discount, sem alterar o código existente.

- Novos tipos de produtos podem ser adicionados sem alterar o código da classe Discount.
*/

public abstract class Discount
{   
    public abstract double Calculate(double price);
}

public class EletronicsDiscount : Discount
{
    public override double Calculate(double price) => price * 0.2;
}

public class HealthDiscount : Discount
{
    public override double Calculate(double price) => price * 0.3;
}

public class BeautyDiscount : Discount
{
    public override double Calculate(double price) => price * 0.4;
}

public class ClothingDiscount : Discount
{
    public override double Calculate(double price) => price * 0.5;
}