using Microsoft.Extensions.Logging;
using MimeKit;

namespace BLL.Services;

public class Service
{

    private  readonly ILogger<Service> logger;

    public Service(ILogger<Service> logger)
    {
        this.logger = logger;
    }

    public static void SendEmail(string name, string email,string phonenumber , string adress, string title,string messagetitle)
    {
        try
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Моя компания", "vzlommamonta@gmail.com"));
            message.To.Add(new MailboxAddress("olegsolovyanenko@gmail.com"));
            message.Subject = "Первый первый я второй ,мамонт заскамлен";
            message.Body = new BodyBuilder()
            {
                HtmlBody = $"<div style=\"color: blue;\">Хахаха заскамил мамонта: {name} {email} {phonenumber} {adress} {title} {messagetitle}</div>"
            }.ToMessageBody();

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("vzlommamonta@gmail.com", "r6dlZ4fHHA");
                client.Send(message);

                client.Disconnect(true);
            }

        }
        catch (Exception e)
        {
        }
    }
}