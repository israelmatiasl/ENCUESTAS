using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ENCUESTA.WEB.Helpers
{
    public class GetRecomendaciones
    {
        public static List<String> RecomendacionTotal()
        {
            List<String> recomendaciones = new List<String>();
            recomendaciones.Add("0. ");
            recomendaciones.Add("1. Botón de pago");
            recomendaciones.Add("2. Le recomendamos que venda sus productos en la página web de su negocio ya que le brindara acceso a los siguientes medios de pago: Botón de pago, Aplicación QR en Página web");
            recomendaciones.Add("3. Le recomendamos que implemente una página web para su negocio ya que le brindara acceso a los siguientes medios de pago: Botón de pago, Aplicación QR en Página web");
            recomendaciones.Add("4. SMS Billing");
            recomendaciones.Add("5. Aplicación QR(Venta por QR página web");
            recomendaciones.Add("6. Soluciones NFC (Mediante billetera electronica");
            recomendaciones.Add("7. Mobile POS");
            recomendaciones.Add("8. NFC POS");
            recomendaciones.Add("9. Le recomendamos que compre un dispositivo smartphone con NFC para su negocio ya que le brindará acceso a los siguientes medios de pago: Soluciones NFC (mediante billetera electronica)");
            recomendaciones.Add("10. Le recomendamos que adquiera información de sus clientes acerca del uso de smartphones ya que le brindará acceso a los siguientes medios de pago: Aplicación QR(Venta por QR página web) ,  Soluciones NFC ( Mediante Billetera electronica) , Mobile POS , NFC POS");
            recomendaciones.Add("11. IVR Billing");
            recomendaciones.Add("12. Le recomendamos que automatice el servicio de atención de pedidos por llamada ya que le brindará acceso a los siguientes medios de pago: IVR Billing");
            recomendaciones.Add("13. Carrier Billing");
            recomendaciones.Add("14. Le recomendamos que implemente el recargo del cobro de sus producto por medio de una operadora telefónica ya que le brindará acceso a los siguientes medios de pago: Carrier Billing");
            recomendaciones.Add("15. Le recomendamos que adquiera información de sus clientes acerca del uso de dispositivos móviles ya que le brindará acceso a los siguientes medios de pago: Carrier Billing , SMS Billing, IVR Billing , Aplicación QR(Venta por QR página web) ,  Soluciones NFC ( Mediante Billetera electronica) , Mobile POS , NFC POS");
            recomendaciones.Add("16. Tecnologia cognitiva (Chatbot)");
            recomendaciones.Add("17. Le recomendamos que venda sus productos en la página de faceebook del negocio ya que le brindará acceso a los siguientes medios de pago: Tecnologia cognitiva (Chatbot)");
            recomendaciones.Add("18. Le recomendamos que cree una página en faceebook para su negocio ya que le brindará acceso a los siguientes medios de pago: Tecnologia cognitiva (Chatbot)");
            recomendaciones.Add("19. Soluciones de social banking (Whatsapp)");
            recomendaciones.Add("20. Le recomendamos que venda sus productos a través de Whatsapp ya que le brindará acceso a los siguientes medios de pago: Soluciones de social banking (Whatsapp)");
            recomendaciones.Add("21. Le recomendamos que utilice Whatsapp para la comunicación con sus clientes ya que le brindará acceso a los siguientes medios de pago: Soluciones de social banking (Whatsapp)");
            recomendaciones.Add("22. Aplicaciones QR ( Revistas )");
            recomendaciones.Add("23. Beacons");
            recomendaciones.Add("24. Le recomendamos que genere campañas basadas en descuentos para su negocio ya que le brindará acceso a los siguientes medios de pago: Beacons, los cuales permitirán brindar cliente nuevas ofertas en tiempo real mientras que este dentro del local.");
            recomendaciones.Add("25. Le recomendamos que genere campañas de marketing para su negocio ya que le brindara acceso a los siguientes medios de pago: Aplicaciones QR ( Revistas ) y si tiene un local podría implementar Beacons");
            recomendaciones.Add("26. Tarjetas de fidelizacion");
            recomendaciones.Add("27. Tarjetas de descuentos");
            recomendaciones.Add("28. Le recomendamos que genere campañas de fidelizacion de clientes ya que le brindará acceso a los siguientes medios de pago: Tarjetas de fidelizacion y Tarjetas de descuentos");
            recomendaciones.Add("29. Giftcards");
            recomendaciones.Add("30. Le recomendamos que trabaje en conjunto con otras empresas ya que le brindará acceso a los siguientes medios de pago: Giftcards");
            recomendaciones.Add("31. Dash Button");
            recomendaciones.Add("32. Le recomendamos que tome en cuenta la automatización de pedidos de productos mediante llamadas ya que le brindará acceso a los siguientes medios de pago: Dash Button");


            return recomendaciones;
        }

        public static List<String> MostrarRecomendaciones(String resultado)
        {
            List<String> recomendaciones = new List<String>();
            List<String> lista = resultado.Split('R').Skip(1).ToList();

            for (int i = 0; i<lista.Count; i++)
            {
                recomendaciones.Add(RecomendacionTotal()[Convert.ToInt32(lista[i])]);
            }

            return recomendaciones;
        }
    }
}