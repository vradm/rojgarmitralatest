using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RojgarMitraWebApi.IRepository;
using RojgarMitraWebApi.Repository;
using RojgarMitraWebApi.BusinessModel;
using System.Transactions;
using RojgarMitraWebApi.DBManager;
using RojgarMitraWebApi.BusinessModel.UnitOfWork;
namespace RojgarMitraWebApi.Repository
{
    public class MasterRepository : IMasterRepository
    {

        private RojgarMitraEntities _Context;
        private readonly _UnitOfWork unitOfWork;
        public MasterRepository(RojgarMitraEntities context)
        {
            unitOfWork = new _UnitOfWork();
            this._Context = context;

        }
        public IEnumerable<CountryModel> ListOfCountry()
        {
            List<CountryModel> countryModels = new List<CountryModel>();
            countryModels = SpHelper<CountryModel>.GetListWithRawSql("usp_CountryList").ToList();

            return countryModels;

        }
        public IEnumerable<StateModel> ListOfState(int CountryId)
        {
            List<StateModel> stateModel = new List<StateModel>();
            stateModel = SpHelper<StateModel>.GetListWithRawSql("usp_StateList").ToList();
            return stateModel;
        }

        public IEnumerable<CityModel> ListofCity(int State)
        {
            List<CityModel> cityModel = new List<CityModel>();
            cityModel = SpHelper<CityModel>.GetListWithRawSql("usp_CityList").ToList();
            return cityModel;
        }
        public IEnumerable<OtherMasterModel> ListOfOtherMaster()

        {
            List<OtherMasterModel> otherMasterModel = new List<OtherMasterModel>();
            otherMasterModel = SpHelper<OtherMasterModel>.GetListWithRawSql("usp_otherMasterList").ToList();
            return otherMasterModel;

        }
        public IEnumerable<DesignationModel> ListOfDesigation()
        {
            List<DesignationModel> DesignationModel = new List<DesignationModel>();
            DesignationModel = SpHelper<DesignationModel>.GetListWithRawSql("usp_DesignationList").ToList();
            return DesignationModel;

        }
        public IEnumerable<CompanyModel> ListOfCompany()
        {
            List<CompanyModel> CompanyModel = new List<CompanyModel>();
            CompanyModel = SpHelper<CompanyModel>.GetListWithRawSql("usp_CompanyList").ToList();
            return CompanyModel;

        }
        public IEnumerable<University_CollegeModel> ListOfUniversity_college()
        {
            List<University_CollegeModel> University_CollegeModel = new List<University_CollegeModel>();
            University_CollegeModel = SpHelper<University_CollegeModel>.GetListWithRawSql("usp_University_CollegeList").ToList();
            return University_CollegeModel;

        }

    }
}
