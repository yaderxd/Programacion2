using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDomain.Interfaces
{
    public interface IModel<D>
    {
        D Extraccion(string d);
        void Add(D d);

        List<D> Read();
    }
}
