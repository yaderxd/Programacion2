using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAppCore.ServicesInterfaces
{
    public interface Services<D>
    {
        D Extracción(string d);
        void Add(D d);

        List<D> Read();
    }
}
