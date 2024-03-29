﻿using System;
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
                case "Botón de pago": link = "/TipoPago/BotondePago"; imagename = "1_Boton_de_pago.jpg"; break;
                case "SMS Billing": link = "/TipoPago/SMSBilling"; imagename = "2_SMS_Billing.jpg"; break;
                case "Aplicación QR(Venta por QR página web)": link = "/TipoPago/AplicacionQR"; imagename = "3_Aplicación QR (Venta por QR página web).jpg"; break;
                case "Soluciones NFC (Mediante billetera electronica)": link = "/TipoPago/SolucionesNFC"; imagename = "4_Soluciones_NFC.jpg"; break;
                case "Mobile POS": link = "/TipoPago/MobilePOS"; imagename = "5_Mobile_POS.jpg"; break;
                case "NFC POS": link = "/TipoPago/NFCPOS"; imagename = "6_NFC_POS.jpg"; break;
                case "IVR Billing": link="/TipoPago/IVRBilling"; imagename = "7_IVR_Billing.jpg"; break;
                case "Carrier Billing": link = "/TipoPago/CarrierBilling"; imagename = "8_Carrier_Billing.jpg"; break;
                case "Tecnologia cognitiva (Chatbot)": link = "/TipoPago/TencnologiaCognitivaChatbotFacebook"; imagename = "9_Tecnología cognitiva (Chatbot).jpg"; break;
                case "Soluciones de social banking (Whatsapp)": link = "/TipoPago/SolucionesSocialBankingWhatsapp"; imagename = "10_Soluciones de social banking (Whatsapp).jpg"; break;
                case "Aplicaciones QR ( Revistas )": link = "/TipoPago/BotondePago"; imagename = "11_Aplicaciones QR (Revistas).jpg"; break;
                case "Beacons": link = "/TipoPago/Beacons"; imagename = "12_Beacons.jpg"; break;
                case "Tarjetas de fidelizacion": link = "/TipoPago/TarjetasFidelizacion"; imagename = "13_Tarjetas de fidelización.jpg"; break;
                case "Tarjetas de descuentos": link = "/TipoPago/TarjetasDescuento"; imagename = "14_Tarjetas de descuentos.jpg"; break;
                case "Giftcards": link = "/TipoPago/Giftcards"; imagename = "15_Giftcards.jpg"; break;
                case "Dash Button": link = "/TipoPago/DashButtons"; imagename = "16_Dash Button.jpg"; break;
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