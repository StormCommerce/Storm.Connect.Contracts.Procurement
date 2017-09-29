using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class Envelope<T1, T2> : Entity
    {
        [DataMember(Order = 1)]
        public T1 Header { get; set; }
        [DataMember(Order = 2)]
        public T2 Body { get; set; }
    }
}
