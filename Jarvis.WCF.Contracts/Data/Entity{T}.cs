using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jarvis.WCF.Contracts.Data
{
    [DataContract]
    public class Entity<T>
    {
        [DataMember]
        public T Id { get; set; }
    }
}
