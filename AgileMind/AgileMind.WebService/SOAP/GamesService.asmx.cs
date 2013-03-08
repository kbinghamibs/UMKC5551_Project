﻿#region -- using declarations --

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AgileMind.BLL.Games;

#endregion

namespace AgileMind.WebService.SOAP
{
    /// <summary>
    /// Summary description for GamesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GamesService : System.Web.Services.WebService
    {

        [WebMethod]
        public ColorGameResult FetchGolorGame()
        {
            return ColorGameResult.CreateGame();
        }

        [WebMethod]
		#region -- InsertGameResult() Method --
		public GameResults InsertGameResult(String UserName, String Password, GameListEnum gameType, int Score, decimal TestDuration, int Total)
		{
            return GameResults.InsertGameResult(UserName, Password, gameType, Score, TestDuration, Total);
		}
		#endregion
		

    }
}