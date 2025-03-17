namespace SOLID._04_ISP.Bad;

/*
Mau exemplo de código,
A interface IEmployee tem mais de uma responsabilidade, ela calcula o salário e os benefícios do funcionário.
Isso viola o Princípio da Segregação de Interface, pois força as classes a implementar métodos que a classe não precisa.
*/

public interface IEmployee
{
    public string Name { get; set; }

    void CalculateSalary();
    void CalculateBenefts();
}

public class FullTimeEmployee : IEmployee
{
    public required string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for full time employee");
    }

    public void CalculateBenefts()
    {
        Console.WriteLine("Calculating benefits for full time employee");
    }
}

public class PartTimeEmployee : IEmployee
{
    public required string Name { get; set; }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for part time employee");
    }

    public void CalculateBenefts()
    {
        throw new NotImplementedException();
    }
}