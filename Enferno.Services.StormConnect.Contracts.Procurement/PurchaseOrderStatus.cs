using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [DataContract(Name = "PurchaseOrderStatus", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public enum PurchaseOrderStatus
    {
        [EnumMember]
        Unknown = 0,
        [EnumMember]
        Allocation = 1,
        [EnumMember]
        Confirmed = 2,
        [EnumMember]
        Delivered = 4,
        [EnumMember]
        Invoiced = 5,
        [EnumMember]
        Cancelled = 6,
        [EnumMember]
        PartlyDelivered = 8,
        [EnumMember]
        Acknowledged = 9,
        [EnumMember]
        OnHold = 14,
        [EnumMember]
        WaitingForCancel = 15,
        [EnumMember]
        WaitingForOnHoldRemoved = 16,
        [EnumMember]
        CancelError = 17,
        [EnumMember]
        AcknowledgementError = 18
    }
}
