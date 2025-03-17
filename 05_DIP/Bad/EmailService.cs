namespace SOLID._05_DIP.Bad;

/*
Mau exemplo de código,
A classe NotificationService depende diretamente da implementação concreta da classe EmailService.
Isso dificulta a troca de implementação de EmailService por outra classe que implemente a mesma interface e aumenta o acoplamento.
*/

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