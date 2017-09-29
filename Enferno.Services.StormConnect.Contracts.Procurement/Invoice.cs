using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "Invoice", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public class Invoice : Entity
    {
        [DataMember(Order = 1)]
        public long? StormId { get; set; }
        [DataMember(Order = 2)]
        public string InvoiceNo { get; set; }
        [DataMember(Order = 3)]
        public string SupplierInvoiceNo { get; set; }
        [DataMember(Order = 4)]
        public string PurchaseOrderNo { get; set; }
        [DataMember(Order = 5)]
        public string SupplierOrderNo { get; set; }
        [DataMember(Order = 6)]
        public Address InvoiceAddress { get; set; }
        [DataMember(Order = 7)]
        public DateTime InvoiceDate { get; set; }
        [DataMember(Order = 8)]
        public List<InvoiceLine> Lines { get; set; }
        [DataMember(Order = 9)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 10)]
        public decimal TotalAmount { get; set; }
        [DataMember(Order =11)]
        public decimal? VatAmount { get; set; }
        [DataMember(Order = 12)]
        public bool? IsLastInvoiceForOrder { get; set; }
    }
}
