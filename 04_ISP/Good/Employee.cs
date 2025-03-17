namespace SOLID._04_ISP.Good;

/*
Bom exemplo de código,
A interface ISalaryCalculator e IBenefitsCalculator são interfaces segregadas, cada uma com uma responsabilidade específica.
E permite que as classes implementem apenas os métodos que precisam.
*/

public interface ISalaryCalculator
{
    void CalculateSalary();
}

public interface IBenefitsCalculator
{
    void CalculateBenefits();
}

public class fullTimeEmployee : ISalaryCalculator, IBenefitsCalculator
{
    public void CalculateBenefits()
    {
        Console.WriteLine("Calculating benefits for full time employee");
    }

    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for full time employee");
    }
}

public class PartTimeEmployee : ISalaryCalculator
{
    public void CalculateSalary()
    {
        Console.WriteLine("Calculating salary for part time employee");
    }
}