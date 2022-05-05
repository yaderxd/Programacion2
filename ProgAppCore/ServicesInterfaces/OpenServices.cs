using ProgDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAppCore.ServicesInterfaces
{
    public interface OpenServices : Services<OpenWheather>
    {
        DateTime Tiempo(long o);
    }
}