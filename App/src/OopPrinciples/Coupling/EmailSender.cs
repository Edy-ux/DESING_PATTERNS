

namespace design_patterns.src.OopPrinciples.Coupling;
public class EmailSender : ISenderNotification
{
    public void SendNotification(string message)
    {
        // Email sending logic
        Console.WriteLine($"Sending email notification: {message}");
    }
}
