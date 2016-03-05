using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AllInOne.Legal.Domain.Hospital;

using AllInOne.Legal.DataMapper.BackEnd.Utilities;
using log4net;
using AllInOne.Legal.Entities.BackEnd;

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapping
{
   internal  class PatientMapping
    {
        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
       private static readonly ILog Logger = LogManager.GetLogger(typeof(PatientMapping));

        #endregion Fields

        internal void MapPatientInfoEntityToPatientInfo()
        {
            try
            {
                Mapper.CreateMap<PatientInfoEntity, PatientInfo>()
                    .ForMember(dest => dest.PatientId, opts => opts.MapFrom(src => src.PatientId))
                    .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.UserName ))
                    .ForMember(dest => dest.EmailId, opts => opts.MapFrom(src => src.EmailId))
                    .ForMember(dest => dest.ObsInd, opts => opts.ResolveUsing<YesNoToStringResolver>().FromMember(src => src.ObsInd))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate))
                    ;

            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapPatientInfoEntityToPatientInfo", ex);
                throw;
            }
        }
    }
}
