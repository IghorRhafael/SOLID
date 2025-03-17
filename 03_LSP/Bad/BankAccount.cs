/// <summary>
/// Bad example of code,
/// The SavingsAccount class inherits from BankAccount, but the Withdraw method was overridden and does not respect the base class contract.
/// Breaking the Liskov Substitution Principle.
/// 
/// Mau exemplo de código,
/// A classe SavingsAccount herda de BankAccount, mas o método Withdraw foi sobrescrito e não respeita o contrato da classe base.
/// Quebrando o princípio de substituição segura de Liskov.
/// </summary>
namespace SOLID._03_LSP.Bad;

public class BankAccount
{
    public virtual void Withdraw(decimal amount)
    {
        Console.WriteLine("Withdraw money");
    }
}

public class SavingsAccount : BankAccount
{
    public decimal Balance { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient funds");
        }

        Balance -= amount;
        Console.WriteLine($"Withdraw money {amount}");
    }
}