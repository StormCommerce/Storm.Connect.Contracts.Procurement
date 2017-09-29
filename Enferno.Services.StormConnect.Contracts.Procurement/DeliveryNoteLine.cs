using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "DeliveryNoteLine", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class DeliveryNoteLine : Entity
    {
        [DataMember(Order = 1)]
        public string LineNo { get; set; }
        [DataMember(Order = 2)]
        public string SupplierPurchaseOrderLineNo { get; set; }
        [DataMember(Order = 3)]
        public string PartNo { get; set; }
        [DataMember(Order = 4)]
        public string SupplierPartNo { get; set; }
        [DataMember(Order = 5)]
        public string ProductName { get; set; }
        [DataMember(Order = 6)]
        public decimal QuantityOrdered { get; set; }
        [DataMember(Order = 7)]
        public decimal Quantity { get; set; }
        [DataMember(Order = 8)]
        public List<string> SerialNos { get; set; }
    }
}
