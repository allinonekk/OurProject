namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.Common;
    using AllInOne.Legal.Entities.BackEnd;

    using log4net;
    using AllInOne.Legal.Domain.LawFirm;

    public class LawFirmMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(LawFirmMapping));

        #endregion Fields

        #region Methods

        /// <summary>
        /// Method which maps the <see cref="Solicitor"/> to <see cref="SolicitorEntity"/>.
        /// </summary>
        internal void MapSolicitorEntityToSolicitor()
        {
            try
            {
                Mapper.CreateMap<SolicitorEntity, Solicitor>()
                    .ForMember(dest => dest.AdmittedToBarInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.AdmittedToBarInd))
                    .ForMember(dest => dest.BLERegistrationInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.BLERegistrationInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSolicitorEntityToSolicitor", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawFirm"/> to <see cref="LawFirmEntity"/>.
        /// </summary>
        internal void MapLawFirmEntityToLawFirm()
        {
            try
            {
                Mapper.CreateMap<LawFirmEntity, LawFirm>()
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.LawPracticeType, opts => opts.ResolveUsing<LawPracticeTypeToStringResolver>().FromMember(src => src.LawPracticeType));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLawFirmToLawFirmEntity", ex);
                throw;
            }
        }

        /// <summary>
        /// Method which maps the <see cref="LawFirmAddress"/> to <see cref="LawFirmAddressEntity"/>.
        /// </summary>
        internal void MapLawFirmAddressEntityToLawFirmAddress()
        {
            try
            {
                Mapper.CreateMap<LawFirmAddressEntity, LawFirmAddress>()
                      .ForMember(desc => desc.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                      .ForMember(desc => desc.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                      .ForMember(desc => desc.LawFirm, opts => opts.ResolveUsing<StringToLawFirmResolver>().FromMember(src=>src.LFID))
                      .ForMember(desc => desc.MailingInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MailingInd))
                      .ForMember(desc => desc.UpdateByBEInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.UpdateByBEInd))
                      .ForMember(desc => desc.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                      .ForMember(desc => desc.MinLawInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.MinLawInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapLawFirmAddressEntityToLawFirmAddress", ex);
                throw;
            }
        }

        internal void MapSolicitorAddressEntityToSolicitorAddress()
        {
            try
            {
                Mapper.CreateMap<SolicitorAddressEntity, SolicitorAddress>()
                    .ForMember(dest => dest.AddrType, opts => opts.ResolveUsing<AddressTypeToStringResolver>().FromMember(src => src.AddrType))
                    .ForMember(dest => dest.FormatInd, opts => opts.ResolveUsing<AddressFormatTypeToStringResolver>().FromMember(src => src.FormatInd))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapSolicitorAddressEntityToSolicitorAddress", ex);
                throw;
            }
        }


        #endregion Methods
    }
}