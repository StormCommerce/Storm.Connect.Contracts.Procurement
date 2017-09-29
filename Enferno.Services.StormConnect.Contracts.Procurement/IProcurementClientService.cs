using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Procurement
{
    [ServiceContract(Name = "ProcurementClientService", Namespace = "Enferno.Services.StormConnect.Contracts.Procurement")]
    public interface IProcurementClientService
    {
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CreatePurchaseOrderAsync")]
        void CreatePurchaseOrderAsync(Envelope<RequestHeader, PurchaseOrder> request);

        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "CancelPurchaseOrder")]
        void CancelPurchaseOrder(Envelope<RequestHeader, PurchaseOrder> request);
        
        [OperationContract]
        [FaultContract(typeof(ErrorMessage_v2))]
        [WebInvoke(UriTemplate = "ImportSalesHistory")]
        void ImportSalesHistory(Envelope<RequestHeader, List<SalesHistory>> request);
    }
}
