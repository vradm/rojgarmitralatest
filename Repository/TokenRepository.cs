using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.BusinessModel.UnitOfWork;
using RojgarMitraWebApi.IRepository;

using RojgarMitraWebApi.DBManager;
namespace RojgarMitraWebApi.Repository
{
    public class TokenRepository:ITokenRepository
    {
        private readonly _UnitOfWork _unitOfWork;
        private readonly RojgarMitraEntities _Context;
        public TokenRepository(RojgarMitraEntities  context)
        {
            _unitOfWork = new _UnitOfWork();
            this._Context = context;
        }
        public bool DeleteByUserId(long userId)
        {
            _unitOfWork.TokenRepository.Delete(x => x.UserID == userId);
            _unitOfWork.Save();

            var isNotDeleted = _unitOfWork.TokenRepository.GetMany(x => x.UserID == userId).Any();
            return !isNotDeleted;
        }

        public TokenModel GenerateToken(long userId)
        {
            string token = Guid.NewGuid().ToString();
            DateTime issuedOn = DateTime.Now;
            DateTime expiredOn = DateTime.Now.AddDays(1);//Time to Exipire
            var tokendomain = new Token
            {
                UserID = userId,
                AuthToken = token,
                IssuedOn = issuedOn,
                ExpiresOn = expiredOn
            };

            _unitOfWork.TokenRepository.Insert(tokendomain);
            _unitOfWork.Save();
            var tokenModel = new TokenModel()
            {
                UserID = userId,
                IssuedOn = issuedOn,
                ExpiresOn = expiredOn,
                AuthToken = token
            };

            return tokenModel;
        }

        public bool Kill(string tokenId)
        {
            _unitOfWork.TokenRepository.Delete(x => x.AuthToken == tokenId);
            _unitOfWork.Save();
            var isNotDeleted = _unitOfWork.TokenRepository.GetMany(x => x.AuthToken == tokenId).Any();
            if (isNotDeleted) { return false; }
            return true;
        }

        public long ValidateToken(string tokenId)
        {
            var token = _unitOfWork.TokenRepository.Get(t => t.AuthToken == tokenId && t.ExpiresOn > DateTime.Now);
            if (token != null)
            {
                token.ExpiresOn = token.ExpiresOn.AddDays(1);
                _unitOfWork.TokenRepository.Update(token);
                _unitOfWork.Save();
                return token.UserID;
            }
            return 0;
        }

    }
}