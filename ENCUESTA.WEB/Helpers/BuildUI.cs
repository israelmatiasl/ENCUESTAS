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
            String imagename = String.Empty;

            switch (recomend)
            {
                case "Botón de pago": link = $"https://sites.google.com/view/medios-de-pago-digitales/bot%C3%B3n-de-pago"; imagename = "1_Boton_de_pago.jpg"; break;
                case "SMS Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/sms-billing"; imagename = "2_SMS_Billing.jpg"; break;
                case "Aplicación QR(Venta por QR página web)": link = $"https://sites.google.com/view/medios-de-pago-digitales/aplicaci%C3%B3n-qr"; imagename = "3_Aplicación QR (Venta por QR página web).jpg"; break;
                case "Soluciones NFC (Mediante billetera electronica)": link = $"https://sites.google.com/view/medios-de-pago-digitales/billetera-electr%C3%B3nica"; imagename = "4_Soluciones_NFC.jpg"; break;
                case "Mobile POS": link = $"https://sites.google.com/view/medios-de-pago-digitales/mobile-pos"; imagename = "5_Mobile_POS.jpg"; break;
                case "NFC POS": link = $"https://sites.google.com/view/medios-de-pago-digitales/nfc-pos"; imagename = "6_NFC_POS.jpg"; break;
                case "IVR Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/ivr-billing"; imagename = "7_IVR_Billing.jpg"; break;
                case "Carrier Billing": link = $"https://sites.google.com/view/medios-de-pago-digitales/carrier-billing"; imagename = "8_Carrier_Billing.jpg"; break;
                case "Tecnologia cognitiva (Chatbot)": link = $"https://sites.google.com/view/medios-de-pago-digitales/tecnolog%C3%ADa-cognitiva"; imagename = "9_Tecnología cognitiva (Chatbot).jpg"; break;
                case "Soluciones de social banking (Whatsapp)": link = $"https://sites.google.com/view/medios-de-pago-digitales/soluciones-social-banking"; imagename = "10_Soluciones de social banking (Whatsapp).jpg"; break;
                case "Aplicaciones QR ( Revistas )": link = $"https://sites.google.com/view/medios-de-pago-digitales/aplicaci%C3%B3n-qr"; imagename = "11_Aplicaciones QR (Revistas).jpg"; break;
                case "Beacons": link = $"https://sites.google.com/view/medios-de-pago-digitales/beacons"; imagename = "12_Beacons.jpg"; break;
                case "Tarjetas de fidelizacion": link = $"https://sites.google.com/view/medios-de-pago-digitales/tarjetas-de-fidelizaci%C3%B3n"; imagename = "13_Tarjetas de fidelización.jpg"; break;
                case "Tarjetas de descuentos": link = $"https://sites.google.com/view/medios-de-pago-digitales/tarjetas-de-descuentos"; imagename = "14_Tarjetas de descuentos.jpg"; break;
                case "Giftcards": link = $"https://sites.google.com/view/medios-de-pago-digitales/giftcards"; imagename = "15_Giftcards.jpg"; break;
                case "Dash Button": link = $"https://sites.google.com/view/medios-de-pago-digitales/dash-button"; imagename = "16_Dash Button.jpg"; break;
            }

            builder = $"<div class=\"col-md-3 col-lg-3\" style=\"margin-top:80px\">" +
                         $"<div class=\"rotating-card-container\" style=\"height:200px; width:200px;\">" +
                            $"<div class=\"card card-rotate\">" +
                                $"<div class=\"front\">" +
                                    $"<div class=\"card-content\" style=\"height: 200px; width: 200px; background-image: url('/Content/assets/img/buttons/{imagename}')\"></div>" +
                                $"</div>" +
                                $"<div class=\"back\">" +
                                    $"<div class=\"card-content\">" +
                                        $"<h5 class=\"card-title\">{recomend}</h5>" +
                                        $"<p class=\"card-description\">Si desea más información sobre este método de pago haga clic en Ver más</p>" +
                                        $"<div class=\"footer text-center\">" +
                                            $"<a href=\"{link}\" class=\"btn btn-danger btn-round\"><i class=\"material-icons\">subject</i>Ver más</a>" +
                                        $"</div>" +
                                    $"</div>" +
                                $"</div>" +
                                $"<h4 align=\"center\">{recomend}</h4>" +
                            $"</div>" +
                         $"</div>" +
                      $"</div>";

            return builder;
        }
    }
}