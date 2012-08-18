using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jarvis.WCF.Contracts.Data
{
    public class LocationCategory : Entity<Guid>
    {
        [DataMember]
        public string Name { get; set; }
    }
}
