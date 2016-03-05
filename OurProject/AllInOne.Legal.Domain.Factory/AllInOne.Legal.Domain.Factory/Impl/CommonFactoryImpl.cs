#region Header

/*****************************************************************************************************
 * Description : This file represents a standard implementation for Common factory.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 02/11/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: CommonFactoryImpl.cs
// Description: Represents a standard implementation for Common factory.
// </summary>
// <copyright file= "CommonFactoryImpl.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.Domain.Factory.Impl
{
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Domain.FrontEndSpecific;

    /// <summary>
    /// Represents a standard implementation for Common factory.
    /// It inherits from <see cref="ICommonFactory"/>.
    /// </summary>
    public class CommonFactoryImpl : ICommonFactory
    {
        #region Fields

        /// <summary>
        /// Variable to store ApplicationEnvironment.
        /// </summary>
        private ApplicationEnvironment applicationEnvironment;

        #endregion Fields

        #region Constructors

        public CommonFactoryImpl(ApplicationEnvironment applicationEnvironment)
        {
            this.applicationEnvironment = applicationEnvironment;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="PrintDocumentQueueEntity"/>
        /// </returns>
        /// 
        public PrintDocumentQueueEntity GetPrintDocumentQueueEntityInstance()
        {
            return new PrintDocumentQueueEntity { PrintDocumentQueueId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="PrintDocumentQueueDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="PrintDocumentQueueDetailEntity"/>
        /// </returns>
        /// 
        public PrintDocumentQueueDetailEntity GetPrintDocumentQueueDetailEntityInstance()
        {
            return new PrintDocumentQueueDetailEntity { PrintDocumentQueueDetailID = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="DocCasePartyAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="DocCasePartyAddressEntity"/>
        /// </returns>
        /// 
        public EFilingDraftStateEntity GetEFilingDraftStateEntityInstance()
        {
            return new EFilingDraftStateEntity { EFilingDraftStateId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LegislationProvisionsEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LegislationProvisionsEntity"/>
        /// </returns>
        /// 
        public LegislationProvisionsEntity GetLegislationProvisionsEntityInstance()
        {
            return new LegislationProvisionsEntity { LegislationProvisionId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorAddressEntity"/>
        /// </returns>
        /// 
        public LiquidatorAddressEntity GetLiquidatorAddressEntityInstance()
        {
            return new LiquidatorAddressEntity { LiquidatorAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorAliasEntity"/>
        /// </returns>
        /// 
        public LiquidatorAliasEntity GetLiquidatorAliasEntityInstance()
        {
            return new LiquidatorAliasEntity { LiquidatorAliasId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorEntity"/>
        /// </returns>
        /// 
        public LiquidatorEntity GetLiquidatorEntityInstance()
        {
            return new LiquidatorEntity { LiquidatorId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorPICAddressEntity"/>
        /// </returns>
        /// 
        public LiquidatorPICAddressEntity GetLiquidatorPICAddressEntityInstance()
        {
            return new LiquidatorPICAddressEntity { LiquidatorPICAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICAliasEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorPICAliasEntity"/>
        /// </returns>
        public LiquidatorPICAliasEntity GetLiquidatorPICAliasEntityInstance()
        {
            return new LiquidatorPICAliasEntity { LiquidatorPICAliasId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="LiquidatorPICEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="LiquidatorPICEntity"/>
        /// </returns>
        /// 
        public LiquidatorPICEntity GetLiquidatorPICEntityInstance()
        {
            return new LiquidatorPICEntity { LiquidatorPICId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="NatureOfCaseEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="NatureOfCaseEntity"/>
        /// </returns>
        /// 
        public NatureOfCaseEntity GetNatureOfCaseEntityInstance()
        {
            return new NatureOfCaseEntity { NatureOfCaseId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="OtherITMOEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="OtherITMOEntity"/>
        /// </returns>
        /// 
        public OtherITMOEntity GetOtherITMOEntityInstance()
        {
            return new OtherITMOEntity { OtherITMOId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="ScheduleJobFiredDetailEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="ScheduleJobFiredDetailEntity"/>
        /// </returns>
        public ScheduleJobFiredDetailEntity GetScheduleJobFiredDetailEntityInstance()
        {
            return new ScheduleJobFiredDetailEntity { ScheduleJobFiredDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="ScheduleJobFiredInfoEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="ScheduleJobFiredInfoEntity"/>
        /// </returns>
        public ScheduleJobFiredInfoEntity GetScheduleJobFiredInfoEntityInstance()
        {
            return new ScheduleJobFiredInfoEntity { ScheduleJobFiredInfoId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

        /// <summary>
        /// Gets the <see cref="WOECaseExecutionAddressEntity"/> instance.
        /// </summary>
        /// <returns>
        /// Returns <see cref="WOECaseExecutionAddressEntity"/>
        /// </returns>
        public WOECaseExecutionAddressEntity GetWOECaseExecutionAddressEntityInstance()
        {
            return new WOECaseExecutionAddressEntity { WOECaseExecutionAddressId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }

       
        public RefOrderDetailEntity GetRefOrderDetailEntityInstance()
        {
            return new RefOrderDetailEntity { RefOrderDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }


        public AppealTimeEstimationDetailEntity GetAppealTimeEstimationDetailEntityInstance()
        {
            return new AppealTimeEstimationDetailEntity { AppealTimeEstimationDetailId = FactoryUtil.GetPrimaryKey(this.applicationEnvironment) };
        }
        #endregion
    }
}