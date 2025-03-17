/// <summary>
/// Good example of code,
/// The BankAccount class is an abstract class that defines a contract for the SavingsAccount and CheckingAccount classes.
/// This ensures that both classes respect the base class contract without impacting the application's behavior.
/// 
/// Bom exemplo de código,
/// A classe BankAccount é uma classe abstrata que define um contrato para a classe SavingsAccount e CheckingAccount.
/// Assim garantindo que ambas as classes respeitem o contrato da classe base, sem impactar o comportamento da aplicação.
/// </summary>
namespace SOLID._03_LSP.Good;

public abstract class BankAccount
{
    public decimal Balance { get; protected set; }

    public abstract void Withdraw(decimal amount);

}

public class SavingsAccount : BankAccount
{
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

public class CheckingAccount : BankAccount
{
    public override void Withdraw(decimal amount)
    {
       throw new NotImplementedException();
    }
}