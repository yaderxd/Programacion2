using ProgAppCore.ServicesInterfaces;
using ProgDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace ProgAppCore.IServices
{
    public abstract class Base<D> : Services<D>
    {
        private IModel<D> Model;
        protected Base(IModel<D> mod)
        {
            this.Model = mod;
        }

        public void Add(D d)
        {
            Model.Add(d);
        }

        public D Extracción(string d)
        {
            return Model.Extraccion(d);
        }

        public List<D> Read()
        {
            return Model.Read();
        }
    }
}
