/// <summary>
/// Bad example of code.
/// The NotificationService class directly depends on the concrete implementation of the EmailService class.
/// This makes it difficult to replace the implementation of EmailService with another class that implements the same interface and increases coupling.
/// 
/// Mau exemplo de código.
/// A classe NotificationService depende diretamente da implementação concreta da classe EmailService.
/// Isso dificulta a troca de implementação de EmailService por outra classe que implemente a mesma interface e aumenta o acoplamento.
/// </summary>
namespace SOLID._05_DIP.Bad;

public class EmailService
{
    public void Send()
    {
       Console.WriteLine("Sending email");
    }
}

public class NotificationService(EmailService _emailService)
{
    public void PromoteProduct()
    {
        // Promote product
        _emailService.Send();
    }
}