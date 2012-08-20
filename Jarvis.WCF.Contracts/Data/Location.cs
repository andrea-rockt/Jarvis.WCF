using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jarvis.WCF.Contracts.Data
{
    [KnownType(typeof(List<LocationCategory>))]
    [KnownType(typeof(List<Action>))]
    [DataContract]
    public class Location : Entity<Guid>
    {
        [DataMember]
        public double? Score { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string StreetAddress { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public IList<LocationCategory> Categories { get; set; }
        [DataMember]
        public IList<Action> Actions { get; set; }
    }
}
