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
    public class RefProd
    {
        public int id_ref_prod { get; set; }
        public string name_prod { get; set; }
        public string url_pic { get; set; }
        public int id_list { get; set; }
        public int id_material { get; set; }
        public string name_itm { get; set; }
        public string types_pr { get; set; }
        public int id_decorates { get; set; }
        public double weight_ref { get; set; }
    }

    public class RefProdService
    {
        public List<RefProd> GetRefProds()
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml("<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><getRefProd xmlns=\"https://www.w3schools.com/xml/\"><value_json>5</value_json></getRefProd></soap12:Body></soap12:Envelope>");

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
                        List<RefProd> res = JsonConvert.DeserializeObject<List<RefProd>>(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
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
