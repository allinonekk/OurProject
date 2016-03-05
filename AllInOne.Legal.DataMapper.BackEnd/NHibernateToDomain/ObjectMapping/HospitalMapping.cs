using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using AllInOne.Legal.Domain.Hospital;
using log4net;
using AllInOne.Legal.Entities.BackEnd;

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapping
{
    internal  class HospitalMapping
    {


        #region Fields

        private static readonly ILog Logger = LogManager.GetLogger(typeof(HospitalMapping));

        #endregion Fields
        /// <summary>
        /// Method which maps the <see cref="AffidavitDeponentDetail"/> to <see cref="AffidavitDeponentDetailEntity"/>.
        /// </summary>
        internal void MapPatientInfoEntity()
        {
            try
            {
                Mapper.CreateMap<PatientInfo, PatientInfoEntity>()
                    .ForMember(dest => dest.PatientId, opts => opts.MapFrom(src => src.PatientId))
                    .ForMember(dest => dest.UserName, opts => opts.MapFrom(src => src.UserName ))
                    .ForMember(dest => dest.EmailId, opts => opts.MapFrom(src => src.EmailId ))
                    .ForMember(dest => dest.ObsInd , opts => opts.MapFrom(src => src.ObsInd ))
                    .ForMember(dest => dest.LastModifiedBy, opts => opts.MapFrom(src => src.LastModifiedBy))
                    .ForMember(dest => dest.LastModifiedDate, opts => opts.MapFrom(src => src.LastModifiedDate));
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at MapAffidavitDeponentDetailToAffidavitDeponentDetailEntity", ex);
                throw;
            }
        }
    }
}
