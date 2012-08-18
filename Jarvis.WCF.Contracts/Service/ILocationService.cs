using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Jarvis.WCF.Contracts.Data;

namespace Jarvis.WCF.Contracts.Service
{
    [ServiceKnownType(typeof(List<Location>))]
    [ServiceKnownType(typeof(List<LocationCategory>))]
    [ServiceContract]
    public interface ILocationService
    {
        [OperationContract]
        IList<Location> GetKnownLocations();
    }
}
