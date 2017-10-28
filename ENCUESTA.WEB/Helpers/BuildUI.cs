using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENCUESTA.WEB.Helpers
{
    public class BuildUI
    {
        public static String builRecomendPHtml(String recomend)
        {
            String builder = String.Empty;
            String link = String.Empty;

            switch(recomend)
            {
                case "Botón de pago": link = $"https://sites.google.com/view/medios-de-pago-digitales/bot%C3%B3n-de-pago"; break;
                case "SMS Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/sms-billing"; break;
                case "Aplicación QR(Venta por QR página web)": link = $"https://sites.google.com/view/medios-de-pago-digitales/aplicaci%C3%B3n-qr"; break;
                case "Soluciones NFC (Mediante billetera electronica)": link = $"https://sites.google.com/view/medios-de-pago-digitales/billetera-electr%C3%B3nica"; break;
                case "Mobile POS": link = $"https://sites.google.com/view/medios-de-pago-digitales/mobile-pos"; break;
                case "NFC POS": link = $"https://sites.google.com/view/medios-de-pago-digitales/nfc-pos"; break;
                case "IVR Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/ivr-billing"; break;
                case "Carrier Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/carrier-billing"; break;
                case "Tecnologia cognitiva (Chatbot)": link = $"https://sites.google.com/view/medios-de-pago-digitales/tecnolog%C3%ADa-cognitiva"; break;
                case "Soluciones de social banking (Whatsapp)": link = $"https://sites.google.com/view/medios-de-pago-digitales/soluciones-social-banking"; break;
                case "Aplicaciones QR ( Revistas )": link = $"https://sites.google.com/view/medios-de-pago-digitales/aplicaci%C3%B3n-qr"; break;
                case "Beacons": link = $"https://sites.google.com/view/medios-de-pago-digitales/beacons"; break;
                case "Tarjetas de fidelizacion": link = $"https://sites.google.com/view/medios-de-pago-digitales/tarjetas-de-fidelizaci%C3%B3n"; break;
                case "Tarjetas de descuentos": link = $"https://sites.google.com/view/medios-de-pago-digitales/tarjetas-de-descuentos"; break;
                case "Giftcards": link = $"https://sites.google.com/view/medios-de-pago-digitales/giftcards"; break;
                case "Dash Button": link = $"https://sites.google.com/view/medios-de-pago-digitales/dash-button"; break;
            }

            builder = $"<a target=\"_blank\" class=\"btn btn-success\" href=\"{link}\">{recomend} <div class=\"ripple-container\"></div></a>";

            return builder;
        }
    }
}