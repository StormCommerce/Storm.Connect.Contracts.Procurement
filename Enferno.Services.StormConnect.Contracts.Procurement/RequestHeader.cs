using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "RequestHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class RequestHeader : Entity
    {
        [DataMember(Order = 1)]
        public Guid MessageId { get; set; }
        [DataMember(Order = 2)]
        public DateTime Timestamp { get; set; }
        [DataMember(Order = 3)]
        public Guid ClientKey { get; set; }
        [DataMember(Order = 4)]
        public string SupplierCode { get; set; }
        [DataMember(Order = 5)]
        public Guid? ApplicationKey { get; set; }
        [DataMember(Order = 6)]
        public Guid? AccountKey { get; set; }
    }
}
