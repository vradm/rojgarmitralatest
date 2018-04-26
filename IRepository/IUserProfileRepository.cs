using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RojgarMitraWebApi.BusinessModel;
namespace RojgarMitraWebApi.IRepository
{
   public interface IUserProfileRepository
    {
        UserProfileModel UserdetailsByonId(long UserId);
        ResponseModel UpdateProfileInfo(UserProfileModel model);
        ResponseModel UpdateWorkEducation(UserProfileModel model);
        ResponseModel UpdateBasicInfo(UserProfileModel model);
        ResponseModel UpdateOtherInfo(UserProfileModel model);
        ResponseModel UpdatePersonalSkills(UserSkillsDetails model);
        ResponseModel UpdateWorkHistory(UserProfileModel model);
        ResponseModel UpdateProfileDetails(UserProfileModel model);
        ResponseModel DeleteResume(long Userid);
          }
}
