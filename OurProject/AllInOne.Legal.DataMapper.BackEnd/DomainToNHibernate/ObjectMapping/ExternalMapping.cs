namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;
    using System.Collections.Generic;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain;
    using AllInOne.Legal.Domain.BackEndSpecific;
    using AllInOne.Legal.Domain.Document;
    using AllInOne.Legal.Entities.BackEnd;

    internal class ExternalMapping
    {
        #region Constructors

        internal ExternalMapping()
        {
        }

        #endregion Constructors

        #region Methods

        internal void MapInterfaceICAEntityToInterfaceICA()
        {
            Mapper.CreateMap<InterfaceICAEntity, InterfaceICA>()
                .ForMember(dest => dest.CaseNo, opts => opts.MapFrom(src => src.CaseNo))
                .ForMember(dest => dest.DateOfOrder, opts => opts.MapFrom(src => src.DateOfOrder))
                .ForMember(dest => dest.DocId, opts => opts.MapFrom(src => src.DocId))
                .ForMember(dest => dest.ICAInterfaceId, opts => opts.MapFrom(src => src.ICAInterfaceId))
                .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                .ForMember(dest => dest.NoOfTry, opts => opts.MapFrom(src => src.NoOfTry))
                .ForMember(dest => dest.OrderNo, opts => opts.MapFrom(src => src.OrderNo))
                .ForMember(dest => dest.Status, opts => opts.ResolveUsing<ICAInterfaceStatusToStringResolver>().FromMember(src => src.Status));
        }

        #endregion Methods
    }
}