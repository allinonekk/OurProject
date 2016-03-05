using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AllInOne.Legal.Entities.BackEnd;
using AllInOne.Legal.Domain.Hospital;
using AutoMapper;
using log4net;
using AllInOne.Legal.Entities.BackEnd;

namespace AllInOne.Legal.DataMapper.BackEnd.NHibernateToDomain.ObjectMapper
{
  public class HospitalMapper
    {

        #region Fields
        /// <summary>
        /// ILog instance for logging.
        /// </summary>
      private static readonly ILog Logger = LogManager.GetLogger(typeof(HospitalMapper));

        #endregion Fields

        /// <summary>
        /// Gets the <see cref="ReportConfigUser"/> from <see cref="ReportConfigUserEntity"/> input.
        /// </summary>
        /// <param name="reportConfigUserEntity"><see cref="ReportConfigUserEntity"/></param>
        /// <returns>Returns <see cref="ReportConfigUser"/>, else null.</returns>
        public static PatientInfoEntity GetPatientInfoEntity(PatientInfo patientInfo)
        {
            PatientInfoEntity patientInfoEntity = null;

            try
            {
                if (patientInfo != null)
                {
                    patientInfoEntity = Mapper.Map<PatientInfo, PatientInfoEntity>(patientInfo);
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Error at GetIndexDocInfoEntity", ex);
                throw;
            }

            return patientInfoEntity;
        }
    }
}
