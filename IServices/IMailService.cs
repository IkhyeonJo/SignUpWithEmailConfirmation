using System.Threading.Tasks;
using SignupWithMailConfirmation.Models;

namespace SignupWithMailConfirmation.IServices
{
    public interface IMailService
    {
         Task<string> SendMail(Mail oMailClass);
         string GetMailBody(LoginInfo oLoginInfo);
    }
}