using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Daw.Client.WebServices.Interfaces
{
    [ServiceContract(Namespace = "http:/D53.Sportsbook.WebService.Contracts/WhiteListedUrlService")]
    public interface IWhiteListedUrlService
    {
        [OperationContract, XmlSerializerFormat]
        XmlDocument LoadXmlFromUrl(string url);

        [OperationContract, XmlSerializerFormat]
        XmlDocument LoadXmlFromUrlAuthenticated(string url, string userName, string password);

        [OperationContract]
        string LoadJsonFromUrl(string url);
    }
}
