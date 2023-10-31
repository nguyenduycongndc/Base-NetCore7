using Web.Common;
using Web.Data;
using Web.Model;
using Web.Repo;
using Web.Repo.Interface;
using Web.Services.Interface;
using System;
using System.Diagnostics.Metrics;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web.Helpers;

namespace Web.Services
{
    public class SendMailService : ISendMailService
    {
        private readonly ILogger<SendMailService> _logger;
        private readonly IConfiguration _configuration;
        private readonly IUserRepo _userRepo;

        public SendMailService(IConfiguration configuration, ILogger<SendMailService> logger, IUserRepo userRepo)
        {
            _logger = logger;
            _configuration = configuration;
            _userRepo = userRepo;
        }
        #region Send OTP
        public bool SendMailOTPAsync(string email)
        {
            try
            {
                string OTP = "";
                Random rand = new Random();
                OTP = rand.Next(0, 1000000).ToString("D6");
                var datenow = DateTime.Now;
                var expdate = datenow.AddMinutes(2);
                var rs = _userRepo.CheckEmailUser(email);
                if (rs.Count == 0)
                {
                    return false;
                }
                else
                {
                    var userUpdateOTP = new UserUpdateOTPModel()
                    {
                        Email = email,
                        OTP = OTP,
                        Expdate = expdate,
                    };
                    _userRepo.UpdateOTPUs(userUpdateOTP);
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.Subject = "OTP thay đổi mật khẩu";
                    mailMessage.Body = "Mã OTP của bạn là: " + OTP;
                    mailMessage.From = new MailAddress(_configuration.GetSection("EmailUsername").Value);
                    mailMessage.To.Add(new MailAddress(email));
                    mailMessage.IsBodyHtml = true;
                    var smtpClient = new SmtpClient(_configuration.GetSection("EmailHost").Value)
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(_configuration.GetSection("EmailUsername").Value, _configuration.GetSection("EmailPassword").Value),
                        EnableSsl = true,
                    };
                    smtpClient.Send(mailMessage);
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #endregion
        
    }
}
