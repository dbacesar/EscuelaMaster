using EscuelaMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscuelaMaster.Controllers
{
    [HandleError()]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Acción para autorizar al usuario
        [HttpPost]
        //[CLSCompress]
        public ActionResult Autorizar(TblUsuario objUsuario)
        {
            //Lectura de la DBS
            using (EscuelaMasterEntities DBS = new EscuelaMasterEntities())
            {
                var SQL = DBS.TblUsuario.Where
                    (x => x.ClaveUsuario == objUsuario.ClaveUsuario).FirstOrDefault();

                //VALIDO REGISTROS
                if (SQL == null)
                {
                    objUsuario.PpMensaje = "Por favor revise credenciales.";
                    return View("Index", objUsuario);
                }
                // SI ES VALIDO EL USUARIO AUTORIZO ACCESSO A VIP
                else
                {
                    Session["UsuarioID"] = SQL.UsuarioID;
                    Session["NombreUsuario"] = SQL.NombreUsuario;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult LogOutUser()
        {
            //FINALIZAMOS SESIÓN....
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}