using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "PurchaseOrder", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class PurchaseOrder : Entity
    {
        [DataMember(Order = 1)]
        public long? StormId { get; set; }
        [DataMember(Order = 2)]
        public string PurchaseOrderNo { get; set; }
        [DataMember(Order = 3)]
        public string SupplierPurchaseOrderNo { get; set; }
        [DataMember(Order = 4)]
        public PurchaseOrderStatus Status { get; set; }
        [DataMember(Order = 5)]
        public DateTime PurchaseOrderDate { get; set; }
        [DataMember(Order = 6)]
        public CustomerInfo SellToInfo { get; set; }
        [DataMember(Order = 7)]
        public CustomerInfo ShippingInfo { get; set; }
        [DataMember(Order = 8)]
        public CustomerInfo InvoiceInfo { get; set; }
        [DataMember(Order = 9)]
        public List<PurchaseOrderLine> Lines { get; set; }
        [DataMember(Order = 10)]
        public List<string> SalesOrderNumbers { get; set; }
        [DataMember(Order = 11)]
        public string PurchaseRep { get; set; }
        [DataMember(Order = 12)]
        public string Source { get; set; }
        [DataMember(Order = 13)]
        public string ClientComment { get; set; }
        [DataMember(Order = 14)]
        public string SupplierComment { get; set; }
        [DataMember(Order = 15)]
        public string ShipNoteMark { get; set; }
        [DataMember(Order = 16)]
        public string DeliveryMethodCode { get; set; }
        [DataMember(Order = 17)]
        public string DeliveryTerms { get; set; }
        [DataMember(Order = 18)]
        public string FreightTerms { get; set; }
        [DataMember(Order = 19)]
        public string InvoiceMark { get; set; }
        [DataMember(Order = 20)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 21)]
        public string PaymentTerms { get; set; }
    }
}
