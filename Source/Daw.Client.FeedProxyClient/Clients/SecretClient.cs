using System;
using System.ServiceModel;
using Daw.Client.WebServices.Interfaces;

namespace Daw.Client.WebServices.Clients
{



    public class SecretClient
    {

        public IWhiteListedUrlService Open()
        {
            try
            {
                var myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 10000000;
                var myEndpoint = new EndpointAddress("http://ocfeedproxy.cloudapp.net:8084/WhiteListedUrlService");
                var myChannelFactory = new ChannelFactory<IWhiteListedUrlService>(myBinding, myEndpoint);
                return myChannelFactory.CreateChannel();

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Close(IWhiteListedUrlService service)
        {
            service = null;
        }
    }
}
