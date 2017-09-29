using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "SalesHistory", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class SalesHistory : Entity
    {
        [DataMember(Order = 1)]
        public string WarehouseCode { get; set; }
        [DataMember(Order = 2)]
        public string LocationCode { get; set; }
        [DataMember(Order = 3)]
        public string PartNo { get; set; }
        [DataMember(Order = 4)]
        public DateTime Date { get; set; }
        [DataMember(Order = 5)]
        public decimal Quantity { get; set; }
    }
}
