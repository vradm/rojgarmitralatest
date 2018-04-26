using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.IRepository;

namespace RojgarMitraWebApi.IRepository
{
   public interface IAccountRepository
    {
        AccountModel UserLogin(string EmailID, string Password);
        AccountModel SavePersonalDetails(UserRegistartionPersonalDetailsModel model);
        ResponseModel SaveEmploymentDetails(UserRegistrationEmployeMentModel model);
        ResponseModel SaveEducationDetails(UserRegistrationEducationModel model);
        bool Checkmail(string Email);
    }
}
