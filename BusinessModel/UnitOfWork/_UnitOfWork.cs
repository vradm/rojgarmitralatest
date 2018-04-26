using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using RojgarMitraWebApi.BusinessModel.Generic_Repository;
using RojgarMitraWebApi.DBManager;

namespace RojgarMitraWebApi.BusinessModel.UnitOfWork
{
    public class _UnitOfWork : IDisposable
    {
        #region Private member variables...

        private RojgarMitraEntities _context = null;
        #endregion
        public _UnitOfWork()
        {
            _context = new RojgarMitraEntities();
        }
        #region Public Repository Creation properties...
        private GenericRepository<Token> _tokenRepository;
        private GenericRepository<UserMaster> _UserMastersRepository;
        private GenericRepository<CityMaster> _CityMasterRepository;
        private GenericRepository<StatesMaster> _StatesMasterRepository;
        private GenericRepository<CountriesMaster> _CountriesMasterRepository;
        private GenericRepository<OtherMaster> _OtherMasterRepository;
        private GenericRepository<UserEmployementDetail> _UserEmployementDetailRepository;
        private GenericRepository<UserEducationDetail> _UserEducationDetailRepository;
        #endregion
        #region Public member methods...
        public GenericRepository<Token> TokenRepository
        {
            get
            {
                if (this._tokenRepository == null)
                    this._tokenRepository = new GenericRepository<Token>(_context);
                return _tokenRepository;
            }
        }
        public GenericRepository<UserMaster> UserMastersRepository
        {
            get
            {
                if (this._UserMastersRepository == null)
                    this._UserMastersRepository = new GenericRepository<UserMaster>(_context);
                return _UserMastersRepository;
            }
        }
        public GenericRepository<CityMaster> CityMasterRepository
        {
            get
            {
                if (this._CityMasterRepository == null)
                    this._CityMasterRepository = new GenericRepository<CityMaster>(_context);
                return _CityMasterRepository;
            }
        }
        public GenericRepository<StatesMaster> StateMasterRepository
        {
            get
            {
                if (this._StatesMasterRepository == null)
                    this._StatesMasterRepository = new GenericRepository<StatesMaster>(_context);
                return _StatesMasterRepository;
            }
        }
        public GenericRepository<CountriesMaster> CountryMasterRepository
        {
            get
            {
                if (this._CountriesMasterRepository == null)
                    this._CountriesMasterRepository = new GenericRepository<CountriesMaster>(_context);
                return _CountriesMasterRepository;
            }
        }
        public GenericRepository<OtherMaster> OtherMasterRepository
        {
            get
            {
                if (this._OtherMasterRepository == null)
                    this._OtherMasterRepository = new GenericRepository<OtherMaster>(_context);
                return _OtherMasterRepository;
            }
        }
        public GenericRepository<UserEmployementDetail> UserEmployementDetailRepository
        {
            get
            {
                if (this._UserEmployementDetailRepository == null)
                    this._UserEmployementDetailRepository = new GenericRepository<UserEmployementDetail>(_context);
                return _UserEmployementDetailRepository;
            }
        }
        public GenericRepository<UserEducationDetail>UserEducationDetailRepository
        {
            get
            {
                if (this._UserEducationDetailRepository == null)
                    this._UserEducationDetailRepository = new GenericRepository<UserEducationDetail>(_context);
                return _UserEducationDetailRepository;
            }
        }
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format("{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now, eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

