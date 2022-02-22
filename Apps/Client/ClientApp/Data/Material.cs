using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace ClientApp.Data
{
    public class Material
    {
        public int id_mater { get; set; }
        public string name_mater { get; set; }
        public string url_mater { get; set; }
        public double price_mater { get; set; }
    }
    public class MaterialService
    {
        public List<Material> GetMaterials()
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml("<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><getMats xmlns=\"https://www.w3schools.com/xml/\"><value_json>5</value_json></getMats></soap12:Body></soap12:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new(response.GetResponseStream()))
                    {
                        string soapResult = rd.ReadToEnd();
                        XmlDocument xml = new();
                        xml.LoadXml(soapResult);
                        XmlNamespaceManager nManager = new(xml.NameTable);
                        nManager.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                        nManager.AddNamespace("tns", "http://www.examples.com/wsdl/HelloService.wsdl");
                        List<Material> res = JsonConvert.DeserializeObject<List<Material>>(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
                        return res;
                    }
                }
            }
        }

        public static HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(StaticModels.NgrokURL + "/interation?wsdl");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}
