using Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class Data
    {
        private static PhotoEndProjectEntities dB = new PhotoEndProjectEntities();

        public static PhotoEndProjectEntities DB { get { return dB; } }
    }
}
