using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgDomain.SubOpen
{
    public class Clima
    {
        public int Id { get; set; }
        public string Json { get; set; }

        public static Clima Convert(OpenWheather clima)
        {
            if (clima == null)
            {
                return null;
            }

            Clima climaSubModel = new Clima();
            if (climaSubModel.Id < clima.current.weather.Count)
            {
                climaSubModel.Id = clima.current.weather.Count;
            }
            else
            {
                climaSubModel.Id = climaSubModel.Id + 1;
            }
            climaSubModel.Json = JsonConvert.SerializeObject(clima);

            return climaSubModel;
        }

        public static OpenWheather Convert(Clima climaSubModel)
        {
            if (climaSubModel == null)
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(climaSubModel.Json))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<OpenWheather>(climaSubModel.Json);
        }
    }
}
