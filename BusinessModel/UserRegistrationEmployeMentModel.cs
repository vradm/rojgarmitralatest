using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RojgarMitraWebApi.BusinessModel
{
   public class UserRegistrationEmployeMentModel
    {
        public long ID { get; set; }
        public Nullable<long> UserID { get; set; }
        public Nullable<int> CurrentDesignation { get; set; }
        public Nullable<int> CurrentCompany { get; set; }
        public string AnualSalaryType { get; set; }
        public string AnnualSalaryInlakhs { get; set; }
        public Nullable<int> AnnualSalaryInThousand { get; set; }
        public Nullable<int> WorkingSinceYear { get; set; }
        public string WotkingSinceMonth { get; set; }
        public string WorkingTo { get; set; }
        public Nullable<int> CurrentLocationID { get; set; }
        public string CityName { get; set; }
        public bool OutSideIndia { get; set; } = false;
        public Nullable<int> OutSideIndiaCountryID { get; set; }
        public string OutSideIndiaCity { get; set; }
        public Nullable<int> NoticePeriod { get; set; }
        public bool ServeNoticePeriod { get; set; } = false;
        public Nullable<int> LastWorkingDay_Year { get; set; }
        public Nullable<int> Last_Working_Month { get; set; }
        public Nullable<int> Last_WorkingDate { get; set; }
        public string NewOfferedSalaryIn { get; set; }
        public Nullable<int> NewOfferedSalaryInLakh { get; set; }
        public Nullable<int> NewOfferedSalaryInThousand { get; set; }
        public Nullable<int> OfferedDesignation { get; set; }
        public Nullable<int> NewCompany { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int PassingYear { get; set; }
        public List<SelectListItem> DesignationList { get; set; }
        public List<SelectListItem> CompanyList { get; set; }
        public List<SelectListItem> CityList { get; set; }
        public List<SelectListItem> UniversityList { get; set; }
        public SelectList HighestQulaificationList { get; set; }
        public SelectList CourseList { get; set; }
        public SelectList SpecializationList { get; set; }
    }
}
