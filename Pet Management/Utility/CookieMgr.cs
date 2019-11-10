using System;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace Pet_Management.Common
{
    public class CookieMgr
    {
        /// <summary>
        /// Save Cookie
        /// </summary>
        /// <param name="errMsg">Error mesage</param>
        /// <returns>true:Normal, false:Error</returns>
        public bool SaveCookie(HttpResponse response, string value, out string errMsg)
        {
            errMsg = String.Empty;
            bool bRet = false;

            try
            {
                CookieOptions cookie = new CookieOptions();

                // set expires for cookie
                cookie.Expires = DateTimeMgr.DateTimeJst.AddMonths(1);
                
                // set a cookie
                response.Cookies.Append(FuncDef.COOKIE_NAME, value, cookie);

                bRet = true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                bRet = false;
            }

            return bRet;
        }

        /// <summary>
        /// Load Cookie
        /// </summary>
        /// <param name="errMsg">Error mesage</param>
        /// <returns>true:Normal, false:Error</returns>
        public bool LoadCookie(string value, out string errMsg)
        {
            errMsg = String.Empty;
            bool bRet = false;

            try
            {
                CookieOptions cookie = new CookieOptions();
                //Response.Cookies.Append(FuncDef.COOKIE_NAME, value, cookie);

                // set expires for cookie
                cookie.Expires = DateTimeMgr.DateTimeJst.AddMonths(1);

                bRet = true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                bRet = false;
            }

            return bRet;
        }
    }
}
