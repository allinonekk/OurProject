#region Header

/*****************************************************************************************************
 * Description : This file represents various classes to implement different Resolvers from enum
 *              to string for domain to entity.
 *
 *-----------------------------------------------------------------------------------------------------
 *	                                    File History
 *-----------------------------------------------------------------------------------------------------
 *
 *	Date			          Author			        Description
 *-----------------------------------------------------------------------------------------------------
 * 06/09/2010                 Swaroop             	 	Created
 * 30/10/2010                 Swaroop                   Added logging and comments.
 *****************************************************************************************************/
// <summary>
// File: DomainToEntityResolvers.cs
// Description: Represents a standard various classes to implement different Resolvers from enum to string
// for domain to entity.
// </summary>
// <copyright file= "DomainToEntityResolvers.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.Utilities
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain;

    using log4net;

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AASPCPaidStatus"/> enum.
    /// </summary>
    internal class AASPCPaidStatusToStringResolver : ValueResolver<AASPCPaidStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AASPCPaidStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AASPCPaidStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AASPCPaidStatus"/> enum.</param>
        /// <returns>If the selection is AASPCPaidStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AASPCPaidStatus source)
        {
            try
            {
                if (source == AASPCPaidStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AASPCPaidStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AASPCVoteStatus"/> enum.
    /// </summary>
    internal class AASPCVoteStatusToStringResolver : ValueResolver<AASPCVoteStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AASPCVoteStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AASPCVoteStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AASPCVoteStatus"/> enum.</param>
        /// <returns>If the selection is AASPCVoteStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AASPCVoteStatus source)
        {
            try
            {
                if (source == AASPCVoteStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AASPCVoteStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="HearingModeInd"/> enum.
    /// </summary>
    internal class HearingModeIndToStringResolver : ValueResolver<HearingModeInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HearingModeIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="HearingModeInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="HearingModeInd"/> enum.</param>
        /// <returns>If the selection is HearingModeInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(HearingModeInd source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at HearingModeIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AddLess"/> enum.
    /// </summary>
    internal class AddLessToStringResolver : ValueResolver<AddLess, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AddLessToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AddLess"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AddLess"/> enum.</param>
        /// <returns>If the selection is AddLess.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AddLess source)
        {
            try
            {
                if (source == AddLess.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AddLessToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AddressAvailabilityType"/> enum.
    /// </summary>
    internal class AddressAvailabilityTypeToStringResolver : ValueResolver<AddressAvailabilityType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AddressAvailabilityTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AddressAvailabilityType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AddressAvailabilityType"/> enum.</param>
        /// <returns>If the selection is AddressAvailabilityType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AddressAvailabilityType source)
        {
            try
            {
                if (source == AddressAvailabilityType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AddressAvailabilityTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AddressFormatType"/> enum.
    /// </summary>
    internal class AddressFormatTypeToStringResolver : ValueResolver<AddressFormatType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AddressFormatTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AddressFormatType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AddressFormatType"/> enum.</param>
        /// <returns>If the selection is AddressFormatType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AddressFormatType source)
        {
            try
            {

                if (source == AddressFormatType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AddressFormatTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AddressType"/> enum.
    /// </summary>
    internal class AddressTypeToStringResolver : ValueResolver<AddressType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AddressTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AddressType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AddressType"/> enum.</param>
        /// <returns>If the selection is AddressType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AddressType source)
        {
            try
            {

                if (source == AddressType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AddressTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AdmiralityType"/> enum.
    /// </summary>
    internal class AdmiralityTypeToStringResolver : ValueResolver<AdmiralityType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AdmiralityTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AdmiralityType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AdmiralityType"/> enum.</param>
        /// <returns>If the selection is AdmiralityType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AdmiralityType source)
        {
            try
            {
                if (source == AdmiralityType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AdmiralityTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AdmiraltyWritType"/> enum.
    /// </summary>
    internal class AdmiraltyWritTypeToStringResolver : ValueResolver<AdmiraltyWritType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AdmiraltyWritTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AdmiraltyWritType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AdmiraltyWritType"/> enum.</param>
        /// <returns>If the selection is AdmiraltyWritType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AdmiraltyWritType source)
        {
            try
            {
                if (source == AdmiraltyWritType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AdmiraltyWritTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AffidavitAEICType"/> enum.
    /// </summary>
    internal class AffidavitAEICTypeToStringResolver : ValueResolver<AffidavitAEICType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AffidavitAEICTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AffidavitAEICType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AffidavitAEICType"/> enum.</param>
        /// <returns>If the selection is AffidavitAEICType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AffidavitAEICType source)
        {
            try
            {
                if (source == AffidavitAEICType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AffidavitAEICTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AgreeOrNotAgree"/> enum.
    /// </summary>
    internal class AgreeOrNotAgreeToStringResolver : ValueResolver<AgreeOrNotAgree, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AgreeOrNotAgreeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AgreeOrNotAgree"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AgreeOrNotAgree"/> enum.</param>
        /// <returns>If the selection is AgreeOrNotAgree.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AgreeOrNotAgree source)
        {
            try
            {
                if (source == AgreeOrNotAgree.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AmendmentInSupport"/> enum.
    /// </summary>
    internal class AmendmentInSupportToStringResolver : ValueResolver<AmendmentInSupport, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AmendmentInSupportToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AmendmentInSupport"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AmendmentInSupport"/> enum.</param>
        /// <returns>If the selection is AmendmentInSupport.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AmendmentInSupport source)
        {
            try
            {

                if (source == AmendmentInSupport.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AmendmentInSupportToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CrimeCase"/> enum.
    /// </summary>
    internal class AmendmentPerformedAtToStringResolver : ValueResolver<AmendmentPerformedAt, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AmendmentPerformedAtToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AmendmentPerformedAt"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AmendmentPerformedAt"/> enum.</param>
        /// <returns>If the selection is AmendmentPerformedAt.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AmendmentPerformedAt source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AmendmentPerformedAtToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    //***********************************************************************************
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AmendmentStatus"/> enum.
    /// </summary>
    internal class AmendmentStatusToStringResolver : ValueResolver<AmendmentStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AmendmentStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AmendmentStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AmendmentStatus"/> enum.</param>
        /// <returns>If the selection is AmendmentStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AmendmentStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AmendmentStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AppealsAgainst"/> enum.
    /// </summary>
    internal class AppealsAgainstToStringResolver : ValueResolver<AppealsAgainst, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AppealsAgainstToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AppealsAgainst"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AppealsAgainst"/> enum.</param>
        /// <returns>If the selection is AppealsAgainst.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AppealsAgainst source)
        {
            try
            {
                if (source == AppealsAgainst.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ApplicantType"/> enum.
    /// </summary>
    internal class ApplicantTypeToStringResolver : ValueResolver<ApplicantType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ApplicantTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ApplicantType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ApplicantType"/> enum.</param>
        /// <returns>If the selection is ApplicantType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ApplicantType source)
        {
            try
            {
                if (source == ApplicantType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ApplicantTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ApplicationLimitation"/> enum.
    /// </summary>
    internal class ApplicationLimitationToStringResolver : ValueResolver<ApplicationLimitation, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ApplicationLimitationToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ApplicationLimitation"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ApplicationLimitation"/> enum.</param>
        /// <returns>If the selection is ApplicationLimitation.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ApplicationLimitation source)
        {
            try
            {
                if (source == ApplicationLimitation.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ApplicationLimitationToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AppointmentOrganisationType"/> enum.
    /// </summary>
    internal class AppointmentOrganisationTypeToStringResolver : ValueResolver<AppointmentOrganisationType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AppointmentOrganisationTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AppointmentOrganisationType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AppointmentOrganisationType"/> enum.</param>
        /// <returns>If the selection is AppointmentOrganisationType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AppointmentOrganisationType source)
        {
            try
            {

                if (source == AppointmentOrganisationType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppointmentOrganisationTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AttachmentType"/> enum.
    /// </summary>
    internal class AttachmentTypeToStringResolver : ValueResolver<AttachmentType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AttachmentTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AttachmentType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AttachmentType"/> enum.</param>
        /// <returns>If the selection is AttachmentType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AttachmentType source)
        {
            try
            {
                if (source == AttachmentType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AttachmentTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AttendanceMode"/> enum.
    /// </summary>
    internal class AttendanceModeToStringResolver : ValueResolver<AttendanceMode, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AttendanceModeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AttendanceMode"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AttendanceMode"/> enum.</param>
        /// <returns>If the selection is AttendanceMode.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AttendanceMode source)
        {
            try
            {

                if (source == AttendanceMode.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AttendanceModeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AutionType"/> enum.
    /// </summary>
    internal class AutionTypeToStringResolver : ValueResolver<AutionType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AutionTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AutionType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AutionType"/> enum.</param> 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AutionType source)
        {
            try
            {
                if (source == AutionType.Null)
                {//BUG-ENFPROD-SC-2013100702
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AutionTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AutoTestingMode"/> enum.
    /// </summary>
    internal class AutoTestingModeToStringResolver : ValueResolver<AutoTestingMode, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AutoTestingModeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AutoTestingMode"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AutoTestingMode"/> enum.</param>
        /// <returns>Value as string after converting enum to string will be returned.</returns>
        protected override string ResolveCore(AutoTestingMode source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at AutoTestingModeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="BackdateStatus"/> enum.
    /// </summary>
    internal class BackdateStatusToStringResolver : ValueResolver<BackdateStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BackdateStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="BackdateStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="BackdateStatus"/> enum.</param>
        /// <returns>If the selection is BackdateStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(BackdateStatus source)
        {
            try
            {
                if (source == BackdateStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at BackdateStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="BailiffClaimStatus"/> enum.
    /// </summary>
    internal class BailiffClaimStatusToStringResolver : ValueResolver<BailiffClaimStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BailiffClaimStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="BailiffClaimStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="BailiffClaimStatus"/> enum.</param>
        /// <returns>If the selection is BailiffClaimStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(BailiffClaimStatus source)
        {
            try
            {
                if (source == BailiffClaimStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at BailiffClaimStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="BizMonStatus"/> enum.
    /// </summary>
    internal class BizMonStatusToStringResolver : ValueResolver<BizMonStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(BizMonStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ExecutorStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ExecutorStatus"/> enum.</param>
        /// <returns>If the selection is ExecutorStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(BizMonStatus source)
        {
            try
            {
                if (source == BizMonStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at BizMonStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CashBookReconcileStatus"/> enum.
    /// </summary>
    internal class CaseBookReconcileStatusToStringResolver : ValueResolver<CashBookReconcileStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseBookReconcileStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CashBookReconcileStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CashBookReconcileStatus"/> enum.</param>
        /// <returns>If the selection is CaseBookReconcileStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CashBookReconcileStatus source)
        {
            try
            {
                //if (source == CaseBookReconcileStatus.Null)
                //{
                //    return null;
                //}

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CaseBookReconcileStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CasePartyRepresentedBy"/> enum.
    /// </summary>
    internal class CasePartyRepresentedByToStringResolver : ValueResolver<CasePartyRepresentedBy, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CasePartyRepresentedByToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CasePartyRepresentedBy"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CasePartyRepresentedBy"/> enum.</param>
        /// <returns>If the selection is CasePartyRepresentedBy.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CasePartyRepresentedBy source)
        {
            try
            {
                if (source == CasePartyRepresentedBy.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CasePartyRepresentedByToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CaseTrack"/> enum.
    /// </summary>
    internal class CaseTrackToStringResolver : ValueResolver<CaseTrack, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CaseTrackToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CaseTrack"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CaseTrack"/> enum.</param>
        /// <returns>If the selection is CaseTrack.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CaseTrack source)
        {
            try
            {
                if (source == CaseTrack.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CaseTrackToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CashBookItemType"/> enum.
    /// </summary>
    internal class CashBookItemTypeToStringResolver : ValueResolver<CashBookItemType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CashBookItemTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CashBookItemType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CashBookItemType"/> enum.</param>
        /// <returns>If the selection is CashBookItemType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CashBookItemType source)
        {
            try
            {
                if (source == CashBookItemType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CashBookItemTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChargeStatusType"/> enum.
    /// </summary>
    internal class ChargeStatusTypeToStringResolver : ValueResolver<ChargeStatusType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChargeStatusTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ChargeStatusType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ChargeStatusType"/> enum.</param>
        /// <returns>If the selection is ChargeStatusType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ChargeStatusType source)
        {
            try
            {
                if (source == ChargeStatusType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChecklistStatus"/> enum.
    /// </summary>
    internal class ChecklistStatusToStringResolver : ValueResolver<ChecklistStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChecklistStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ChecklistStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="YesNo"/> enum.</param>
        /// <returns>If the selection is ChecklistStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ChecklistStatus source)
        {
            try
            {
                if (source == ChecklistStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ChecklistStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChecklistCommentType"/> enum.
    /// </summary>
    internal class ChecklistCommentTypeToStringResolver : ValueResolver<ChecklistCommentType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChecklistCommentTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ChecklistCommentType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ChecklistCommentType"/> enum.</param>
        /// <returns>If the selection is ChecklistCommentType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ChecklistCommentType source)
        {
            try
            {
                if (source == ChecklistCommentType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ChecklistCommentTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChecklistCommentStatus"/> enum.
    /// </summary>
    internal class ChecklistCommentStatusToStringResolver : ValueResolver<ChecklistCommentStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChecklistCommentStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ChecklistCommentStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ChecklistCommentStatus"/> enum.</param>
        /// <returns>If the selection is ChecklistCommentStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ChecklistCommentStatus source)
        {
            try
            {
                if (source == ChecklistCommentStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ChecklistCommentStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ChildOf"/> enum.
    /// </summary>
    internal class ChildOfToStringResolver : ValueResolver<ChildOf, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ChildOfToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ChildOf"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ChildOf"/> enum.</param>
        /// <returns>If the selection is ChildOf.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ChildOf source)
        {
            try
            {
                if (source == ChildOf.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ChildOfToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CitizenshipStatus"/> enum.
    /// </summary>
    internal class CitizenshipStatusToStringResolver : ValueResolver<CitizenshipStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CitizenshipStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CitizenshipStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CitizenshipStatus"/> enum.</param>
        /// <returns>If the selection is CitizenshipStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CitizenshipStatus source)
        {
            try
            {

                if (source == CitizenshipStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CitizenshipStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CivilCriminalSaleConductedBy"/> enum.
    /// </summary>
    internal class CivilCriminalSaleConductedByToStringResolver : ValueResolver<CivilCriminalSaleConductedBy, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CivilCriminalSaleConductedByToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CivilCriminalSaleConductedBy"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CivilCriminalSaleConductedBy"/> enum.</param>
        /// <returns>If the selection is CivilCriminalSaleConductedBy.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CivilCriminalSaleConductedBy source)
        {
            try
            {
                if (source == CivilCriminalSaleConductedBy.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CivilCriminalSaleConductedByToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ClaimForPNOrDef"/> enum.
    /// </summary>
    internal class ClaimForPNOrDefToStringResolver : ValueResolver<ClaimForPNOrDef, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ClaimForPNOrDefToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ClaimForPNOrDef"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ClaimForPNOrDef"/> enum.</param>
        /// <returns>If the selection is ClaimForPNOrDef.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ClaimForPNOrDef source)
        {
            try
            {
                if (source == ClaimForPNOrDef.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ClaimForPNOrDefToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ClaimType"/> enum.
    /// </summary>
    internal class ClaimTypeToStringResolver : ValueResolver<ClaimType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ClaimTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ClaimType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ClaimType"/> enum.</param>
        /// <returns>If the selection is ClaimType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ClaimType source)
        {
            try
            {
                if (source == ClaimType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ClaimTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ConsolidatedTypeInd"/> enum.
    /// </summary>
    internal class ConsolidatedTypeIndToStringResolver : ValueResolver<ConsolidatedTypeInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ConsolidatedTypeIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ConsolidatedTypeInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ConsolidatedTypeInd"/> enum.</param>
        /// <returns>If the selection is ConsolidatedTypeInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ConsolidatedTypeInd source)
        {
            try
            {
                if (source == ConsolidatedTypeInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ConsolidatedTypeIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ContactType"/> enum.
    /// </summary>
    internal class ContactTypeToStringResolver : ValueResolver<ContactType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ContactTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ContactType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ContactType"/> enum.</param>
        /// <returns>If the selection is ContactType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ContactType source)
        {
            try
            {
                if (source == ContactType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ContactTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ControlType"/> enum.
    /// </summary>
    internal class ControlTypeToStringResolver : ValueResolver<ControlType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ControlTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ControlType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ControlType"/> enum.</param>
        /// <returns>If the selection is ControlType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ControlType source)
        {
            try
            {
                if (source == ControlType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ControlTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CreditDebit"/> enum.
    /// </summary>
    internal class CreditDebitToStringResolver : ValueResolver<CreditDebit, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CreditDebitToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CreditDebit"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CreditDebit"/> enum.</param>
        /// <returns>If the selection is CreditDebit.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CreditDebit source)
        {
            try
            {
                if (source == CreditDebit.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CreditDebitToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CrimeCase"/> enum.
    /// </summary>
    internal class CrimeCaseToStringResolver : ValueResolver<CrimeCase, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CrimeCaseToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CrimeCase"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CrimeCase"/> enum.</param>
        /// <returns>If the selection is CrimeCase.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CrimeCase source)
        {
            try
            {

                if (source == CrimeCase.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CrimeCaseToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CrimeClaimHearingType"/> enum.
    /// </summary>
    internal class CrimeClaimHearingTypeToStringResolver : ValueResolver<CrimeClaimHearingType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CrimeClaimHearingTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CrimeClaimHearingType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CrimeClaimHearingType"/> enum.</param>
        /// <returns>If the selection is CrimeClaimHearingType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CrimeClaimHearingType source)
        {
            try
            {
                if (source == CrimeClaimHearingType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CrimeClaimHearingTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundOrWaiverStatus"/> enum.
    /// </summary>
    internal class CriminalClaimStatusToStringResolver : ValueResolver<CriminalClaimStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CriminalClaimStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CriminalClaimStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CriminalClaimStatus"/> enum.</param>
        /// <returns>If the selection is CriminalClaimStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalClaimStatus source)
        {
            try
            {
                if (source == CriminalClaimStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CriminalClaimStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CriminalCounselTypes"/> enum.
    /// </summary>
    internal class CriminalCounselTypesToStringResolver : ValueResolver<CriminalCounselTypes, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CriminalCounselTypesToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CriminalCounselTypes"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CriminalCounselTypes"/> enum.</param>
        /// <returns>If the selection is CriminalCounselTypes.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalCounselTypes source)
        {
            try
            {
                if (source == CriminalCounselTypes.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CriminalCounselTypesToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CriminalNatureOfSentence"/> enum.
    /// </summary>
    internal class CriminalNatureOfSentenceToStringResolver : ValueResolver<CriminalNatureOfSentence, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CriminalNatureOfSentenceToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CriminalNatureOfSentence"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CriminalNatureOfSentence"/> enum.</param>
        /// <returns>If the selection is CriminalNatureOfSentence.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalNatureOfSentence source)
        {
            try
            {
                if (source == CriminalNatureOfSentence.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NatureOfSentenceStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CriminalReleaseType"/> enum.
    /// </summary>
    internal class CriminalReleaseTypeToStringResolver : ValueResolver<CriminalReleaseType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CriminalReleaseTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CriminalReleaseType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CriminalReleaseType"/> enum.</param>
        /// <returns>If the selection is CivilCriminalSaleConductedBy.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalReleaseType source)
        {
            try
            {
                if (source == CriminalReleaseType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CriminalReleaseTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CriminalStatusOfSentence"/> enum.
    /// </summary>
    internal class CriminalStatusOfSentenceToStringResolver : ValueResolver<CriminalStatusOfSentence, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CriminalStatusOfSentenceToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="CriminalStatusOfSentence"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="CriminalStatusOfSentence"/> enum.</param>
        /// <returns>If the selection is CriminalNatureOfSentence.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalStatusOfSentence source)
        {
            try
            {
                if (source == CriminalStatusOfSentence.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CriminalStatusOfSentenceToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CustodyRemand"/> enum.
    /// </summary>
    internal class CustodyRemandToStringResolver : ValueResolver<CustodyRemand, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CustodyRemandToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FileInspectionStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FileInspectionStatus"/> enum.</param>
        /// <returns>If the selection is FileInspectionStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CustodyRemand source)
        {
            try
            {
                if (source == CustodyRemand.Null)
                {
                    return null;
                }
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CustodyRemandToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DayInTheWeek"/> enum.
    /// </summary>
    internal class DayInTheWeekToStringResolver : ValueResolver<DayInTheWeek, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DayInTheWeekToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DayInTheWeek"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DayInTheWeek"/> enum.</param>
        /// <returns>If the selection is DayInTheWeek.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DayInTheWeek source)
        {
            try
            {
                if (source == DayInTheWeek.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DayInTheWeekToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref=" DegreeType"/> enum.
    /// </summary>
    internal class DegreeTypeToStringResolver : ValueResolver<DegreeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DegreeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref=" DegreeType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref=" DegreeType"/> enum.</param>
        /// <returns>If the selection is   DegreeType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DegreeType source)
        {
            try
            {
                if (source == DegreeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at  DegreeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DivorceCaseNature"/> enum.
    /// </summary>
    internal class DivorceCaseNatureToStringResolver : ValueResolver<DivorceCaseNature, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DivorceCaseNatureToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OrderType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ParentingPlan"/> enum.</param>
        /// <returns>If the selection is ParentingPlan.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DivorceCaseNature source)
        {
            try
            {
                if (source == DivorceCaseNature.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DivorceCaseNatureToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocCasePartyUpdateType"/> enum.
    /// </summary>
    internal class DocCasePartyUpdateTypeToStringResolver : ValueResolver<DocCasePartyUpdateType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocCasePartyUpdateTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocCasePartyUpdateType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocCasePartyUpdateType"/> enum.</param>
        /// <returns>If the selection is DocCasePartyUpdateType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocCasePartyUpdateType source)
        {
            try
            {
                if (source == DocCasePartyUpdateType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocCasePartyUpdateTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocInitiatedLocation"/> enum.
    /// </summary>
    internal class DocInitiatedLocationToStringResolver : ValueResolver<DocInitiatedLocation, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocInitiatedLocationToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocInitiatedLocation"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocInitiatedLocation"/> enum.</param>
        /// <returns>If the selection is DocInitiatedLocation.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocInitiatedLocation source)
        {
            try
            {
                if (source == DocInitiatedLocation.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocInitiatedLocationToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocumentFileType"/> enum.
    /// </summary>
    internal class DocumentFileTypeToStringResolver : ValueResolver<DocumentFileType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentFileTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocumentFileType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocumentFileType"/> enum.</param>
        /// <returns>If the selection is DocumentFileType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocumentFileType source)
        {
            try
            {
                if (source == DocumentFileType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocumentFileTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocumentFilingType"/> enum.
    /// </summary>
    internal class DocumentFilingTypeToStringResolver : ValueResolver<DocumentFilingType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentFilingTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocumentFilingType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocumentFilingType"/> enum.</param>
        /// <returns>If the selection is DocumentFilingType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocumentFilingType source)
        {
            try
            {
                if (source == DocumentFilingType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocumentFilingTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocumentProcessType"/> enum.
    /// </summary>
    internal class DocumentProcessTypeToStringResolver : ValueResolver<DocumentProcessType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocumentProcessTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocumentProcessType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocumentProcessType"/> enum.</param>
        /// <returns>If the selection is DocumentProcessType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocumentProcessType source)
        {
            try
            {
                if (source == DocumentProcessType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocumentProcessTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EHearingStatus"/> enum.
    /// </summary>
    internal class EHearingStatusToStringResolver : ValueResolver<EHearingStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(EHearingStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EHearingStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="EHearingStatus"/> enum.</param>
        /// <returns>If the selection is EHearingStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(EHearingStatus source)
        {
            try
            {
                if (source == EHearingStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at EHearingStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EMSType"/> enum.
    /// </summary>
    internal class EMSTypeToStringResolver : ValueResolver<EMSType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(EMSTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EMSType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="EMSType"/> enum.</param>
        /// <returns>If the selection is EMSType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(EMSType source)
        {
            try
            {
                if (source == EMSType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at EMSTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="EndorsementType"/> enum.
    /// </summary>
    internal class EndorsementTypeToStringResolver : ValueResolver<EndorsementType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(EndorsementTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="EndorsementType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="EndorsementType"/> enum.</param>
        /// <returns>If the selection is EndorsementType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(EndorsementType source)
        {
            try
            {
                if (source == EndorsementType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at EndorsementTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ExecutionOutcome"/> enum.
    /// </summary>
    internal class ExecutionOutcomeToStringResolver : ValueResolver<ExecutionOutcome, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ExecutionOutcomeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ExecutionOutcome"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ExecutionOutcome"/> enum.</param>
        /// <returns>If the selection is ExecutionOutcome.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ExecutionOutcome source)
        {
            try
            {
                if (source == ExecutionOutcome.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ExecutionOutcomeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ExecutorStatus"/> enum.
    /// </summary>
    internal class ExecutorStatusToStringResolver : ValueResolver<ExecutorStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ExecutorStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ExecutorStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ExecutorStatus"/> enum.</param>
        /// <returns>If the selection is ExecutorStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ExecutorStatus source)
        {
            try
            {
                if (source == ExecutorStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ExecutorStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FeeRuleType"/> enum.
    /// </summary>
    internal class FeeRuleTypeToStringResolver : ValueResolver<FeeRuleType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FeeRuleTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FeeRuleType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FeeRuleType"/> enum.</param>
        /// <returns>If the selection is FeeRuleType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FeeRuleType source)
        {
            try
            {

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FeeRuleTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FiledUserType"/> enum.
    /// </summary>
    internal class FiledUserTypeToStringResolver : ValueResolver<FiledUserType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FiledUserTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FiledUserType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FiledUserType"/> enum.</param>
        /// <returns>If the selection is FiledUserType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FiledUserType source)
        {
            try
            {
                if (source == FiledUserType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FiledUserTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FileInspectionDocStatus"/> enum.
    /// </summary>
    internal class FileInspectionDocStatusToStringResolver : ValueResolver<FileInspectionDocStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FileInspectionDocStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FileInspectionDocStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FileInspectionDocStatus"/> enum.</param>
        /// <returns>If the selection is FileInspectionDocStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FileInspectionDocStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FileInspectionDocStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FileInspectionStatus"/> enum.
    /// </summary>
    internal class FileInspectionStatusToStringResolver : ValueResolver<FileInspectionStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FileInspectionStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FileInspectionStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FileInspectionStatus"/> enum.</param>
        /// <returns>If the selection is FileInspectionStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FileInspectionStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FileInspectionStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FilingFrom"/> enum.
    /// </summary>
    internal class FilingFromToStringResolver : ValueResolver<FilingFrom, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FilingFromToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FilingFrom"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="YesNo"/> enum.</param>
        /// <returns>If the selection is FilingFrom.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FilingFrom source)
        {
            try
            {
                if (source == FilingFrom.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FilingFromToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FilingOrderFor"/> enum.
    /// </summary>
    internal class FilingOrderForToStringResolver : ValueResolver<FilingOrderFor, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FilingOrderForToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FilingOrderFor"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FilingOrderFor"/> enum.</param>
        protected override string ResolveCore(FilingOrderFor source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FilingOrderForToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="FilingPartyInd"/> enum.
    /// </summary>
    internal class FilingPartyIndToStringResolver : ValueResolver<FilingPartyInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FilingPartyIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FilingPartyInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FilingPartyInd"/> enum.</param>
        /// <returns>If the selection is FilingPartyInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FilingPartyInd source)
        {
            try
            {
                if (source == FilingPartyInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FilingPartyIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="HearingCategory"/> enum.
    /// </summary>
    internal class HearingCategoryToStringResolver : ValueResolver<HearingCategory, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(HearingCategoryToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="HearingCategory"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="HearingCategory"/> enum.</param>
        /// <returns>If the selection is HearingCategory.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(HearingCategory source)
        {
            try
            {
                if (source == HearingCategory.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at HearingCategoryToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ICAInterfaceStatus"/> enum.
    /// </summary>
    internal class ICAInterfaceStatusToStringResolver : ValueResolver<ICAInterfaceStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ICAInterfaceStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ICAInterfaceStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ICAInterfaceStatus"/> enum.</param>
        /// <returns>If the selection is ICAInterfaceStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ICAInterfaceStatus source)
        {
            try
            {
                if (source == ICAInterfaceStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ICAInterfaceStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="InterfaceCriminalStatus"/> enum.
    /// </summary>
    internal class InterfaceCriminalStatusToStringResolver : ValueResolver<InterfaceCriminalStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(InterfaceCriminalStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="InterfaceCriminalStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="InterfaceCriminalStatus"/> enum.</param>
        /// <returns>If the selection is InterfaceCriminalStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(InterfaceCriminalStatus source)
        {
            try
            {
                if (source == InterfaceCriminalStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at InterfaceCriminalStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="InterpreterLanguage"/> enum.
    /// </summary>
    internal class InterpreterLanguageToStringResolver : ValueResolver<InterpreterLanguage, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(InterpreterLanguageToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="InterpreterLanguage"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="InterpreterLanguage"/> enum.</param>
        /// <returns>If the selection is InterpreterLanguage.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(InterpreterLanguage source)
        {
            try
            {
                if (source == InterpreterLanguage.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at InterpreterLanguageToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="InvolvementInd"/> enum.
    /// </summary>
    internal class InvolvementIndToStringResolver : ValueResolver<InvolvementInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(InvolvementIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="InvolvementInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="InvolvementInd"/> enum.</param>
        /// <returns>If the selection is InvolvementInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(InvolvementInd source)
        {
            try
            {
                if (source == InvolvementInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at InvolvementIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="JudgmentFor"/> enum.
    /// </summary>
    internal class JudgmentForToStringResolver : ValueResolver<JudgmentFor, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(JudgmentForToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="JudgmentFor"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="JudgmentFor"/> enum.</param>
        /// <returns>If the selection is JudgmentFor.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(JudgmentFor source)
        {
            try
            {
                if (source == JudgmentFor.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at JudgmentForToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="JurisdictionDomicileForParty"/> enum.
    /// </summary>
    internal class JurisdictionDominicleForPartyToStringResolver : ValueResolver<JurisdictionDomicileForParty, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(JurisdictionDominicleForPartyToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="JurisdictionDomicileForParty"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="JurisdictionDomicileForParty"/> enum.</param>
        /// <returns>If the selection is ParentingPlan.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(JurisdictionDomicileForParty source)
        {
            try
            {
                if (source == JurisdictionDomicileForParty.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at JurisdictionDominicleForPartyToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="JurisdictionInSingapore"/> enum.
    /// </summary>
    internal class JurisdictionInSingaporeToStringResolver : ValueResolver<JurisdictionInSingapore, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(JurisdictionInSingaporeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="JurisdictionInSingapore"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="JurisdictionInSingapore"/> enum.</param>
        /// <returns>If the selection is JurisdictionInSingapore.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(JurisdictionInSingapore source)
        {
            try
            {
                if (source == JurisdictionInSingapore.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at JurisdictionInSingaporeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACConcludedStatus"/> enum.
    /// </summary>
    internal class LACConcludedStatusToStringResolver : ValueResolver<LACConcludedStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LACConcludedStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACConcludedStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LACConcludedStatus"/> enum.</param>
        /// <returns>If the selection is LACConcludedStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LACConcludedStatus source)
        {
            try
            {
                if (source == LACConcludedStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LACConcludedStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACDocStatus"/> enum.
    /// </summary>
    internal class LACDocStatusToStringResolver : ValueResolver<LACDocStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LACDocStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACDocStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LACDocStatus"/> enum.</param>
        /// <returns>If the selection is LACDocStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LACDocStatus source)
        {
            try
            {
                if (source == LACDocStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LACDocStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACRefStatus"/> enum.
    /// </summary>
    internal class LACRefStatusToStringResolver : ValueResolver<LACRefStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LACRefStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACRefStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LACRefStatus"/> enum.</param>
        /// <returns>If the selection is LACRefStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LACRefStatus source)
        {
            try
            {
                if (source == LACRefStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LACRefStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACStatus"/> enum.
    /// </summary>
    internal class LACStatusToStringResolver : ValueResolver<LACStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LACStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LACStatus"/> enum.</param>
        /// <returns>If the selection is LACStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LACStatus source)
        {
            try
            {
                if (source == LACStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LACStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LACType"/> enum.
    /// </summary>
    internal class LACTypeToStringResolver : ValueResolver<LACType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LACTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LACType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LACType"/> enum.</param>
        /// <returns>If the selection is LACType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LACType source)
        {
            try
            {
                if (source == LACType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LACTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LAPInterfaceFileStatus"/> enum.
    /// </summary>
    internal class LAPInterfaceFileStatusToStringResolver : ValueResolver<LAPInterfaceFileStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LAPInterfaceFileStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LAPInterfaceFileStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LAPInterfaceFileStatus"/> enum.</param>
        /// <returns>If the selection is LAPInterfaceFileStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LAPInterfaceFileStatus source)
        {
            try
            {
                if (source == LAPInterfaceFileStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LAPInterfaceFileStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LawFirmContactType"/> enum.
    /// </summary>
    internal class LawPracticeTypeToStringResolver : ValueResolver<LawPracticeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LawPracticeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LawPracticeType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LawPracticeType"/> enum.</param>
        /// <returns>If the selection is LawPracticeType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LawPracticeType source)
        {
            try
            {
                if (source == LawPracticeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LawPracticeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref=" LegalExperienceType"/> enum.
    /// </summary>
    internal class LegalExperienceTypeToStringResolver : ValueResolver<LegalExperienceType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LegalExperienceTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref=" LegalExperienceType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref=" LegalExperienceType"/> enum.</param>
        /// <returns>If the selection is   LegalExperienceType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LegalExperienceType source)
        {
            try
            {
                if (source == LegalExperienceType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at  LegalExperienceTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LegalOrganizationType"/> enum.
    /// </summary>
    internal class LegalOrganizationTypeToStringResolver : ValueResolver<LegalOrganizationType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LegalOrganizationTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LegalOrganizationType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocInitiatedLocation"/> enum.</param>
        /// <returns>If the selection is ChecklistCommentType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LegalOrganizationType source)
        {
            try
            {
                if (source == LegalOrganizationType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LegalOrganizationTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="LFGroupCode"/> enum.
    /// </summary>
    internal class LFGroupCodeToStringResolver : ValueResolver<LFGroupCode, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LFGroupCodeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="LFGroupCode"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="LFGroupCode"/> enum.</param>
        /// <returns>If the selection is LFGroupCode.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LFGroupCode source)
        {
            try
            {
                if (source == LFGroupCode.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at LFGroupCodeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref=" LPALPRSectionOrProvision"/> enum.
    /// </summary>
    internal class LPALPRSectionOrProvisionToStringResolver : ValueResolver<LPALPRSectionOrProvision, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LPALPRSectionOrProvisionToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref=" LPALPRSectionOrProvision"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref=" LPALPRSectionOrProvision"/> enum.</param>
        /// <returns>If the selection is   LPALPRSectionOrProvision.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(LPALPRSectionOrProvision source)
        {
            try
            {
                if (source == LPALPRSectionOrProvision.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at  LPALPRSectionOrProvisionToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="MailboxMessageType"/> enum.
    /// </summary>
    internal class MailboxMessageTypeToStringResolver : ValueResolver<MailboxMessageType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MailboxMessageTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="MailboxMessageType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="MailboxMessageType"/> enum.</param>
        /// <returns>If the selection is MailboxMessageType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(MailboxMessageType source)
        {
            try
            {
                if (source == MailboxMessageType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MailboxMessageTypeToStringResolver >> ResolverCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="MailboxStatus"/> enum.
    /// </summary>
    internal class MailboxStatusToStringResolver : ValueResolver<MailboxStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(MailboxStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="MailboxStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="MailboxStatus"/> enum.</param>
        /// <returns>If the selection is MailboxStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(MailboxStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MailboxStatusToStringResolver >> ResolverCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    ///// <summary>
    ///// Method implementing <see cref="ValueResolver"/> for <see cref="MiscellaneousClaimStatus"/> enum.
    ///// </summary>
    //internal class MiscellaneousClaimStatusToStringResolver : ValueResolver<MiscellaneousClaimStatus, string>
    //{
    //    #region Fields
    //    /// <summary>
    //    /// ILog instance for logging.
    //    /// </summary>
    //    private static readonly ILog Logger = LogManager.GetLogger(typeof(MiscellaneousClaimStatusToStringResolver));
    //    #endregion Fields
    //    #region Methods
    //    /// <summary>
    //    /// Implements ResolveCore method for resolving <see cref="MiscellaneousClaimStatus"/> enum to string value.
    //    /// </summary>
    //    /// <param name="source"><see cref="MiscellaneousClaimStatus"/> enum.</param>
    //    /// <returns>If the selection is MiscellaneousClaimStatus.Null then return will be null,
    //    /// else value as string after converting enum to string.</returns>
    //    protected override string ResolveCore(MiscellaneousClaimStatus source)
    //    {
    //        try
    //        {
    //            if (source == MiscellaneousClaimStatus.Null)
    //            {
    //                return null;
    //            }
    //            return source.ToString();
    //        }
    //        catch (Exception ex)
    //        {
    //            Logger.Error("Error at MiscellaneousClaimStatusToStringResolver >> ResolveCore", ex);
    //            throw;
    //        }
    //    }
    //    #endregion Methods
    //}
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ModeOfAmendment"/> enum.
    /// </summary>
    internal class ModeOfAmendmentToStringResolver : ValueResolver<ModeOfAmendment, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ModeOfAmendmentToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ModeOfAmendment"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ModeOfAmendment"/> enum.</param>
        /// <returns>If the selection is ModeOfAmendment.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ModeOfAmendment source)
        {
            try
            {
                if (source == ModeOfAmendment.Administrative)
                {
                    return "1";
                }
                else if (source == ModeOfAmendment.CourtApproval)
                {
                    return "2";
                }
                else
                {
                    return "3";
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ModeOfAmendmentToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="NatureOfCDR"/> enum.
    /// </summary>
    internal class NatureOfCDRToStringResolver : ValueResolver<NatureOfCDR, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NatureOfCDRToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="NatureOfCDR"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="NatureOfCDR"/> enum.</param>
        /// <returns>If the selection is NatureOfCDR.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(NatureOfCDR source)
        {
            try
            {
                if (source == NatureOfCDR.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NatureOfCDRToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="NatureOfDeputyShip"/> enum.
    /// </summary>
    internal class NatureOfDeputyShipToStringResolver : ValueResolver<NatureOfDeputyShip, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(NatureOfDeputyShipToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="NatureOfDeputyShip"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="NatureOfDeputyShip"/> enum.</param>
        /// <returns>If the selection is NatureOfDeputyShip.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(NatureOfDeputyShip source)
        {
            try
            {
                if (source == NatureOfDeputyShip.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at NatureOfDeputyShipToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OCRStatus"/> enum.
    /// </summary>
    internal class OCRStatusToStringResolver : ValueResolver<OCRStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OCRStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OCRStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OCRStatus"/> enum.</param>
        protected override string ResolveCore(OCRStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OCRStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OGCQueueStatus"/> enum.
    /// </summary>
    internal class OGCQueueStatusToStringResolver : ValueResolver<OGCQueueStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OGCQueueStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OGCQueueStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OGCQueueStatus"/> enum.</param>
        /// <returns>If the selection is OGCQueueStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OGCQueueStatus source)
        {
            try
            {

                if (source == OGCQueueStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OGCQueueStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OnlineEnquiryReportType"/> enum.
    /// </summary>
    internal class OnlineEnquiryReportTypeToStringResolver : ValueResolver<OnlineEnquiryReportType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OnlineEnquiryReportTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OnlineEnquiryReportType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OnlineEnquiryReportType"/> enum.</param>
        /// <returns>If the selection is OnlineEnquiryReportType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OnlineEnquiryReportType source)
        {
            try
            {
                if (source == OnlineEnquiryReportType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OnlineEnquiryReportTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OnlineEnquirySchedulerInfo"/> enum.
    /// </summary>
    internal class OnlineEnquirySchedulerInfoToStringResolver : ValueResolver<OnlineEnquirySchedulerInfo, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OnlineEnquirySchedulerInfoToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OnlineEnquirySchedulerInfo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OnlineEnquirySchedulerInfo"/> enum.</param>
        /// <returns>If the selection is OnlineEnquirySchedulerInfo.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OnlineEnquirySchedulerInfo source)
        {
            try
            {
                if (source == OnlineEnquirySchedulerInfo.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OnlineEnquirySchedulerInfoToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OrderEnforcedTypes"/> enum.
    /// </summary>
    internal class OrderEnforcedTypesToStringResolver : ValueResolver<OrderEnforcedTypes, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OrderEnforcedTypesToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OrderEnforcedTypes"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OrderEnforcedTypes"/> enum.</param>
        /// <returns>If the selection is OrderEnforcedTypes.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OrderEnforcedTypes source)
        {
            try
            {
                if (source == OrderEnforcedTypes.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OrderEnforcedTypesToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OrderMadeIn"/> enum.
    /// </summary>
    internal class OrderMadeInToStringResolver : ValueResolver<OrderMadeIn, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OrderMadeInToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OrderType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OrderType"/> enum.</param>
        /// <returns>If the selection is OrderType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OrderMadeIn source)
        {
            try
            {
                if (source == OrderMadeIn.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OrderMadeInToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OrderType"/> enum.
    /// </summary>
    internal class OrderTypeToStringResolver : ValueResolver<OrderType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OrderTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OrderType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OrderType"/> enum.</param>
        /// <returns>If the selection is OrderType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OrderType source)
        {
            try
            {
                if (source == OrderType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OrderTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="Origin"/> enum.
    /// </summary>
    internal class OriginToStringResolver : ValueResolver<Origin, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OriginToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="Origin"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="Origin"/> enum.</param>
        /// <returns>If the selection is Origin.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(Origin source)
        {
            try
            {
                if (source == Origin.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OriginToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    ///// <summary>
    ///// Method implementing <see cref="ValueResolver"/> for <see cref="DebtorClaimantIdentifierType"/> enum.
    ///// </summary>
    //internal class DebtorClaimantIdentifierTypeToStringResolver : ValueResolver<DebtorClaimantIdentifierType, string>
    //{
    //    #region Fields
    //    /// <summary>
    //    /// ILog instance for logging.
    //    /// </summary>
    //    private static readonly ILog Logger = LogManager.GetLogger(typeof(DebtorClaimantIdentifierTypeToStringResolver));
    //    #endregion Fields
    //    #region Methods
    //    /// <summary>
    //    /// Implements ResolveCore method for resolving <see cref="DebtorClaimantIdentifierType"/> enum to string value.
    //    /// </summary>
    //    /// <param name="source"><see cref="DebtorClaimantIdentifierType"/> enum.</param>
    //    /// <returns>If the selection is DebtorClaimantIdentifierType.Null then return will be null,
    //    /// else value as string after converting enum to string.</returns>
    //    protected override string ResolveCore(DebtorClaimantIdentifierType source)
    //    {
    //        try
    //        {
    //            if (source == DebtorClaimantIdentifierType.Null)
    //            {
    //                return null;
    //            }
    //            return source.ToString();
    //        }
    //        catch (Exception ex)
    //        {
    //            Logger.Error("Error at DebtorClaimantIdentifierTypeToStringResolver >> ResolveCore", ex);
    //            throw;
    //        }
    //    }
    //    #endregion Methods
    //}
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DebtorClaimantOtherIdentifierType"/> enum.
    /// </summary>
    internal class OtherPartyTypeTypeToStringResolver : ValueResolver<OtherPartyType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OtherPartyTypeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OtherPartyType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OtherPartyType"/> enum.</param>
        /// <returns>If the selection is OtherPartyType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OtherPartyType source)
        {
            try
            {
                if (source == OtherPartyType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OtherPartyTypeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OutgoingCorrespondanceSentCopy"/> enum.
    /// </summary>
    internal class OutgoingCorrespondanceSentCopyToStringResolver : ValueResolver<OutgoingCorrespondanceSentCopy, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OutgoingCorrespondanceSentCopyToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="YesNo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="YesNo"/> enum.</param>
        /// <returns>If the selection is YesNo.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OutgoingCorrespondanceSentCopy source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OutgoingCorrespondanceSentCopyToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OutOfOfficeStatus"/> enum.
    /// </summary>
    internal class OutOfOfficeStatusToStringResolver : ValueResolver<OutOfOfficeStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OutOfOfficeStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OutOfOfficeStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OutOfOfficeStatus"/> enum.</param>
        /// <returns>If the selection is OutOfOfficeStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OutOfOfficeStatus source)
        {
            try
            {
                if (source == OutOfOfficeStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OutOfOfficeStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OutstandingPaymentType"/> enum.
    /// </summary>
    internal class OutstandingPaymentTypeToStringResolver : ValueResolver<OutstandingPaymentType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OutstandingPaymentTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OutstandingPaymentType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="OutstandingPaymentType"/> enum.</param>
        /// <returns>If the selection is OutstandingPaymentType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(OutstandingPaymentType source)
        {
            try
            {
                if (source == OutstandingPaymentType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OutstandingPaymentTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ParentingPlan"/> enum.
    /// </summary>
    internal class ParentingPlanToStringResolver : ValueResolver<ParentingPlan, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ParentingPlanToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ParentingPlan"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ParentingPlan"/> enum.</param>
        /// <returns>If the selection is ParentingPlan.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ParentingPlan source)
        {
            try
            {
                if (source == ParentingPlan.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ParentingPlanToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CriminalPartyInType"/> enum.
    /// </summary>
    internal class PartyInTypeToStringResolver : ValueResolver<CriminalPartyInType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PartyInTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="FileInspectionStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="FileInspectionStatus"/> enum.</param>
        /// <returns>If the selection is FileInspectionStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CriminalPartyInType source)
        {
            try
            {
                if (source == CriminalPartyInType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PartyInTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PartyRepresentationType"/> enum.
    /// </summary>
    internal class PartyRepresentationTypeToStringResolver : ValueResolver<PartyRepresentationType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PartyRepresentationTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PartyRepresentationType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PartyRepresentationType"/> enum.</param>
        /// <returns>If the selection is PartyRepresentationType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PartyRepresentationType source)
        {
            try
            {
                if (source == PartyRepresentationType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PartyRepresentationTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PartyRepresentedBy"/> enum.
    /// </summary>
    internal class PartyRepresentedByToStringResolver : ValueResolver<PartyRepresentedBy, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PartyRepresentedByToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PartyRepresentedBy"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PartyRepresentedBy"/> enum.</param>
        /// <returns>If the selection is PartyRepresentedBy.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PartyRepresentedBy source)
        {
            try
            {
                if (source == PartyRepresentedBy.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PartyRepresentedByToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PartyUpdateInd"/> enum.
    /// </summary>
    internal class PartyUpdateIndToStringResolver : ValueResolver<PartyUpdateInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PartyUpdateIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PartyUpdateInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PartyUpdateInd"/> enum.</param>
        /// <returns>If the selection is PartyUpdateInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PartyUpdateInd source)
        {
            try
            {
                if (source == PartyUpdateInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PartyUpdateIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PayingInType"/> enum.
    /// </summary>
    internal class PayingInTypeToStringResolver : ValueResolver<PayingInType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PayingInTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PayingInType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PayingInType"/> enum.</param>
        /// <returns>If the selection is PayingInType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PayingInType source)
        {
            try
            {
                if (source == PayingInType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PayingInTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentChequeStatus"/> enum.
    /// </summary>
    internal class PaymentChequeStatusToStringResolver : ValueResolver<PaymentChequeStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentChequeStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentChequeStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentChequeStatus"/> enum.</param>
        /// <returns>If the selection is PaymentChequeStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentChequeStatus source)
        {
            try
            {
                if (source == PaymentChequeStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentChequeStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentInReasonType"/> enum.
    /// </summary>
    internal class PaymentInReasonTypeToStringResolver : ValueResolver<PaymentInReasonType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentInReasonTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentInReasonType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentInReasonType"/> enum.</param>
        /// <returns>If the selection is PaymentInReasonType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentInReasonType source)
        {
            try
            {
                if (source == PaymentInReasonType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentInReasonTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentStatus"/> enum.
    /// </summary>
    internal class PaymentStatusToStringResolver : ValueResolver<PaymentStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentStatus"/> enum.</param> 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentVoucherStatus"/> enum.
    /// </summary>
    internal class PaymentVoucherStatusToStringResolver : ValueResolver<PaymentVoucherStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentVoucherStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentVoucherStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentVoucherStatus"/> enum.</param>
        /// <returns>If the selection is PaymentVoucherStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentVoucherStatus source)
        {
            try
            {
                if (source == PaymentVoucherStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentVoucherStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PaymentVoucherType"/> enum.
    /// </summary>
    internal class PaymentVoucherTypeToStringResolver : ValueResolver<PaymentVoucherType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentVoucherTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentVoucherType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentVoucherType"/> enum.</param>
        /// <returns>If the selection is PaymentVoucherType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentVoucherType source)
        {
            try
            {
                if (source == PaymentVoucherType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentVoucherTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ProbateInfoType"/> enum.
    /// </summary>
    internal class ProbateInfoTypeToStringResolver : ValueResolver<ProbateInfoType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ProbateInfoTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ProbateInfoType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ProbateInfoType"/> enum.</param>
        /// <returns>If the selection is ProbateInfoType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ProbateInfoType source)
        {
            try
            {
                if (source == ProbateInfoType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ProbateInfoTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PropertyType"/> enum.
    /// </summary>
    internal class PropertyTypeToStringResolver : ValueResolver<PropertyType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PropertyTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PropertyType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PropertyType"/> enum.</param>
        /// <returns>If the selection is PropertyType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PropertyType source)
        {
            try
            {
                if (source == PropertyType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PropertyTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AdmLetterUsed"/> enum.
    /// </summary>
    internal class RAdmLetterUsedToStringResolver : ValueResolver<AdmLetterUsed, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RAdmLetterUsedToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AdmLetterUsed"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AdmLetterUsed"/> enum.</param>
        /// <returns>If the selection is AdmLetterUsed.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AdmLetterUsed source)
        {
            try
            {
                if (source == AdmLetterUsed.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RAdmLetterUsedToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ReceiptAduitType"/> enum.
    /// </summary>
    internal class ReceiptAduitTypeToStringResolver : ValueResolver<ReceiptAduitType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ReceiptAduitTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ReceiptAduitType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ReceiptAduitType"/> enum.</param>
        /// <returns>If the selection is ReceiptAduitType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ReceiptAduitType source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ReceiptAduitTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ReceiptStatus"/> enum.
    /// </summary>
    internal class ReceiptStatusToStringResolver : ValueResolver<ReceiptStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ReceiptStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ReceiptStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ReceiptStatus"/> enum.</param>
        /// <returns>If the selection is ReceiptStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ReceiptStatus source)
        {
            try
            {
                if (source == ReceiptStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ReceiptStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundFeeType"/> enum.
    /// </summary>
    internal class RefundFeeTypeToStringResolver : ValueResolver<RefundFeeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RefundFeeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RefundFeeType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RefundFeeType"/> enum.</param>
        /// <returns>If the selection is RefundFeeType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RefundFeeType source)
        {
            try
            {
                if (source == RefundFeeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RefundFeeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundOrWaiverStatus"/> enum.
    /// </summary>
    internal class RefundOrWaiverStatusToStringResolver : ValueResolver<RefundOrWaiverStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RefundOrWaiverStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RefundOrWaiverStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RefundOrWaiverStatus"/> enum.</param>
        /// <returns>If the selection is RefundOrWaiverStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RefundOrWaiverStatus source)
        {
            try
            {
                if (source == RefundOrWaiverStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RefundOrWaiverStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundOrWaiverStatus"/> enum.
    /// </summary>
    internal class RefundOrWaiverTypeToStringResolver : ValueResolver<RefundOrWaiverType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RefundOrWaiverTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RefundOrWaiverType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RefundOrWaiverType"/> enum.</param>
        /// <returns>If the selection is RefundOrWaiverType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RefundOrWaiverType source)
        {
            try
            {
                if (source == RefundOrWaiverType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RefundOrWaiverTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundStatus"/> enum.
    /// </summary>
    internal class RefundStatusToStringResolver : ValueResolver<RefundStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RefundStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RefundStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RefundStatus"/> enum.</param>
        /// <returns>If the selection is RefundStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RefundStatus source)
        {
            try
            {

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RefundStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RefundType"/> enum.
    /// </summary>
    internal class RefundTypeToStringResolver : ValueResolver<RefundType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RefundTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RefundType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RefundType"/> enum.</param>
        /// <returns>If the selection is RefundType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RefundType source)
        {
            try
            {

                if (source == RefundType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RefundTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ReleaseType"/> enum.
    /// </summary>
    internal class ReleaseTypeToStringResolver : ValueResolver<ReleaseType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ReleaseTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ReleaseType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ReleaseType"/> enum.</param>
        /// <returns>If the selection is ReleaseType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ReleaseType source)
        {
            try
            {
                if (source == ReleaseType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ReleaseTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ReprintType"/> enum.
    /// </summary>
    internal class ReprintTypeToStringResolver : ValueResolver<ReprintType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ReprintTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ReprintType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ReprintType"/> enum.</param>
        /// <returns>If the selection is ReprintType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(ReprintType source)
        {
            try
            {
                if (source == ReprintType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ReprintTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RequestType"/> enum.
    /// </summary>
    internal class RequestTypeToStringResolver : ValueResolver<RequestType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RequestTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RequestType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RequestType"/> enum.</param>
        /// <returns>If the selection is RequestType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RequestType source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RequestTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SaleType"/> enum.
    /// </summary>
    internal class SaleTypeToStringResolver : ValueResolver<SaleType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SaleTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SaleType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SaleType"/> enum.</param>
        /// <returns>If the selection is SaleType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SaleType source)
        {
            try
            {
                if (source == SaleType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SaleTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SchedulerProcessStatus"/> enum.
    /// </summary>
    internal class SchedulerProcessStatusToStringResolver : ValueResolver<SchedulerProcessStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SchedulerProcessStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SchedulerProcessStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SchedulerProcessStatus"/> enum.</param>
        /// <returns>If the selection is SchedulerProcessStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SchedulerProcessStatus source)
        {
            try
            {
                if (source == SchedulerProcessStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SchedulerProcessStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ServiceStatus"/> enum.
    /// </summary>
    internal class ServiceStatusToStringResolver : ValueResolver<ServiceStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ServiceStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="ServiceStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="ServiceStatus"/> enum.</param>
        protected override string ResolveCore(ServiceStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ServiceStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SetDownPursuantTo"/> enum.
    /// </summary>
    internal class SetDownPursuantToStringResolver : ValueResolver<SetDownPursuantTo, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SetDownPursuantToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SetDownPursuantTo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SetDownPursuantTo"/> enum.</param>
        /// <returns>If the selection is SetDownPursuantTo.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SetDownPursuantTo source)
        {
            try
            {
                if (source == SetDownPursuantTo.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SetDownPursuantToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SettingDownStatus"/> enum.
    /// </summary>
    internal class SettingDownStatusToStringResolver : ValueResolver<SettingDownStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SettingDownStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SettingDownStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SettingDownStatus"/> enum.</param>
        /// <returns>If the selection is SettingDownStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SettingDownStatus source)
        {
            try
            {
                if (source == SettingDownStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SettlementOutcomeType"/> enum.
    /// </summary>
    internal class SettlementOutcomeTypeToStringResolver : ValueResolver<SettlementOutcomeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SettlementOutcomeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SettlementOutcomeType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SettlementOutcomeType"/> enum.</param>
        /// <returns>If the selection is SettlementOutcomeType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SettlementOutcomeType source)
        {
            try
            {
                if (source == SettlementOutcomeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SettlementOutcomeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="StatementOrEndorsementInWrit"/> enum.
    /// </summary>
    internal class StatementOrEndorsementInWritToStringResolver : ValueResolver<StatementOrEndorsementInWrit, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StatementOrEndorsementInWritToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="StatementOrEndorsementInWrit"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="StatementOrEndorsementInWrit"/> enum.</param>
        /// <returns>If the selection is StatementOrEndorsementInWrit.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(StatementOrEndorsementInWrit source)
        {
            try
            {
                if (source == StatementOrEndorsementInWrit.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StatementOrEndorsementInWritToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for string to an object.
    /// In this, only Int64 value will be returned.
    /// </summary>
    internal class StringToInt64Resolver : ValueResolver<string, object>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInt64Resolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving string to an object.
        /// </summary>
        /// <param name="source"><see cref="AddressAvailabilityType"/> enum.</param>
        /// <returns>If source is null or empty "NULL" will be returned else source will be converted to Int64 and returned.</returns>
        protected override object ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    throw new Exception("String cannot be empty or null when converting to non-nullable Int64 field");
                }

                return Convert.ToInt64(source);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInt64Resolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for string to an object.
    /// In this, either NULL or Int64 value will be returned.
    /// </summary>
    internal class StringToNullableInt64Resolver : ValueResolver<string, object>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToNullableInt64Resolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving string to an object.
        /// </summary>
        /// <param name="source"><see cref="AddressAvailabilityType"/> enum.</param>
        /// <returns>If source is null or empty "NULL" will be returned else source will be converted to Int64 and returned.</returns>
        protected override object ResolveCore(string source)
        {
            try
            {
                if (string.IsNullOrEmpty(source))
                {
                    return null;
                }

                return Convert.ToInt64(source);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToNullableInt64Resolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SubmissionStage"/> enum.
    /// </summary>
    internal class SubmissionStageToStringResolver : ValueResolver<SubmissionStage, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubmissionStageToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SubmissionStage"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SubmissionStage"/> enum.</param>
        /// <returns>If the selection is SubmissionStage.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SubmissionStage source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SubmissionStageToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SubpoenaPurpose"/> enum.
    /// </summary>
    internal class SubpoenaPurposeToStringResolver : ValueResolver<SubpoenaPurpose, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubpoenaPurposeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SubpoenaPurpose"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SubpoenaPurpose"/> enum.</param>
        /// <returns>If the selection is SubpoenaPurpose.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SubpoenaPurpose source)
        {
            try
            {

                if (source == SubpoenaPurpose.Null)
                {
                    return null;
                }
                else if (source == SubpoenaPurpose.DSH)
                {
                    return "Documents specified hereunder";
                }
                else if (source == SubpoenaPurpose.TPFD)
                {
                    return "Testify and to produce the following documents";
                }
                else
                    return "Attendance of witness to testify";

            }
            catch (Exception ex)
            {
                Logger.Error("Error at SubpoenaPurposeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SystemInd"/> enum.
    /// </summary>
    internal class SystemIndToStringResolver : ValueResolver<SystemInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SystemIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SystemInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SystemInd"/> enum.</param>
        /// <returns>If the selection is SystemInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SystemInd source)
        {
            try
            {
                if (source == SystemInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SystemIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref=" TasklistMessageType"/> enum.
    /// </summary>
    internal class TasklistMessageTypeToStringResolver : ValueResolver<TasklistMessageType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TasklistMessageTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref=" TasklistMessageType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref=" TasklistMessageType"/> enum.</param>
        /// <returns>If the selection is   TasklistMessageType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TasklistMessageType source)
        {
            try
            {
                if (source == TasklistMessageType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at  TasklistMessageTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    //
    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref=" TasklistMessageType"/> enum.
    /// </summary>
    internal class TaskListStatusToStringResolver : ValueResolver<TaskListStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TaskListStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref=" TaskListStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref=" TaskListStatus"/> enum.</param>
        /// <returns>If the selection is   TaskListStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TaskListStatus source)
        {
            try
            {
                if (source == TaskListStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at  TaskListStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="TeamManagementProceedingType"/> enum.
    /// </summary>
    internal class TeamManagementProceedingTypeToStringResolver : ValueResolver<TeamManagementProceedingType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TeamManagementProceedingTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="TeamManagementProceedingType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="TeamManagementProceedingType"/> enum.</param>
        /// <returns>If the selection is TeamManagementProceedingType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TeamManagementProceedingType source)
        {
            try
            {
                if (source == TeamManagementProceedingType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TeamManagementProceedingTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="TransferStateFundStatus"/> enum.
    /// </summary>
    internal class TransferStateFundStatusToStringResolver : ValueResolver<TransferStateFundStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TransferStateFundStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="TransferStateFundStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="TransferStateFundStatus"/> enum.</param>
        /// <returns>value as string after converting enum to string.</returns>
        protected override string ResolveCore(TransferStateFundStatus source)
        {
            try
            {
                //if (source == TransferStateFundStatus.Null)
                //{
                //    return null;
                //}

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TransferStateFundStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="TransferTypeInd"/> enum.
    /// </summary>
    internal class TransferTypeIndToStringResolver : ValueResolver<TransferTypeInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TransferTypeIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="TransferTypeInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="TransferTypeInd"/> enum.</param>
        /// <returns>If the selection is TransferTypeInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TransferTypeInd source)
        {
            try
            {
                if (source == TransferTypeInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TransferTypeIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="TypeOfArrest"/> enum.
    /// </summary>
    internal class TypeOfArrestToStringResolver : ValueResolver<TypeOfArrest, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TypeOfArrestToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="TypeOfArrest"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="TypeOfArrest"/> enum.</param>
        /// <returns>If the selection is TypeOfArrest.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TypeOfArrest source)
        {
            try
            {
                if (source == TypeOfArrest.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TypeOfArrestToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="TypeOfJurisdiction"/> enum.
    /// </summary>
    internal class TypeOfJurisdictionToStringResolver : ValueResolver<TypeOfJurisdiction, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TypeOfJurisdictionToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="OrderType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="TypeOfJurisdiction"/> enum.</param>
        /// <returns>If the selection is TypeOfJurisdiction.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TypeOfJurisdiction source)
        {
            try
            {
                if (source == TypeOfJurisdiction.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TypeOfJurisdictionToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="UnliquidatedClaimType"/> enum.
    /// </summary>
    internal class UnLiquidatedClaimTypeToStringResolver : ValueResolver<UnliquidatedClaimType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(UnLiquidatedClaimTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="UnliquidatedClaimType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="UnliquidatedClaimType"/> enum.</param>
        /// <returns>If the selection is UnliquidatedClaimType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(UnliquidatedClaimType source)
        {
            try
            {
                if (source == UnliquidatedClaimType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at UnLiquidatedClaimTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="VesselIdType"/> enum.
    /// </summary>
    internal class VesselIdTypeToStringResolver : ValueResolver<VesselIdType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(VesselIdTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="VesselIdType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="VesselIdType"/> enum.</param>
        /// <returns>If the selection is VesselIdType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(VesselIdType source)
        {
            try
            {
                if (source == VesselIdType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at VesselIdTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="VoidReason"/> enum.
    /// </summary>
    internal class VoidReasonToStringResolver : ValueResolver<VoidReason, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(VoidReasonToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="VoidReason"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="VoidReason"/> enum.</param>
        /// <returns>If the selection is VoidReason.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(VoidReason source)
        {
            try
            {
                if (source == VoidReason.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at VoidReasonToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WaiverInd"/> enum.
    /// </summary>
    internal class WaiverIndToStringResolver : ValueResolver<WaiverInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WaiverIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WaiverInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WaiverInd"/> enum.</param>
        /// <returns>If the selection is WaiverInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WaiverInd source)
        {
            try
            {
                if (source == WaiverInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WaiverIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WaiverStatus"/> enum.
    /// </summary>
    internal class WaiverStatusToStringResolver : ValueResolver<WaiverStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WaiverStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WaiverStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WaiverStatus"/> enum.</param>
        /// <returns>If the selection is WaiverStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WaiverStatus source)
        {
            try
            {
                if (source == WaiverStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WaiverStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WaiverType"/> enum.
    /// </summary>
    internal class WaiverTypeToStringResolver : ValueResolver<WaiverType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WaiverTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WaiverType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WaiverType"/> enum.</param>
        /// <returns>If the selection is WaiverType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WaiverType source)
        {
            try
            {
                if (source == WaiverType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WaiverTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WindingType"/> enum.
    /// </summary>
    internal class WindingTypeToStringResolver : ValueResolver<WindingType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WindingTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WindingType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WindingType"/> enum.</param>
        /// <returns>If the selection is WindingType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WindingType source)
        {
            try
            {
                if (source == WindingType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WindingTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WitnessType"/> enum.
    /// </summary>
    internal class WitnessTypeToStringResolver : ValueResolver<WitnessType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WitnessTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WitnessType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WitnessType"/> enum.</param>
        /// <returns>If the selection is WitnessType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WitnessType source)
        {
            try
            {
                if (source == WitnessType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WitnessTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WOEEmpActOrderType"/> enum.
    /// </summary>
    internal class WOEEmpActOrderTypeToStringResolver : ValueResolver<WOEEmpActOrderType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WOEEmpActOrderTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WOEEmpActOrderType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WOEEmpActOrderType"/> enum.</param>
        /// <returns>If the selection is WOEEmpActOrderType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WOEEmpActOrderType source)
        {
            try
            {
                if (source == WOEEmpActOrderType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WOEEmpActOrderTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WOEInfoClaimStatus"/> enum.
    /// </summary>
    internal class WOEInfoClaimStatusToStringResolver : ValueResolver<WOEInfoClaimStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WOEInfoClaimStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WOEInfoClaimStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WOEInfoClaimStatus"/> enum.</param>
        /// <returns>If the selection is WOEInfoClaimStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WOEInfoClaimStatus source)
        {
            try
            {
                if (source == WOEInfoClaimStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WOEInfoClaimStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WOEInfoClaimType"/> enum.
    /// </summary>
    internal class WOEInfoClaimTypeToStringResolver : ValueResolver<WOEInfoClaimType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WOEInfoClaimTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WOEInfoClaimType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WOEInfoClaimType"/> enum.</param>
        /// <returns>If the selection is WOEInfoClaimType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WOEInfoClaimType source)
        {
            try
            {
                if (source == WOEInfoClaimType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WOEInfoClaimTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WOEType"/> enum.
    /// </summary>
    internal class WOETypeToStringResolver : ValueResolver<WOEType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WOETypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WOEType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WOEType"/> enum.</param>
        /// <returns>If the selection is WOEType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WOEType source)
        {
            try
            {
                if (source == WOEType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at WOETypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WorkItemDetailsIndType"/> enum.
    /// </summary>
    internal class WorkItemDetailsIndTypeToStringResolver : ValueResolver<WorkItemDetailsIndType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WorkItemDetailsIndTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WorkItemDetailsIndType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WorkItemDetailsIndType"/> enum.</param>
        /// <returns>If the selection is WorkItemDetailsIndType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WorkItemDetailsIndType source)
        {
            try
            {
                if (source == WorkItemDetailsIndType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="WorkItemRecipientStatus"/> enum.
    /// </summary>
    internal class WorkItemRecipientStatusToStringResolver : ValueResolver<WorkItemRecipientStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(WorkItemRecipientStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="WorkItemRecipientStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="WorkItemRecipientStatus"/> enum.</param>
        /// <returns>If the selection is WorkItemRecipientStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(WorkItemRecipientStatus source)
        {
            try
            {
                if (source == WorkItemRecipientStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AppealsAgainstToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="YesNo"/> enum.
    /// </summary>
    internal class YesNoToStringResolver : ValueResolver<YesNo, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(YesNoToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="YesNo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="YesNo"/> enum.</param>
        /// <returns>If the selection is YesNo.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(YesNo source)
        {
            try
            {
                if (source == YesNo.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at YesNoToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PartyFlippingCategory"/> enum.
    /// </summary>
    internal class PartyFlippingCategoryToStringResolver : ValueResolver<PartyFlippingCategory, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PartyFlippingCategoryToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PartyFlippingCategory"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PartyFlippingCategory"/> enum.</param>
        /// <returns>If the selection is PartyFlippingCategory.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PartyFlippingCategory source)
        {
            try
            {
                if (source == PartyFlippingCategory.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PartyFlippingCategoryToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="DocCommentType"/> enum.
    /// </summary>
    internal class DocCommentTypeToStringResolver : ValueResolver<DocCommentType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DocCommentTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DocCommentType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DocCommentType"/> enum.</param>
        /// <returns>If the selection is DocCommentType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DocCommentType source)
        {
            try
            {
                if (source == DocCommentType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DocCommentTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="RoleCode"/> enum.
    /// </summary>
    internal class RoleCodeToStringResolver : ValueResolver<RoleCode, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RoleCodeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RoleCode"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RoleCode"/> enum.</param>
        /// <returns>If the selection is RoleCode.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RoleCode source)
        {
            try
            {
                if (source == RoleCode.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RoleCodeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="YesNoMandatory"/> enum.
    /// </summary>
    internal class YesNoMandatoryToStringResolver : ValueResolver<YesNoMandatory, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(YesNoMandatoryToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="MandatoryYesNo"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="MandatoryYesNo"/> enum.</param>
        /// <returns>If the selection is MandatoryYesNo.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(YesNoMandatory source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at YesNoMandatoryToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AASPCPaidStatus"/> enum.
    /// </summary>
    internal class DivorceFilingForToStringResolver : ValueResolver<DivorceFilingFor, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DivorceFilingForToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="DivorceFilingFor"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="DivorceFilingFor"/> enum.</param>
        /// <returns>If the selection is DivorceFilingFor.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(DivorceFilingFor source)
        {
            try
            {
                if (source == DivorceFilingFor.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DivorceFilingForToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }
    

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PrintStatus"/> enum.
    /// </summary>
    internal class PrintStatusToStringResolver : ValueResolver<PrintStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PrintStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PrintStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PrintStatus"/> enum.</param>
        /// <returns>If the selection is PrintStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PrintStatus source)
        {
            try
            {
                if (source == PrintStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PrintStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="JudgeAssignStatus"/> enum.
    /// </summary>
    internal class JudgeAssignStatusToStringResolver : ValueResolver<JudgeAssignStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(JudgeAssignStatusToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(JudgeAssignStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at JudgeAssignStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="PurposeOfOrder"/> enum.
    /// </summary>
    internal class PurposeOfOrderToStringResolver : ValueResolver<PurposeOfOrder, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PurposeOfOrderToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(PurposeOfOrder source)
        {
            try
            {
                if (source == PurposeOfOrder.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PurposeOfOrderToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="ReqDecision"/> enum.
    /// </summary>
    internal class ReqDecisionToStringResolver : ValueResolver<ReqDecision, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(ReqDecisionToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(ReqDecision source)
        {
            try
            {
                if (source == ReqDecision.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at ReqDecisionToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="OGCProcessType"/> enum.
    /// </summary>
    internal class OGCProcessTypeToStringResolver : ValueResolver<OGCProcessType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(OGCProcessTypeToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(OGCProcessType source)
        {
            try
            {
                if (source == OGCProcessType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at OGCProcessTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AuditTrialActionType"/> enum.
    /// </summary>
    internal class AuditTrialActionTypeToStringResolver : ValueResolver<AuditTrialActionType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditTrialActionTypeToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(AuditTrialActionType source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AuditTrialActionTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AuditTrailBackEndFuctions"/> enum.
    /// </summary>
    internal class AuditTrailBackEndFuctionsToStringResolver : ValueResolver<AuditTrailBackEndFuctions, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditTrailBackEndFuctionsToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(AuditTrailBackEndFuctions source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AuditTrailBackEndFuctionsToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AuditTrailBackEndModule"/> enum.
    /// </summary>
    internal class AuditTrailBackEndModuleToStringResolver : ValueResolver<AuditTrailBackEndModule, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditTrailBackEndModuleToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(AuditTrailBackEndModule source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AuditTrailBackEndModuleToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AuditTrailBackEndSubModule"/> enum.
    /// </summary>
    internal class AuditTrailBackEndSubModuleToStringResolver : ValueResolver<AuditTrailBackEndSubModule, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditTrailBackEndSubModuleToStringResolver));

        #endregion Fields

        #region Methods

        protected override string ResolveCore(AuditTrailBackEndSubModule source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AuditTrailBackEndSubModuleToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }



    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AdmChargeType"/> enum.
    /// </summary>
    internal class AdmChargeTypeToStringResolver : ValueResolver<AdmChargeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AdmChargeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AdmChargeType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AdmChargeType"/> enum.</param>
        /// <returns>If the selection is AdmChargeType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(AdmChargeType source)
        {
            try
            {
                if (source == AdmChargeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at AdmChargeTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="RejectionFeeType"/> for <see cref="RejectionFeeType"/> enum.
    /// </summary>
    internal class RejectionFeeTypeToStringResolver : ValueResolver<RejectionFeeType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(RejectionFeeTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RejectionFeeActionType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RejectionFeeActionType"/> enum.</param>
        /// <returns>If the selection is RejectionFeeActionType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(RejectionFeeType source)
        {
            try
            {
                if (source == RejectionFeeType.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at RejectionFeeActionTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="RejectionFeeType"/> for <see cref="TransferActionType"/> enum.
    /// </summary>
    internal class TransferActionTypeToStringResolver : ValueResolver<TransferActionType, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(TransferActionTypeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RejectionFeeActionType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RejectionFeeActionType"/> enum.</param>
        /// <returns>If the selection is RejectionFeeActionType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(TransferActionType source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at TransferActionTypeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="FilingbrokerQueueStatus"/> for <see cref="FilingbrokerQueueStatus"/> enum.
    /// </summary>
    internal class FilingbrokerQueueStatusToStringResolver : ValueResolver<FilingbrokerQueueStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(FilingbrokerQueueStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="RejectionFeeActionType"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="RejectionFeeActionType"/> enum.</param>
        /// <returns>If the selection is RejectionFeeActionType.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(FilingbrokerQueueStatus source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at FilingbrokerQueueStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="SubCaseRequestInd"/> enum.
    /// </summary>
    internal class SubCaseRequestIndToStringResolver : ValueResolver<SubCaseRequestInd, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(SubCaseRequestIndToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SubCaseRequestInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SubCaseRequestInd"/> enum.</param>
        /// <returns>If the selection is SubCaseRequestInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(SubCaseRequestInd source)
        {
            try
            {
                if (source == SubCaseRequestInd.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at SubCaseRequestIndToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="IsConfidential"/> enum.
    /// </summary>
    internal class IsConfidentialToStringResolver : ValueResolver<IsConfidential, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(IsConfidentialToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="SubCaseRequestInd"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="SubCaseRequestInd"/> enum.</param>
        /// <returns>If the selection is SubCaseRequestInd.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(IsConfidential source)
        {
            try
            {
                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at IsConfidentialToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="CPDRequirements"/> enum.
    /// </summary>
    internal class CPDRequirementsToStringResolver : ValueResolver<CPDRequirements, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(CPDRequirementsToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AASPCVoteStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AASPCVoteStatus"/> enum.</param>
        /// <returns>If the selection is AASPCVoteStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(CPDRequirements source)
        {
            try
            {
                if (source == CPDRequirements.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at CPDRequirementsToStringResolver >> ResolveCore", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ValueResolver"/> for <see cref="AASPCVoteStatus"/> enum.
    /// </summary>
    internal class VoteInfoValueToStringResolver : ValueResolver<VoteInfoValue, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(VoteInfoValueToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="AASPCVoteStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="AASPCVoteStatus"/> enum.</param>
        /// <returns>If the selection is AASPCVoteStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(VoteInfoValue source)
        {
            try
            {
                if (source == VoteInfoValue.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at VoteInfoValueToStringResolver >> ResolveCore", ex);
                throw;
            }
        }
        #endregion
    }

    /// <summary>
    /// Method implementing <see cref="PaymentMode"/> for <see cref="CaseInfo"/> enum.
    /// </summary>
    internal class PaymentModeToStringResolver : ValueResolver<PaymentMode, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(PaymentModeToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="PaymentMode"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="PaymentMode"/> enum.</param>
        /// <returns>If the selection is PaymentMode.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(PaymentMode source)
        {
            try
            {
                if (source == PaymentMode.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at PaymentModeToStringResolver >> ResolveCore", ex);
                throw;
            }
        }
        #endregion
    }

    /// <summary>
    /// Method implementing <see cref="InterfaceStatus"/> for <see cref="OutgoingCorrespondenceInfo"/> enum.
    /// 
    /// </summary>
    internal class InterfaceStatusToStringResolver : ValueResolver<InterfaceStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(InterfaceStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="InterfaceStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="InterfaceStatus"/> enum.</param>
        /// <returns>If the selection is InterfaceStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(InterfaceStatus source)
        {
            try
            {
                if (source == InterfaceStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at InterfaceStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }
        #endregion
    }


    /// <summary>
    /// Method implementing <see cref="VerStatus"/> for <see cref="LawFirmRegistration"/> enum.
    /// 
    /// </summary>
    internal class VerStatusToStringResolver : ValueResolver<VerStatus, string>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(VerStatusToStringResolver));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements ResolveCore method for resolving <see cref="VerStatus"/> enum to string value.
        /// </summary>
        /// <param name="source"><see cref="VerStatus"/> enum.</param>
        /// <returns>If the selection is VerStatus.Null then return will be null, 
        /// else value as string after converting enum to string.</returns>
        protected override string ResolveCore(VerStatus source)
        {
            try
            {
                if (source == VerStatus.Null)
                {
                    return null;
                }

                return source.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at VerStatusToStringResolver >> ResolveCore", ex);
                throw;
            }
        }
        #endregion
    }
}