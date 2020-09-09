// ***********************************************************************
// Assembly         : BPS.MVC
// Author           : cmceledon (Carlos Mario Celedón Rodelo)
// Created          : 08-09-2020
//
// Last Modified By : cmceledon (Carlos Mario Celedón Rodelo)
// Last Modified On : 08-09-2020
// ***********************************************************************
// <copyright file="HomeController.cs" company="">
//     Copyright ©  2020
// </copyright>
// <summary></summary>
// ***********************************************************************
using BPS.Comun.Enumerators;
using NLog;
using System.Web.Mvc;
namespace BPS.MVC.Controllers.Home
{
    /// <summary>
    /// Class HomeController.
    /// Implements the <see cref="System.Web.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    ///
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>ActionResult.</returns>
        public ActionResult Index()
        {
            return RedirectToAction(Enums.Result.swaggerDefault.ToStringAttribute(), Enums.Result.swagger.ToStringAttribute());
        }

      
    }
}