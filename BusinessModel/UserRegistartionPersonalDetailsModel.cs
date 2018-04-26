using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RojgarMitraWebApi.BusinessModel
{
 public   class UserRegistartionPersonalDetailsModel
    {
        public long UserID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public string StdCode { get; set; }        
        public string MobileNumber { get; set; }
        public Nullable<int> TotalExYear { get; set; }
        public Nullable<int> ToalExMonth { get; set; }
        public string Resume { get; set; }
        public string CurrentLocation { get; set; }
        public string LandLineNumber1 { get; set; }
        public string LandLineNumer2 { get; set; }
        public string MobileNumber2 { get; set; }
        public string Role { get; set; }
        public string AuthTocken { get; set; }
        public Nullable<int> Prefereedocation { get; set; }
        public string PermanentAddress { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string HomeTown { get; set; }
        public Nullable<int> PinCode { get; set; }
        public Nullable<int> MartialStatus { get; set; }
        public string KeySkills { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool Active { get; set; }
        public bool Rememberme { get; set; } = false;
        public string  Extension { get; set; }
        public SelectList ListOfExper { get; set; }
        public SelectList AnnualSalaryInLakh { get; set; }
        public SelectList AnnualSalaryInThousand { get; set; }
        public SelectList WorkingSince { get; set; }
        public SelectList WorkingMonth { get; set; }
        public SelectList HighestQulaificationList { get; set; }
        public SelectList CourseList { get; set; }
        public SelectList SpecializationList { get; set; }
        public List<SelectListItem> UniversityList { get; set; }
    }
}
