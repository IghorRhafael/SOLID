/// <summary>
/// Good example of code,
/// The NotificationService class depends on an abstraction of the EmailService class, the IEmailService interface.
/// Allowing to replace the concrete implementation of EmailService with any other class that implements IEmailService.
/// 
/// Bom exemplo de código,
/// A classe NotificationService depende de uma abstração da classe EmailService, a interface IEmailService.
/// Permitindo trocar a implementação concreta de EmailService por qualquer outra classe que implemente IEmailService.
/// </summary>
namespace SOLID._05_DIP.Good;

public interface IEmailService
{
    void Send();
}

public class EmailService : IEmailService
{
    public void Send()
    {
       Console.WriteLine("Sending email");
    }
}

public class FakeEmailService : IEmailService
{
    public void Send()
    {
       Console.WriteLine("Sending fake email");
    }
}

public class NotificationService(IEmailService _emailService)
{
    public void PromoteProduct()
    {
        // Promote product
        _emailService.Send();
    }
}