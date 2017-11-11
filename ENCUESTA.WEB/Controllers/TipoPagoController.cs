using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ENCUESTA.WEB.Controllers
{
    public class TipoPagoController : Controller
    {
        // GET: TipoPago
        public ActionResult BotondePago()
        {
            return View();
        }

        public ActionResult SMSBilling()
        {
            return View();
        }
        public ActionResult AplicacionQR()
        {
            return View();
        }
        public ActionResult SolucionesNFC()
        {
            return View();
        }
        public ActionResult MobilePOS()
        {
            return View();
        }
        public ActionResult NFCPOS()
        {
            return View();
        }
        public ActionResult IVRBilling()
        {
            return View();
        }
        public ActionResult CarrierBilling()
        {
            return View();
        }
        public ActionResult TencnologiaCognitivaChatbotFacebook()
        {
            return View();
        }
        public ActionResult SolucionesSocialBankingWhatsapp()
        {
            return View();
        }
        public ActionResult Beacons()
        {
            return View();
        }
        public ActionResult TarjetasFidelizacion()
        {
            return View();
        }
        public ActionResult TarjetasDescuento()
        {
            return View();
        }
        public ActionResult Giftcards()
        {
            return View();
        }
        public ActionResult DashButtons()
        {
            return View();
        }
    }
}