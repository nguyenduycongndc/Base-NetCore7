using Web.Common;
using Web.Model;
namespace Web.Services.Interface
{
    public interface ISendMailService
    {
        bool SendMailOTPAsync(string Email);
    }
}
