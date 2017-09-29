using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "InvoiceLine", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class InvoiceLine : Entity
    {
        [DataMember(Order = 1)]
        public string LineNo { get; set; }
        [DataMember(Order = 2)]
        public string SupplierLineNo { get; set; }
        [DataMember(Order = 3)]
        public string PartNo { get; set; }
        [DataMember(Order = 4)]
        public string SupplierPartNo { get; set; }
        [DataMember(Order = 5)]
        public string ProductName { get; set; }
        [DataMember(Order = 6)]
        public int Quantity { get; set; }
        [DataMember(Order = 7)]
        public decimal ItemPrice { get; set; }
        [DataMember(Order = 8)]
        public decimal? VatRate { get; set; }
        [DataMember(Order = 9)]
        public List<string> SerialNos { get; set; }
    }
}
