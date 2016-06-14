using System.ServiceModel;
using Daw.Client.WebServices.Interfaces;

namespace Daw.Client.WebServices.Clients
{



    public class SecretClient
    {

        public IWhiteListedUrlService Open()
        {
            BasicHttpBinding myBinding = new BasicHttpBinding();
            myBinding.MaxReceivedMessageSize = 10000000;
            EndpointAddress myEndpoint = new EndpointAddress("http://ocfeedproxy.cloudapp.net:8084/WhiteListedUrlService");
            ChannelFactory<IWhiteListedUrlService> myChannelFactory = new ChannelFactory<IWhiteListedUrlService>(myBinding, myEndpoint);
            return myChannelFactory.CreateChannel();

        }

        public void Close(IWhiteListedUrlService service)
        {
            service = null;
        }
    }
}
