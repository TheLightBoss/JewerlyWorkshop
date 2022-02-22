
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace ClientApp.Data
{
    public class SOAPService
    {
        static string BaseURL = StaticModels.NgrokURL;//notforget: добавить 
        public static HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(BaseURL + "/interation?wsdl");
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        public List<OrderSOAP> GetOrders(int idClient)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml("<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><getOrders xmlns=\"https://www.w3schools.com/xml/\"><value_json>{\"id_client\":" + idClient + "}</value_json></getOrders></soap12:Body></soap12:Envelope>");

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
                        List<OrderSOAP> orders = JsonConvert.DeserializeObject<List<OrderSOAP>>(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
                        return orders;
                    }
                }
            }

        }
        public bool CreateOrder(CreateOrder createOrder)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml($"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><createOrder xmlns=\"https://www.w3schools.com/xml/\"><value_json>{JsonConvert.SerializeObject(createOrder)}</value_json></createOrder></soap12:Body></soap12:Envelope>");

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
                        int result = Convert.ToInt32(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
                        return result == 0;
                    }
                }
            }


        }
        public ClientSOAP Registration(ClientSOAP client)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml($"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><createClient xmlns=\"https://www.w3schools.com/xml/\"><value_json>{JsonConvert.SerializeObject(client)}</value_json></createClient></soap12:Body></soap12:Envelope>");

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader rd = new(response.GetResponseStream()))
                    {
                        ClientSOAP clientSOAP;
                        string soapResult = rd.ReadToEnd();
                        XmlDocument xml = new();
                        xml.LoadXml(soapResult);
                        XmlNamespaceManager nManager = new(xml.NameTable);
                        nManager.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                        nManager.AddNamespace("tns", "http://www.examples.com/wsdl/HelloService.wsdl");
                        if (xml.SelectSingleNode("//tns:bmi", nManager).InnerText == "-1") return null;
                        clientSOAP = JsonConvert.DeserializeObject<ClientSOAP>(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
                        return clientSOAP;
                    }
                }
            }


        }
        public ClientSOAP Login(ClientSOAP client)
        {
            HttpWebRequest request = CreateWebRequest();
            XmlDocument soapEnvelopeXml = new();
            soapEnvelopeXml.LoadXml($"<soap12:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope\"> <soap12:Body><authClient xmlns=\"https://www.w3schools.com/xml/\"><value_json>{JsonConvert.SerializeObject(client)}</value_json></authClient></soap12:Body></soap12:Envelope>");

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
                        ClientSOAP clientSOAP;
                        XmlNamespaceManager nManager = new(xml.NameTable);
                        nManager.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
                        nManager.AddNamespace("tns", "http://www.examples.com/wsdl/HelloService.wsdl");
                        if (xml.SelectSingleNode("//tns:bmi", nManager).InnerText == "-1") return null;
                        else clientSOAP = JsonConvert.DeserializeObject<ClientSOAP>(xml.SelectSingleNode("//tns:bmi", nManager).InnerText);
                        return clientSOAP;
                    }
                }
            }
        }
    }
}
