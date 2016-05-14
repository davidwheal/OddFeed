using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

namespace Daw.Common.Redis
{
    public class Cache
    {
        private static BasicRedisClientManager _manager = null;
        private static IRedisClient _client = null;

        public void Connect()
        {
            if (_manager == null)
            {
                _manager = new BasicRedisClientManager("localhost:6379");
                _client = _manager.GetClient();
            }

        }
    }
}
