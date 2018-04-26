using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RojgarMitraWebApi.IRepository;
using RojgarMitraWebApi.Repository;
using RojgarMitraWebApi.DBManager;
using RojgarMitraWebApi.BusinessModel;

namespace RojgarMitraWebApi.Controllers
{

    public class AccountController : ApiController
    {
        
        static readonly IAccountRepository ObjAccountRepository = new AccountRepository(new RojgarMitraEntities());
        static readonly ITokenRepository _objTokenRepository = new TokenRepository(new RojgarMitraEntities());                  

        [HttpGet]
        public HttpResponseMessage Login(string UserName, string Password, bool? rememberMe)
        {
          
            rememberMe = rememberMe == null ? true : rememberMe;
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                var objUser = ObjAccountRepository.UserLogin(UserName, Password);
                if (objUser != null)
                {
                    if (string.IsNullOrEmpty(objUser.AuthTocken))
                    {
                        var objTok = _objTokenRepository.GenerateToken(objUser.UserID);
                        objUser.AuthTocken = objTok.AuthToken;
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, objUser);                
                                       
                }
                
            }
           
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest,"Please enter valid Data");
        }
        [HttpPost]
        public IHttpActionResult SavePersonalDetails(UserRegistartionPersonalDetailsModel model)
        {
           return Json(ObjAccountRepository.SavePersonalDetails(model));            
        }
        [HttpPost]
        public IHttpActionResult SaveEmploymentDetails(UserRegistrationEmployeMentModel model)
        {
            return Json(ObjAccountRepository.SaveEmploymentDetails(model));
        }
        [HttpPost]
        public IHttpActionResult SaveEducationDetails(UserRegistrationEducationModel model)
        {
          
            return Json(ObjAccountRepository.SaveEducationDetails(model));
        }
        [HttpGet]
        public IHttpActionResult CheckMail(string email)
        {

            return Json(ObjAccountRepository.Checkmail(email));
        }
    }
}
