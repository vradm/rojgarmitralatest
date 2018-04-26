using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.DBManager;
using RojgarMitraWebApi.Repository;
using RojgarMitraWebApi.IRepository;
using System.Configuration;
using System.Web;

namespace RojgarMitraWebApi.Controllers
{
    
    public class UserProfileController : ApiController
    {
        static readonly private IUserProfileRepository _UserProfileRepository = new UserProfileRepository(new RojgarMitraEntities());

        [HttpGet]
        public IHttpActionResult UserdetailsByonId(long Userid)
        {

            return Json(_UserProfileRepository.UserdetailsByonId(Userid));
        }

        [HttpPost]
        public IHttpActionResult UpdateProfileInfo(UserProfileModel Model)
        {

            return Json(_UserProfileRepository.UpdateProfileInfo(Model));
        }

        [HttpPost]
        public IHttpActionResult UpdateWorkEducation()
        {
            UserProfileModel Model = new UserProfileModel();
            try
            {
                Model.HighestQualification = (HttpContext.Current.Request.Params["HighestQualification"]);
                Model.Course = (HttpContext.Current.Request.Params["Course"]);
                Model.Specialization = (HttpContext.Current.Request.Params["Specialization"]);
                Model.University_College = (HttpContext.Current.Request.Params["University_College"]);
                Model.CourseType = (HttpContext.Current.Request.Params["CourseType"]);
                Model.PassingYear = Convert.ToInt32(HttpContext.Current.Request.Params["PassingYear"]);
                Model.UserId = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
                
            }
            
            return Json(_UserProfileRepository.UpdateWorkEducation(Model));
        }
        [HttpPost]
        public IHttpActionResult UpdateBasicInfo()
        {
            try
            {
                UserProfileModel Model = new UserProfileModel();
                Model.FullName = (HttpContext.Current.Request.Params["FullName"]);
                Model.EmailID = (HttpContext.Current.Request.Params["EmailID"]);
                Model.MobileNumber = (HttpContext.Current.Request.Params["MobileNumber"]);
                Model.UserId = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
                return Json(_UserProfileRepository.UpdateBasicInfo(Model));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }
        [HttpPost]
        public IHttpActionResult UpdateOtherInfo()
        {
            UserProfileModel Model = new UserProfileModel();
            try
            {
                Model.Dobyear = (HttpContext.Current.Request.Params["Dobyear"]);
                Model.DobMonth = (HttpContext.Current.Request.Params["DobMonth"]);
                Model.DobDay = (HttpContext.Current.Request.Params["Dobday"]);
                Model.Gender = (HttpContext.Current.Request.Params["Gender"]);
                Model.MaritalStatus = (HttpContext.Current.Request.Params["MaritalStatus"]);
                Model.MailingAddress = (HttpContext.Current.Request.Params["MailingAddress"]);
                Model.CityID = Convert.ToInt32(HttpContext.Current.Request.Params["CityID"]);
                Model.Pincode = Convert.ToInt32(HttpContext.Current.Request.Params["Pincode"]);
                Model.DifferAbled = (HttpContext.Current.Request.Params["DifferAbled"]);
                Model.UserId = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
                return Json(_UserProfileRepository.UpdateOtherInfo(Model));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }


        }
        [HttpPost]
        public IHttpActionResult UpdatePerosnalSkills()
        {
            UserSkillsDetails Model = new UserSkillsDetails();
            try
            {
                Model.Skills = (HttpContext.Current.Request.Params["UserSkillsDetail_Skills"]);
                Model.Version =Convert.ToDecimal(HttpContext.Current.Request.Params["UserSkillsDetail_Version"]);
                Model.LastUsedYear = Convert.ToInt32(HttpContext.Current.Request.Params["UserSkillsDetail_LastUsedYear"]);
                Model.Experience = Convert.ToInt32(HttpContext.Current.Request.Params["UserSkillsDetail_Experience"]);
                Model.UserID = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
                return Json(_UserProfileRepository.UpdatePersonalSkills(Model));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }


        }
        [HttpPost]
        public IHttpActionResult UpdateWorkHistory()
        {
            UserProfileModel Model = new UserProfileModel();
            try
            {
                Model.DesignationID = Convert.ToInt32(HttpContext.Current.Request.Params["DesignationID"]);
                Model.CompanyId = Convert.ToInt32(HttpContext.Current.Request.Params["CompanyId"]);
                Model.WorkingSinceYear = (HttpContext.Current.Request.Params["WorkingSinceYear"]);
                Model.WorkingSinceMonth = (HttpContext.Current.Request.Params["WorkingSinceMonth"]);
                Model.WorkingTo = (HttpContext.Current.Request.Params["WorkingTo"]);
                Model.UserId = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
                return Json(_UserProfileRepository.UpdateWorkHistory(Model));
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }


        }
        [HttpPost]
        public IHttpActionResult UpdateProfileDetails()
        {
            UserProfileModel Model = new UserProfileModel();
            try
            {
                Model.ExperienceID = (HttpContext.Current.Request.Params["ExperienceID"]);
                Model.CurrentLocationID= (HttpContext.Current.Request.Params["CurrentLocationID"]);
                Model.OutSideIndia =Convert.ToBoolean(HttpContext.Current.Request.Params["OutSideIndia"]);
                Model.FunctionalArea = (HttpContext.Current.Request.Params["FunctionalArea"]);
                Model.DesignationID = Convert.ToInt32(HttpContext.Current.Request.Params["DesignationID"]);
                Model.IndustryId = (HttpContext.Current.Request.Params["IndustryId"]);
                Model.JobTypeId = (HttpContext.Current.Request.Params["JobTypeId"]);
                Model.UserId = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
                return Json(_UserProfileRepository.UpdateProfileDetails(Model));
            }
            catch(Exception ex)
            {
                return Json(ex.Message);
            }
           
        }
        
        [HttpPost]
        public IHttpActionResult DeleteResume()
        {
           
             long UserID = Convert.ToInt32(HttpContext.Current.Request.Params["UserId"]);
            return Json(_UserProfileRepository.DeleteResume(UserID));
        }


    }
}
