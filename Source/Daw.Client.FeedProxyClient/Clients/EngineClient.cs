using System;
using System.ServiceModel;
using Daw.Common.Interfaces;

namespace Daw.Client.WebServices.Clients
{



    public class EngineClient
    {

        public IEngineWebService Open()
        {
            try
            {
                var myBinding = new BasicHttpBinding();
                myBinding.MaxReceivedMessageSize = 10000000;
                var myEndpoint = new EndpointAddress("http://localhost:8733/EngineWebService");
                var myChannelFactory = new ChannelFactory<IEngineWebService>(myBinding, myEndpoint);
                return myChannelFactory.CreateChannel();

            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void Close(IEngineWebService service)
        {
            service = null;
        }
    }
}
