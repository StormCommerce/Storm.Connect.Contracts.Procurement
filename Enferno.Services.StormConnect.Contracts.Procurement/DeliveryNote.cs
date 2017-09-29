using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "DeliveryNote", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class DeliveryNote : Entity
    {
        [DataMember(Order = 1)]
        public long? StormId { get; set; }
        [DataMember(Order = 2)]
        public string DeliveryNoteNo { get; set; }
        [DataMember(Order = 3)]
        public string PurchaseOrderNo { get; set; }
        [DataMember(Order = 4)]
        public string SupplierOrderNo { get; set; }
        [DataMember(Order = 5)]
        public Address DeliveryAddress { get; set; }
        [DataMember(Order = 6)]
        public DateTime? DeliveryDate { get; set; }
        [DataMember(Order = 7)]
        public List<DeliveryNoteLine> Lines { get; set; }
        [DataMember(Order = 8)]
        public List<string> ShippingNos { get; set; }
        [DataMember(Order = 9)]
        public int? PackageQuantity { get; set; }
        [DataMember(Order = 10)]
        public decimal? Volume { get; set; }
        [DataMember(Order = 11)]
        public decimal? Weight { get; set; }
        [DataMember(Order = 12)]
        public string DeliveryMark { get; set; }
    }
}
