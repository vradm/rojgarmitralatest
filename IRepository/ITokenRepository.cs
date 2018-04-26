﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RojgarMitraWebApi.BusinessModel;
using RojgarMitraWebApi.Repository;


namespace RojgarMitraWebApi.IRepository
{
    public interface ITokenRepository
    {
        #region Interface member methods.
        /// <summary>
        ///  Function to generate unique token with expiry against the provided userId.
        ///  Also add a record in database for generated token.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        TokenModel GenerateToken(long userId);

        /// <summary>
        /// Function to validate token againt expiry and existance in database.
        /// </summary>
        /// <param name="tokenId"></param>
        /// <returns></returns>
        long ValidateToken(string tokenId);

        /// <summary>
        /// Method to kill the provided token id.
        /// </summary>
        /// <param name="tokenId"></param>
        bool Kill(string tokenId);

        /// <summary>
        /// Delete tokens for the specific deleted user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool DeleteByUserId(long userId);
        #endregion
    }
}