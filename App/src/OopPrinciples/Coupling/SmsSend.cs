

namespace design_patterns.src.OopPrinciples.Coupling;

public class SmsSend : ISenderNotification
{
    public void SendNotification(string message)
    {
        //SMS sending logic
        Console.WriteLine($"SMS notification: {message}");
    }
}
