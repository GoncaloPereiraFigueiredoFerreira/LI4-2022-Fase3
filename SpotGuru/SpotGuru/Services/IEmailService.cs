using System.Threading.Tasks;

namespace SpotGuru.Services
{
    public interface IEmailService
    {
        Task SendEmail(string email, string subject, string message);
    }
}
