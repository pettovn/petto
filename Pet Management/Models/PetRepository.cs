/************************************************************************
/* Copyright (©) 2019 PETTO SYSTEM
/************************************************************************
/* File Name    : PetRepository.cs
/* Function     : Reponsitory dataset
/* Create       : LinhTran 2019/11/11
/************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pet_Management.Models
{
    public class PetRepository
    {
        private EntrySetContext _db = new EntrySetContext();

        #region USER
        /// <summary>
        /// Get user by email
        /// </summary>
        /// <param name="email">email address</param>
        /// <param name="password">password</param>
        /// <param name="errMsg">error messahe</param>
        /// <returns>USER object</returns>
        public USER GetUserByEmail(String email, String password, out string errMsg)
        {
            errMsg = String.Empty;
            USER objUSER = null;

            try
            {
                objUSER = _db.USER.Where(m => m.email == email && m.password == password).FirstOrDefault();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }

            return objUSER;
        }

        /// <summary>
        /// Get user by phone number
        /// </summary>
        /// <param name="phone">phone number</param>
        /// <param name="password">password</param>
        /// <param name="errMsg">error messahe</param>
        /// <returns>USER object</returns>
        public USER GetUserByPhone(String phone, String password, out string errMsg)
        {
            errMsg = String.Empty;
            USER objUSER = null;

            try
            {
                objUSER = _db.USER.Where(m => m.phone == phone && m.password == password).FirstOrDefault();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }

            return objUSER;
        }

        /// <summary>
        /// get all user
        /// </summary>
        /// <param name="errMsg">error message</param>
        /// <returns>list user</returns>
        public List<USER> GetListAllUser(out string errMsg)
        {
            errMsg = String.Empty;
            List<USER> lstUSER = new List<USER>();

            try
            {
                lstUSER = _db.USER.ToList();
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
            }

            return lstUSER;
        }
        #endregion

        #region PET 
        #endregion

        #region PURCHASE
        #endregion
    }
}
