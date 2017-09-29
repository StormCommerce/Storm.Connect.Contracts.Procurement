using System.ServiceModel;
using System.ServiceModel.Web;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [ServiceContract(Name = "ProcurementClientNotificationService", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public interface IProcurementClientNotificationService
    {
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CreatePurchaseOrder")]
        Envelope<RequestHeader, PurchaseOrder> CreatePurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "UpdatePurchaseOrder")]
        void UpdatePurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CancelPurchaseOrder")]
        void CancelPurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CreateDeliveryNote")]
        void CreateDeliveryNote(Envelope<RequestHeader, DeliveryNote> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CreateInvoice")]
        void CreateInvoice(Envelope<RequestHeader, Invoice> request);
    }
}
