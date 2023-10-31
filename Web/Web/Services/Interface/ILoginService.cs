using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Common;
using Web.Model;

namespace Web.Services.Interface
{
    public interface ILoginService
    {
        public ResultModel Login(InputLoginModel inputModel);
        public Task<ResultModel> ForgotPassWordAsync(ForgotPassWordModel forgotPassWordModel); 
        public Task<ResultModel> RegisterAsync(RegisterModel registerModel);
    }
}
