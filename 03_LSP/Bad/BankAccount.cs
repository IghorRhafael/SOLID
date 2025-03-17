namespace SOLID._03_LSP.Bad;

/*
Mau exemplo de código,
A classe SavingsAccount herda de BankAccount, mas o método Withdraw foi sobrescrito e não respeita o contrato da classe base.
Quebrando o princípio de substituição segura de Liskov.
*/
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