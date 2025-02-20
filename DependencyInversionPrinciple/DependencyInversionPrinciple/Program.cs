public class Program
{
    public static void Main()
    {
        IEmailService emailService = new EmailService();
        var notification = new Notification(emailService);
        notification.PromotionalNotification();
        Console.WriteLine("You got mail!");
    }
}

public interface IEmailService
{
    void SendEmail(string emailContent);
}   


public class EmailService: IEmailService
{
    public void SendEmail(string emailContent)
    {
        Console.WriteLine("Sending email:" + emailContent);
    }
}

//Business Logic
public class Notification
{
    private IEmailService _emailService;

    public Notification(IEmailService emailService)
    {
        _emailService = new EmailService();
    }



    public void PromotionalNotification()
    {
        var content = "You have won a gift!";
        _emailService.SendEmail(content);
    }
}
