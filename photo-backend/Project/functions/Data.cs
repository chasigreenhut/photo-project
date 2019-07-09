using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.functions
{
    public class Data
    {

        private static PhotoDBChasiLeaEntities1 dB = new PhotoDBChasiLeaEntities1();

        public static PhotoDBChasiLeaEntities1 DB { get { return dB; }  }
    }
}