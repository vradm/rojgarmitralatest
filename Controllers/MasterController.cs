using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using RojgarMitraWebApi.IRepository;
using RojgarMitraWebApi.Repository;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.DBManager;
using System.Net.Http.Headers;
namespace RojgarMitraWebApi.Controllers
{
   
    public class MasterController : ApiController
    {

        static readonly IMasterRepository _masterRepository = new MasterRepository(new RojgarMitraEntities());

        public IHttpActionResult Contry()
        {

            return Json("ok");
        }
        [HttpGet]
        public IHttpActionResult StateList()
        {
            return Json(_masterRepository.ListOfState(100));
        }
        public HttpResponseMessage CountryList()
        {

            return Request.CreateResponse();
        }
        [HttpGet]
        public IHttpActionResult OthermasterList()
        {
            //List<OtherMasterModel> otherMasterModels = new List<OtherMasterModel>();
            try
            {
                return Json(_masterRepository.ListOfOtherMaster());

            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }

        }

        [HttpGet]       
        public IHttpActionResult DesignationList()
        {
            //return Request.CreateResponse(HttpStatusCode.OK, _masterRepository.ListOfDesigation());
            List<DesignationModel> DesignationModel = new List<DesignationModel>();
            try
            {
                
                DesignationModel = _masterRepository.ListOfDesigation().ToList();
                if (DesignationModel != null)
                {
                    return Json(DesignationModel);

                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }
            return Json(DesignationModel);
        }
        [HttpGet]
        public IHttpActionResult CompanyList()
        {
            List<CompanyModel> CompanyModel = new List<CompanyModel>();
            try
            {
                CompanyModel = _masterRepository.ListOfCompany().ToList();
                if (CompanyModel != null)
                {
                    return Json(CompanyModel);

                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }
            return Json(CompanyModel);
        }
        [HttpGet]
        public IHttpActionResult University_CollegeList()
        {
            return Json(_masterRepository.ListOfUniversity_college());
        }
        
    }
}
