using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jarvis.WCF.Contracts.Data
{
    [DataContract]
    public class ShowMessageAction : Action
    {
        [DataMember]
        public string Message { get; set; }
    }
}
