using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RojgarMitraWebApi.BusinessModel;


namespace RojgarMitraWebApi.IRepository
{
  public  interface IMasterRepository
    {

        IEnumerable<CountryModel> ListOfCountry();
        IEnumerable<StateModel> ListOfState(int Countryid);
        IEnumerable<CityModel> ListofCity(int stateid);
        IEnumerable<OtherMasterModel> ListOfOtherMaster();
        IEnumerable<DesignationModel> ListOfDesigation();
        IEnumerable<CompanyModel> ListOfCompany();
        IEnumerable<University_CollegeModel> ListOfUniversity_college();
    }
}
