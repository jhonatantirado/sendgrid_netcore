using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        private static void Main()
        {
            Execute().Wait();
        }

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("Morita-SendGridAPIKey");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("jhonatantiradotiradodeep@gmail.com", "Jhonatan Tirado");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("jhonatan.tirado@unmsm.edu.pe", "Jhonatan Tirado UNMSM");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
