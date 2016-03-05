#region Header

/*****************************************************************************************************
 * Description : This file represents various classes to implement different Resolvers from string
 *              to NHibernate entity object.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 30/12/2010                 Swaroop             	 	Created
 *****************************************************************************************************/
// <summary>
// File: DomainToNHibernateObjectResolvers.cs
// Description: Represents a standard various classes to implement different Resolvers from string
// to NHibernate entity object.
// </summary>
// <copyright file= "DomainToNHibernateObjectResolvers.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.Utilities
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="Hearing"/>.
    /// </summary>
    internal class Int64ToHearingResolver : ValueResolver<Int64, Hearing>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Int64ToHearingResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override Hearing ResolveCore(Int64 source)
        {
            try
            {
                if (source.Equals(null))
                {
                    return null;
                }

                return new Hearing { HRGID = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at Int64ToHearingResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SubCaseInfo"/>.
    /// </summary>
    internal class LongToHearingResolver : ValueResolver<long, Hearing>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LongToHearingResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override Hearing ResolveCore(long source)
        {
            try
            {

                return new Hearing { HRGID = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToHearingResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="MBasisForTaxationEntity"/>.
    /// </summary>
    internal class MBasisForTaxationEntityToStringResolver : ValueResolver<MBasisForTaxationEntity, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MBasisForTaxationEntityToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override string ResolveCore(MBasisForTaxationEntity source)
        {
            try
            {
                if (source == null)
                {
                    return null;
                }

                return source.BFTCode;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MBasisForTaxationEntityToStringResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="Hearing"/>.
    /// </summary>
    internal class MCurrencyEntityToStringResolver : ValueResolver<MCurrencyEntity, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MCurrencyEntityToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override string ResolveCore(MCurrencyEntity source)
        {
            try
            {
                if (source.Equals(null))
                {
                    return null;
                }

                return source.CurrencyCode;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MCurrencyEntityToStringResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="Hearing"/>.
    /// </summary>
    internal class MHRGTypeEntityToStringResolver : ValueResolver<MHRGTypeEntity, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MHRGTypeEntityToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override string ResolveCore(MHRGTypeEntity source)
        {
            try
            {
                if (source.Equals(null))
                {
                    return null;
                }

                return source.HRGTypeCode;
            }
            catch (Exception ex)
            {
                Logger.Error("Error at MHRGTypeEntityToStringResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CaseInfo"/>.
    /// </summary>
    internal class StringToCaseInfoResolver : ValueResolver<string, CaseInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCaseInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CaseInfo"/> object to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return CaseInfo.</returns>
        protected override CaseInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new CaseInfo { CaseInfoId = Convert.ToInt64(source) };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCaseInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CasePartyBailorInfo"/>.
    /// </summary>
    internal class StringToCasePartyBailorInfoResolver : ValueResolver<string, CasePartyBailorInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCasePartyBailorInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CasePartyBailorInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return CasePartyBailorInfo.</returns>
        protected override CasePartyBailorInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new CasePartyBailorInfo { CasePartyBailorInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCasePartyBailorInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CaseParty"/>.
    /// </summary>
    internal class StringToCasePartyResolver : ValueResolver<string, CaseParty>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCasePartyResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CaseParty"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return CaseParty.</returns>
        protected override CaseParty ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new CaseParty { CasePartyId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCasePartyResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChargeInfo"/>.
    /// </summary>
    internal class StringToChargeInfoResolver : ValueResolver<string, ChargeInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChargeInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CasePartyBailorInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return CasePartyBailorInfo.</returns>
        protected override ChargeInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new ChargeInfo { ChargeInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChargeInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocCasePartyBailorInfo"/>.
    /// </summary>
    internal class StringToDocCasePartyBailorInfoResolver : ValueResolver<string, DocCasePartyBailorInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocCasePartyBailorInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Hearing"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return Hearing.</returns>
        protected override DocCasePartyBailorInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new DocCasePartyBailorInfo { DocCasePartyBailorInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocCasePartyBailorInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocCaseParty"/>.
    /// </summary>
    internal class StringToDocCasePartyResolver : ValueResolver<string, DocCaseParty>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocCasePartyResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocCaseParty"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return DocCaseParty.</returns>
        protected override DocCaseParty ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new DocCaseParty { DCPID = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocCasePartyResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocumentInfo"/>.
    /// </summary>
    internal class StringToDocumentInfoResolver : ValueResolver<string, DocumentInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocumentInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AddressAvailabilityType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return DocumentInfo.</returns>
        protected override DocumentInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new DocumentInfo { DocId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocumentInfoResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAccount"/>.
    /// </summary>
    internal class StringToEMSAccountResolver : ValueResolver<string, EMSAccount>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAccountResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAccount"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAccount.</returns>
        protected override EMSAccount ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAccount { EMSAccountId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAccountResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAdmCharge"/>.
    /// </summary>
    internal class StringToEMSAdmChargeResolver : ValueResolver<string, EMSAdmCharge>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAdmChargeResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAdmCharge"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAdmCharge.</returns>
        protected override EMSAdmCharge ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAdmCharge { EMSAdmChargeId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAdmChargeResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAdmExec"/>.
    /// </summary>
    internal class StringToEMSAdmExecResolver : ValueResolver<string, EMSAdmExec>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAdmExecResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAdmExec"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAdmExec.</returns>
        protected override EMSAdmExec ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAdmExec { EMSAdmExecId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAdmExecResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAdmProperty"/>.
    /// </summary>
    internal class StringToEMSAdmPropertyResolver : ValueResolver<string, EMSAdmProperty>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAdmPropertyResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAdmProperty"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAdmProperty.</returns>
        protected override EMSAdmProperty ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAdmProperty { EMSAdmPropertyId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAdmPropertyResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAdmRelease"/>.
    /// </summary>
    internal class StringToEMSAdmReleaseResolver : ValueResolver<string, EMSAdmRelease>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAdmReleaseResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAdmRelease"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAdmRelease.</returns>
        protected override EMSAdmRelease ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAdmRelease { EMSAdmReleaseId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAdmReleaseResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSAppointment"/>.
    /// </summary>
    internal class StringToEMSAppointmentResolver : ValueResolver<string, EMSAppointment>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSAppointmentResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSAppointment"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSAppointment.</returns>
        protected override EMSAppointment ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSAppointment { EMSAppointmentId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSAppointmentResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSApptDateTime"/>.
    /// </summary>
    internal class StringToEMSApptDateTimeResolver : ValueResolver<string, EMSApptDateTime>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSApptDateTimeResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSApptDateTime"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSApptDateTime.</returns>
        protected override EMSApptDateTime ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSApptDateTime { EMSApptDateTimeId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSApptDateTimeResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSRecTrans"/>.
    /// </summary>
    internal class StringToEMSCashBookReconcileResolver : ValueResolver<string, EMSCashBookReconcile>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSCashBookReconcileResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSCashBookReconcile"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSCashBookReconcile.</returns>
        protected override EMSCashBookReconcile ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSCashBookReconcile { EMSCashBookReconcileId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSCashBookReconcileResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSCheque"/>.
    /// </summary>
    internal class StringToEMSChequeResolver : ValueResolver<string, EMSCheque>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSChequeResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSCheque"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSCheque.</returns>
        protected override EMSCheque ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSCheque { EMSChequeId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSChequeResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSCivCrmSeizure"/>.
    /// </summary>
    internal class StringToEMSCivCrmSeizureResolver : ValueResolver<string, EMSCivCrmSeizure>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSCivCrmSeizureResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSCivCrmSeizure"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSCivCrmSeizure.</returns>
        protected override EMSCivCrmSeizure ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSCivCrmSeizure { EMSCivCrmSeizureId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSCivCrmSeizureResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSCrmCase"/>.
    /// </summary>
    internal class StringToEMSCrmCaseResolver : ValueResolver<string, EMSCrmCase>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSCrmCaseResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSCrmCase"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSCrmCase.</returns>
        protected override EMSCrmCase ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSCrmCase { EMSCrmCaseId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSCrmCaseResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSPayment"/>.
    /// </summary>
    internal class StringToEMSPaymentResolver : ValueResolver<string, EMSPayment>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSPaymentResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSPayment"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSPayment.</returns>
        protected override EMSPayment ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSPayment { EMSPaymentId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSPaymentResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSPaymentVoucherFinal"/>.
    /// </summary>
    internal class StringToEMSPaymentVoucherFinalResolver : ValueResolver<string, EMSPaymentVoucherFinal>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSPaymentVoucherFinalResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSPaymentVoucherFinal"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSPaymentVoucherFinal.</returns>
        protected override EMSPaymentVoucherFinal ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSPaymentVoucherFinal { EMSPaymentVoucherFinalId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSPaymentVoucherFinalResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSPaymentVoucher"/>.
    /// </summary>
    internal class StringToEMSPaymentVoucherResolver : ValueResolver<string, EMSPaymentVoucher>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSPaymentVoucherResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSPaymentVoucher"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSPaymentVoucher.</returns>
        protected override EMSPaymentVoucher ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSPaymentVoucher { EMSPaymentVoucherId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSPaymentVoucherResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSRecapitulation"/>.
    /// </summary>
    internal class StringToEMSRecapitulationResolver : ValueResolver<string, EMSRecapitulation>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSRecapitulationResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSRecapitulation"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSRecapitulation.</returns>
        protected override EMSRecapitulation ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSRecapitulation { EMSRecapitulationId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSRecapitulationResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSReceipt"/>.
    /// </summary>
    internal class StringToEMSReceiptResolver : ValueResolver<string, EMSReceipt>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSReceiptResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSReceipt"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSReceipt.</returns>
        protected override EMSReceipt ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSReceipt { EMSReceiptId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSReceiptResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSRecTrans"/>.
    /// </summary>
    internal class StringToEMSRecTransResolver : ValueResolver<string, EMSRecTrans>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSRecTransResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSRecTrans"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSRecTrans.</returns>
        protected override EMSRecTrans ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSRecTrans { EMSRecTransId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSRecTransResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSSale"/>.
    /// </summary>
    internal class StringToEMSSaleResolver : ValueResolver<string, EMSSale>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSSaleResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSSale"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return EMSSale.</returns>
        protected override EMSSale ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new EMSSale { EMSSaleId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSSaleResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FileInspection"/>.
    /// </summary>
    internal class StringToFileInspectionResolver : ValueResolver<string, FileInspection>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFileInspectionResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FileInspection"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return FileInspection.</returns>
        protected override FileInspection ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new FileInspection { FileInspectionId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFileInspectionResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ForeignLawPracticeReg"/>.
    /// </summary>
    internal class StringToForeignLawPracticeRegResolver : ValueResolver<string, ForeignLawPracticeReg>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToForeignLawPracticeRegResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ForeignLawPracticeReg"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return ForeignLawPracticeReg.</returns>
        protected override ForeignLawPracticeReg ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new ForeignLawPracticeReg { ForeignLawPracticeRegId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToForeignLawPracticeRegResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="JudicialUser"/>.
    /// </summary>
    internal class StringToJudicialUserResolver : ValueResolver<string, JudicialUser>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToJudicialUserResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="JudicialUser"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return JudicialUser.</returns>
        protected override JudicialUser ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new JudicialUser { UserId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToJudicialUserResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /*
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ForeignLawPractice"/>.
    /// </summary>
    internal class StringToForeignLawPracticeResolver : ValueResolver<string, ForeignLawPractice>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToForeignLawPracticeResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ForeignLawPractice"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null,
        /// else return ForeignLawPractice.</returns>
        protected override ForeignLawPractice ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new ForeignLawPractice { ForeignLawPracticeId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToForeignLawPracticeResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }*/
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACDocumentDetail"/>.
    /// </summary>
    internal class StringtoLACDocumentDetailResolver : ValueResolver<string, LACDocumentDetail>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringtoLACDocumentDetailResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACDocumentDetail"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return LACDocDetailId.</returns>
        protected override LACDocumentDetail ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new LACDocumentDetail { LACDocDetailId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringtoLACDocumentDetailResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACInfo"/>.
    /// </summary>
    internal class StringToLACInfoResolver : ValueResolver<string, LACInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return LACInfoId.</returns>
        protected override LACInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new LACInfo { LACInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringtoLACInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LawFirm"/>.
    /// </summary>
    internal class StringToLawFirmResolver : ValueResolver<string, LawFirm>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLawFirmResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LawFirm"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return LawFirm.</returns>
        protected override LawFirm ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new LawFirm { LFID = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLawFirmResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LegislationProvision"/>.
    /// </summary>
    internal class StringToLegislationProvisionResolver : ValueResolver<string, LegislationProvision>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLegislationProvisionResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LegislationProvision"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return LegislationProvision.</returns>
        protected override LegislationProvision ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new LegislationProvision { LegislationProvisionId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLegislationProvisionResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LPOthLegalOrgInfo"/>.
    /// </summary>
    internal class StringToLPOthLegalOrgInfoResolver : ValueResolver<string, LPOthLegalOrgInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLPOthLegalOrgInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LPOthLegalOrgInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return LPOthLegalOrgInfo.</returns>
        protected override LPOthLegalOrgInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new LPOthLegalOrgInfo { LPOthLegalOrgInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLPOthLegalOrgInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentInDocDetail"/>.
    /// </summary>
    internal class StringToPaymentInDocDetailResolver : ValueResolver<string, PaymentInDocDetail>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentInDocDetailResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentInDocDetail"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return PaymentInId.</returns>
        protected override PaymentInDocDetail ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new PaymentInDocDetail { PaymentInId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentInDocDetailResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SentenceInfo"/>.
    /// </summary>
    internal class StringToSentenceInfoResolver : ValueResolver<string, SentenceInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSentenceInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SentenceInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return SentenceInfo.</returns>
        protected override SentenceInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new SentenceInfo { SentenceInfoId = source };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSentenceInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SubCaseInfo"/>.
    /// </summary>
    internal class StringToSubCaseInfoResolver : ValueResolver<string, SubCaseInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSubCaseInfoResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SubCaseInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="source"/> id from Domain Object.</param>
        /// <returns>If the selection is null then return will be null, 
        /// else return SubCaseInfo.</returns>
        protected override SubCaseInfo ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return new SubCaseInfo { SubCaseInfoId = Convert.ToInt64(source) };
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocumentInfoResolver " + "value " + source + " >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }
}