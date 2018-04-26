using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.DBManager;
using RojgarMitraWebApi.BusinessModel.Generic_Repository;
using RojgarMitraWebApi.BusinessModel.UnitOfWork;
using RojgarMitraWebApi.IRepository;
using System.Transactions;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace RojgarMitraWebApi.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly RojgarMitraEntities _Context;
        private readonly _UnitOfWork unitOfWork;
        private  ResponseModel responseModel;
        public UserProfileRepository(RojgarMitraEntities Context)
        {
            unitOfWork = new _UnitOfWork();

            this._Context = Context;
            responseModel = new ResponseModel();
        }

        public UserProfileModel UserdetailsByonId(long UserId)
        {
            UserProfileModel userProfileModel = new UserProfileModel();
            try
            {
                userProfileModel = DBManager.SpHelper<UserProfileModel>.GetListWithRawSql("Usp_UserInfoOnId @Userid",
              new SqlParameter { ParameterName = "@Userid", DbType = System.Data.DbType.Int64, Value = UserId }).FirstOrDefault();
               
                userProfileModel.userSkillsDetails=DBManager.SpHelper<UserSkillsDetails>.GetListWithRawSql("Usp_UserSkillsDetails @Userid",
              new SqlParameter { ParameterName = "@Userid", DbType = System.Data.DbType.Int64, Value = UserId }).ToList();

                userProfileModel.userWorkHistories=DBManager.SpHelper<UserWorkHistory>.GetListWithRawSql("Usp_UserWorkHistory @Userid",
                       new SqlParameter { ParameterName = "@Userid", DbType = System.Data.DbType.Int64, Value = UserId }).ToList();

                userProfileModel.UserEducationDetails= DBManager.SpHelper<UserEducationDetails>.GetListWithRawSql("Usp_UserEducatioNDetails @Userid",
                       new SqlParameter { ParameterName = "@Userid", DbType = System.Data.DbType.Int64, Value = UserId }).ToList();
                return userProfileModel;

            }
            catch (Exception ex)
            {

            }
            return userProfileModel;


        }
        public ResponseModel UpdateProfileInfo(UserProfileModel model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdateuserProfile @userid,@FullName,@Designationid,@ResumeTitle,@ResumeName",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@FullName", DbType = System.Data.DbType.String, Value = model.FullName },
                        new SqlParameter { ParameterName = "@Designationid", DbType = System.Data.DbType.Int32, Value = model.DesignationID },
                          new SqlParameter { ParameterName = "@ResumeTitle", DbType = System.Data.DbType.String, Value = model.ResumeTitle },
                                  new SqlParameter { ParameterName = "@ResumeName", DbType = System.Data.DbType.String, Value = model.ResumeName }).FirstOrDefault();



                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel UpdateWorkEducation(UserProfileModel model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdateWorkEducation @userid,@HighestQualification,@Course,@Specialization,@University_College,@CourseType,@PassingYear",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@HighestQualification", DbType = System.Data.DbType.Int32, Value = model.HighestQualification },
                        new SqlParameter { ParameterName = "@Course", DbType = System.Data.DbType.Int32, Value = model.Course },
                          new SqlParameter { ParameterName = "@Specialization", DbType = System.Data.DbType.Int32, Value = model.Specialization },
                                  new SqlParameter { ParameterName = "@University_College", DbType = System.Data.DbType.Int32, Value = model.University_College },
                                  new SqlParameter { ParameterName = "@CourseType", DbType = System.Data.DbType.String, Value = model.CourseType },
                                   new SqlParameter { ParameterName = "@PassingYear", DbType = System.Data.DbType.Int32, Value = model.PassingYear }).FirstOrDefault();



                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel UpdateBasicInfo(UserProfileModel model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdateBasicInfo @userid,@FullName,@EmailID,@MobileNumber",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@FullName", DbType = System.Data.DbType.String, Value = model.FullName },
                        new SqlParameter { ParameterName = "@EmailID", DbType = System.Data.DbType.String, Value = model.EmailID },
                          new SqlParameter { ParameterName = "@MobileNumber", DbType = System.Data.DbType.String, Value = model.MobileNumber }).FirstOrDefault();

                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel UpdateOtherInfo(UserProfileModel model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdateOtherInfo @userid,@Dobyear,@DobMonth,@Dobday,@Gender,@MaritalStatus,@MailingAddress,@CityID,@DifferAbled",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@Dobyear", DbType = System.Data.DbType.Int32, Value = model.Dobyear },
                        new SqlParameter { ParameterName = "@DobMonth", DbType = System.Data.DbType.Int32, Value = model.DobMonth },
                          new SqlParameter { ParameterName = "@Dobday", DbType = System.Data.DbType.Int32, Value = model.DobDay },
                            new SqlParameter { ParameterName = "@Gender", DbType = System.Data.DbType.String, Value = model.Gender },
                      new SqlParameter { ParameterName = "@MaritalStatus", DbType = System.Data.DbType.Int32, Value = model.MaritalStatus },
                        new SqlParameter { ParameterName = "@MailingAddress", DbType = System.Data.DbType.String, Value = model.MailingAddress },
                        new SqlParameter { ParameterName = "@CityID", DbType = System.Data.DbType.Int32, Value = model.CityID },
                          new SqlParameter { ParameterName = "@DifferAbled", DbType = System.Data.DbType.String, Value = model.DifferAbled }).FirstOrDefault();

                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel UpdatePersonalSkills(UserSkillsDetails model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdatePersonalSkills @userid,@Skills,@Version,@LastUsedYear,@Experience",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserID },
                      new SqlParameter { ParameterName = "@Skills", DbType = System.Data.DbType.String, Value = model.Skills },
                        new SqlParameter { ParameterName = "@Version", DbType = System.Data.DbType.Decimal, Value = model.Version },
                          new SqlParameter { ParameterName = "@LastUsedYear", DbType = System.Data.DbType.Int32, Value = model.LastUsedYear },
                            new SqlParameter { ParameterName = "@Experience", DbType = System.Data.DbType.Int32, Value = model.Experience }).Single();

                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }
        public ResponseModel UpdateWorkHistory(UserProfileModel model)
        {
           
            try
            {

                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("Usp_UpdateWorkHistory @userid,@DesignationID,@Companyid,@WorkingSinceYear,@WorkingSinceMonth,@WorkingTo",
                    new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@DesignationID", DbType = System.Data.DbType.Int32, Value = model.DesignationID },
                       new SqlParameter { ParameterName = "@Companyid", DbType = System.Data.DbType.Int32, Value = model.CompanyId },
                        new SqlParameter { ParameterName = "@WorkingSinceYear", DbType = System.Data.DbType.Int32, Value = model.WorkingSinceYear },
                          new SqlParameter { ParameterName = "@WorkingSinceMonth", DbType = System.Data.DbType.Int32, Value = model.WorkingSinceMonth },
                            new SqlParameter { ParameterName = "@WorkingTo", DbType = System.Data.DbType.Int32, Value = model.WorkingTo }).Single();

                return responseModel;
            }
            catch (Exception ex)
            {

                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;

        }
        public ResponseModel UpdateProfileDetails(UserProfileModel model)
        {
           
            try
            {
                responseModel = DBManager.SpHelper<ResponseModel>.GetListWithRawSql("[Usp_UpdateProfileDetails] @userid,@Experince,@currentLocation,@OutSideInda,@FuntionalArea,@Desigationid,@Industry,@JobType",
                      new SqlParameter { ParameterName = "@userid", DbType = System.Data.DbType.Int32, Value = model.UserId },
                      new SqlParameter { ParameterName = "@Experince", DbType = System.Data.DbType.Int32, Value = model.ExperienceID },
                       new SqlParameter { ParameterName = "@currentLocation", DbType = System.Data.DbType.Int32, Value = model.CurrentLocationID },
                        new SqlParameter { ParameterName = "@OutSideInda", DbType = System.Data.DbType.Boolean, Value = model.OutSideIndia },
                          new SqlParameter { ParameterName = "@FuntionalArea", DbType = System.Data.DbType.Int32, Value = model.FunctionalArea },
                            new SqlParameter { ParameterName = "@Desigationid", DbType = System.Data.DbType.Int32, Value = model.DesignationID },
                             new SqlParameter { ParameterName = "@Industry", DbType = System.Data.DbType.Int32, Value = model.IndustryId },
                              new SqlParameter { ParameterName = "@JobType", DbType = System.Data.DbType.String, Value = model.JobTypeId }).FirstOrDefault();
              
            }
            catch(Exception ex)
            {
                responseModel.Status = false;
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }
        public ResponseModel DeleteResume(long UserID)
        {
            try
            {
                var result =_Context.UserMasters.Where(x => x.UserID == UserID).FirstOrDefault();

                if (result != null)
                {
                    result.Resume = string.Empty;
                }

               int i= _Context.SaveChanges();
                if(i>0)
                {
                    responseModel.Status = true;
                    responseModel.Message = "Your Resume has been deleted !";
                }
                else
                {
                    responseModel.Status = false;
                    responseModel.Message = "Your Resume is not deleted some kind of Reason";
                }

            }
            catch(Exception ex)
            {
                responseModel.Status = false;
                responseModel.Message = ex.Message;

            }
            return responseModel;
        }
    }
}