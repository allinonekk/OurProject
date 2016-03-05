using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using AllInOne.Legal.Domain.Hospital;
using AutoMapper;
using AllInOne.Legal.Entities.BackEnd;

namespace AllInOne.Legal.DataMapper.BackEnd.DomainToNHibernate.ObjectMapper
{

    public interface IPatientInfoMapper
    {
        PatientInfo GetPatientInfo(PatientInfoEntity pateintInfoEntity);
    }

    public class PatientInfoMapper : IPatientInfoMapper
    {


        #region Fields

        /// <summary>
        /// ILog instance for logging.
        /// </summary>
       private static readonly ILog Logger = LogManager.GetLogger(typeof(PatientInfoMapper));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="AASObjection"/>
        /// </summary>
        /// <param name="pateintInfoEntity">The AASObjectionEntity.</param>
        /// <returns></returns>
        public  PatientInfo GetPatientInfo(PatientInfoEntity pateintInfoEntity)
        {
            PatientInfo patinetInfo = null;
            try
            {
                patinetInfo = Mapper.Map<PatientInfoEntity, PatientInfo>(pateintInfoEntity);
            }
            catch (Exception ex)
            {
                Logger.Error("Error encountered at GetPatientInfo", ex);
                throw;
            }
            return patinetInfo;
        }
    }
}
