using Enferno.Services.Contracts;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [ServiceContract(Name = "ProcurementSupplierNotificationService",
        Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public interface IProcurementSupplierNotificationService
    {
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CreatePurchaseOrder")]
        Envelope<RequestHeader, PurchaseOrder> CreatePurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);
        
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CancelPurchaseOrder")]
        void CancelPurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "ConfirmPurchaseOrder")]
        void ConfirmPurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);
    }
}
