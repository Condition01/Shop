namespace Shop.Domain.Services
{
    public class EmailService : IEmailService
    {
        void IEmailService.Send(string name, string email)
        {
            Console.WriteLine($"Email enviado para endereço: ${email}, cliente: {name}");
        }
    }
}
