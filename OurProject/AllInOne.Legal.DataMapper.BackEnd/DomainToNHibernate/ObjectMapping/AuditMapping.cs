
namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
    using System;
    using System.Collections.Generic;

    using log4net;

    using AutoMapper;

    using AllInOne.Legal.DataMapper.BackEnd.Utilities;
    using AllInOne.Legal.Domain.Audit;    
    using AllInOne.Legal.Entities.BackEnd;
    using AllInOne.Legal.Domain.BackEndSpecific;

    /// <summary>
    /// 
    /// </summary>
    public class AuditMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
        private static readonly ILog Logger = LogManager.GetLogger(typeof(AuditMapping));

        #endregion Fields

        #region Methods

        public void CreateMapping()
        {
            MapAuditModuleVisitEntityToAuditModuleVisit();
            MapAuditTrialJudicialVisitEntityToAuditTrialJudicialVisit();
        }

        /// <summary>
        /// Method which maps the <see cref="AuditModuleVisitEntity"/> to <see cref="AuditModuleVisit"/>.
        /// </summary>
        internal void MapAuditModuleVisitEntityToAuditModuleVisit()
        {
            try
            {
                Mapper.CreateMap<AuditModuleVisitEntity, AuditModuleVisit>();
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAuditModuleVisitEntityToAuditModuleVisit", ex);
                throw ex;
            }
        }

        internal void MapAuditTrialJudicialVisitEntityToAuditTrialJudicialVisit()
        {
            try
            {
                Mapper.CreateMap<AuditTrailJudicialVisitEntity, AuditTrailJudicialVisit>()
                    .ForMember(dest => dest.ActionType, opts => opts.ResolveUsing<AuditTrialActionTypeToStringResolver>().FromMember(src => src.ActionType))
                    .ForMember(dest => dest.FunctionType, opts => opts.ResolveUsing<AuditTrailBackEndFuctionsToStringResolver>().FromMember(src => src.FunctionType))
                    .ForMember(dest => dest.Module, opts => opts.ResolveUsing<AuditTrailBackEndModuleToStringResolver>().FromMember(src => src.Module))
                    .ForMember(dest => dest.SubModule, opts => opts.ResolveUsing<AuditTrailBackEndSubModuleToStringResolver>().FromMember(src => src.SubModule))
                    .ForMember(dest => dest.CaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.CaseInfoId))
                    .ForMember(dest => dest.SubCaseInfoId, opts => opts.ResolveUsing<StringToNullableInt64Resolver>().FromMember(src => src.SubCaseInfoId));

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAuditTrialJudicialVisitEntityToAuditTrialJudicialVisit", ex);
                throw;
            }
        }

        #endregion
    }
}
