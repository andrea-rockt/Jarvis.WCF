using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Jarvis.WCF.Contracts.Data
{
    [DataContract]
    public class ExecuteProgramAction : Action
    {
        [DataMember]
        public string CommandString { get; set; }
        
        [DataMember]
        public string ExecuteInDirectory { get; set; }
    }
}
