#region Header

/*****************************************************************************************************
 * Description : This file represents various classes to implement different converters from string
 *              to enum.
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
// File: EntityToDomainConverter.cs
// Description: Represents various classes to implement different converters from string to enum.
// </summary>
// <copyright file= "EntityToDomainConverter.cs" company="AllInOne Pte Ltd">
// Copyright (C) 2010 AllInOne Pte Ltd. All rights reserved.
// </copyright>

#endregion Header

namespace AllInOne.Legal.DataMapper.BackEnd.Utilities
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.Master;

    using log4net;

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="Int64"/> enum.
    /// </summary>
    internal class DecimalToInt64Converter : ITypeConverter<decimal, Int64>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(DecimalToInt64Converter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="Int64"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public Int64 Convert(ResolutionContext context)
        {
            try
            {
                return Int64.Parse(context.SourceValue.ToString());
            }
            catch (Exception ex)
            {
                Logger.Error("Error at DecimalToInt64Converter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="String"/> enum.
    /// </summary>
    internal class Int64ToStringConverter : ITypeConverter<Int64, String>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Int64ToStringConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="String"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public String Convert(ResolutionContext context)
        {
            try
            {
                return context.SourceValue.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error at Int64ToStringConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }


    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="String"/> enum.
    /// </summary>
    internal class StringToHearingModeIndConverter : ITypeConverter<string, HearingModeInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToHearingModeIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="String"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public HearingModeInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (HearingModeInd)Enum.Parse(typeof(HearingModeInd), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToHearingModeIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AASPCPaidStatus"/> enum.
    /// </summary>
    internal class StringToAASPCPaidStatusConverter : ITypeConverter<string, AASPCPaidStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAASPCPaidStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AASPCPaidStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AASPCPaidStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AASPCPaidStatus.Null;
                }

                else
                {
                    return (AASPCPaidStatus)Enum.Parse(typeof(AASPCPaidStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAASPCPaidStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AASPCVoteStatus"/> enum.
    /// </summary>
    internal class StringToAASPCVoteStatusConverter : ITypeConverter<string, AASPCVoteStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAASPCVoteStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AASPCVoteStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AASPCVoteStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AASPCVoteStatus.Null;
                }
                else
                {
                    return (AASPCVoteStatus)Enum.Parse(typeof(AASPCVoteStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAASPCVoteStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AddLess"/> enum.
    /// </summary>
    internal class StringToAddLessConverter : ITypeConverter<string, AddLess>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAddLessConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AddLess"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AddLess Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AddLess.Null;
                }
                else
                {
                    return (AddLess)Enum.Parse(typeof(AddLess), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAddLessConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AddressAvailabilityType"/> enum.
    /// </summary>
    internal class StringToAddressAvailabilityTypeConverter : ITypeConverter<string, AddressAvailabilityType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAddressAvailabilityTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AddressAvailabilityType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AddressAvailabilityType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AddressAvailabilityType.Null;
                }
                else
                {
                    return (AddressAvailabilityType)Enum.Parse(typeof(AddressAvailabilityType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAddressAvailabilityTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AddressFormatType"/> enum.
    /// </summary>
    internal class StringToAddressFormatTypeConverter : ITypeConverter<string, AddressFormatType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAddressFormatTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AddressFormatType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AddressFormatType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AddressFormatType.Null;
                }
                else
                {
                    return (AddressFormatType)Enum.Parse(typeof(AddressFormatType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAddressFormatTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AddressType"/> enum.
    /// </summary>
    internal class StringToAddressTypeConverter : ITypeConverter<string, AddressType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAddressTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AddressType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AddressType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AddressType.Null;
                }
                else
                {
                    return (AddressType)Enum.Parse(typeof(AddressType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAddressTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AdmiralityType"/> enum.
    /// </summary>
    internal class StringToAdmiralityTypeConverter : ITypeConverter<string, AdmiralityType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAdmiralityTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AdmiralityType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AdmiralityType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AdmiralityType.Null;
                }
                else
                {
                    return (AdmiralityType)Enum.Parse(typeof(AdmiralityType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAdmiralityTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AdmiraltyWritType"/> enum.
    /// </summary>
    internal class StringToAdmiraltyWritTypeConverter : ITypeConverter<string, AdmiraltyWritType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAdmiraltyWritTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AdmiraltyWritType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AdmiraltyWritType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AdmiraltyWritType.Null;
                }
                else
                {
                    return (AdmiraltyWritType)Enum.Parse(typeof(AdmiraltyWritType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAdmiraltyWritTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AdmLetterUsed"/> enum.
    /// </summary>
    internal class StringToAdmLetterUsedConverter : ITypeConverter<string, AdmLetterUsed>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAdmLetterUsedConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AdmLetterUsed"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AdmLetterUsed Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AdmLetterUsed.Null;
                }
                else
                {
                    return (AdmLetterUsed)Enum.Parse(typeof(AdmLetterUsed), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAdmLetterUsedConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AffidavitAEICType"/> enum.
    /// </summary>
    internal class StringToAffidavitAEICTypeConverter : ITypeConverter<string, AffidavitAEICType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAffidavitAEICTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AffidavitAEICType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AffidavitAEICType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AffidavitAEICType.Null;
                }
                else
                {
                    return (AffidavitAEICType)Enum.Parse(typeof(AffidavitAEICType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAffidavitAEICTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AgreeOrNotAgree"/> enum.
    /// </summary>
    internal class StringToAgreeOrNotAgreeConverter : ITypeConverter<string, AgreeOrNotAgree>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAgreeOrNotAgreeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AgreeOrNotAgree"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AgreeOrNotAgree Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AgreeOrNotAgree.Null;
                }
                else
                {
                    return (AgreeOrNotAgree)Enum.Parse(typeof(AgreeOrNotAgree), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAgreeOrNotAgreeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AmendmentInSupport"/> enum.
    /// </summary>
    internal class StringToAmendmentInSupportConverter : ITypeConverter<string, AmendmentInSupport>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAmendmentInSupportConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AmendmentInSupport"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AmendmentInSupport Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AmendmentInSupport.Null;
                }

                else
                {
                    return (AmendmentInSupport)Enum.Parse(typeof(AmendmentInSupport), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAmendmentInSupportConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AmendmentPerformedAt"/> enum.
    /// </summary>
    internal class StringToAmendmentPerformedAtConverter : ITypeConverter<string, AmendmentPerformedAt>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAmendmentPerformedAtConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AmendmentPerformedAt"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AmendmentPerformedAt Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (AmendmentPerformedAt)Enum.Parse(typeof(AmendmentPerformedAt), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAmendmentPerformedAtConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AmendmentStatus"/> enum.
    /// </summary>
    internal class StringToAmendmentStatusConverter : ITypeConverter<string, AmendmentStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAmendmentStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AmendmentStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AmendmentStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (AmendmentStatus)Enum.Parse(typeof(AmendmentStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAmendmentStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AppealsAgainst"/> enum.
    /// </summary>
    internal class StringToAppealsAgainstConverter : ITypeConverter<string, AppealsAgainst>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAppealsAgainstConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AppealsAgainst"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AppealsAgainst Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AppealsAgainst.Null;
                }
                else
                {
                    return (AppealsAgainst)Enum.Parse(typeof(AppealsAgainst), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAppealsAgainstConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ApplicantType"/> enum.
    /// </summary>
    internal class StringToApplicantTypeConverter : ITypeConverter<String, ApplicantType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToApplicantTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ApplicantType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ApplicantType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ApplicantType.Null;
                }
                else
                {
                    return (ApplicantType)Enum.Parse(typeof(ApplicantType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToApplicantTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ApplicationLimitation"/> enum.
    /// </summary>
    internal class StringToApplicationLimitationConverter : ITypeConverter<String, ApplicationLimitation>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToApplicationLimitationConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ApplicationLimitation"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ApplicationLimitation Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ApplicationLimitation.Null;
                }
                else
                {
                    return (ApplicationLimitation)Enum.Parse(typeof(ApplicationLimitation), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToApplicationLimitationConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AppointmentOrganisationType"/> enum.
    /// </summary>
    internal class StringToAppointmentOrganisationTypeConverter : ITypeConverter<string, AppointmentOrganisationType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAppointmentOrganisationTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AppointmentOrganisationType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AppointmentOrganisationType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AppointmentOrganisationType.Null;
                }
                else
                {
                    return (AppointmentOrganisationType)Enum.Parse(typeof(AppointmentOrganisationType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAppointmentOrganisationTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="HearingCategory"/> enum.
    /// </summary>
    internal class StringToAttachmentTypeConverter : ITypeConverter<String, AttachmentType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAttachmentTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AttachmentType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AttachmentType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AttachmentType.Null;
                }
                else
                {
                    return (AttachmentType)Enum.Parse(typeof(AttachmentType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAttachmentTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AttendanceMode"/> enum.
    /// </summary>
    internal class StringToAttendanceModeConverter : ITypeConverter<string, AttendanceMode>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAttendanceModeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AttendanceMode"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AttendanceMode Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AttendanceMode.Null;
                }

                else
                {
                    return (AttendanceMode)Enum.Parse(typeof(AttendanceMode), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAttendanceModeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AutionType"/> enum.
    /// </summary>
    internal class StringToAutionTypeConverter : ITypeConverter<string, AutionType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAutionTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AutionType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AutionType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {//BUG-ENFPROD-SC-2013100702
                    return AutionType.Null;
                }
                else
                {
                    return (AutionType)Enum.Parse(typeof(AutionType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAutionTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AutoTestingMode"/> enum.
    /// </summary>
    internal class StringToAutoTestingModeConverter : ITypeConverter<string, AutoTestingMode>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAutoTestingModeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AutoTestingMode"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AutoTestingMode Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;
                return (AutoTestingMode)Enum.Parse(typeof(AutoTestingMode), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at StringToAutoTestingModeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="BackdateStatus"/> enum.
    /// </summary>
    internal class StringToBackdateStatusConverter : ITypeConverter<string, BackdateStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToBackdateStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="BackdateStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public BackdateStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return BackdateStatus.Null;
                }
                else
                {
                    return (BackdateStatus)Enum.Parse(typeof(BackdateStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToBackdateStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="BailiffClaimStatus"/> enum.
    /// </summary>
    internal class StringToBailiffClaimStatusConverter : ITypeConverter<string, BailiffClaimStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToBailiffClaimStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TransportClaimStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public BailiffClaimStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return BailiffClaimStatus.Null;
                }
                else
                {
                    return (BailiffClaimStatus)Enum.Parse(typeof(BailiffClaimStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToBailiffClaimStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ProbateInfoType"/> enum.
    /// </summary>
    internal class StringToBizMonStatusConverter : ITypeConverter<String, BizMonStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToBizMonStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ProbateInfoType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public BizMonStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return BizMonStatus.Null;
                }
                else
                {
                    return (BizMonStatus)Enum.Parse(typeof(BizMonStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToBizMonStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CashBookReconcileStatus"/> enum.
    /// </summary>
    internal class StringToCaseBookReconcileStatusConverter : ITypeConverter<string, CashBookReconcileStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCaseBookReconcileStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CashBookReconcileStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CashBookReconcileStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                //if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                //{
                //    return CaseBookReconcileStatus.Null;
                //}
                //else
                {
                    return (CashBookReconcileStatus)Enum.Parse(typeof(CashBookReconcileStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCaseBookReconcileStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CasePartyRepresentedBy"/> enum.
    /// </summary>
    internal class StringToCasePartyRepresentedByConverter : ITypeConverter<string, CasePartyRepresentedBy>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCasePartyRepresentedByConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CasePartyRepresentedBy"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CasePartyRepresentedBy Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CasePartyRepresentedBy.Null;
                }
                else
                {
                    return (CasePartyRepresentedBy)Enum.Parse(typeof(CasePartyRepresentedBy), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCasePartyRepresentedByConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CaseTrack"/> enum.
    /// </summary>
    internal class StringToCaseTrackConverter : ITypeConverter<string, CaseTrack>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCaseTrackConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CaseTrack"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CaseTrack Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CaseTrack.Null;
                }
                else
                {
                    return (CaseTrack)Enum.Parse(typeof(CaseTrack), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCaseTrackConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CashBookItemType"/> enum.
    /// </summary>
    internal class StringToCashBookItemTypeConverter : ITypeConverter<string, CashBookItemType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCashBookItemTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CashBookItemType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CashBookItemType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CashBookItemType.Null;
                }
                else
                {
                    return (CashBookItemType)Enum.Parse(typeof(CashBookItemType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCashBookItemTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ChargeStatusType"/> enum.
    /// </summary>
    internal class StringToChargeStatusTypeConverter : ITypeConverter<string, ChargeStatusType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChargeStatusTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ChargeStatusType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ChargeStatusType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ChargeStatusType.Null;
                }
                else
                {
                    return (ChargeStatusType)Enum.Parse(typeof(ChargeStatusType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChargeStatusTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ChecklistStatus"/> enum.
    /// </summary>
    internal class StringToChecklistStatusConverter : ITypeConverter<string, ChecklistStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChecklistStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ChecklistStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ChecklistStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ChecklistStatus.Null;
                }
                else
                {
                    return (ChecklistStatus)Enum.Parse(typeof(ChecklistStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChecklistStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ChecklistCommentType"/> enum.
    /// </summary>
    internal class StringToChecklistCommentTypeConverter : ITypeConverter<string, ChecklistCommentType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChecklistCommentTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ChecklistCommentType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ChecklistCommentType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ChecklistCommentType.Null;
                }
                else
                {
                    return (ChecklistCommentType)Enum.Parse(typeof(ChecklistCommentType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChecklistCommentTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ChecklistCommentStatus"/> enum.
    /// </summary>
    internal class StringToChecklistCommentStatusConverter : ITypeConverter<string, ChecklistCommentStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChecklistCommentStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ChecklistCommentStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ChecklistCommentStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ChecklistCommentStatus.Null;
                }
                else
                {
                    return (ChecklistCommentStatus)Enum.Parse(typeof(ChecklistCommentStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChecklistCommentStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ChildOf"/> enum.
    /// </summary>
    internal class StringToChildOfConverter : ITypeConverter<string, ChildOf>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToChildOfConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ChildOf"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ChildOf Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ChildOf.Null;
                }
                else
                {
                    return (ChildOf)Enum.Parse(typeof(ChildOf), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToChildOfConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CivilCriminalSaleConductedBy"/> enum.
    /// </summary>
    internal class StringToCivilCriminalSaleConductedByConverter : ITypeConverter<string, CivilCriminalSaleConductedBy>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCivilCriminalSaleConductedByConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CivilCriminalSaleConductedBy"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CivilCriminalSaleConductedBy Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CivilCriminalSaleConductedBy.Null;
                }
                else
                {
                    return (CivilCriminalSaleConductedBy)Enum.Parse(typeof(CivilCriminalSaleConductedBy), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCivilCriminalSaleConductedByConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ClaimForPNOrDef"/> enum.
    /// </summary>
    internal class StringToClaimForPNOrDefConverter : ITypeConverter<string, ClaimForPNOrDef>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToClaimForPNOrDefConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ClaimForPNOrDef"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ClaimForPNOrDef Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ClaimForPNOrDef.Null;
                }
                else
                {
                    return (ClaimForPNOrDef)Enum.Parse(typeof(ClaimForPNOrDef), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToClaimForPNOrDefConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ClaimType"/> enum.
    /// </summary>
    internal class StringToClaimTypeConverter : ITypeConverter<string, ClaimType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToClaimTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ClaimType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ClaimType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ClaimType.Null;
                }
                else
                {
                    return (ClaimType)Enum.Parse(typeof(ClaimType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToClaimTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ConsolidatedTypeInd"/> enum.
    /// </summary>
    internal class StringToConsolidatedTypeIndConverter : ITypeConverter<string, ConsolidatedTypeInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToConsolidatedTypeIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ConsolidatedTypeInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ConsolidatedTypeInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ConsolidatedTypeInd.Null;
                }
                else
                {
                    return (ConsolidatedTypeInd)Enum.Parse(typeof(ConsolidatedTypeInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToConsolidatedTypeIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ContactType"/> enum.
    /// </summary>
    internal class StringToContactTypeConverter : ITypeConverter<string, ContactType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToContactTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ContactType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ContactType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ContactType.Null;
                }
                else
                {
                    return (ContactType)Enum.Parse(typeof(ContactType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToContactTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="HearingCategory"/> enum.
    /// </summary>
    internal class StringToControlTypeConverter : ITypeConverter<String, ControlType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToControlTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ControlType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ControlType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ControlType.Null;
                }
                else
                {
                    return (ControlType)Enum.Parse(typeof(ControlType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToControlTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CrimeCase"/> enum.
    /// </summary>
    internal class StringToCrimeCaseConverter : ITypeConverter<string, CrimeCase>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCrimeCaseConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CrimeCase"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CrimeCase Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CrimeCase.Null;
                }

                else
                {
                    return (CrimeCase)Enum.Parse(typeof(CrimeCase), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCrimeCaseConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CrimeClaimHearingType"/> enum.
    /// </summary>
    internal class StringToCrimeClaimHearingTypeConverter : ITypeConverter<string, CrimeClaimHearingType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCrimeClaimHearingTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CrimeClaimHearingType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CrimeClaimHearingType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CrimeClaimHearingType.Null;
                }
                else
                {
                    return (CrimeClaimHearingType)Enum.Parse(typeof(CrimeClaimHearingType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCrimeClaimHearingTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalClaimStatus"/> enum.
    /// </summary>
    internal class StringToCriminalClaimStatusConverter : ITypeConverter<string, CriminalClaimStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalClaimStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalClaimStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalClaimStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalClaimStatus.Null;
                }
                else
                {
                    return (CriminalClaimStatus)Enum.Parse(typeof(CriminalClaimStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalClaimStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalCounselTypes"/> enum.
    /// </summary>
    internal class StringToCriminalCounselTypesConverter : ITypeConverter<string, CriminalCounselTypes>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalCounselTypesConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalCounselTypes"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalCounselTypes Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalCounselTypes.Null;
                }
                else
                {
                    return (CriminalCounselTypes)Enum.Parse(typeof(CriminalCounselTypes), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalCounselTypesConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalNatureOfSentence"/> enum.
    /// </summary>
    internal class StringToCriminalNatureOfSentenceConverter : ITypeConverter<string, CriminalNatureOfSentence>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalNatureOfSentenceConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalCounselTypes"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalNatureOfSentence Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalNatureOfSentence.Null;
                }

                else
                {
                    return (CriminalNatureOfSentence)Enum.Parse(typeof(CriminalNatureOfSentence), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalNatureOfSentenceConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalPartyInTypes"/> enum.
    /// </summary>
    internal class StringToCriminalPartyInTypesConverter : ITypeConverter<string, CriminalPartyInType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalPartyInTypesConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalPartyInType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalPartyInType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalPartyInType.Null;
                }

                else
                {
                    return (CriminalPartyInType)Enum.Parse(typeof(CriminalPartyInType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalPartyInTypesConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalStatusOfSentence"/> enum.
    /// </summary>
    internal class StringToCriminalStatusOfSentenceConverter : ITypeConverter<string, CriminalStatusOfSentence>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalStatusOfSentenceConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalCounselTypes"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalStatusOfSentence Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalStatusOfSentence.Null;
                }

                else
                {
                    return (CriminalStatusOfSentence)Enum.Parse(typeof(CriminalStatusOfSentence), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalStatusOfSentenceConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalPartyInTypes"/> enum.
    /// </summary>
    internal class StringToCustodyRemandConverter : ITypeConverter<string, CustodyRemand>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCustodyRemandConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CustodyRemand"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CustodyRemand Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CustodyRemand.Null;
                }

                else
                {
                    return (CustodyRemand)Enum.Parse(typeof(CustodyRemand), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCustodyRemandConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DayInTheWeek"/> enum.
    /// </summary>
    internal class StringToDayInTheWeekConverter : ITypeConverter<string, DayInTheWeek>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDayInTheWeekConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DayInTheWeek"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DayInTheWeek Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DayInTheWeek.Null;
                }
                else
                {
                    return (DayInTheWeek)Enum.Parse(typeof(DayInTheWeek), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDayInTheWeekConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DegreeType"/> enum.
    /// </summary>
    internal class StringToDegreeTypeConverter : ITypeConverter<string, DegreeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDegreeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DegreeType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DegreeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DegreeType.Null;
                }
                else
                {
                    return (DegreeType)Enum.Parse(typeof(DegreeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDegreeTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DivorceCaseNature"/> enum.
    /// </summary>
    internal class StringToDivorceCaseNatureConverter : ITypeConverter<string, DivorceCaseNature>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDivorceCaseNatureConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DivorceCaseNature"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DivorceCaseNature Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DivorceCaseNature.Null;
                }
                else
                {
                    return (DivorceCaseNature)Enum.Parse(typeof(DivorceCaseNature), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDivorceCaseNatureConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocCasePartyUpdateType"/> enum.
    /// </summary>
    internal class StringToDocCasePartyUpdateTypeConverter : ITypeConverter<string, DocCasePartyUpdateType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocCasePartyUpdateTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocCasePartyUpdateType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocCasePartyUpdateType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocCasePartyUpdateType.Null;
                }
                else
                {
                    return (DocCasePartyUpdateType)Enum.Parse(typeof(DocCasePartyUpdateType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocCasePartyUpdateTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocInitiatedLocation"/> enum.
    /// </summary>
    internal class StringToDocInitiatedLocationConverter : ITypeConverter<string, DocInitiatedLocation>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocInitiatedLocationConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocInitiatedLocation"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocInitiatedLocation Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocInitiatedLocation.Null;
                }
                else
                {
                    return (DocInitiatedLocation)Enum.Parse(typeof(DocInitiatedLocation), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocInitiatedLocationConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocumentFileType"/> enum.
    /// </summary>
    internal class StringToDocumentFileTypeConverter : ITypeConverter<string, DocumentFileType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocumentFileTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocumentFileType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocumentFileType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocumentFileType.Null;
                }
                else
                {
                    return (DocumentFileType)Enum.Parse(typeof(DocumentFileType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocumentFileTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocumentFilingType"/> enum.
    /// </summary>
    internal class StringToDocumentFilingTypeConverter : ITypeConverter<string, DocumentFilingType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocumentFilingTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocumentFilingType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocumentFilingType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocumentFilingType.Null;
                }
                else
                {
                    return (DocumentFilingType)Enum.Parse(typeof(DocumentFilingType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocumentFilingTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocumentProcessType"/> enum.
    /// </summary>
    internal class StringToDocumentProcessTypeConverter : ITypeConverter<string, DocumentProcessType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocumentProcessTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocumentProcessType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocumentProcessType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocumentProcessType.Null;
                }
                else
                {
                    return (DocumentProcessType)Enum.Parse(typeof(DocumentProcessType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocumentProcessTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="EHearingStatus"/> enum.
    /// </summary>
    internal class StringToEHearingStatusConverter : ITypeConverter<string, EHearingStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEHearingStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="EHearingStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public EHearingStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return EHearingStatus.Null;
                }
                else
                {
                    return (EHearingStatus)Enum.Parse(typeof(EHearingStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEHearingStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="EMSType"/> enum.
    /// </summary>
    internal class StringToEMSTypeConverter : ITypeConverter<string, EMSType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEMSTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="EMSType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public EMSType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return EMSType.Null;
                }
                else
                {
                    return (EMSType)Enum.Parse(typeof(EMSType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEMSTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="EndorsementType"/> enum.
    /// </summary>
    internal class StringToEndorsementTypeConverter : ITypeConverter<string, EndorsementType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToEndorsementTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="EndorsementType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public EndorsementType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return EndorsementType.Null;
                }
                else
                {
                    return (EndorsementType)Enum.Parse(typeof(EndorsementType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToEndorsementTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ExecutionOutcome"/> enum.
    /// </summary>
    internal class StringToExecutionOutcomeConverter : ITypeConverter<string, ExecutionOutcome>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToExecutionOutcomeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ExecutionOutcome"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ExecutionOutcome Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ExecutionOutcome.Null;
                }
                else
                {
                    return (ExecutionOutcome)Enum.Parse(typeof(ExecutionOutcome), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToExecutionOutcomeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FeeRuleType"/> enum.
    /// </summary>
    internal class StringToFeeRuleTypeConverter : ITypeConverter<string, FeeRuleType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFeeRuleTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FeeRuleType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FeeRuleType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return FeeRuleType.Null;
                }

                else
                {
                    return (FeeRuleType)Enum.Parse(typeof(FeeRuleType), context.SourceValue.ToString(), ignorecase);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFeeRuleTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FiledUserType"/> enum.
    /// </summary>
    internal class StringToFiledUserTypeConverter : ITypeConverter<string, FiledUserType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFiledUserTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FiledUserType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FiledUserType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return FiledUserType.Null;
                }
                else
                {
                    return (FiledUserType)Enum.Parse(typeof(FiledUserType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFiledUserTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FileInspectionDocStatus"/> enum.
    /// </summary>
    internal class StringToFileInspectionDocStatusConverter : ITypeConverter<string, FileInspectionDocStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFileInspectionDocStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FileInspectionDocStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FileInspectionDocStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (FileInspectionDocStatus)Enum.Parse(typeof(FileInspectionDocStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFileInspectionDocStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FileInspectionStatus"/> enum.
    /// </summary>
    internal class StringToFileInspectionStatusConverter : ITypeConverter<string, FileInspectionStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFileInspectionStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FileInspectionStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FileInspectionStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (FileInspectionStatus)Enum.Parse(typeof(FileInspectionStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFileInspectionStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FilingFrom"/> enum.
    /// </summary>
    internal class StringToFilingFromConverter : ITypeConverter<string, FilingFrom>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFilingFromConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FilingFrom"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FilingFrom Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return FilingFrom.Null;
                }
                else
                {
                    return (FilingFrom)Enum.Parse(typeof(FilingFrom), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFilingFromConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FilingOrderFor"/> enum.
    /// </summary>
    internal class StringToFilingOrderForConverter : ITypeConverter<string, FilingOrderFor>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFilingOrderForConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FilingOrderFor"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FilingOrderFor Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (FilingOrderFor)Enum.Parse(typeof(FilingOrderFor), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFilingOrderForConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FilingPartyInd"/> enum.
    /// </summary>
    internal class StringToFilingPartyIndConverter : ITypeConverter<string, FilingPartyInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFilingPartyIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FilingPartyInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FilingPartyInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return FilingPartyInd.N;
                }
                else
                {
                    return (FilingPartyInd)Enum.Parse(typeof(FilingPartyInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFilingPartyIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="HearingCategory"/> enum.
    /// </summary>
    internal class StringToHearingCategoryConverter : ITypeConverter<string, HearingCategory>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToHearingCategoryConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="HearingCategory"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public HearingCategory Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return HearingCategory.Null;
                }
                else
                {
                    return (HearingCategory)Enum.Parse(typeof(HearingCategory), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToHearingCategoryConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ICAInterfaceStatus"/> enum.
    /// </summary>
    internal class StringToICAInterfaceStatusConverter : ITypeConverter<string, ICAInterfaceStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToICAInterfaceStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ICAInterfaceStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ICAInterfaceStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ICAInterfaceStatus.Null;
                }
                else
                {
                    return (ICAInterfaceStatus)Enum.Parse(typeof(ICAInterfaceStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToICAInterfaceStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="Int64"/> enum.
    /// </summary>
    internal class StringToInt64Converter : ITypeConverter<string, Int64>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInt64Converter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="Int64"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public Int64 Convert(ResolutionContext context)
        {
            try
            {
                return Int64.Parse(context.SourceValue.ToString());
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInt64Converter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    internal class StringToNullableInt64Converter : ITypeConverter<string, Int64?>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInt64Converter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="Int64"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public Int64? Convert(ResolutionContext context)
        {
            try
            {
                if (!string.IsNullOrEmpty(System.Convert.ToString(context.SourceValue.ToString())))
                {
                    return Int64.Parse(context.SourceValue.ToString());
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToNullableInt64Converter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="InterfaceCriminalStatus"/> enum.
    /// </summary>
    internal class StringToInterfaceCriminalStatusConverter : ITypeConverter<string, InterfaceCriminalStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInterfaceCriminalStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="InterfaceCriminalStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public InterfaceCriminalStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return InterfaceCriminalStatus.Null;
                }
                else
                {
                    return (InterfaceCriminalStatus)Enum.Parse(typeof(InterfaceCriminalStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInterfaceCriminalStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="InterpreterLanguage"/> enum.
    /// </summary>
    internal class StringToInterpreterLanguageConverter : ITypeConverter<string, InterpreterLanguage>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInterpreterLanguageConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="InterpreterLanguage"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public InterpreterLanguage Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return InterpreterLanguage.Null;
                }
                else
                {
                    return (InterpreterLanguage)Enum.Parse(typeof(InterpreterLanguage), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInterpreterLanguageConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="InvolvementInd"/> enum.
    /// </summary>
    internal class StringToInvolvementIndConverter : ITypeConverter<string, InvolvementInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInvolvementIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="InvolvementInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public InvolvementInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return InvolvementInd.Null;
                }
                else
                {
                    return (InvolvementInd)Enum.Parse(typeof(InvolvementInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInvolvementIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="JudgmentFor"/> enum.
    /// </summary>
    internal class StringToJudgmentForConverter : ITypeConverter<string, JudgmentFor>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToJudgmentForConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgmentFor"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public JudgmentFor Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return JudgmentFor.Null;
                }
                else
                {
                    return (JudgmentFor)Enum.Parse(typeof(JudgmentFor), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToJudgmentForConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="JurisdictionDomicileForParty"/> enum.
    /// </summary>
    internal class StringToJurisdictionDomicileForPartyConverter : ITypeConverter<string, JurisdictionDomicileForParty>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToJurisdictionDomicileForPartyConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JurisdictionDomicileForParty"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public JurisdictionDomicileForParty Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return JurisdictionDomicileForParty.Null;
                }
                else
                {
                    return (JurisdictionDomicileForParty)Enum.Parse(typeof(JurisdictionDomicileForParty), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToJurisdictionDomicileForPartyConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="JurisdictionInSingapore"/> enum.
    /// </summary>
    internal class StringToJurisdictionInSingaporeConverter : ITypeConverter<string, JurisdictionInSingapore>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToJurisdictionInSingaporeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JurisdictionInSingapore"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public JurisdictionInSingapore Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return JurisdictionInSingapore.Null;
                }
                else
                {
                    return (JurisdictionInSingapore)Enum.Parse(typeof(JurisdictionInSingapore), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToJurisdictionInSingaporeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LACConcludedStatus"/> enum.
    /// </summary>
    internal class StringToLACConcludedStatusConverter : ITypeConverter<string, LACConcludedStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACConcludedStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LACConcludedStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LACConcludedStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LACConcludedStatus.Null;
                }
                else
                {
                    return (LACConcludedStatus)Enum.Parse(typeof(LACConcludedStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLACConcludedStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LACDocStatus"/> enum.
    /// </summary>
    internal class StringToLACDocStatusConverter : ITypeConverter<string, LACDocStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACDocStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LACDocStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LACDocStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LACDocStatus.Null;
                }
                else
                {
                    return (LACDocStatus)Enum.Parse(typeof(LACDocStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLACDocStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LACRefStatus"/> enum.
    /// </summary>
    internal class StringToLACRefStatusConverter : ITypeConverter<string, LACRefStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACRefStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LACRefStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LACRefStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LACRefStatus.Null;
                }
                else
                {
                    return (LACRefStatus)Enum.Parse(typeof(LACRefStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLACRefStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LACStatus"/> enum.
    /// </summary>
    internal class StringToLACStatusConverter : ITypeConverter<string, LACStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LACStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LACStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LACStatus.Null;
                }
                else
                {
                    return (LACStatus)Enum.Parse(typeof(LACStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLACStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LACType"/> enum.
    /// </summary>
    internal class StringToLACTypeConverter : ITypeConverter<string, LACType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLACTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LACType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LACType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LACType.Null;
                }
                else
                {
                    return (LACType)Enum.Parse(typeof(LACType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLACTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LAPInterfaceFileStatus"/> enum.
    /// </summary>
    internal class StringToLAPInterfaceFileStatusConverter : ITypeConverter<string, LAPInterfaceFileStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLAPInterfaceFileStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LAPInterfaceFileStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LAPInterfaceFileStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LAPInterfaceFileStatus.Null;
                }
                else
                {
                    return (LAPInterfaceFileStatus)Enum.Parse(typeof(LAPInterfaceFileStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLAPInterfaceFileStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LawPracticeType"/> enum.
    /// </summary>
    internal class StringToLawPracticeTypeConverter : ITypeConverter<string, LawPracticeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLawPracticeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LawPracticeType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LawPracticeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LawPracticeType.Null;
                }
                else
                {
                    return (LawPracticeType)Enum.Parse(typeof(LawPracticeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLawPracticeTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CitizenshipStatus"/> enum.
    /// </summary>
    internal class StringToLegalExperienceTypeConverter : ITypeConverter<string, LegalExperienceType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLegalExperienceTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LegalExperienceType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LegalExperienceType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LegalExperienceType.Null;
                }
                else
                {
                    return (LegalExperienceType)Enum.Parse(typeof(LegalExperienceType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLegalExperienceTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LegalOrganizationType"/> enum.
    /// </summary>
    internal class StringToLegalOrganizationTypeConverter : ITypeConverter<string, LegalOrganizationType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLegalOrganizationTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LegalOrganizationType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LegalOrganizationType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LegalOrganizationType.Null;
                }
                else
                {
                    return (LegalOrganizationType)Enum.Parse(typeof(LegalOrganizationType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLegalOrganizationTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LFGroupCode"/> enum.
    /// </summary>
    internal class StringToLFGroupCodeConverter : ITypeConverter<string, LFGroupCode>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLFGroupCodeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LFGroupCode"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LFGroupCode Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LFGroupCode.Null;
                }
                else
                {
                    return (LFGroupCode)Enum.Parse(typeof(LFGroupCode), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLFGroupCodeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LogicalOperator"/> enum.
    /// </summary>
    internal class StringToLogicalOperatorConverter : ITypeConverter<string, LogicalOperator>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLogicalOperatorConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LogicalOperator"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LogicalOperator Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (LogicalOperator)Enum.Parse(typeof(LogicalOperator), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLogicalOperatorConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="LPALPRSectionOrProvision"/> enum.
    /// </summary>
    internal class StringToLPALPRSectionOrProvisionConverter : ITypeConverter<string, LPALPRSectionOrProvision>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToLPALPRSectionOrProvisionConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="LPALPRSectionOrProvision"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public LPALPRSectionOrProvision Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return LPALPRSectionOrProvision.Null;
                }
                else
                {
                    return (LPALPRSectionOrProvision)Enum.Parse(typeof(LPALPRSectionOrProvision), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToLPALPRSectionOrProvisionConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="MailboxMessageType"/> enum.
    /// </summary>
    internal class StringToMailboxMessageTypeConverter : ITypeConverter<string, MailboxMessageType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMailboxMessageTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="MailboxMessageType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public MailboxMessageType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return MailboxMessageType.Null;
                }
                else
                {
                    return (MailboxMessageType)Enum.Parse(typeof(MailboxMessageType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToMailboxMessageTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="MailboxStatus"/> enum.
    /// </summary>
    internal class StringToMailboxStatusConverter : ITypeConverter<string, MailboxStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMailboxStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="MailboxStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public MailboxStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (MailboxStatus)Enum.Parse(typeof(MailboxStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToMailboxStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="MHRGTypeEntity"/> enum.
    /// </summary>
    internal class StringToMBasisForTaxationEntityConverter : ITypeConverter<String, MBasisForTaxationEntity>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMBasisForTaxationEntityConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ControlType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public MBasisForTaxationEntity Convert(ResolutionContext context)
        {
            try
            {

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return null;
                }
                else
                {
                    return new MBasisForTaxationEntity { BFTCode = context.SourceValue.ToString() };
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToMBasisForTaxationEntityConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="HearingCategory"/> enum.
    /// </summary>
    internal class StringToMCurrencyEntityConverter : ITypeConverter<String, MCurrencyEntity>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMCurrencyEntityConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ControlType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public MCurrencyEntity Convert(ResolutionContext context)
        {
            try
            {

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return null;
                }
                else
                {
                    return new MCurrencyEntity { CurrencyCode = context.SourceValue.ToString() };
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToMCurrencyEntityConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="MHRGTypeEntity"/> enum.
    /// </summary>
    internal class StringToMHRGTypeEntityConverter : ITypeConverter<String, MHRGTypeEntity>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMHRGTypeEntityConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ControlType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public MHRGTypeEntity Convert(ResolutionContext context)
        {
            try
            {

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return null;
                }
                else
                {
                    return new MHRGTypeEntity { HRGTypeCode = context.SourceValue.ToString() };
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToMHRGTypeEntityConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    ///// <summary>
    ///// Method implementing <see cref="ITypeConverter"/> for <see cref="MiscellaneousClaimStatus"/> enum.
    ///// </summary>
    //internal class StringToMiscellaneousClaimStatusConverter : ITypeConverter<string, MiscellaneousClaimStatus>
    //{
    //    #region Fields
    //    /// <summary>
    //    /// ILog instance for logging.
    //    /// </summary>
    //    private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMiscellaneousClaimStatusConverter));
    //    #endregion Fields
    //    #region Methods
    //    /// <summary>
    //    /// Implements Convert method for converting string value to <see cref="MiscellaneousClaimStatus"/> enum.
    //    /// </summary>
    //    /// <param name="source">context as string</param>
    //    /// <returns>If the context value is null or empty then enum's Null value type is selected,
    //    /// else matching value type is selected through Enum.Parse.</returns>
    //    public MiscellaneousClaimStatus Convert(ResolutionContext context)
    //    {
    //        try
    //        {
    //            var ignorecase = true;
    //            if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
    //            {
    //                return MiscellaneousClaimStatus.Null;
    //            }
    //            else
    //            {
    //                return (MiscellaneousClaimStatus)Enum.Parse(typeof(MiscellaneousClaimStatus), context.SourceValue.ToString(), ignorecase);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Logger.Error("Error at StringToMiscellaneousClaimStatusConverter >> Convert", ex);
    //            throw;
    //        }
    //    }
    //    #endregion Methods
    //}
    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ModeOfAmendment"/> enum.
    /// </summary>
    internal class StringToModeOfAmendmentConverter : ITypeConverter<string, ModeOfAmendment>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToModeOfAmendmentConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ModeOfAmendment"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ModeOfAmendment Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (ModeOfAmendment)Enum.Parse(typeof(ModeOfAmendment), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToModeOfAmendmentConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="NatureOfCDR"/> enum.
    /// </summary>
    internal class StringToNatureOfCDRConverter : ITypeConverter<string, NatureOfCDR>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToNatureOfCDRConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="NatureOfCDR"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public NatureOfCDR Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return NatureOfCDR.Null;
                }
                else
                {
                    return (NatureOfCDR)Enum.Parse(typeof(NatureOfCDR), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToNatureOfCDRConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="NatureOfDeputyShip"/> enum.
    /// </summary>
    internal class StringToNatureOfDeputyShipConverter : ITypeConverter<string, NatureOfDeputyShip>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToNatureOfDeputyShipConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="NatureOfDeputyShip"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public NatureOfDeputyShip Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return NatureOfDeputyShip.Null;
                }
                else
                {
                    return (NatureOfDeputyShip)Enum.Parse(typeof(NatureOfDeputyShip), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToNatureOfDeputyShipConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OCRStatus"/> enum.
    /// </summary>
    internal class StringToOCRStatusConverter : ITypeConverter<string, OCRStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOCRStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OCRStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OCRStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (OCRStatus)Enum.Parse(typeof(OCRStatus), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOCRStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AppointmentOrganisationType"/> enum.
    /// </summary>
    internal class StringToOGCQueueStatusConverter : ITypeConverter<string, OGCQueueStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOGCQueueStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AppointmentOrganisationType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OGCQueueStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OGCQueueStatus.Null;
                }
                else
                {
                    return (OGCQueueStatus)Enum.Parse(typeof(OGCQueueStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOGCQueueStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OnlineEnquiryReportType"/> enum.
    /// </summary>
    internal class StringToOnlineEnquiryReportTypeConverter : ITypeConverter<string, OnlineEnquiryReportType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOnlineEnquiryReportTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OnlineEnquiryReportType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OnlineEnquiryReportType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OnlineEnquiryReportType.Null;
                }
                else
                {
                    return (OnlineEnquiryReportType)Enum.Parse(typeof(OnlineEnquiryReportType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOnlineEnquiryReportTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OnlineEnquirySchedulerInfo"/> enum.
    /// </summary>
    internal class StringToOnlineEnquirySchedulerInfoConverter : ITypeConverter<string, OnlineEnquirySchedulerInfo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOnlineEnquirySchedulerInfoConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OnlineEnquirySchedulerInfo"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OnlineEnquirySchedulerInfo Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OnlineEnquirySchedulerInfo.Null;
                }
                else
                {
                    return (OnlineEnquirySchedulerInfo)Enum.Parse(typeof(OnlineEnquirySchedulerInfo), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOnlineEnquirySchedulerInfoConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OrderEnforcedTypes"/> enum.
    /// </summary>
    internal class StringToOrderEnforcedTypesConverter : ITypeConverter<string, OrderEnforcedTypes>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOrderEnforcedTypesConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OrderEnforcedTypes"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OrderEnforcedTypes Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OrderEnforcedTypes.Null;
                }
                else
                {
                    return (OrderEnforcedTypes)Enum.Parse(typeof(OrderEnforcedTypes), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOrderEnforcedTypesConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OrderMadeIn"/> enum.
    /// </summary>
    internal class StringToOrderMadeInConverter : ITypeConverter<string, OrderMadeIn>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOrderMadeInConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OrderMadeIn"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OrderMadeIn Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OrderMadeIn.Null;
                }
                else
                {
                    return (OrderMadeIn)Enum.Parse(typeof(OrderMadeIn), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOrderMadeInConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OrderType"/> enum.
    /// </summary>
    internal class StringToOrderTypeConverter : ITypeConverter<string, OrderType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOrderTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OrderType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OrderType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OrderType.Null;
                }
                else
                {
                    return (OrderType)Enum.Parse(typeof(OrderType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOrderTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="Origin"/> enum.
    /// </summary>
    internal class StringToOriginConverter : ITypeConverter<String, Origin>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOriginConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="Origin"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public Origin Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return Origin.Null;
                }
                else
                {
                    return (Origin)Enum.Parse(typeof(Origin), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOriginConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OtherPartyType"/> enum.
    /// </summary>
    internal class StringToOtherPartyTypeConverter : ITypeConverter<string, OtherPartyType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOtherPartyTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DebtorClaimantIdentifierType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OtherPartyType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OtherPartyType.Null;
                }
                else
                {
                    return (OtherPartyType)Enum.Parse(typeof(OtherPartyType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOtherPartyTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OutOfOfficeStatus"/> enum.
    /// </summary>
    internal class StringToOutOfOfficeStatusConverter : ITypeConverter<string, OutOfOfficeStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOutOfOfficeStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OutOfOfficeStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OutOfOfficeStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OutOfOfficeStatus.Null;
                }
                else
                {
                    return (OutOfOfficeStatus)Enum.Parse(typeof(OutOfOfficeStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOutOfOfficeStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OutstandingPaymentType"/> enum.
    /// </summary>
    internal class StringToOutstandingPaymentTypeConverter : ITypeConverter<string, OutstandingPaymentType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOutstandingPaymentTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OutstandingPaymentType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OutstandingPaymentType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OutstandingPaymentType.Null;
                }
                else
                {
                    return (OutstandingPaymentType)Enum.Parse(typeof(OutstandingPaymentType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOutstandingPaymentTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ParentingPlan"/> enum.
    /// </summary>
    internal class StringToParentingPlanConverter : ITypeConverter<string, ParentingPlan>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToParentingPlanConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AddressAvailabilityType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ParentingPlan Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ParentingPlan.Null;
                }
                else
                {
                    return (ParentingPlan)Enum.Parse(typeof(ParentingPlan), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToParentingPlanConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PartyRepresentationType"/> enum.
    /// </summary>
    internal class StringToPartyRepresentationTypeConverter : ITypeConverter<string, PartyRepresentationType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPartyRepresentationTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PartyRepresentationType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PartyRepresentationType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PartyRepresentationType.Null;
                }
                else
                {
                    return (PartyRepresentationType)Enum.Parse(typeof(PartyRepresentationType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPartyRepresentationTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PartyRepresentedBy"/> enum.
    /// </summary>
    internal class StringToPartyRepresentedByConverter : ITypeConverter<string, PartyRepresentedBy>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPartyRepresentedByConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PartyRepresentedBy"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PartyRepresentedBy Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PartyRepresentedBy.Null;
                }
                else
                {
                    return (PartyRepresentedBy)Enum.Parse(typeof(PartyRepresentedBy), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPartyRepresentedByConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PartyUpdateInd"/> enum.
    /// </summary>
    internal class StringToPartyUpdateIndConverter : ITypeConverter<string, PartyUpdateInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPartyUpdateIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PartyUpdateInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PartyUpdateInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PartyUpdateInd.Null;
                }
                else
                {
                    return (PartyUpdateInd)Enum.Parse(typeof(PartyUpdateInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPartyUpdateIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PayingInType"/> enum.
    /// </summary>
    internal class StringToPayingInTypeConverter : ITypeConverter<string, PayingInType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPayingInTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PayingInType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PayingInType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PayingInType.Null;
                }
                else
                {
                    return (PayingInType)Enum.Parse(typeof(PayingInType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPayingInTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PaymentChequeStatus"/> enum.
    /// </summary>
    internal class StringToPaymentChequeStatusConverter : ITypeConverter<string, PaymentChequeStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentChequeStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PaymentChequeStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PaymentChequeStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PaymentChequeStatus.Null;
                }
                else
                {
                    return (PaymentChequeStatus)Enum.Parse(typeof(PaymentChequeStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentChequeStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PaymentInReasonType"/> enum.
    /// </summary>
    internal class StringToPaymentInReasonTypeConverter : ITypeConverter<string, PaymentInReasonType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentInReasonTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PaymentInReasonType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PaymentInReasonType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PaymentInReasonType.Null;
                }
                else
                {
                    return (PaymentInReasonType)Enum.Parse(typeof(PaymentInReasonType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentInReasonTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PaymentVoucherStatus"/> enum.
    /// </summary>
    internal class StringToPaymentVoucherStatusConverter : ITypeConverter<string, PaymentVoucherStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentVoucherStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PaymentVoucherStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PaymentVoucherStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PaymentVoucherStatus.Null;
                }
                else
                {
                    return (PaymentVoucherStatus)Enum.Parse(typeof(PaymentVoucherStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentVoucherStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PaymentVoucherType"/> enum.
    /// </summary>
    internal class StringToPaymentVoucherTypeConverter : ITypeConverter<string, PaymentVoucherType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentVoucherTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PaymentVoucherType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PaymentVoucherType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PaymentVoucherType.Null;
                }
                else
                {
                    return (PaymentVoucherType)Enum.Parse(typeof(PaymentVoucherType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentVoucherTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ProbateInfoType"/> enum.
    /// </summary>
    internal class StringToProbateInfoTypeConverter : ITypeConverter<String, ProbateInfoType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToProbateInfoTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ProbateInfoType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ProbateInfoType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ProbateInfoType.Null;
                }
                else
                {
                    return (ProbateInfoType)Enum.Parse(typeof(ProbateInfoType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToProbateInfoTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PropertyType"/> enum.
    /// </summary>
    internal class StringToPropertyTypeConverter : ITypeConverter<string, PropertyType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPropertyTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PropertyType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PropertyType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PropertyType.Null;
                }
                else
                {
                    return (PropertyType)Enum.Parse(typeof(PropertyType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPropertyTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ReceiptAduitType"/> enum.
    /// </summary>
    internal class StringToReceiptAduitTypeConverter : ITypeConverter<string, ReceiptAduitType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToReceiptAduitTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ReceiptAduitType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ReceiptAduitType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (ReceiptAduitType)Enum.Parse(typeof(ReceiptAduitType), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToReceiptAduitTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ReceiptStatus"/> enum.
    /// </summary>
    internal class StringToReceiptStatusConverter : ITypeConverter<string, ReceiptStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToReceiptStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ReceiptStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ReceiptStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ReceiptStatus.Null;
                }
                else
                {
                    return (ReceiptStatus)Enum.Parse(typeof(ReceiptStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToReceiptStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RefundFeeType"/> enum.
    /// </summary>
    internal class StringToRefundFeeTypeConverter : ITypeConverter<string, RefundFeeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRefundFeeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RefundFeeType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RefundFeeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return RefundFeeType.Null;
                }
                else
                {
                    return (RefundFeeType)Enum.Parse(typeof(RefundFeeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRefundFeeTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RefundStatus"/> enum.
    /// </summary>
    internal class StringToRefundStatusConverter : ITypeConverter<string, RefundStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRefundStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RefundStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RefundStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (RefundStatus)Enum.Parse(typeof(RefundStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRefundStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RefundType"/> enum.
    /// </summary>
    internal class StringToRefundTypeConverter : ITypeConverter<string, RefundType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRefundTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RefundType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RefundType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return RefundType.Null;
                }

                else
                {
                    return (RefundType)Enum.Parse(typeof(RefundType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRefundTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ReleaseType"/> enum.
    /// </summary>
    internal class StringToReleaseTypeConverter : ITypeConverter<string, ReleaseType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToReleaseTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ReleaseType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ReleaseType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ReleaseType.Null;
                }
                else
                {
                    return (ReleaseType)Enum.Parse(typeof(ReleaseType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToReleaseTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CriminalReleaseType"/> enum.
    /// </summary>
    internal class StringToCriminalReleaseTypeConverter : ITypeConverter<string, CriminalReleaseType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCriminalReleaseTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="CriminalReleaseType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CriminalReleaseType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CriminalReleaseType.Null;
                }
                else
                {
                    return (CriminalReleaseType)Enum.Parse(typeof(CriminalReleaseType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCriminalReleaseTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ReprintType"/> enum.
    /// </summary>
    internal class StringToReprintTypeConverter : ITypeConverter<string, ReprintType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToReprintTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ReprintType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ReprintType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ReprintType.Null;
                }
                else
                {
                    return (ReprintType)Enum.Parse(typeof(ReprintType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToReprintTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RequestType"/> enum.
    /// </summary>
    internal class StringToRequestTypeConverter : ITypeConverter<string, RequestType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRequestTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RequestType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RequestType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (RequestType)Enum.Parse(typeof(RequestType), context.SourceValue.ToString(), ignorecase);
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRequestTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SaleType"/> enum.
    /// </summary>
    internal class StringToSaleTypeConverter : ITypeConverter<string, SaleType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSaleTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SaleType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SaleType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SaleType.Null;
                }
                else
                {
                    return (SaleType)Enum.Parse(typeof(SaleType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSaleTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SchedulerProcessStatus"/> enum.
    /// </summary>
    internal class StringToSchedulerProcessStatusConverter : ITypeConverter<string, SchedulerProcessStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSchedulerProcessStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SchedulerProcessStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SchedulerProcessStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SchedulerProcessStatus.Null;
                }
                else
                {
                    return (SchedulerProcessStatus)Enum.Parse(typeof(SchedulerProcessStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSchedulerProcessStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ServiceStatus"/> enum.
    /// </summary>
    internal class StringToServiceStatusConverter : ITypeConverter<string, ServiceStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToServiceStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="ServiceStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        public ServiceStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (ServiceStatus)Enum.Parse(typeof(ServiceStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToServiceStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SetDownPursuantTo"/> enum.
    /// </summary>
    internal class StringToSetDownPursuantToConverter : ITypeConverter<string, SetDownPursuantTo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSetDownPursuantToConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SetDownPursuantTo"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SetDownPursuantTo Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SetDownPursuantTo.Null;
                }
                else
                {
                    return (SetDownPursuantTo)Enum.Parse(typeof(SetDownPursuantTo), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSetDownPursuantToConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SettingDownStatus"/> enum.
    /// </summary>
    internal class StringToSettingDownStatusConverter : ITypeConverter<string, SettingDownStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSettingDownStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SettingDownStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SettingDownStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SettingDownStatus.Null;
                }
                else
                {
                    return (SettingDownStatus)Enum.Parse(typeof(SettingDownStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSettingDownStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SettlementOutcomeType"/> enum.
    /// </summary>
    internal class StringToSettlementOutcomeTypeConverter : ITypeConverter<string, SettlementOutcomeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSettlementOutcomeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SettlementOutcomeType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SettlementOutcomeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SettlementOutcomeType.Null;
                }
                else
                {
                    return (SettlementOutcomeType)Enum.Parse(typeof(SettlementOutcomeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSettlementOutcomeTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="StatementOrEndorsementInWrit"/> enum.
    /// </summary>
    internal class StringToStatementOrEndorsementInWritConverter : ITypeConverter<string, StatementOrEndorsementInWrit>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToStatementOrEndorsementInWritConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="StatementOrEndorsementInWrit"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public StatementOrEndorsementInWrit Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return StatementOrEndorsementInWrit.Null;
                }
                else
                {
                    return (StatementOrEndorsementInWrit)Enum.Parse(typeof(StatementOrEndorsementInWrit), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToStatementOrEndorsementInWritConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SubmissionStage"/> enum.
    /// </summary>
    internal class StringToSubmissionStageConverter : ITypeConverter<string, SubmissionStage>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSubmissionStageConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SubmissionStage"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SubmissionStage Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (SubmissionStage)Enum.Parse(typeof(SubmissionStage), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSubmissionStageConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SubpoenaPurpose"/> enum.
    /// </summary>
    internal class StringToSubpoenaPurposeConverter : ITypeConverter<string, SubpoenaPurpose>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSubpoenaPurposeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SubpoenaPurpose"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SubpoenaPurpose Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SubpoenaPurpose.Null;
                }

                else
                {
                    return (SubpoenaPurpose)Enum.Parse(typeof(SubpoenaPurpose), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSubpoenaPurposeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SystemInd"/> enum.
    /// </summary>
    internal class StringToSystemIndConverter : ITypeConverter<string, SystemInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSystemIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="SystemInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SystemInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SystemInd.Null;
                }
                else
                {
                    return (SystemInd)Enum.Parse(typeof(SystemInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSystemIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TaskListStatus"/> enum.
    /// </summary>
    internal class StringToTaskListStatusConverter : ITypeConverter<string, TaskListStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTaskListStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TaskListStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public TaskListStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return TaskListStatus.Null;
                }
                else
                {
                    return (TaskListStatus)Enum.Parse(typeof(TaskListStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTaskListStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TeamManagementProceedingType"/> enum.
    /// </summary>
    internal class StringToTeamManagementProceedingTypeConverter : ITypeConverter<string, TeamManagementProceedingType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTeamManagementProceedingTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TeamManagementProceedingType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public TeamManagementProceedingType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return TeamManagementProceedingType.Null;
                }
                else
                {
                    return (TeamManagementProceedingType)Enum.Parse(typeof(TeamManagementProceedingType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTeamManagementProceedingTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TransferStateFundStatus"/> enum.
    /// </summary>
    internal class StringToTransferStateFundStatusConverter : ITypeConverter<string, TransferStateFundStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTransferStateFundStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TransferStateFundStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>matching value type is selected through Enum.Parse.</returns>
        public TransferStateFundStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                //if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                //{
                //    return OGCQueueStatus.Null;
                //}
                //else
                {
                    return (TransferStateFundStatus)Enum.Parse(typeof(TransferStateFundStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTransferStateFundStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TransferTypeInd"/> enum.
    /// </summary>
    internal class StringToTransferTypeIndConverter : ITypeConverter<string, TransferTypeInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTransferTypeIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TransferTypeInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public TransferTypeInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return TransferTypeInd.Null;
                }
                else
                {
                    return (TransferTypeInd)Enum.Parse(typeof(TransferTypeInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTransferTypeIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TypeOfArrest"/> enum.
    /// </summary>
    internal class StringToTypeOfArrestConverter : ITypeConverter<string, TypeOfArrest>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTypeOfArrestConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TypeOfArrest"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public TypeOfArrest Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return TypeOfArrest.Null;
                }
                else
                {
                    return (TypeOfArrest)Enum.Parse(typeof(TypeOfArrest), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTypeOfArrestConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="TypeOfJurisdiction"/> enum.
    /// </summary>
    internal class StringToTypeOfJurisdictionConverter : ITypeConverter<string, TypeOfJurisdiction>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToTypeOfJurisdictionConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="TypeOfJurisdiction"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public TypeOfJurisdiction Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return TypeOfJurisdiction.Null;
                }
                else
                {
                    return (TypeOfJurisdiction)Enum.Parse(typeof(TypeOfJurisdiction), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToTypeOfJurisdictionConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="UnliquidatedClaimType"/> enum.
    /// </summary>
    internal class StringToUnliquidatedClaimTypeConverter : ITypeConverter<string, UnliquidatedClaimType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToUnliquidatedClaimTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="UnliquidatedClaimType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public UnliquidatedClaimType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return UnliquidatedClaimType.Null;
                }
                else
                {
                    return (UnliquidatedClaimType)Enum.Parse(typeof(UnliquidatedClaimType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToUnliquidatedClaimTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="VesselIdType"/> enum.
    /// </summary>
    internal class StringToVesselIdTypeConverter : ITypeConverter<string, VesselIdType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToVesselIdTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="VesselIdType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public VesselIdType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return VesselIdType.Null;
                }
                else
                {
                    return (VesselIdType)Enum.Parse(typeof(VesselIdType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToVesselIdTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="VoidReason"/> enum.
    /// </summary>
    internal class StringToVoidReasonConverter : ITypeConverter<string, VoidReason>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToVoidReasonConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="VoidReason"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public VoidReason Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return VoidReason.Null;
                }
                else
                {
                    return (VoidReason)Enum.Parse(typeof(VoidReason), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToVoidReasonConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WaiverInd"/> enum.
    /// </summary>
    internal class StringToWaiverIndConverter : ITypeConverter<string, WaiverInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWaiverIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WaiverInd"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WaiverInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WaiverInd.Null;
                }
                else
                {
                    return (WaiverInd)Enum.Parse(typeof(WaiverInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWaiverIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WaiverStatus"/> enum.
    /// </summary>
    internal class StringToWaiverStatusConverter : ITypeConverter<string, WaiverStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWaiverStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WaiverStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WaiverStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WaiverStatus.Null;
                }
                else
                {
                    return (WaiverStatus)Enum.Parse(typeof(WaiverStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWaiverStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WaiverType"/> enum.
    /// </summary>
    internal class StringToWaiverTypeConverter : ITypeConverter<string, WaiverType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWaiverTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WaiverType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WaiverType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WaiverType.Null;
                }
                else
                {
                    return (WaiverType)Enum.Parse(typeof(WaiverType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWaiverTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WindingType"/> enum.
    /// </summary>
    internal class StringToWindingTypeConverter : ITypeConverter<string, WindingType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWindingTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WindingType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WindingType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WindingType.Null;
                }
                else
                {
                    return (WindingType)Enum.Parse(typeof(WindingType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWindingTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WitnessType"/> enum.
    /// </summary>
    internal class StringToWitnessTypeConverter : ITypeConverter<string, WitnessType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWitnessTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WitnessType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WitnessType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WitnessType.Null;
                }
                else
                {
                    return (WitnessType)Enum.Parse(typeof(WitnessType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWitnessTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WOEEmpActOrderType"/> enum.
    /// </summary>
    internal class StringToWOEEmpActOrderTypeConverter : ITypeConverter<string, WOEEmpActOrderType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWOEEmpActOrderTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WOEEmpActOrderType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WOEEmpActOrderType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WOEEmpActOrderType.Null;
                }
                else
                {
                    return (WOEEmpActOrderType)Enum.Parse(typeof(WOEEmpActOrderType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWOEEmpActOrderTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WOEInfoClaimStatus"/> enum.
    /// </summary>
    internal class StringToWOEInfoClaimStatusConverter : ITypeConverter<string, WOEInfoClaimStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWOEInfoClaimStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WOEInfoClaimStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WOEInfoClaimStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WOEInfoClaimStatus.Null;
                }
                else
                {
                    return (WOEInfoClaimStatus)Enum.Parse(typeof(WOEInfoClaimStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWOEInfoClaimStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WOEInfoClaimType"/> enum.
    /// </summary>
    internal class StringToWOEInfoClaimTypeConverter : ITypeConverter<string, WOEInfoClaimType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWOEInfoClaimTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WOEInfoClaimType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WOEInfoClaimType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WOEInfoClaimType.Null;
                }
                else
                {
                    return (WOEInfoClaimType)Enum.Parse(typeof(WOEInfoClaimType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWOEInfoClaimTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WOEType"/> enum.
    /// </summary>
    internal class StringToWOETypeConverter : ITypeConverter<string, WOEType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWOETypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WOEType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WOEType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WOEType.Null;
                }
                else
                {
                    return (WOEType)Enum.Parse(typeof(WOEType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWOETypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WorkItemDetailsIndType"/> enum.
    /// </summary>
    internal class StringToWorkItemDetailsIndTypeConverter : ITypeConverter<string, WorkItemDetailsIndType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWorkItemDetailsIndTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WorkItemDetailsIndType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WorkItemDetailsIndType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WorkItemDetailsIndType.Null;
                }
                else
                {
                    return (WorkItemDetailsIndType)Enum.Parse(typeof(WorkItemDetailsIndType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWorkItemDetailsIndTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="WorkItemRecipientStatus"/> enum.
    /// </summary>
    internal class StringToWorkItemRecipientStatusConverter : ITypeConverter<string, WorkItemRecipientStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToWorkItemRecipientStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="WorkItemRecipientStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public WorkItemRecipientStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return WorkItemRecipientStatus.Null;
                }
                else
                {
                    return (WorkItemRecipientStatus)Enum.Parse(typeof(WorkItemRecipientStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToWorkItemRecipientStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="YesNo"/> enum.
    /// </summary>
    internal class StringToYesNoConverter : ITypeConverter<string, YesNo>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToYesNoConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="YesNo"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public YesNo Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return YesNo.Null;
                }
                else
                {
                    return (YesNo)Enum.Parse(typeof(YesNo), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToYesNoConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PartyFlippingCategory"/> enum.
    /// </summary>
    internal class StringToPartyFlippingConverter : ITypeConverter<string, PartyFlippingCategory>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPartyFlippingConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PartyFlippingCategory"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PartyFlippingCategory Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PartyFlippingCategory.Null;
                }
                else
                {
                    return (PartyFlippingCategory)Enum.Parse(typeof(PartyFlippingCategory), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPartyFlippingConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }


    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DocCommentType"/> enum.
    /// </summary>
    internal class StringToDocCommentTypeConverter : ITypeConverter<string, DocCommentType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDocCommentTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DocCommentType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DocCommentType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DocCommentType.Null;
                }
                else
                {
                    return (DocCommentType)Enum.Parse(typeof(DocCommentType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDocCommentTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RoleCode"/> enum.
    /// </summary>
    internal class StringToRoleCodeConverter : ITypeConverter<string, RoleCode>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRoleCodeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RoleCode"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RoleCode Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return RoleCode.Null;
                }

                else
                {
                    return (RoleCode)Enum.Parse(typeof(RoleCode), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRoleCodeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }


    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="MandatoryYesNo"/> enum.
    /// </summary>
    internal class StringToMandatoryYesNoConverter : ITypeConverter<string, YesNoMandatory>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToMandatoryYesNoConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="YesNoMandatory"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public YesNoMandatory Convert(ResolutionContext context)
        {
            try
            {

                return (YesNoMandatory)Enum.Parse(typeof(YesNoMandatory), context.SourceValue.ToString());

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToYesNoMandatoryConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="DivorceFilingFor"/> enum.
    /// </summary>
    internal class StringToDivorceFilingForConverter : ITypeConverter<string, DivorceFilingFor>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToDivorceFilingForConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="DivorceFilingFor"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public DivorceFilingFor Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return DivorceFilingFor.Null;
                }
                else
                {
                    return (DivorceFilingFor)Enum.Parse(typeof(DivorceFilingFor), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToDivorceFilingForConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PrintStatus"/> enum.
    /// </summary>
    internal class StringToPrintStatusConverter : ITypeConverter<string, PrintStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPrintStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PrintStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PrintStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PrintStatus.Null;
                }
                else
                {
                    return (PrintStatus)Enum.Parse(typeof(PrintStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPrintStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="JudgeAssignStatus"/> enum.
    /// </summary>
    internal class StringToJudgeAssignStatusConverter : ITypeConverter<string, JudgeAssignStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToJudgeAssignStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public JudgeAssignStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (JudgeAssignStatus)Enum.Parse(typeof(JudgeAssignStatus), context.SourceValue.ToString(), ignorecase);

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToJudgeAssignStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="PurposeOfOrder"/> enum.
    /// </summary>
    internal class StringToPurposeOfOrderConverter : ITypeConverter<string, PurposeOfOrder>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPurposeOfOrderConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PurposeOfOrder Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PurposeOfOrder.Null;
                }
                else
                {
                    return (PurposeOfOrder)Enum.Parse(typeof(PurposeOfOrder), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPurposeOfOrderConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ReqDecision"/> enum.
    /// </summary>
    internal class StringToReqDecisionConverter : ITypeConverter<string, ReqDecision>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToReqDecisionConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ReqDecision Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ReqDecision.Null;
                }
                else
                {
                    return (ReqDecision)Enum.Parse(typeof(ReqDecision), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToReqDecisionConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="OGCProcessType"/> enum.
    /// </summary>
    internal class StringToOGCProcessTypeConverter : ITypeConverter<string, OGCProcessType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToOGCProcessTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OGCProcessType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public OGCProcessType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return OGCProcessType.Null;
                }
                else
                {
                    return (OGCProcessType)Enum.Parse(typeof(OGCProcessType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToOGCProcessTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RefundOrWaiverType"/> enum.
    /// </summary>
    internal class StringToRefundOrWaiverTypeConverter : ITypeConverter<string, RefundOrWaiverType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRefundOrWaiverTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="OGCProcessType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RefundOrWaiverType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return RefundOrWaiverType.Null;
                }
                else
                {
                    return (RefundOrWaiverType)Enum.Parse(typeof(RefundOrWaiverType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRefundOrWaiverTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="AdmChargeType"/> enum.
    /// </summary>
    internal class StringToAdmChargeTypeConverter : ITypeConverter<string, AdmChargeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToAdmChargeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="AdmChargeType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public AdmChargeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return AdmChargeType.Null;
                }
                else
                {
                    return (AdmChargeType)Enum.Parse(typeof(AdmChargeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToAdmChargeTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="RejectionFeeActionType"/> enum.
    /// </summary>
    internal class StringToRejectionFeeTypeConverter : ITypeConverter<string, RejectionFeeType>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToRejectionFeeTypeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="RejectionFeeActionType"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public RejectionFeeType Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return RejectionFeeType.Null;
                }
                else
                {
                    return (RejectionFeeType)Enum.Parse(typeof(RejectionFeeType), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToRejectionFeeActionTypeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="FilingbrokerQueueStatus"/> enum.
    /// </summary>
    internal class StringToFilingbrokerQueueStatusConverter : ITypeConverter<string, FilingbrokerQueueStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToFilingbrokerQueueStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="FilingbrokerQueueStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public FilingbrokerQueueStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;


                return (FilingbrokerQueueStatus)Enum.Parse(typeof(FilingbrokerQueueStatus), context.SourceValue.ToString(), ignorecase);
                
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToFilingbrokerQueueStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="SubCaseRequestInd"/> enum.
    /// </summary>
    internal class StringToSubCaseRequestIndConverter : ITypeConverter<string, SubCaseRequestInd>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToSubCaseRequestIndConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public SubCaseRequestInd Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return SubCaseRequestInd.Null;
                }
                else
                {
                    return (SubCaseRequestInd)Enum.Parse(typeof(SubCaseRequestInd), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToSubCaseRequestIndConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="IsConfidential"/> enum.
    /// </summary>
    internal class StringToIsConfidentialConverter : ITypeConverter<string, IsConfidential>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToIsConfidentialConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public IsConfidential Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                return (IsConfidential)Enum.Parse(typeof(IsConfidential), context.SourceValue.ToString(), ignorecase);
                           }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToIsConfidentialConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="ExecutorStatus"/> enum.
    /// </summary>
    internal class StringToExecutorStatusConverter : ITypeConverter<string, ExecutorStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToExecutorStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public ExecutorStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return ExecutorStatus.Null;
                }
                else
                {
                    return (ExecutorStatus)Enum.Parse(typeof(ExecutorStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToExecutorStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CPDRequirements"/> enum.
    /// </summary>
    internal class StringToCPDRequirementsConverter : ITypeConverter<string, CPDRequirements>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToCPDRequirementsConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public CPDRequirements Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return CPDRequirements.Null;
                }
                else
                {
                    return (CPDRequirements)Enum.Parse(typeof(CPDRequirements), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToCPDRequirementsConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="CPDRequirements"/> enum.
    /// </summary>
    internal class StringToVoteInfoValueConverter : ITypeConverter<string, VoteInfoValue>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToVoteInfoValueConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="JudgeAssignStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public VoteInfoValue Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return VoteInfoValue.Null;
                }
                else
                {
                    return (VoteInfoValue)Enum.Parse(typeof(VoteInfoValue), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToVoteInfoValueConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="PaymentMode"/> for <see cref="Caseinfo"/> enum.
    /// </summary>
    internal class StringToPaymentModeConverter : ITypeConverter<string, PaymentMode>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToPaymentModeConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="PaymentMode"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public PaymentMode Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return PaymentMode.Null;
                }
                else
                {
                    return (PaymentMode)Enum.Parse(typeof(PaymentMode), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToPaymentModeConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }

    /// <summary>
    /// Method implementing <see cref="InterfaceStatus"/> for <see cref="OutgoingCorrespondenceInfo"/> enum.
    /// </summary>
    internal class StringToInterfaceStatusConverter : ITypeConverter<string, InterfaceStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToInterfaceStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="InterfaceStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public InterfaceStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return InterfaceStatus.Null;
                }
                else
                {
                    return (InterfaceStatus)Enum.Parse(typeof(InterfaceStatus), context.SourceValue.ToString(), ignorecase);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToInterfaceStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }


    /// <summary>
    /// Method implementing <see cref="ITypeConverter"/> for <see cref="VerStatus"/> enum.
    /// </summary>
    internal class StringToVerStatusConverter : ITypeConverter<string, VerStatus>
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(StringToVerStatusConverter));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Implements Convert method for converting string value to <see cref="VerStatus"/> enum.
        /// </summary>
        /// <param name="source">context as string</param>
        /// <returns>If the context value is null or empty then enum's Null value type is selected,
        /// else matching value type is selected through Enum.Parse.</returns>
        public VerStatus Convert(ResolutionContext context)
        {
            try
            {
                var ignorecase = true;

                if (context.IsSourceValueNull || string.IsNullOrEmpty(context.SourceValue.ToString().Trim()))
                {
                    return VerStatus.Null;
                }
                else
                {
                    return (VerStatus)Enum.Parse(typeof(VerStatus), context.SourceValue.ToString(), ignorecase);
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error at StringToVerStatusConverter >> Convert", ex);
                throw;
            }
        }

        #endregion Methods
    }
}