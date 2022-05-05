using ProgAppCore.ServicesInterfaces;
using ProgDomain;
using ProgDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAppCore.IServices
{
    public class Clima : Base<OpenWheather>, OpenServices
    {
        IModelServices climaModel;
        public Clima(IModelServices mod) : base(mod)
        {
            this.climaModel = mod;
        }

        public DateTime Tiempo(long o)
        {
            return climaModel.Tiempo(o);
        }
    }
}
