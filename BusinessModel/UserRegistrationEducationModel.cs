using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RojgarMitraWebApi.BusinessModel
{
  public  class UserRegistrationEducationModel
    {
        public long ID { get; set; }
        public string ProfileImage { get; set; }
        public string ProfessionalExperience { get; set; }
        public string Extension { get; set; }
        public Nullable<int> HighestQualification { get; set; }
        public Nullable<int> Course { get; set; }
        public Nullable<int> Specialization { get; set; }
        public Nullable<long> University_College { get; set; }
        public string CourseType { get; set; }
        public Nullable<int> PassingYear { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public long UserId { get; set; }
    }
}
