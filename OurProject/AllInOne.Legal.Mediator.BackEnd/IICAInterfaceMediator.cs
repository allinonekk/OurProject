namespace AllInOne.Legal.Mediator.BackEnd
{
    using System.Collections.Generic;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Case;
    using AllInOne.Legal.Domain.Document;

    public interface IICAInterfaceMediator : IMediator
    {
        #region Methods

        /// <summary>
        /// Deletes the ICAInterfaceEntity If Status='C'
        /// </summary>
        /// <param name="status">Status</param>
        void DeleteICAInterfaceEntity(ICAInterfaceStatus iCAInterfaceStatus);

        /// <summary>
        /// Gets all the InterfaceEntity
        /// </summary>
        /// <returns></returns>
        List<InterfaceICAEntity> GetAllInterfaceEntity();

        /// <summary>
        /// Gets all InterfaceEntity Where Status <> C
        /// </summary>
        /// <param name="status">The status</param>
        /// <returns></returns>
        List<InterfaceICAEntity> GetAllInterfaceEntityByStatus();

        /// <summary>
        /// Gets the CaseInfo entity by pk.
        /// </summary>
        /// <param name="caseInfoId">CaseInfoId</param>
        /// <returns></returns>
        CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId);

        /// <summary>
        /// Gets the Documentinfo entity.
        /// </summary>
        /// <param name="docCode">DocCode</param>
        /// <param name="documentStatus">DocStatus</param>
        /// <param name="someDay">SomeDay</param>
        /// <returns></returns>
        List<DocumentInfoEntity> GetDocumentInfoEntity(string docCode, object documentStatus, int day);

        /// <summary>
        /// Gets the interface ICA entity by PK.
        /// </summary>
        /// <param name="iCAInterfaceId">The i CA interface id.</param>
        /// <returns></returns>
        InterfaceICAEntity GetInterfaceICAEntityByPK(string iCAInterfaceId);

        /// <summary>
        /// SavesOrUpdates the ICAInterfaceEntity
        /// </summary>
        /// <param name="interfaceICAEntity">The interface ICA entity.</param>
        void SaveOrUpdateICAInterfaceEntity(InterfaceICAEntity interfaceICAEntity);

        #endregion Methods

        #region Other

        //List<DocumentInfoEntity> GetDocumentInfoEntity(string docCode, string documentStatus, int someday);
        //CaseInfoEntity GetCaseInfoEntityByPk(string caseInfoId);
        //void SaveOrUpdateICAInterfaceEntity(ICAInterfaceEntity iCAInterfaceEntity);
        //void DeleteICAInterfaceEntity(string status: = 'C');
        //List<ICAInterfaceEntity> GetAllICAInterfaceEntity();
        //List<ICAInterfaceEntity> GetAllICAInterfaceEntity(string status: <> 'C');

        #endregion Other
    }
}