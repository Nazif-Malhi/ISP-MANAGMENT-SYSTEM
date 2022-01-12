using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_MANAGMENT_SYSTETEM
{
    class FireBase
    {
        public IFirebaseConfig config = new FirebaseConfig
        {

            AuthSecret = "*****",
            BasePath = "****"
        };
        public IFirebaseClient client;
    }
}
