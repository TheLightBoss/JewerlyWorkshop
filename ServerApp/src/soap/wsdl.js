// файл .wsdl 
var xml_orders = `<definitions name="HelloService"
targetNamespace="http://www.examples.com/wsdl/HelloService.wsdl"
xmlns="http://schemas.xmlsoap.org/wsdl/"
xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/"
xmlns:tns="http://www.examples.com/wsdl/HelloService.wsdl"
xmlns:xsd="http://www.w3.org/2001/XMLSchema">

<message name="getBMIRequest">
<part name="value_json" type="xsd:string"/>
</message>

<message name="getBMIResponse">
<part name="res_value_json" type="xsd:string"/>
</message>

<portType name="Hello_PortType">
<operation name="getOrders">
<input message="tns:getBMIRequest"/>
<output message="tns:getBMIResponse"/>
</operation>
<operation name="createOrder">
<input message="tns:getBMIRequest"/>
<output message="tns:getBMIResponse"/>
</operation>
<operation name="updateOrder">
<input message="tns:getBMIRequest"/>
<output message="tns:getBMIResponse"/>
</operation>
</portType>

<binding name="Hello_Binding" type="tns:Hello_PortType">
<soap:binding style="rpc"
transport="http://schemas.xmlsoap.org/soap/http"/>
<operation name="getOrders">
<operation name="createOrder">
<operation name="updateOrder">
<soap:operation soapAction="getOrders"/>
<input>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</input>
<output>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</output>
</operation>
<soap:operation soapAction="createOrder"/>
<input>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</input>
<output>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</output>
</operation>
<soap:operation soapAction="updateOrder"/>
<input>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</input>
<output>
<soap:body
encodingStyle="http://schemas.xmlsoap.org/soap/encoding/"
namespace="urn:examples:helloservice"
use="encoded"/>
</output>
</operation>

</binding>

<service name="Orders_Service">
<documentation>WSDL File for HelloService</documentation>
<port binding="tns:Hello_Binding" name="Orders_Port">
<soap:address
location="http://localhost:50/interation/" />
</port>
</service>
</definitions>`;

module.exports = xml_orders;