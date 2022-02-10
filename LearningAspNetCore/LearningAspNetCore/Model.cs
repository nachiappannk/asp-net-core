using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningAspNetCore
{
    [JsonObject(MemberSerialization.OptIn)]
    [Serializable]
    public class Model
    {
        [JsonProperty]
        public string WellIdentifier { get; set; }

        [JsonProperty]
        public string Configuration { get; set; }

    }
}
