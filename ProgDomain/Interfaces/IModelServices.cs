﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDomain.Interfaces
{
    interface IModelServices : IModel<OpenWheather>
    {
        DateTime Tiempo(long o);
    
    }
}
