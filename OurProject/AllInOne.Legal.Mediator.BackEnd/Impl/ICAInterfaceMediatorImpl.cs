namespace AllInOne.Legal.Mediator.BackEnd.Impl
{
    using System;
    using System.Collections.Generic;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Mediator.BackEnd.Data;

    public class ICAInterfaceMediatorImpl : IICAInterfaceMediator
    {
        #region Methods

        public void DeleteICAInterfaceEntity(ICAInterfaceStatus iCAInterfaceStatus)
        {
            if (iCAInterfaceStatus == ICAInterfaceStatus.Null)
            {
                throw new ArgumentNullException("iCAInterfaceStatus", "Param iCAInterfaceStatus should not be null.");
            }

            InterfaceICAGateway interfaceGateway = new InterfaceICAGateway();
            interfaceGateway.DeleteInterfaceICAByStatus(iCAInterfaceStatus);
        }

        public List<InterfaceICAEntity> GetAllInterfaceEntity()
        {
            InterfaceICAGateway interfaceGateway = new InterfaceICAGateway();
              return  interfaceGateway.GetAllInterfaceICAEntity();
        }

        public List<InterfaceICAEntity> GetAllInterfaceEntityByStatus()
        {
            InterfaceICAGateway interfaceICAGateway = new InterfaceICAGateway();
            return interfaceICAGateway.GetAllInterfaceICAEntityByStatus();
        }

        public CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId)
        {
            CaseGateway casegateway = new CaseGateway();
            return casegateway.GetCaseInfoByPK(caseInfoId);
        }

        public List<DocumentInfoEntity> GetDocumentInfoEntity(string docCode, object documentStatus, int day)
        {
            DocumentGateway documentGateway = new DocumentGateway();
               return documentGateway.GetDocumentInfoEntity(docCode, documentStatus, day);
        }

        public InterfaceICAEntity GetInterfaceICAEntityByPK(string iCAInterfaceId)
        {
            InterfaceICAGateway interfaceICAGateway = new InterfaceICAGateway();
            return interfaceICAGateway.GetInterfaceICAByPK(iCAInterfaceId);
        }

        public void SaveOrUpdateICAInterfaceEntity(InterfaceICAEntity interfaceICAEntity)
        {
            InterfaceICAGateway interfaceICAGateway = new InterfaceICAGateway();
            interfaceICAGateway.SaveOrUpdateInterfaceICAEntity(interfaceICAEntity);
        }

        #endregion Methods
    }
}