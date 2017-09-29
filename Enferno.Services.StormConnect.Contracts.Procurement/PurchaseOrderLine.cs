using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "PurchaseOrderLine", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class PurchaseOrderLine : Entity
    {
        [DataMember(Order = 1)]
        public string LineNo { get; set; }
        [DataMember(Order = 2)]
        public string SupplierLineNo { get; set; }
        [DataMember(Order = 3)]
        public string SalesOrderNo { get; set; }
        [DataMember(Order = 4)]
        public string SalesOrderLineNo { get; set; }
        [DataMember(Order = 5)]
        public PurchaseOrderStatus Status { get; set; }
        [DataMember(Order = 6)]
        public string PartNo { get; set; }
        [DataMember(Order = 7)]
        public string SupplierPartNo { get; set; }
        [DataMember(Order = 8)]
        public string ManufacturerPartNo { get; set; }
        [DataMember(Order = 9)]
        public string ProductName { get; set; }
        [DataMember(Order = 10)]
        public string ClientProductSkuType { get; set; }
        [DataMember(Order = 11)]
        public string EanCode { get; set; }
        [DataMember(Order = 12)]
        public decimal Quantity { get; set; }
        [DataMember(Order = 13)]
        public decimal QuantityOriginallyOrdered { get; set; }
        [DataMember(Order = 14)]
        public decimal QuantityDelivered { get; set; }
        [DataMember(Order = 15)]
        public decimal ItemPrice { get; set; }
        [DataMember(Order = 16)]
        public decimal? VatRate { get; set; }
        [DataMember(Order = 17)]
        public string ManufacturerCode { get; set; }
        [DataMember(Order = 18)]
        public string ClientComment { get; set; }
        [DataMember(Order = 19)]
        public string SupplierComment { get; set; }
        [DataMember(Order = 20)]
        public DateTime? RequestedDeliveryDate { get; set; }
        [DataMember(Order = 21)]
        public DateTime? ExpectedDeliveryDate { get; set; }
        [DataMember(Order = 22)]
        public DateTime? ConfirmedDeliveryDate { get; set; }
        [DataMember(Order = 23)]
        public string ShippingLineMark { get; set; }
    }
}
