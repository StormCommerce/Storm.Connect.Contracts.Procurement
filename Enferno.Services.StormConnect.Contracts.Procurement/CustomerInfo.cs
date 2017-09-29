using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "CustomerInfo", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class CustomerInfo : Entity
    {
        [DataMember(Order = 1)]
        public string CustomerCode { get; set; }
        [DataMember(Order = 2)]
        public string SupplierCustomerCode { get; set; }
        [DataMember(Order = 3)]
        public Address Address { get; set; }
        [DataMember(Order = 4)]
        public string Email { get; set; }
        [DataMember(Order = 5)]
        public string Phone { get; set; }
    }
}
